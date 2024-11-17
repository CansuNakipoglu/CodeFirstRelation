using CodeFirstRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Data
{
    public class SqlDbContext : DbContext
    {

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<PostEntity> Posts => Set<PostEntity>();
    }
}
