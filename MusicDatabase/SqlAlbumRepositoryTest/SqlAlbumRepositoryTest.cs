using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Transactions;
using MusicDatabase.Models;
using MusicDatabase;

namespace MusicDatabase.Tests
{
    [TestClass]
    public class SqlAlbumRepositoryTest
    {

        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=   ;Integrated Security=SSPI;";

        private static string GetTestString() => Guid.NewGuid().ToString("N");

        private SqlAlbumRepository albumRepo;
        
        private TransactionScope transaction;

        [TestInitialize]
        public void InitializeTest()
        {
            repo = new SqlAlbumRepository(connectionString);
          
            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            transaction.Dispose();
        }

        [TestMethod]
        public void CreateAlbumShouldWork()
        {
            var title = GetTestString();
            var release = GetTestString();
            

            var actual = repo.CreatePerson(firstName, lastName, email);

            Assert.IsNotNull(actual);
            Assert.AreEqual(firstName, actual.FirstName);
            Assert.AreEqual(lastName, actual.LastName);
            Assert.AreEqual(email, actual.Email);
        }
    }
}
