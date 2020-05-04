using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.Capua;
using R5T.Liverpool;


namespace Capua
{
    class Program : AsyncHostedServiceProgramBase
    {
        static async Task Main(string[] args)
        {
            //Construction.SetCommandLineArguments();

            await HostedServiceProgram.RunAsync<Program, Startup>();
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
