using System;

using ΩMaintenance.Services;


namespace ΩMaintenance
{
    public static class Configuration
    {
        public static void ConfigureProjectSpecificValues(string projectName, string buildConfigurationName, string targetFrameworkName)
        {
            ProjectNameProvider.ProjectName = projectName;
            BuildConfigurationNameProvider.BuildConfigurationName = buildConfigurationName;
            TargetFrameworkNameProvider.TargetFrameworkName = targetFrameworkName;
        }
    }
}
