using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsInCSharp
{
    class ThreadClient
    {
        public static void StartClient()
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "TestPipe", PipeDirection.In))
            {
                Console.WriteLine("Client: Connecting to pipe...");
                pipeClient.Connect();

                using (StreamReader reader = new StreamReader(pipeClient))
                {
                    string message = reader.ReadLine();
                    Console.WriteLine($"Client received: {message}");
                }
            }
        }
    }
}
