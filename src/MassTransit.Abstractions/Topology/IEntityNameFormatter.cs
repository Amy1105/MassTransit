namespace MassTransit
{
    /// <summary>
    /// Used to build entity names for the publish topology
    /// 用于为发布拓扑构建实体名称
    /// </summary>
    public interface IEntityNameFormatter
    {
        /// <summary>
        /// Formats the entity name for the given message type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        string FormatEntityName<T>();
    }
}
