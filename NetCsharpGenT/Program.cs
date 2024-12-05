// See https://aka.ms/new-console-template for more information
using NetCsharpGenT;

Oceanarium<Inhabitant> ocean = new();
ocean.AddInhabitant(new Crab());
ocean.AddInhabitant(new Fish());
ocean.AddInhabitant(new Whale());

MyIterator<Oceanarium<Inhabitant>> myIterator = new MyIterator<Oceanarium<Inhabitant>>(ocean);
myIterator.Print();
Console.WriteLine();

FootballTeam<FootballPlayer> ft1 = new();
ft1.AddPlayer(new Goalkeeper(23, "Alex"));
ft1.AddPlayer(new Defender(25, "Dima"));
ft1.AddPlayer(new Midfielder(27, "Ivan"));

FootballIterator<FootballTeam<FootballPlayer>> FIterator=new FootballIterator<FootballTeam<FootballPlayer>>(ft1);
FIterator.Print();
Console.WriteLine();

Cafe<CafeWorker> cafe1 = new();
cafe1.AddWorker(new Barmen(23, "Alex"));
cafe1.AddWorker(new Cook(25, "Dima"));
cafe1.AddWorker(new Waiter(27, "Ivan"));

CafeIterator<Cafe<CafeWorker>> CafeIterator = new CafeIterator<Cafe<CafeWorker>>(cafe1);
CafeIterator.Print();
Console.WriteLine();