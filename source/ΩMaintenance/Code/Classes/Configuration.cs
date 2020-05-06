using System;

using R5T.Palembang.Default;


namespace ΩMaintenance
{
    public static class Configuration
    {
        public static void ConfigureProjectSpecificValues(string projectName, string buildConfigurationName, string targetFrameworkName)
        {
            StaticValueProjectNameProvider.ProjectName = projectName;
            StaticValueBuildConfigurationNameProvider.BuildConfigurationName = buildConfigurationName;
            StaticValueTargetFrameworkNameProvider.TargetFrameworkName = targetFrameworkName;
        }
    }
}
