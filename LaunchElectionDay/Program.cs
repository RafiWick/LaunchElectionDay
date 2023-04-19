using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");

Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);
var Race1 = new Race("Prelims");
Race1.RegisterCandidate(diana);
Console.WriteLine(Race1.Candidates.Last().Name);
