using System;
using Ninject;
using Task1.Solution;
using Task1;

namespace Dependecy_resolver
{
    public class Config
    {
        public IKernel Kernel {get; private set;}

        public Config()
        {
            this.Kernel = new StandardKernel();
            this.Kernel.Bind<IPasswordRepository>().To<Task1.SqlRepository>();
            this.Kernel.Bind<IPasswordChecker>().To<PasswordCheckerService>().WithConstructorArgument(Kernel.Get<IPasswordRepository>());
        }
    }
}
