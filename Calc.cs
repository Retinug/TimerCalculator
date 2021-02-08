using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerCalculator
{
    static class Calc
    {
        public static UInt64 GetTimeTicks(uint freq, uint prescaller, uint sec)
        {
            return freq / prescaller * sec;
        }

        public static UInt64 GetTimeTicks(uint overflow, uint remainTicks, UInt64 res)
        {
            return overflow * res + remainTicks;
        }

        public static UInt64 GetOverflow(uint freq, UInt64 res)
        {
            return freq / res;
        }

        public static UInt64 GetOverflowTicks(uint totalTicks, UInt64 res)
        {
            return totalTicks / res;
        }

        public static UInt64 GetRemainTicks(uint freq, UInt64 res)
        {
            UInt64 result = freq - GetOverflow(freq, res) * res;

            return result;
        }

        public static double GetFreq(uint freq)
        {
            return 1 / (double)freq;
        }

        public static double GetFreqPres(uint sec, UInt64 prescaller)
        {
            return 1 / (double)sec * prescaller;
        }

        public static double GetFreq(uint clockFreq, UInt64 totalTicks)
        {
            return (double)(clockFreq/totalTicks);
        }
        public static double GetFreq(uint clockFreq, UInt64 totalTicks, UInt64 prescaller)
        {
            double res = (double)clockFreq / (double)totalTicks / (double)prescaller;
            return res;
        }
    }
}
