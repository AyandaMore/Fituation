using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FituationAPI.EntityFrameworkCore
{
    public static class FituationAPIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FituationAPIDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FituationAPIDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
