using System;

using R5T.Argumentos;
using R5T.Capua.Source;


namespace Capua.Services
{
    class TargetFrameworkNameProvider : ITargetFrameworkNameProvider
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
