using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.Capua;
using R5T.Liverpool;

using Capua.Services;


namespace Capua
{
    class Program : AsyncHostedServiceProgramBase
    {
        static async Task Main(string[] args)
        {
            Program.SetCommandLineArguments();

            await HostedServiceProgram.RunAsync<Program, Startup>();
        }

        private static void SetCommandLineArguments()
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


        private IDeployBuiltBinariesAction DeployBuiltBinariesAction { get; }


        public Program(IApplicationLifetime applicationLifetime,
            IDeployBuiltBinariesAction deployBuiltBinariesAction)
            : base(applicationLifetime)
        {
            this.DeployBuiltBinariesAction = deployBuiltBinariesAction;
        }

        protected override async Task SubMainAsync()
        {
            await this.DeployBuiltBinariesAction.RunAsync();
        }
    }
}
