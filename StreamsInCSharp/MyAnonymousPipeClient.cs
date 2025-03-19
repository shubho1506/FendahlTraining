using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsInCSharp
{
    class MyAnonymousPipeClient
    {
        public static void StartClient(string pipeHandle)
        {
            using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeHandle))
            using (StreamReader reader = new StreamReader(pipeClient))
            {
                string message = reader.ReadLine();
                Console.WriteLine($"Client received: {message}");
            }
        }
    }
}
