using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsInCSharp
{
    class PipeClient
    {
        public static void StartClient()
        {
            Task.Run(() =>
            {
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "MyPipe", PipeDirection.In))
                {
                    Console.WriteLine("Client: Connecting to server...");
                    pipeClient.Connect();
                    Console.WriteLine("Client: Connected!");

                    using (StreamReader reader = new StreamReader(pipeClient))
                    {
                        string message = reader.ReadLine();
                        Console.WriteLine($"Client received: {message}");
                    }
                }
            });
        }
    }
}
