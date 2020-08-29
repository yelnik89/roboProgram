using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace robo
{
    class FileReader
    {
        private const string FORMAT = ".txt";
        private const string LOG = "log";

        public string readFile(string name)
        {
            string result = "";
            try
            {
                FileStream file = File.OpenRead(fileName(name));
                byte[] array = new byte[file.Length];
                file.Read(array, 0, array.Length);
                result = Encoding.Default.GetString(array);
            }catch(Exception)
            {
                throw;
            }
            return result;
        }

        public Dictionary<string, string[]> itemInfo(string name)
        {
            string fileText = "";
            try
            {
                fileText = readFile(name);
            }
            catch (Exception)
            {
                throw;
            }
            Dictionary<string, string[]> result = splitString(fileText);
            return result;
        }

        private string fileName(string name)
        {
            return "_" + name + FORMAT;
        }

        private Dictionary<string, string[]> splitString(string text)
        {
            Dictionary<string, string[]> result = new Dictionary<string, string[]>();
            string[] splitStrings = text.Split('\n');
            foreach (string s in splitStrings)
            {
                string[] array = s.Split(';');
                result.Add(array[0],array);
            }
            return result;
        }
    }
}
