using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExam.Application.Service.Contracts;
using VuelingExam.Infrastucture.Repository.Contracts;

namespace VuelingExam.Application.Service.Implementation
{
    public class FizzBuzzAppService : IFizzBuzzAppService
    {
        private readonly IFizzBuzzRepository _fizzBuzzRepository;
        private readonly ILog _log;

        public FizzBuzzAppService(IFizzBuzzRepository fizzBuzzRepository, ILog log)
        {
            _fizzBuzzRepository = fizzBuzzRepository;
            _log = log;
        }

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
            _log.Info("From the list we make the logic");
            _fizzBuzzRepository.AddToList(result);
            return result;
        }


    }
}
