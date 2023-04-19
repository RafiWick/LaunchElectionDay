using System;
using System.Collections.Generic;

namespace LaunchElectionDay
{
    public class Election
    {
        List<Race> Races;
        string Year;

        public Election(string year)
        {
            Year = year;
            Races = new List<Race>();
        }
        public string GetYear()
        {
            return Year;
        } 
        public List<Race> GetRaces()
        {
            return Races;
        }
        public void AddRace(Race race)
        {
            Races.Add(race);
        }
        public List<Candidate> GetAllCandidates()
        {
            var allCandidates = new List<Candidate>();
            foreach (Race race in Races)
            {
                allCandidates.AddRange(race.GetCandidates());
            }
            return allCandidates;
        }
        public Dictionary<string, int> GetVoteCounts()
        {
            var voteCounts = new Dictionary<string, int>();
            foreach (Race race in Races)
            {
                foreach (KeyValuePair<string, int> candidate in race.GetVoteCount())
                    voteCounts.Add(candidate.Key, candidate.Value);
            }
            return voteCounts;
        }
    }
}
