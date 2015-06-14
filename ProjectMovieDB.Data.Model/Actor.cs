using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMovieDB.Data.Model
{
    public class Actor
    {
        // This will be the Primary key for Actor Table
        public int ActorId { get; set; }
        public string ActorFullName { get; set; }
        public int Awards { get; set; }

        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }
    }
}
