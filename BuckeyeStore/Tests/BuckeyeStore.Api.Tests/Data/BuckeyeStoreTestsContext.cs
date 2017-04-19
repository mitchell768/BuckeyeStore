using Microsoft.EntityFrameworkCore;
using BuckeyeStore.Core;

namespace BuckeyeStore.Api.Tests.Data{
    public class BuckeyeStoreTestsContext : DbContext
    {
        public BuckeyeStoreTestsContext(){}
        public BuckeyeStoreTestsContext(DbContextOptions<BuckeyeStoreTestsContext> options) : base(options) {}
        public DbSet<Product> Products {get; set;}
    }
}