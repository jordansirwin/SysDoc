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
    public class when_getting_a_node
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
        public void a_valid_id_should_return_a_node()
        {
            const int validId = 1;
            _repo.Get(validId).should_not_be_null();
        }

        [TestMethod]
        public void a_valid_id_should_return_a_node_with_same_id()
        {
            const int validId = 1;
            _repo.Get(validId).Id.should_be(validId);
        }

        [TestMethod]
        public void an_invalid_id_should_return_null()
        {
            const int invalidId = -1;
            _repo.Get(invalidId).should_be(null);
        }
    }
}
