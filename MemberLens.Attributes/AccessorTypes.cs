namespace MemberLens.Attributes
{
    /// <summary>
    /// Determines what types of members the MemberAccessor parameter should provide autocomplete suggestions for.
    /// </summary>
    public enum AccessorTypes
    {
        /// <summary>
        /// Fields on the source type
        /// </summary>
        Field = 0,
        /// <summary>
        /// Methods on the source type
        /// </summary>
        Method = 1
    }
}
