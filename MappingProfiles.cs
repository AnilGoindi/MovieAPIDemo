using AutoMapper;
using MovieAPIDemo.Entities;
using MovieAPIDemo.Models;

namespace MovieAPIDemo
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Movie, MovieListViewModel>(); // Now in MovieController.cs mapping is done
            CreateMap<Movie, MovieDetailsViewModel>(); // Now in MovieController.cs mapping is done
            CreateMap<MovieListViewModel , Movie>(); // Now in MovieController.cs mapping is done
            CreateMap<CreateMovieViewModel, Movie>().ForMember(x => x.Actors, y => y.Ignore()); // Ignore Actor fields

            CreateMap<Person, ActorViewModel>();
            CreateMap<Person, ActorDetailsViewModel>();
            CreateMap<ActorViewModel, Person>();

        }
    }
}
