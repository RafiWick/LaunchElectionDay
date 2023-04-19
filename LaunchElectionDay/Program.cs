using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");
var tonald = new Candidate("Tonald D", "Republican");

var election2024 = new Election("2024");
Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

tonald.VoteFor();
tonald.VoteFor();
tonald.VoteFor();
tonald.VoteFor();


Console.WriteLine(diana.Votes);
var Race1 = new Race("Prelims");
Race1.RegisterCandidate(diana);
Race1.RegisterCandidate(tonald);
election2024.AddRace(Race1);
Console.WriteLine(Race1.Candidates.Last().Name);

Race1.Close();

var test = election2024.GetAllCandidates();
var test2 = election2024.GetVoteCounts();
var test3 = Race1.GetWinner();
var test4 = Race1.isTie();
Console.WriteLine();
