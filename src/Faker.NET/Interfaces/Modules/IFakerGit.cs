using Faker.NET.Common;

namespace Faker.NET.Interfaces.Modules
{
    public interface IFakerGit
    {
        public string Branch();
        public string CommitDate();
        public string CommitEntry(LineEnding eol = LineEnding.LF, bool isMergeCommit = false);
        public string CommitMessage();
        public string CommitSha(int length = 40);
    }
}
