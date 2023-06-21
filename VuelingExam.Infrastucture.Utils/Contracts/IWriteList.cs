using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingExam.Infrastucture.Utils.Contracts
{
    public interface IWriteList
    {
        void WriteListToFile(List<string> list, string filePath);
    }
}
