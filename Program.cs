using System;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var filename = "2018_06_08_13_18_41_Adhoc.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var CycleTimefilepath = Path.Combine(currentDirectory, filename);

            //Displays the xml file before conversion
            Console.WriteLine(CycleTimefilepath);

            XmlDocument doc = new XmlDocument();
            doc.Load(CycleTimefilepath);

            //Serialize the XML nodes in json objects
            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented, true);
            Console.WriteLine(json);
            Console.ReadLine();

            //Write stream to the file
            TextWriter tw = new StreamWriter("SavedJSON.json"); 

            // write lines of text to the file
            tw.WriteLine(json);     

            // close the stream     
            tw.Close();
            
        }
    }
}
