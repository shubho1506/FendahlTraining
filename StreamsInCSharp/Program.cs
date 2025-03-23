using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StreamsInCSharp
{
    //Streams in C# are used for reading and writing data sequentially.
    //They provide an abstraction over different types of I/O operations, such as file handling, network communication,
    //or inter-process communication.

    //Key Features of Streams:
    //Sequential Access: Data flows in one direction(either read or write).
    //Buffered Operations: Data is read/written in chunks for efficiency.
    //Abstract Layer: Streams work with different data sources like files, memory, and network sockets.

    //Types of Streams in C#
    //File Streams (e.g., FileStream) – For file operations.
    //Memory Streams (e.g., MemoryStream) – Operate on RAM instead of disk.
    //Network Streams (e.g., NetworkStream) – Used for network communication.
    //Pipe Streams (e.g., PipeStream) – For inter-process/thread communication.

    class Program
    {
        static void Main(string[] args)
        {
            //MyFileStream.FileStreamImplementation();
            //PipeStreamImplementation();
            //ThreadPipeStreamImplementation();
            AnonymousPipeStreamImplementation();
        }

        static void PipeStreamImplementation()
        {
            PipeServer.StartServer();
            Thread.Sleep(1000); // Ensure server starts first
            PipeClient.StartClient();

            Console.ReadLine(); // Keep console open to see output
        }

        static void ThreadPipeStreamImplementation()
        {
            ThreadServer.StartServer();
            Thread.Sleep(500); // Give server some time to start

            ThreadClient.StartClient();
            Console.ReadLine(); // Keep console open
        }

        static void AnonymousPipeStreamImplementation()
        {
            Console.WriteLine("Starting Pipe Communication...");
            MyAnonymousPipeServer.StartServer();
        }
    }
}
