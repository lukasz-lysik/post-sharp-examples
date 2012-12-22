using PostSharp.Aspects;
using System.Diagnostics;
using System;

namespace GettingStarted
{
    [Serializable]
    public sealed class TraceAttribute : OnMethodBoundaryAspect
    {
        private readonly string _category;

        public TraceAttribute(string category)
        {
            _category = category;
        }

        public string Category { get { return _category; } }

        public override void OnEntry(MethodExecutionArgs args)
        {
            Trace.WriteLine(string.Format("Entering {0}.{1}.",
                args.Method.DeclaringType.Name, args.Method.Name), _category);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Trace.WriteLine(string.Format("Leaving {0}.{1}.",
                args.Method.DeclaringType.Name, args.Method.Name), _category);
        }
    }
}
