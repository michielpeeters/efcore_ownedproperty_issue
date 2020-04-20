namespace ClassLibrary1
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class TestDbContextDesignFactory : IDesignTimeDbContextFactory<TestDbContext>
    {
        public TestDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<TestDbContext>().UseSqlServer("Server=.;Database=Test;Integrated Security=SSPI;");
            return new TestDbContext(options.Options);
        }
    }
}