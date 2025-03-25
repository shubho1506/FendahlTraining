using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    // custom attribute LogExecutionTimeAttribute that logs the execution time of a method.

    //We define a metadata marker that can be attached to methods.
    //It doesn't execute anything by itself.
    //It just tells the runtime: "This method needs execution time logging."
    //At this point, there’s no logging—just a marker.

    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class LogExecutionTimeAttribute : Attribute { }

}
