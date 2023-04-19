using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Race
    {
        public string Office;
        public List<Candidate> Candidates;
        bool isOpen;

        public Race(string office)
        {
            Office = office;
            Candidates = new List<Candidate>();
            isOpen = true;
        }
        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }
        public List<Candidate> GetCandidates()
        {
            return Candidates;
        }
        public Dictionary<string, int> GetVoteCount()
        {
            var voteCount = new Dictionary<string, int>();
            foreach (Candidate candidate in Candidates)
            {
                voteCount.Add(candidate.GetVoteCount().Key, candidate.GetVoteCount().Value);
            }
            return voteCount;
        }
        public void Close()
        {
            isOpen = false;
        }

        public Candidate GetWinner()
        {
            Candidate ReturnCandidate = new Candidate("", "");
            if (!isOpen)
            {
                foreach (Candidate candidate in Candidates)
                {
                    if (candidate.Votes >= ReturnCandidate.Votes)
                    {
                        ReturnCandidate = candidate;
                    }

                }
            }
            return ReturnCandidate;
        }
        public bool isTie()
        {
            int counter = 0;
            int maxVotes = this.GetWinner().Votes;
            foreach (Candidate candidate in Candidates)
            {
                if (candidate.Votes == maxVotes)
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
