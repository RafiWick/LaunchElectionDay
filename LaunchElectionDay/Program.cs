using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");

var election2024 = new Election("2024");
Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);
var Race1 = new Race("Prelims");
Race1.RegisterCandidate(diana);
election2024.AddRace(Race1);
Console.WriteLine(Race1.Candidates.Last().Name);

var test = election2024.GetAllCandidates();
var test2 = election2024.GetVoteCounts();
Console.WriteLine();
