using System;
using System.Diagnostics;

namespace Infrastructure
{
    public static class Chronometer
    {
        public static event Action<string> OnObservationCompleted;

        public static Action<string> OutputToConsole = (msg) => Console.WriteLine(msg);

        private static void Process(string description, Action action, Action<string> resultHandler)
        {
            Stopwatch chrono = new Stopwatch();
            chrono.Start();

            action.Invoke();

            chrono.Stop();

            string result = string.Format("Duration of {0} = {1} ms", description, chrono.ElapsedMilliseconds);

            if (resultHandler != null)
                resultHandler.Invoke(result);

            if (OnObservationCompleted != null)
                OnObservationCompleted.Invoke(result);
        }

        public static void Observe(string description, Action action)
        {
            Process(description, action, null);
        }

        public static void Observe(string description, Action action, Action<string> resultHandler)
        {
            Process(description, action, resultHandler);
        }
    }
}