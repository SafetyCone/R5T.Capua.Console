using System;

using R5T.Argumentos;
using R5T.Capua.Common;


namespace Capua.Services
{
    class ProjectNameProvider : IProjectNameProvider
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
