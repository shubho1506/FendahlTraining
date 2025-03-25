using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_XMLManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLManipulation.CreateXml();
            XMLManipulation.ReadXml();
            XMLManipulation.ModifyXml();
            XMLManipulation.ReadXml();

            JSONManipulation.Start();
        }
    }
}
