using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Actors.Data
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //[Display(Name="Upload Actor Image")]
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
