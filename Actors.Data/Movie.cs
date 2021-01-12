using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Data
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }

        public List<Actor> Actors { get; set; } = new List<Actor>();
    }
}
