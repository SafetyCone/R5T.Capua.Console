using System;

using R5T.Capua.Source;


namespace ΩMaintenance.Services
{
    class TargetFrameworkNameProvider : ITargetFrameworkNameProvider
    {
        public static string TargetFrameworkName { get; set; }


        public string GetTargetFrameworkName()
        {
            return TargetFrameworkNameProvider.TargetFrameworkName;
        }
    }
}
