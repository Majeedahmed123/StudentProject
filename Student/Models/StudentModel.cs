using System;
using System.Data.Entity;

namespace Student.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string studentname { get; set; }
        public DateTime dateofbirth { get; set; }
        public string Gender { get; set; }
        public decimal fee { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Movie> Students { get; set; }
    }
}