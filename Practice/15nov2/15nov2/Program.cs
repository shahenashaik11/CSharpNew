using System;

namespace _15nov2
{
     abstract public class Details
    {
     
       
        public int _id;
        public abstract int id { get; set; }
        public string _name;
        public abstract string name { get; set; }
        public abstract void inputdetails();
        public abstract void outputdetails();

    }
    public class Team : Details
    {

        public Player[] p = new Player[3];
        public Player Max = new Player();
        public int totalscore = 0;
        public override int id { get { return _id; } set { _id = value; } }
        public override string name { get { return _name; } set { _name = value; } }
        public override void inputdetails()
        {
            Console.WriteLine("enter the Team name");
            name = Console.ReadLine();
            Console.WriteLine("enter the Team ID");
            id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                p[i] = new Player();
                p[i].inputdetails();
                Console.ReadLine();
            }

            Console.ReadLine();
        }
        public void totalscoreofteam()
        {
            for (int i = 0; i < 3; i++)
            {
                if (p[i].score > Max.score)
                {
                    Max.score = p[i].score;
                    Max.name = p[i].name;

                }
                totalscore = p[i].score + totalscore;


            }
            Console.WriteLine("total score of team is:" + totalscore);
            Console.ReadLine();

        }

        public override void outputdetails()
        {
            Console.WriteLine("NAME OF TEAM IS:" + name);
            Console.WriteLine("Team ID IS:" + id);
            for (int i = 0; i < 3; i++)
            {

                p[i].outputdetails();
                Console.ReadLine();
            }

        }



    }
    public class Player : Details
    {
        public override int id { get { return _id; } set { _id = value; } }
        public override string name { get { return _name; } set { _name = value; } }
        public int score;
        public override void inputdetails()
        {
            Console.WriteLine("enter the player name");
            name = Console.ReadLine();
            Console.WriteLine("enter the player ID");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the score");
            score = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


        }
        public override void outputdetails()
        {
            Console.WriteLine("NAME OF PLAYER IS:" + name);
            Console.WriteLine("PLAYER ID IS:" + id);
            Console.WriteLine("SCORE IS:" + score);
            Console.ReadLine();
        }


    }
    class Match
    {
        public Team t1 = new Team();
     


        public Team t2 = new Team();


        public Player[] p = new Player[3];
        public void result()
        {

            t1.inputdetails();
            t1.outputdetails();
            t2.inputdetails();
            t2.outputdetails();
            t1.totalscoreofteam();
            t2.totalscoreofteam();


        }
        public void winner()
        {
            if ((t1.totalscore) > (t2.totalscore))
            {
                Console.WriteLine("winner is team1");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("winner is team2");
                Console.ReadLine();
            }
        }
        public void manofmatch()
        {
            if (t1.Max.score > t2.Max.score)
            {
                Console.WriteLine("man of match is" + t1.Max.name);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("man of match is" + t2.Max.name);
                Console.ReadLine();
            }
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
         
            Match m = new Match();
            m.result();
            m.winner();
            m.manofmatch();
        }
    }
}
