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
        //private SqlAddressRepository addressRepo;
        private TransactionScope transaction;

        [TestInitialize]
        public void InitializeTest()
        {
            personRepo = new SqlPersonRepository(connectionString);
            addressRepo = new SqlAddressRepository(connectionString);

            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            transaction.Dispose();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
