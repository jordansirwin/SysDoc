using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysDoc.Models;

namespace SysDoc.Services
{
    public class ManageNodeService : IManageNodeService
    {
        private Core.INodeRepository _nodeRepository;

        public ManageNodeService(Core.INodeRepository nodeRepository)
        {
            _nodeRepository = nodeRepository;
        }

        public ValidationResult<Node> Validate(Node node)
        {
            var result =  new ValidationResult<Node>();

            if (string.IsNullOrWhiteSpace(node.Name))
                result.ValidationErrors.Add("Name is required");

            return result;
        }

        public void AddNode(Node node)
        {
            var validationResult = Validate(node);
            if (!validationResult.IsValid)
                throw new InvalidOperationException("Node is not valid. Call Validate() for details.");

            _nodeRepository.Add(node);
        }

        public void LinkNodes(int dependentNodeId, int dependencyNodeId)
        {
            _nodeRepository.LinkNodes(dependentNodeId, dependencyNodeId);
        }
    }
}
