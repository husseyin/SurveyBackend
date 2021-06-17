using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class SurveyContext : DbContext
    {
        public SurveyContext() : base("survey")
        {

        }


        public DbSet<Answer> Answers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
