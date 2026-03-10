namespace MemberLens.Attributes
{
    /// <summary>
    /// Specifies whether the source for a MemberAccessor source type is a generic parameter on the class or the method,
    /// when the source type is generic and cannot be given statically.
    /// </summary>
    public enum GenericSources
    {
        /// <summary>
        /// The source type is a generic parameter on the containing class.
        /// </summary>
        Class = 0,
        /// <summary>
        /// The source type is a generic parameter on the containing method.
        /// </summary>
        Method = 1
    }
}
