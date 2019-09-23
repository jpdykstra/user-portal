using JPD.Demo.Service.Data;
using Microsoft.EntityFrameworkCore;

namespace JPD.Demo.Tests
{
    public abstract class BaseDataTests
    {
        protected readonly UserContext _context;

        public BaseDataTests()
        {
            var database = new DbContextOptionsBuilder<UserContext>();

            database.UseInMemoryDatabase(databaseName: "Data_Tests");

            _context = new UserContext(database.Options);

            _context.Database.EnsureDeleted();

            _context.Database.EnsureCreated();
        }
    }
}
