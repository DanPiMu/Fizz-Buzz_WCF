using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExam.Application.Service.Contracts;

namespace VuelingExam.Application.Service.Implementation
{
    public class FizzBuzzAppService : IFizzBuzzAppService
    {


        public List<string> FizzBuzzGenerate(int start, int limit)
        {
            List<string> result = new List<string>();
            for (int i = start; i <= limit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }


    }
}
