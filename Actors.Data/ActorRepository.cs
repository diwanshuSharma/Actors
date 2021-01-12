using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Data
{
    public class ActorRepository : IActorRepository
    {
        ActorContextDB db = new ActorContextDB();

        public Actor GetActorById(int id)
        {
            var actor = (from a in db.Actors.Include("Movies")
                         where a.ActorId == id
                         select a).FirstOrDefault();

            return actor;
        }

        public List<Actor> GetActors()
        {
            var actors = db.Actors.Include("Movies").ToList();
            
            return actors;
        }

        public void AddActor(Actor actor)
        {
            db.Actors.Add(actor);
            db.SaveChanges();
        }

        public List<Movie> GetMovies()
        {
            return db.Movies.ToList();
        }

        public void AddMovieToActor(int id, Movie movie)
        {
            var actor = db.Actors.FirstOrDefault(x => x.ActorId == id);
            actor.Movies.Add(movie);
            db.SaveChanges();
        }
    }
}
