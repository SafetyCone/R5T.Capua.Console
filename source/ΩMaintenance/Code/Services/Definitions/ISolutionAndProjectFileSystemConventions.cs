using System;


namespace ΩMaintenance.Services
{
    public interface ISolutionAndProjectFileSystemConventions
    {
        string GetSolutionDirectoryPathFromExecutableFileDirectoryPath(string executableFileDirectoryPath);
    }
}
