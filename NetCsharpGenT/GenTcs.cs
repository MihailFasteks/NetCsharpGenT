using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpGenT
{
    abstract class Inhabitant
    {
        public abstract string Name { get; set; }
    }
     class Fish : Inhabitant
    {
        public override string Name { get; set; }

        public Fish()
        {
            Name = "fish";
        }
      
    }
     class Crab: Inhabitant
    {
        public override string Name { get; set; }

        public Crab()
        {
            Name = "Crab";
        }
    }
     class Whale: Inhabitant
    {
        public override string Name { get; set; }

        public Whale()
        {
            Name = "Whale";
        }
    }
     class Oceanarium<T> :IEnumerable where T: Inhabitant
    {
        public List<T> inhabitants {  get; set; }

        public Oceanarium()
        {
            inhabitants = new List<T>();
        }
        public void AddInhabitant(T inhabitant) {
            inhabitants.Add(inhabitant);
        }
     public IEnumerator GetEnumerator()
        {
            foreach(var inh in inhabitants)
            {
                yield return inh;
            }
        }

    }
    class MyIterator<T> where T : IEnumerable
    {
        readonly T collection = default;

        public MyIterator(T collection)
        {
            this.collection = collection;
        }
        public void Print()
        {
            foreach (object obj in collection)
            {
                Console.WriteLine(obj.GetType().Name + " ");
            }
        }
    }
     abstract class FootballPlayer
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public abstract string Role { get; set; }

    }
    class Goalkeeper: FootballPlayer
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Role { get; set; }

        public Goalkeeper(int a, string n)
        {
            Name = n;
            Age = a;
            Role = "Goalkeeper";
        }
    }
    class Defender : FootballPlayer
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Role { get; set; }

        public Defender(int a, string n)
        {
            Name = n;
            Age = a;
            Role = "Defender";
        }
    }
    class Midfielder : FootballPlayer
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Role { get; set; }

        public Midfielder(int a, string n)
        {
            Name = n;
            Age = a;
            Role = "Midfielder";
        }
    }
    class FootballTeam<T> : IEnumerable where T : FootballPlayer
    {
        public List<T> players { get; set; }

        public FootballTeam()
        {
            players = new List<T>();
        }
        public void AddPlayer(T player)
        {
            players.Add(player);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var inh in players)
            {
                yield return inh;
            }
        }

    }
    class FootballIterator<T> where T : IEnumerable
    {
        readonly T collection = default;

        public FootballIterator(T collection)
        {
            this.collection = collection;
        }
        public void Print()
        {
            foreach (object obj in collection)
            {
                if (obj is FootballPlayer fp)
                Console.WriteLine(fp.Name + " "+ fp.Age+" "+fp.Role);
            }
        }
    }



    abstract class CafeWorker
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public abstract string Job { get; set; }

    }
    class Barmen : CafeWorker
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Job { get; set; }

        public Barmen(int a, string n)
        {
            Name = n;
            Age = a;
            Job = "Barmen";
        }
    }
    class Cook : CafeWorker
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Job { get; set; }

        public Cook(int a, string n)
        {
            Name = n;
            Age = a;
            Job = "Cook";
        }
    }
    class Waiter : CafeWorker
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Job { get; set; }

        public Waiter(int a, string n)
        {
            Name = n;
            Age = a;
            Job = "Waiter";
        }
    }
    class Cafe<T> : IEnumerable where T : CafeWorker
    {
        public List<T> workers { get; set; }

        public Cafe()
        {
            workers = new List<T>();
        }
        public void AddWorker(T worker)
        {
            workers.Add(worker);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var w in workers)
            {
                yield return w;
            }
        }

    }
    class CafeIterator<T> where T : IEnumerable
    {
        readonly T collection = default;

        public CafeIterator(T collection)
        {
            this.collection = collection;
        }
        public void Print()
        {
            foreach (object obj in collection)
            {
                if (obj is CafeWorker cw)
                    Console.WriteLine(cw.Name + " " + cw.Age + " " + cw.Job);
            }
        }
    }


}
