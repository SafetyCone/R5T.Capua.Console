using System;

using R5T.Argumentos;
using R5T.Palembang;using R5T.T0064;


namespace Capua.Services
{[ServiceImplementationMarker]
    class BuildConfigurationNameProvider : IBuildConfigurationNameProvider,IServiceImplementation
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
