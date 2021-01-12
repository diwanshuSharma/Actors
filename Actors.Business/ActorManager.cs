using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actors.Data;
using Grpc.Core;

namespace Actors.Business
{
    public class ActorManager : IActorManager
    {
        IActorRepository repo = new ActorRepository();

        public List<Actor> GetActors()
        {
            return repo.GetActors();
        }
        public Actor GetActorById(int id)
        {
            return repo.GetActorById(id);
        }

        public void AddActor(Actor actor, string filename)
        {

            if(actor != null)
            {
                var addActor = new Actor()
                {
                    ActorId = actor.ActorId,
                    Name = actor.Name,
                    DOB = actor.DOB,
                    ImagePath = filename
                };

                repo.AddActor(addActor);
            }
        }

        public List<Movie> GetMovies()
        {
            return repo.GetMovies();
        }

        public void AddMovieToActor(int id, Movie movie)
        {
            repo.AddMovieToActor(id, movie);
        }
    }
}
