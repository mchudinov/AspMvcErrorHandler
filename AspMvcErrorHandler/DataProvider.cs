using System;

namespace AspMvcErrorHandler
{
    [Log(AspectPriority = 2)]
    [LogException(AspectPriority = 1)]
    public class DataProvider
    {
        private static readonly Random _rnd = new Random();

        public static string GetData()
        {
            throw new Exception("Hoho!");
            return _rnd.Next(1, 1000000).ToString();
        }
    }
}