using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skriftlig_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Ballsport ballsport = new Ballsport("Soccer","","Hand","Football");
            
            Console.WriteLine(ballsport.Name+" "+ballsport.BallType);
            Console.ReadLine();
             
        }
    }
}
