using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skriftlig_opgave
{
    public abstract class Sport
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Sport(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
