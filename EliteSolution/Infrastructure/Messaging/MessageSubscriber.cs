using System;
using System.Reflection;

namespace Infrastructure
{
    /// <summary>
    /// Maintains a weak reference to an action/delegate.
    /// </summary>
    public sealed class MessageSubscriber
    {
        private readonly WeakReference subscriberReference;
        private readonly MethodInfo handlerMethod;

        /// <param name="action">The action/delegate to be referenced.</param>
        public MessageSubscriber(Delegate action)
        {
            this.subscriberReference = new WeakReference(action.Target);
            this.handlerMethod = action.Method;
        }

        public bool IsAlive
        {
            get { return this.subscriberReference.IsAlive; }
        }

        public bool Match(Delegate action)
        {
            return (this.subscriberReference.Target == action.Target) && this.handlerMethod.Equals(action.Method);
        }

        public void Invoke(params object[] args)
        {
            //if Target has been collected since MessageBus cleanup : instance == null => method not invoked
            //if Target is about to be collected : targetInstance keeps a reference and prevents GC from collecting while invoking the method
            object targetInstance = this.subscriberReference.Target;
            if (targetInstance != null)
                this.handlerMethod.Invoke(targetInstance, args);
        }
    }
}