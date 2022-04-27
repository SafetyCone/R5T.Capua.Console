using System;

using R5T.Argumentos;
using R5T.Palembang;using R5T.T0064;


namespace Capua.Services
{[ServiceImplementationMarker]
    class ProjectNameProvider : IProjectNameProvider,IServiceImplementation
    {
        private ICommandLineArgumentsProvider CommandLineArgumentsProvider { get; }


        public ProjectNameProvider(ICommandLineArgumentsProvider commandLineArgumentsProvider)
        {
            this.CommandLineArgumentsProvider = commandLineArgumentsProvider;
        }

        public string GetProjectName()
        {
            var commandLineArguments = this.CommandLineArgumentsProvider.GetCommandLineArguments();

            var projectName = commandLineArguments[2];
            return projectName;
        }
    }
}
