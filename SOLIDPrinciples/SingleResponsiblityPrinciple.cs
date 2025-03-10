using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    class SingleResponsiblityPrinciple
    {
        public class ReportGenerator
        {
            public string GenerateReport()
            {
                return "Report Data";
            }
        }

        public class ReportSaver
        {
            public void SaveToFile(string filePath, string data)
            {
                Console.WriteLine("File saved");
            }
        }
    }
}
