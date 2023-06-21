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

        public VuelingWebService(ILog log, IFizzBuzzAppService fizzBuzzAppService)
        {
            _log = log;
            _fizzBuzzAppService = fizzBuzzAppService;
        }
        public List<string> FizzBuzz(string start)
        {
            int startInt = Int32.Parse(start);
            int limit;
            try
            {
                limit = int.Parse(ConfigurationManager.AppSettings["FizzBuzzLimit"]);
            }
            catch
            {
                // Lanzar una excepción con un mensaje más amigable
                throw new ConfigurationErrorsException("'FizzBuzzLimit' is not present in the configuration file or it is not an integer.");
            }

            List<string> result = _fizzBuzzAppService.FizzBuzzGenerate(startInt, limit);
            
            return result;
        }


    }
}
