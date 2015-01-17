using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    /// <summary>
    /// A Message Bus is a central messaging system for an application.
    /// </summary>
    public sealed class MessageBus
    {
        private object locker = new object();

        private Dictionary<Type, List<MessageSubscriber>> subscribers = new Dictionary<Type, List<MessageSubscriber>>();

        /// <summary>
        /// Subscribes an action to a particular message type. When that message type is published, this action will be called.
        /// </summary>
        /// <typeparam name="TMessage">The type of message to listen for.</typeparam>
        /// <param name="handler">The action which will be called when a message of type <typeparamref name="TMessage"/> is published.</param>
        public void Subscribe<TMessage>(Action<TMessage> handler)
        {
            lock (this.locker)
            {
                if (!this.subscribers.ContainsKey(typeof(TMessage)))
                    this.subscribers[typeof(TMessage)] = new List<MessageSubscriber>();

                this.subscribers[typeof(TMessage)].Add(new MessageSubscriber(handler));
            }
        }

        /// <summary>
        /// Unsubscribes an action from a particular message type.
        /// </summary>
        /// <typeparam name="TMessage">The type of message to stop listening for.</typeparam>
        /// <param name="handler">The action which is to be unsubscribed from messages of type <typeparamref name="TMessage"/>.</param>
        public void Unsubscribe<TMessage>(Action<TMessage> handler)
        {
            lock (this.locker)
            {
                if (this.subscribers.ContainsKey(typeof(TMessage)))
                {
                    MessageSubscriber targetSubscriber = this.subscribers[typeof(TMessage)].FirstOrDefault(subscriber => subscriber.Match(handler));

                    if (targetSubscriber != null)
                        this.subscribers[typeof(TMessage)].Remove(targetSubscriber);

                    if (this.subscribers[typeof(TMessage)].Count <= 0)
                        this.subscribers.Remove(typeof(TMessage));
                }
            }
        }

        /// <summary>
        /// Publishes a message to any subscribers of a particular message type.
        /// </summary>
        /// <typeparam name="TMessage">The type of message to publish.</typeparam>
        /// <param name="message">The message to be published</param>
        public void Publish<TMessage>(TMessage message)
        {
            lock (this.locker)
            {
                if (this.subscribers.ContainsKey(typeof(TMessage)))
                {
                    IEnumerable<MessageSubscriber> zombies = this.subscribers[typeof(TMessage)].Where(subscriber => !subscriber.IsAlive);
                    this.subscribers[typeof(TMessage)] = this.subscribers[typeof(TMessage)].Except(zombies).ToList();

                    if (this.subscribers[typeof(TMessage)].Count <= 0)
                        this.subscribers.Remove(typeof(TMessage));
                }

                if (this.subscribers.ContainsKey(typeof(TMessage)))
                    this.subscribers[typeof(TMessage)].ForEach(subscriber => subscriber.Invoke(message));
            }
        }
    }
}