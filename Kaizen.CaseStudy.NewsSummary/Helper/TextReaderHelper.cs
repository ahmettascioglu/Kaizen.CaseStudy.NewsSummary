using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.CaseStudy.NewsSummary.Helper
{
    public class TextReaderHelper
    {
        public static string ReadTextFile(string path)
        {
            if (!System.IO.File.Exists(path))
                throw new Exception("File does not exists");

            using (TextReader reader = new StreamReader(System.IO.File.Open(path, FileMode.Open)))
            {
                try
                {
                    var newsContent = reader.ReadToEnd();
                    return newsContent;
                }
                catch (Exception)
                {
                    throw new Exception("File couldn't open and read");
                }
            }
        }
    }
}
