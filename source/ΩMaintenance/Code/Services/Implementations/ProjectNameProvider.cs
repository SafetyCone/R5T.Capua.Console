using System;

using R5T.Capua.Common;


namespace ΩMaintenance.Services
{
    class ProjectNameProvider : IProjectNameProvider
    {
        public static string ProjectName { get; set; }


        public string GetProjectName()
        {
            return ProjectNameProvider.ProjectName;
        }
    }
}
