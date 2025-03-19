using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsInCSharp
{
    class MyFileStream
    {
        public static void FileStreamImplementation()
        {
            string path = "example.txt";

            using(StreamWriter write = new StreamWriter(path, true))
            {
                for(int i = 1; i <= 100000; i++)
                {
                    write.Write(i + " ");
                }
            }

            using(StreamReader read = new StreamReader(path, true))
            {
                foreach (var line in File.ReadLines(path))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
