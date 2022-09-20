using System.Diagnostics;

namespace Algorithms.API.Utils
{
    public static class TimeCalculator
    {
        public static float CountTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action.Invoke();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds / 1000.0f;
        }
    }
}
