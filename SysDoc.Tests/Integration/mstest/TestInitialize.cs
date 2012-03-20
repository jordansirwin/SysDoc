using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlServerCe;
using NHibernate.Cfg;
using SysDoc.Models;
using NHibernate.Tool.hbm2ddl;
using SysDoc.Repositories;
using NSpec;

namespace SysDoc.Tests.Integration.mstest
{
    [TestClass]
    public class TestInitialize
    {
        private static string _dbName = "IntegrationTestsDb.sdf";

        [AssemblyInitialize]
        public static void InitializeDatabase(TestContext context)
        {
            new SqlCeEngine("Data Source=" + _dbName).CreateDatabase();

            var configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof(Node).Assembly);
            new SchemaExport(configuration).Execute(true, true, false);

            SeedDatabase();
        }

        private static void SeedDatabase()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var trans = session.BeginTransaction())
            {
                session.Save(new Node { Name = "Seed 1" });
                session.Save(new Node { Name = "Seed 2" });
                session.Save(new Node { Name = "Seed 3" });
                session.Save(new Node { Name = "Seed 4" });
                session.Save(new Node { Name = "Seed 5" });
                trans.Commit();
            }
        }

        [AssemblyCleanup]
        public static void Cleanup()
        {
            System.IO.File.Delete(_dbName);
        }
    }
}
