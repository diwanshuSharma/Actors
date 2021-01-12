using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Data
{
    public interface IActorRepository
    {
        List<Actor> GetActors();
        List<Movie> GetMovies();
        Actor GetActorById(int id);

        void AddActor(Actor actor);
        void AddMovieToActor(int id, Movie movie);
    }
}
