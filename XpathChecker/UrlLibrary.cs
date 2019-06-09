using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpathChecker
{
    public class UrlLibrary
    {
        private static string UrlLibPath = AppDomain.CurrentDomain.BaseDirectory + @"\UrlLibrary.csv";
        public static List<string> ReadUrls()
        {
            if (!File.Exists(UrlLibPath))
            {
                File.Create(UrlLibPath).Dispose();
            }
            List<string> urls = new List<string>();
            string ln;
            using (StreamReader file = new StreamReader(UrlLibPath))
            {
                while ((ln = file.ReadLine()) != null)
                {
                    urls.Add(ln);
                }
                file.Close();
            }
            return urls;
        }

        public static bool CheckLibrary(string url)
        {
            try
            {
                if (!File.Exists(UrlLibPath))
                {
                    File.Create(UrlLibPath).Dispose();
                }

                return (ReadUrls().Contains(url));
               
                
            }
            catch
            {
                return false;
            }
        }

        public static void WriteToLibrary(string url)
        {
            if (!CheckLibrary(url))
            {
                List<string> urls = ReadUrls();
                urls.Add(url);

                TextWriter tw = new StreamWriter(UrlLibPath);
                foreach (string newUrl in urls)
                {
                    tw.WriteLine(newUrl);
                }
                tw.Close();
            }
        }

        public static void ClearLibrary()
        {
            File.Delete(UrlLibPath);
        }
    }
}
