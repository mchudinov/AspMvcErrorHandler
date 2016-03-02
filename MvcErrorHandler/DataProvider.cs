﻿using System;

namespace MvcErrorHandler
{
    public class DataProvider
    {
        private static readonly Random _rnd = new Random();

        public static string GetData()
        {
            return _rnd.Next(1, 1000000).ToString();
        }
    }
}