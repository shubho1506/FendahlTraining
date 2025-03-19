using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StreamsInCSharp
{
    class ThreadServer
    {
        public static void StartServer()
        {
            new Thread(() =>
            {
                using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("TestPipe", PipeDirection.Out))
                {
                    Console.WriteLine("Server: Waiting for client connection...");
                    pipeServer.WaitForConnection();

                    using (StreamWriter writer = new StreamWriter(pipeServer))
                    {
                        writer.AutoFlush = true;
                        Console.WriteLine("Server: Sending message...");
                        writer.WriteLine("Hello from Server!");
                    }
                }
            }).Start();
        }
    }
}
