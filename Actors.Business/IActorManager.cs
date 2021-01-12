using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actors.Data;

namespace Actors.Business
{
    public interface IActorManager
    {
        List<Actor> GetActors();
        List<Movie> GetMovies();

        Actor GetActorById(int id);

        void AddActor(Actor actor, string filename);
        void AddMovieToActor(int id, Movie movie);
    }
}
