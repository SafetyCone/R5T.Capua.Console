using System;

using R5T.Capua.Source;


namespace ΩMaintenance.Services
{
    class BuildConfigurationNameProvider : IBuildConfigurationNameProvider
    {
        public const string DefaultBuildConfigurationName = "Debug";


        public static string BuildConfigurationName { get; set; } = BuildConfigurationNameProvider.DefaultBuildConfigurationName;


        public string GetBuildConfigurationName()
        {
            return BuildConfigurationNameProvider.BuildConfigurationName;
        }
    }
}
