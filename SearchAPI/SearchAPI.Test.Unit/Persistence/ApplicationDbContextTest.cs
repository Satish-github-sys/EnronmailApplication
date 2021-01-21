using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using SearchAPI.Domain.Entities;
using SearchAPI.Persistence;

namespace SearchAPI.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertCustomerIntoDatabasee()
        {

            using var context = new ApplicationDbContext();
            var c = new Output();
            context.Output.Add(c);
            Assert.AreEqual(EntityState.Added, context.Entry(c).State);
        }
    }
}
