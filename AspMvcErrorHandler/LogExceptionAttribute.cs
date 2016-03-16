﻿using System;
using NLog;
using PostSharp.Aspects;

namespace AspMvcErrorHandler
{
    [Serializable]
    public class LogExceptionAttribute : OnExceptionAspect
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        public LogExceptionAttribute()
        {
            AspectPriority = 10;
        }

        public override void OnException(MethodExecutionArgs args)
        {
            log.Error("Exception {0} in {1}.{2}()", args.Exception, args.Method.DeclaringType.Name, args.Method.Name);
        }
    }
}
