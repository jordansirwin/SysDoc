namespace SysDoc.Services
{
    public interface IManageNodeService
    {
         void LinkNodes(int dependentNodeId, int dependencyNodeId);
    }
}
