using System;
using System.Threading;

namespace Infrastructure
{
    public static class DispatcherHelper
    {
        private static SynchronizationContext uiContext;

        private static bool IsInvokeRequired()
        {
            return (SynchronizationContext.Current != uiContext);
        }

        public static void Initialize(SynchronizationContext context)
        {
            if (context == null)
                throw new ArgumentNullException();

            uiContext = context;
        }

        public static void Invoke(Action action)
        {
            if (IsInvokeRequired())
                uiContext.Send((e) => { action(); }, null);
            else
                action();
        }

        public static void Invoke<T>(Action<T> action, T arg)
        {
            if (IsInvokeRequired())
                uiContext.Send((e) => { action((T)e); }, arg);
            else
                action(arg);
        }

        public static void BeginInvoke(Action action)
        {
//            if (IsInvokeRequired())
                uiContext.Post((e) => { action(); }, null);
//            else
//                ThreadPool.QueueUserWorkItem((e) => { action(); }, null);
        }

        public static void BeginInvoke<T>(Action<T> action, T arg)
        {
//            if (IsInvokeRequired())
                uiContext.Post((e) => { action((T)e); }, arg);
//            else
//                ThreadPool.QueueUserWorkItem((e) => { action((T)e); }, arg);
        }
    }
}
