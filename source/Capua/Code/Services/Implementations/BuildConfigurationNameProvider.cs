using System;

using R5T.Argumentos;
using R5T.Capua.Source;


namespace Capua.Services
{
    class BuildConfigurationNameProvider : IBuildConfigurationNameProvider
    {
        private ICommandLineArgumentsProvider CommandLineArgumentsProvider { get; }


        public BuildConfigurationNameProvider(ICommandLineArgumentsProvider commandLineArgumentsProvider)
        {
            this.CommandLineArgumentsProvider = commandLineArgumentsProvider;
        }

        public string GetBuildConfigurationName()
        {
            var commandLineArguments = this.CommandLineArgumentsProvider.GetCommandLineArguments();

            var buildConfigurationName = commandLineArguments[3];
            return buildConfigurationName;
        }
    }
}
