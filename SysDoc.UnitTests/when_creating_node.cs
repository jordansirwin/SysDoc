//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using NSpec;
//using SysDoc.Services;

//namespace SysDoc.UnitTests
//{
//    class when_creating_node : nspec
//    {
//        void should_return_a_node_with_id()
//        {
//            new Models.Node().Id.should_not_be(Guid.Empty);
//        }

//        void should_return_a_node_with_empty_dependents()
//        {
//            new Models.Node().Dependents.should_be_empty();
//        }

//        void should_return_a_node_with_empty_dependencies()
//        {
//            new Models.Node().Dependencies.should_not_be_empty();
//        }
//    }
//}
