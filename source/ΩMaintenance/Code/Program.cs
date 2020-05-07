using System;
using System.Threading.Tasks;

using R5T.Miletus;


namespace ΩMaintenance
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string projectName = "Capua";
            string buildConfigurationName = "Debug";
            string targetFrameworkName = "netcoreapp2.2";

            // Scripts.
            await Maintenance.DeployBuiltBinaries(projectName, buildConfigurationName, targetFrameworkName);
        }   
    }
}
