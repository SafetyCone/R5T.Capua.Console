using System;

using R5T.Argumentos;using R5T.T0064;


namespace Capua.Services
{[ServiceImplementationMarker]
    class DummyCommandLineArgumentsProvider : ICommandLineArgumentsProvider,IServiceImplementation
    {
        public const string[] InitialDummyCommandLineArguments = null;


        public static string[] CommandLineArguments { get; set; } = DummyCommandLineArgumentsProvider.InitialDummyCommandLineArguments;
        public static bool UseDummyCommandLineArguments
        {
            get
            {
                var useDummyCommandLineArguments = DummyCommandLineArgumentsProvider.CommandLineArguments != DummyCommandLineArgumentsProvider.InitialDummyCommandLineArguments;
                return useDummyCommandLineArguments;
            }
        }


        public string[] GetCommandLineArguments()
        {
            var commandLineArguments = DummyCommandLineArgumentsProvider.CommandLineArguments;
            return commandLineArguments;
        }
    }
}
