using System;

namespace AnalogWay.ARCORX.Tools.Base
{
    public static class Randomizer
    {
        private static Random generator = new Random();

        public static double NextDouble()
        {
            return generator.NextDouble();
        }

        public static uint NextUInt(uint min, uint max)
        {
            return (uint)generator.Next((int)min, (int)max);
        }
    }
}