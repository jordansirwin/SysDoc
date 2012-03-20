using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using SysDoc.Models;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlServerCe;
using SysDoc.Repositories;

namespace SysDoc.IntegrationTests
{
    [TestClass]
    public class node_repository_can
    {        
        [TestMethod]
        public void add_new_node()
        {
            var node = new Node();
            var repo = new NodeRepository();
            repo.Add(node);

            var found = repo.Get(node.Id.Value);

            Assert.IsNotNull(found);
            Assert.AreEqual(node.Id, found.Id);
        }

        [TestMethod]
        public void get_new_node()
        {
            var id = 1;
            var repo = new NodeRepository();
            var found = repo.Get(id);

            Assert.IsNotNull(found);
            Assert.AreEqual(id, found.Id);
        }
    }
}
