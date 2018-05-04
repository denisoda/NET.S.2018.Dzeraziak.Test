using System;
using Task1;
using Task1.Solution;
using Ninject;
using Dependecy_resolver;

namespace Task1.Console
{
    class Program
    {
        public Program()
        {
            kernel = new Config().Kernel;
        }
        private IKernel kernel;
        
        void Main(string[] args)
        {
            addPass("123");
        }

        private void addPass(string pass)
        {
            var passValid = kernel.Get<IPasswordChecker>();

            passValid.VerifyPassword(pass);
        }
    }
}

