using DevOps.VersionControl.Structures.GitCommitUser;
using static DevOps.VersionControl.Functions.AddAndCommitGitChanges.GitChangeAdderAndCommitter;
using static Metaproject.Cdn.Containers.VersionControl.Helpers.VersionControlContentHelper;

namespace DevOps.VersionControl.Functions.AddAndCommitGitAttributesIgnoreFiles
{
    public static class GitAttirubtesIgnoreFilesCommitter
    {
        private const string CommitMessage = "Add .gitattributes and .gitignore files";

        public static void AddAndCommitGitAttributeIgnoreFiles(string repositoryDirectory, UserInfo? user = null)
        {
            SaveGitAttributeIgnoreFiles(repositoryDirectory);
            AddAndCommitChanges(repositoryDirectory, CommitMessage, user);
        }
    }
}
