namespace SysDoc.Core
{
    public interface INodeRepository
    {
        Models.Node Add(Models.Node node);
        Models.Node Get(int id);
        void LinkNodes(int dependentNodeId, int dependencyNodeId);
    }
}
