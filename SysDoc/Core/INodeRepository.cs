namespace SysDoc.Core
{
    public interface INodeRepository
    {
        void Add(Models.Node node);
        Models.Node Get(int id);
        void LinkNodes(int dependentNodeId, int dependencyNodeId);
    }
}
