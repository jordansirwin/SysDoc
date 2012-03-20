using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysDoc.Models;
using SysDoc.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSpec;
using SysDoc.Services;
using SysDoc.Core;

namespace SysDoc.Tests.Integration.mstest.describe_nodes
{
    [TestClass]
    public class when_adding_a_node
    {
        private INodeRepository _repo;
        private IManageNodeService _svc;

        [TestInitialize]
        public void before_each()
        {
            _repo = new NodeRepository();
            _svc = new ManageNodeService(_repo);
        }

        [TestMethod]
        public void the_id_should_be_populated_by_the_repository()
        {
            var node = new Node { Name = "test" };
            _repo.Add(node).Id.should_be_greater_than(0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void the_name_cannot_be_null()
        {
            var node = new Node { Name = null };
            _svc.AddNode(node);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void the_name_cannot_be_empty()
        {
            var node = new Node { Name = string.Empty };
            _svc.AddNode(node);
        }
    }
}
