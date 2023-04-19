namespace LaunchElectionDay
{
    public class Candidate
    {
        public int Votes;
        public string Name;
        public string Party;

        public Candidate(string name, string party)
        {
            Name = name;
            Party = party;
            Votes = 0;
        }
        public void VoteFor()
        {
            Votes++;
        }
    }
}
