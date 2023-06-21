using Autofac;
using Autofac.log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VuelingExam.Application.Service.AutofacModule;
using VuelingExam.Application.Service.Contracts;
using VuelingExam.Application.Service.Implementation;

namespace VuelingExam.Distributed.WebService.Configuration
{
    public class AutofacConfiguration
    {
        public static IContainer Configure() {
            var builder = new ContainerBuilder();

            builder.RegisterModule<Log4NetModule>();
            builder.RegisterModule<AppServiceModule>();

            builder.RegisterType<VuelingWebService>().As<IVuelingWebService>().InstancePerDependency();
            builder.RegisterType<FizzBuzzAppService>().As<IFizzBuzzAppService>().InstancePerDependency();

            return builder.Build();
        }
    }
}