using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsInCSharp
{
    class MyAnonymousPipeServer
    {
        public static void StartServer()
        {
            using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                Console.WriteLine($"Server: Created Pipe with Handle - {pipeServer.GetClientHandleAsString()}");

                // Start the client process and pass the pipe handle
                Process clientProcess = new Process();
                clientProcess.StartInfo.FileName = "AnonymousPipeClient.exe"; // Ensure the client executable is available
                clientProcess.StartInfo.Arguments = pipeServer.GetClientHandleAsString();
                clientProcess.StartInfo.UseShellExecute = false;
                clientProcess.Start();

                pipeServer.DisposeLocalCopyOfClientHandle(); // Release the handle in the server

                using (StreamWriter writer = new StreamWriter(pipeServer))
                {
                    writer.AutoFlush = true;
                    Console.WriteLine("Server: Sending message...");
                    writer.WriteLine("Hello from Server!");
                }

                clientProcess.WaitForExit(); // Ensure the client finishes execution
            }
        }
    }
}
