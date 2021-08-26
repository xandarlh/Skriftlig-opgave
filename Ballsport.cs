using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skriftlig_opgave
{
    public class Ballsport : Sport, IField
    {
        public string Playstyle { get; set; }
        public string BallType { get; set; }

        public Ballsport(string name, string description, string playstyle, string ballType) : base(name, description)
        {
            this.Playstyle = playstyle;
            this.BallType = ballType;
        }

        public string displayField()
        {
            return "Sportfield";
        }
    }
}
