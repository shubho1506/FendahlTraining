using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsInCSharp
{
    class PipeServer
    {
        public static void StartServer()
        {
            Task.Run(() =>
            {
                using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("MyPipe", PipeDirection.Out))
                {
                    Console.WriteLine("Server: Waiting for connection...");
                    pipeServer.WaitForConnection();
                    Console.WriteLine("Server: Client connected!");

                    using (StreamWriter writer = new StreamWriter(pipeServer))
                    {
                        writer.AutoFlush = true;
                        writer.WriteLine("Hello from Server!");
                        Console.WriteLine("Server: Message sent.");
                    }
                }
            });
        }
    }
}
