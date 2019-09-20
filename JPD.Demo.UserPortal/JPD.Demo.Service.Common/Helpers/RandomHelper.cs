using System;
using System.Collections.Generic;
using System.Linq;

namespace JPD.Demo.Service.Common.Helpers
{
    public static class RandomHelper
    {
        private static Random random = new Random();

        public static string GetRandomString(Func<List<string>> func)
        {
            string returnValue = "";
            var list = func.Invoke();
            int index = random.Next(list.Count());

            if (index > 0)
            {
                returnValue = list[index];
            }

            return returnValue;
        }

        public static string GetRandomFormattedString(Func<List<string>> func, string arg0)
        {
            var list = func.Invoke();
            int index = random.Next(list.Count());

            return string.Format(list[index], arg0);
        }

        public static short GetRandomShort(short maxValue)
        {
            return Convert.ToInt16(random.Next(maxValue));
        }
    }
}
