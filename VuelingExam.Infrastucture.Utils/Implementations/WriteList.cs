﻿using System;
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
        public void WriteListToFile(List<string> list, string filePath)
        {
            string content = string.Join(", ", list);

            content = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + content;

            File.AppendAllText(filePath, content + Environment.NewLine);
        }

    }
}
