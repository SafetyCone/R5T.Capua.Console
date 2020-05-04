using System;

using Capua.Services;


namespace Capua
{
    static class Construction
    {
        public static void SetCommandLineArguments()
        {
            var actualCommandLineArguments = Environment.GetCommandLineArgs();

            DummyCommandLineArgumentsProvider.CommandLineArguments = new[]
            {
                actualCommandLineArguments[0], // The executable path.
                @"C:\GitHub\MinexAutomation\R5T.Capua.Console\source",
                "Capua",
                "Debug",
                "netcoreapp2.2"
            };
        }
    }
}
