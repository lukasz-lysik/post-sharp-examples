using PostSharp.Aspects;
using System;
using System.Diagnostics;

namespace OnExceptionAspect
{
    [Serializable]
    public class DatabaseExceptionWrapper : PostSharp.Aspects.OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            string msg = string.Format("{0} had an error @ {1}: {2}\n{3}",
                args.Method.Name, DateTime.Now,
                args.Exception.Message, args.Exception.StackTrace);

            Trace.WriteLine(msg);

            throw new Exception("There was a problem");
        }

        public override Type GetExceptionType(System.Reflection.MethodBase targetMethod)
        {
            return typeof(ArgumentException);
        }
    }
}
