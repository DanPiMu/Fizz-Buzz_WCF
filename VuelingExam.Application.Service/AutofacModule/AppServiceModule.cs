using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExam.Infrastucture.Repository.AutofacModule;
using VuelingExam.Infrastucture.Repository.Contracts;
using VuelingExam.Infrastucture.Repository.Implementations;

namespace VuelingExam.Application.Service.AutofacModule
{
    public class AppServiceModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterType<FizzBuzzRepository>().As<IFizzBuzzRepository>().InstancePerDependency();

            base.Load(builder);
        }
    }
}
