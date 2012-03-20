using SysDoc.Models;
namespace SysDoc.Services
{
    public interface IManageNodeService
    {
        ValidationResult<Node> Validate(Node node);
        void AddNode(Node node);
        void LinkNodes(int dependentNodeId, int dependencyNodeId);
    }
}
