using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysDoc.Repositories
{
    public class NodeRepository : Core.INodeRepository
    {
        public Models.Node Add(Models.Node node)
        {
            using(var session = NHibernateHelper.OpenSession())
            using (var trans = session.BeginTransaction())
            {
                session.Save(node);
                trans.Commit();
            }

            return node;
        }

        public Models.Node Get(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Get<Models.Node>(id);
            }
        }

        public void LinkNodes(int dependentNodeId, int dependencyNodeId)
        {
            throw new NotImplementedException();
        }
    }
}
