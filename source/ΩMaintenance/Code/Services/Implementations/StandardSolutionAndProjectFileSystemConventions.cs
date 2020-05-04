using System;

using R5T.Lombardy;


namespace ΩMaintenance.Services
{
    // Standard is based on ..\R5T.Capua.Console\source\ΩMaintenance\bin\Debug\netcoreapp2.2
    class StandardSolutionAndProjectFileSystemConventions : ISolutionAndProjectFileSystemConventions
    {
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public StandardSolutionAndProjectFileSystemConventions(
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetSolutionDirectoryPathFromExecutableFileDirectoryPath(string executableFileDirectoryPath)
        {
            var ensuredExecutableFileDirectoryPath = this.StringlyTypedPathOperator.EnsureDirectoryPathIsDirectoryIndicated(executableFileDirectoryPath);

            var buildConfigurationDirectoryPath = this.StringlyTypedPathOperator.GetParentDirectoryPathForDirectoryPath(ensuredExecutableFileDirectoryPath); // Debug
            var binariesOutputDirectoryPath = this.StringlyTypedPathOperator.GetParentDirectoryPathForDirectoryPath(buildConfigurationDirectoryPath); // bin
            var projectDirectoryPath = this.StringlyTypedPathOperator.GetParentDirectoryPathForDirectoryPath(binariesOutputDirectoryPath); // ΩMaintenance
            var solutionDirectoryPath = this.StringlyTypedPathOperator.GetParentDirectoryPathForDirectoryPath(projectDirectoryPath); // source
            return solutionDirectoryPath;
        }
    }
}
