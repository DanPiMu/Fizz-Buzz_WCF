using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingExam.Application.Service.Contracts
{
    public interface IFizzBuzzAppService
    {
        List<string> FizzBuzzGenerate(int start, int limit);
    }
}
