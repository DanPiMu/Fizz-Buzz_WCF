using Autofac;
using Autofac.log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VuelingExam.Distributed.WebService.Configuration
{
    public class AutofacConfiguration
    {
        public static IContainer Configure() {
            var builder = new ContainerBuilder();

            builder.RegisterModule<Log4NetModule>();

            builder.RegisterType<VuelingWebService>().As<IVuelingWebService>().InstancePerDependency();


            return builder.Build();
        }
    }
}