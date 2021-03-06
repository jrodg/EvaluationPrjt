﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace GitHub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gig> Gig { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<ContactModel> Contacts { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public ApplicationDbContext()
            : base("GitHub", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}