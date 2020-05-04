using System;
using System.Threading.Tasks;

using ΩMaintenance.Scripts;
using ΩMaintenance.Services;


namespace ΩMaintenance
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await DeployBuiltBinaries.SubMain();
        }

        public static void ConfigureProjectSpecificValues()
        {
            ProjectNameProvider.ProjectName = "Capua";
            BuildConfigurationNameProvider.BuildConfigurationName = "Debug";
            TargetFrameworkNameProvider.TargetFrameworkName = "netcoreapp2.2";
        }
    }
}
