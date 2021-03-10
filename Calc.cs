using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerCalculator
{
    static class Calc
    {
        public static uint GetTimeTicks(uint freq, uint prescaller, double sec)
        {
            return (uint)(freq / prescaller * sec);
        }

        public static ulong GetTimeTicks(uint overflow, uint remainTicks, ulong res)
        {
            return overflow * res + remainTicks;
        }

        public static uint GetTimeTicksFreq(uint freq, uint prescaller, double newFreq)
        {
            return (uint)(freq / prescaller * 1 / newFreq);
        }

        public static uint GetOverflow(uint freq, ulong res, uint pres, double sec)
        {
            return (uint)(freq / res / (double)pres * Math.Round(sec, 2));
        }

        public static double GetRealTime(uint clockFreq, ulong totalTicks, uint pres)
        {
            return Math.Round(1 / (clockFreq / totalTicks / (double)pres), 2);
        }

        public static uint GetRemainTicks(uint freq, ulong res, uint pres, double sec)
        {
            return (uint)(freq * Math.Round(sec, 2) - GetOverflow(freq, res, pres, sec) * res * pres) / pres;
        }

        public static double GetFreq(double freq)
        {
            return Math.Round(1 / freq, 2);
        }
    }
}
