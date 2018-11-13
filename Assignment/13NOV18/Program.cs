using System;

namespace _13NOV2018
{
    public class Details
    {
        public string name;
        public int id;
    }
    public class Team:Details
    {
        
        public Player[] p = new Player[3];
        public Player Max = new Player();
        public int totalscore = 0;
        
        public void inputteam()
        {
            Console.WriteLine("enter the Team name");
            name = Console.ReadLine();
            Console.WriteLine("enter the Team ID");
            id = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<3;i++)
            {
                p[i] = new Player();
                p[i].inputplayer();
                Console.ReadLine();
            }
            
            Console.ReadLine();
        }
        public void totalscoreofteam()
        {
            for(int i=0;i<3;i++)
            {
               if(p[i].score>Max.score)
                {
                    Max.score = p[i].score;
                    Max.name = p[i].name;

                }
                totalscore= p[i].score + totalscore;
            
                
            }
            Console.WriteLine("total score of team is:" +totalscore);
            Console.ReadLine();
            
        }

        public void outputteam()
        {
            Console.WriteLine("NAME OF TEAM IS:" + name);
            Console.WriteLine("Team ID IS:" + id);
            for(int i=0;i<3;i++)
            {
                
                p[i].outputplayer();
                Console.ReadLine();
            }
            
        }
        


    }
    public class Player:Details
    {
        
        public int  score;
        public void inputplayer()
        {
            Console.WriteLine("enter the player name");
            name = Console.ReadLine();
            Console.WriteLine("enter the player ID");
            id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the score");
            score = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


        }
        public void outputplayer()
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

            t1.inputteam();
            t1.outputteam();
            t2.inputteam();
            t2.outputteam();
            t1.totalscoreofteam();
            t2.totalscoreofteam();


        }
        public void winner()
        {
            if((t1.totalscore)>(t2.totalscore))
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
        public void  manofmatch()
        {
            if(t1.Max.score > t2.Max.score)
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

