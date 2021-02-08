using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerCalculator
{
    static class Calc
    {
        public static uint GetTimeTicks(uint freq, uint prescaller, uint sec)
        {
            return freq / prescaller * sec;
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

        public static double GetFreqPres(uint sec, uint prescaller)
        {
            return 1 / (double)sec * prescaller;
        }

        public static double GetFreq(uint clockFreq, uint totalTicks)
        {
            return (double)(clockFreq/totalTicks);
        }
        public static double GetFreq(uint clockFreq, uint totalTicks, uint prescaller)
        {
            double res = (double)clockFreq / (double)totalTicks / (double)prescaller;
            return res;
        }
    }
}
