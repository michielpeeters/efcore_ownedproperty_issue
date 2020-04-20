namespace ClassLibrary1
{
    using Microsoft.EntityFrameworkCore;

    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options) { }

        public virtual DbSet<TestClassBase> TestClassBases { get; set; }
        public virtual DbSet<TestClass> TestClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TestClass>()
            //    .OwnsOne(c => c.TestProperty,
            //        b =>
            //        {
            //            b.Property(c => c.SomeDoubleValue).HasColumnName("TestProperty_SomeDoubleValue");
            //        });
        }
    }
}