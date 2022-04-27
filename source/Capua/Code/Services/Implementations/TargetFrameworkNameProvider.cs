using System;

using R5T.Argumentos;
using R5T.Palembang;using R5T.T0064;


namespace Capua.Services
{[ServiceImplementationMarker]
    class TargetFrameworkNameProvider : ITargetFrameworkNameProvider,IServiceImplementation
    {
        private ICommandLineArgumentsProvider CommandLineArgumentsProvider { get; }


        public TargetFrameworkNameProvider(ICommandLineArgumentsProvider commandLineArgumentsProvider)
        {
            this.CommandLineArgumentsProvider = commandLineArgumentsProvider;
        }

        public string GetTargetFrameworkName()
        {
            var commandLineArguments = this.CommandLineArgumentsProvider.GetCommandLineArguments();

            var targetFrameworkName = commandLineArguments[4];
            return targetFrameworkName;
        }
    }
}
