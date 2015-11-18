using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MusicStore.Models
{
    public class MusicStoreEntities : DbContext
    {
        // properties to hold data for types albums and genres
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
