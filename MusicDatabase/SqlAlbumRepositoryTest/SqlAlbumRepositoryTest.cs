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
        //private static string GetTestDateTime() => Guid.NewGuid();


        private SqlAlbumRepository repo;
        
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
            var name = GetTestString();
            var release = DateTime.Now;
            

            var actual = repo.CreateAlbum(name, release);

            Assert.IsNotNull(actual);
            Assert.AreEqual(name, actual.Name);
            Assert.AreEqual(release, actual.ReleaseDate);
        }
    }
}
