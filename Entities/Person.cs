using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieAPIDemo.Entities
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Movie> Movies { get; set; } // Many to many relation as actor can appear in many movies and 1 movie can have many actors
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
