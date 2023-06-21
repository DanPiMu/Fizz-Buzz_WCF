using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using VuelingExam.Application.Service.Contracts;
namespace VuelingExam.Distributed.WebService
{
    
    public class VuelingWebService : IVuelingWebService
    {
        private readonly ILog _log;
        private readonly IFizzBuzzAppService _fizzBuzzAppService;

        public VuelingWebService() { }

        public VuelingWebService( IFizzBuzzAppService fizzBuzzAppService, ILog log)
        {
            _log = log;
            _fizzBuzzAppService = fizzBuzzAppService;
        }
        public List<string> FizzBuzz(string start)
        {
            int startInt = Int32.Parse(start);
            int limit = GetFizzBuzzLimit();
            _log.Info("We have the initial number");

            List<string> result = _fizzBuzzAppService.FizzBuzzGenerate(startInt, limit);
            
            return result;
        }

        public List<string> FizzBuzzP(string start)
        {
            int startInt = Int32.Parse(start);
            int limit = GetFizzBuzzLimit();

            List<string> result = _fizzBuzzAppService.FizzBuzzGenerate(startInt, limit);

            return result;
        }
        private int GetFizzBuzzLimit()
        {
            string fizzBuzzLimit = ConfigurationManager.AppSettings["FizzBuzzLimit"];

            if (int.TryParse(fizzBuzzLimit, out int limit))
            {
                return limit;
            }

            
            return 100;
        }
    }
}
