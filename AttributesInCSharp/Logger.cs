using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace AttributesInCSharp
{
    //Implement Logging Using Reflection - Since attributes alone do nothing, we need to use Reflection to capture method execution and log the duration.

    //Step 2: Intercept Method Calls
    //We create a utility class to handle method invocation

    //✔ How does this work?
    //It checks if [LogExecutionTime] is applied to the method.
    //If yes, it:
    //Starts a stopwatch.
    //Calls the method dynamically.
    //Stops the stopwatch.
    //Logs the execution time.
    //If no, it just calls the method normally.
    public static class Logger
    {
        public static void ExecuteWithLogging(object instance, string methodName, params object[] parameters)
        {
            MethodInfo method = instance.GetType().GetMethod(methodName);
            if (method == null) return;

            // Check if method has LogExecutionTime attribute
            if (Attribute.IsDefined(method, typeof(LogExecutionTimeAttribute)))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                // Invoke the method dynamically
                method.Invoke(instance, parameters);

                stopwatch.Stop();
                Console.WriteLine($"Method {method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");
            }
            else
            {
                // If no attribute, invoke normally
                method.Invoke(instance, parameters);
            }
        }
    }
}
