using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExam.Infrastucture.Utils.Contracts;
using VuelingExam.Infrastucture.Utils.Implementations;

namespace VuelingExam.Infrastucture.Repository.AutofacModule
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<WriteList>().As<IWriteList>().InstancePerDependency();
            base.Load(builder);
        }
    }
}
