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

namespace SysDoc.IntegrationTests
{
    [TestClass]
    public static class TestInitialize
    {
        [AssemblyInitialize]
        public static void initialize_new_database_for_testing(TestContext testContext)
        {
            new SqlCeEngine("Data Source=IntegrationTestsDb.sdf").CreateDatabase();

            var configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof(Node).Assembly);
            new SchemaExport(configuration).Execute(true, true, false);

            seed_database();
        }

        private static void seed_database()
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
    }
}
