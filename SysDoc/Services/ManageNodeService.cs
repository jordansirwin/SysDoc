using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysDoc.Services
{
    public class ManageNodeService
    {
        private Core.INodeRepository _nodeRepository;

        public ManageNodeService(Core.INodeRepository nodeRepository)
        {
            _nodeRepository = nodeRepository;
        }

        public void LinkNodes(int dependentNodeId, int dependencyNodeId)
        {
            _nodeRepository.LinkNodes(dependentNodeId, dependencyNodeId);
        }
    }
}
