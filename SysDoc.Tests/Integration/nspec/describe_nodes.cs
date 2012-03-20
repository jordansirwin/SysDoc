//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using NHibernate.Cfg;
//using SysDoc.Models;
//using NHibernate.Tool.hbm2ddl;
//using NHibernate;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Data.SqlServerCe;
//using SysDoc.Repositories;
//using NSpec;

//namespace SysDoc.Tests.Integration
//{
//    [TestClass]
//    public class describe_nodes : nspec
//    {
//        private NodeRepository _repo;
//        private Node _node;

//        public void before_all()
//        {
//        }

//        public void before_each()
//        {
//            _repo = new NodeRepository();
//            _node = new Node();
//        }

//        public void when_adding_a_node()
//        {
//            //it["the name should be required"] = expect<NullReferenceException>(() => _repo.Add(_node));
//            it["the id should be populated by the database"] = () => _repo.Add(_node).Id.should_be_greater_than(0);
//        }

//        public void when_getting_a_node()
//        {
//            context["with a valid id"] = () =>
//            {
//                const int validId = 1;
//                before = () => _node = _repo.Get(validId);
//                it["the returned node should not be null"] = () => _node.should_not_be_null();
//                it["the returned node should have a matching Id"] = () => _node.Id.should_be_same(validId);
//            }; 
            
//            context["with an invalid id"] = () =>
//            {
//                const int invalidId = -1;
//                before = () => _node = _repo.Get(invalidId);
//                it["the returned node should be null"] = () => _node.should_not_be_null();
//            };
//        }
//    }
//}
