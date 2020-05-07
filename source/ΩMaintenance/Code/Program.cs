using System;
using System.Threading.Tasks;

using R5T.Miletus.Configuration;

using ΩMaintenance.Scripts;


namespace ΩMaintenance
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string projectName = "Capua";
            string buildConfigurationName = "Debug";
            string targetFrameworkName = "netcoreapp2.2";

            Configure.ProjectSpecificValues(projectName, buildConfigurationName, targetFrameworkName);

            // Scripts.
            await DeployBuiltBinaries.SubMain();
        }   
    }
}
