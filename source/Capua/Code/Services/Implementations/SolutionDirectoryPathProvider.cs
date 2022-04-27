using System;

using R5T.Argumentos;
using R5T.Ujung;using R5T.T0064;



namespace Capua.Services
{[ServiceImplementationMarker]
    class SolutionDirectoryPathProvider : ISolutionDirectoryPathProvider,IServiceImplementation
    {
        private ICommandLineArgumentsProvider CommandLineArgumentsProvider { get; }


        public SolutionDirectoryPathProvider(ICommandLineArgumentsProvider commandLineArgumentsProvider)
        {
            this.CommandLineArgumentsProvider = commandLineArgumentsProvider;
        }

        public string GetSolutionDirectoryPath()
        {
            var commandLineArguments = this.CommandLineArgumentsProvider.GetCommandLineArguments();

            var solutionDirectoryPath = commandLineArguments[1];
            return solutionDirectoryPath;
        }
    }
}
