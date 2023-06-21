using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExam.Infrastucture.Repository.Contracts;
using VuelingExam.Infrastucture.Utils.Contracts;

namespace VuelingExam.Infrastucture.Repository.Implementations
{
    public class FizzBuzzRepository : IFizzBuzzRepository
    {
        private readonly IWriteList _writeList;

        public FizzBuzzRepository(IWriteList writeList) { 
            _writeList = writeList;
        }

        public void AddToList(List<string> result) 
        {

            _writeList.WriteListToFile(result);
        }
    }
}
