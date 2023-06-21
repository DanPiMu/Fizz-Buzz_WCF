using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExam.Infrastucture.Utils.Contracts;

namespace VuelingExam.Infrastucture.Utils.Implementations
{
    public class WriteList : IWriteList
    {
        private readonly ILog _log;
        public WriteList() { }

        public WriteList(ILog log) { 
            _log = log;
        }
        
        public void WriteListToFile(List<string> list)
        {
            string currentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(currentDirectory, "FizzBuzzList.txt");
            string content = string.Join(", ", list);

            content = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + content;
            _log.Info("Add the number to the list");

            File.AppendAllText(filePath, content + Environment.NewLine);
        }

    }
}
