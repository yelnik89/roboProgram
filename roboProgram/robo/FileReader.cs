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

        public List<string[]> itemInfo(string name)
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
            List<string[]> result = splitString(fileText);
            return result;
        }

        private string fileName(string name)
        {
            return "_" + name + FORMAT;
        }

        private List<string[]> splitString(string text)
        {
            List<string[]> result = new List<string[]>();
            string[] splitStrings = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in splitStrings)
            {
                string[] array = s.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                result.Add(array);
            }
            return result;
        }
    }
}
