using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAppForGit;

namespace MovieAppForGit.Data
{
    public class MovieAppForGitContext : DbContext
    {
        public MovieAppForGitContext (DbContextOptions<MovieAppForGitContext> options)
            : base(options)
        {
        }

        public DbSet<MovieAppForGit.Movie> Movie { get; set; } = default!;
    }
}
