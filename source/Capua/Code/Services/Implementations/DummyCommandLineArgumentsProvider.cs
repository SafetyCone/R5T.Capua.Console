using System;

using R5T.Argumentos;


namespace Capua.Services
{
    class DummyCommandLineArgumentsProvider : ICommandLineArgumentsProvider
    {
        public static string[] CommandLineArguments { get; set; }


        public string[] GetCommandLineArguments()
        {
            var commandLineArguments = DummyCommandLineArgumentsProvider.CommandLineArguments;
            return commandLineArguments;
        }
    }
}
