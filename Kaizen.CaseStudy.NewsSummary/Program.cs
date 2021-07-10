using System;
using System.Collections.Generic;
using System.Linq;
using Kaizen.CaseStudy.NewsSummary.Helper;

namespace Kaizen.CaseStudy.NewsSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = TextReaderHelper.ReadTextFile(@"C:\Users\ahmet\Downloads\news.txt");
                string title = "Korona günlerinde arabalı sinema keyfi";

                // I decided to split news title and get words. after getting them we will search words in main content to get summary

                var titleWords = title.Split(" ");

                // Split sentences with (dash) character
                var sentencesOfContent = content.Split(".");

                List<string> summarySentenceList = new List<string>();
                foreach (var sentence in sentencesOfContent)
                {
                    foreach (var word in titleWords)
                    {
                        if (sentence.Contains(word))
                        {
                            if (!summarySentenceList.Any(x => x.Equals(sentence)))
                            {
                                summarySentenceList.Add(sentence);
                            }
                        }
                    }
                }

                var summary = string.Join(".", summarySentenceList);

                Console.Write(summary);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
