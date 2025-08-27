using Microsoft.EntityFrameworkCore;
using System;

namespace DotnetCore_CrudProject.Models
{
    public class ApplicationDBContext: DbContext
    {
        //ApplicationDBContext is child class and DbContext is parent class which is used for Database opertions using Code-First-Approach
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        //It will represent tables of databases which is created using migrations
        public DbSet<StudentModel> Students { get; set; }
    }
}
