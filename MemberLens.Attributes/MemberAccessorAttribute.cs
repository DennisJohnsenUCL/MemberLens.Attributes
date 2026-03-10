namespace MemberLens.Attributes
{
    /// <summary>
    /// Attribute to decorate string parameters that should provide autocomplete suggestions with.
    /// </summary>
    /// <remarks>
    /// Decorate string parameters with this when the string parameter is used for reflection,
    /// such as being passed to GetField or GetMethod, when you want stronger safety for the member name.
    /// If the MemberLens VS extension is installed, these parameters will get autocomplete suggestions for the type members.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class MemberAccessorAttribute : Attribute
    {
        public AccessorTypes AccessorTypes { get; }
        public Type? Type { get; }
        public GenericSources? GenericSources { get; }
        public int? GenericIndex { get; }

        /// <summary>
        /// Constructor for building a statically typed MemberAccessor.
        /// </summary>
        /// <param name="accessorTypes">The member type.</param>
        /// <param name="type">The source type of the member names.</param>
        public MemberAccessorAttribute(AccessorTypes accessorTypes, Type type)
        {
            AccessorTypes = accessorTypes;
            Type = type;
        }

        /// <summary>
        /// Constructor for building a MemberAccessor when the source type is a generic parameter on the containing class or method and cannot be given statically.
        /// </summary>
        /// <param name="accessorTypes">The member type.</param>
        /// <param name="genericSource">The source of the generic parameter.</param>
        /// <param name="genericIndex">The index of the generic parameter.</param>
        public MemberAccessorAttribute(AccessorTypes accessorTypes, GenericSources genericSource, int genericIndex)
        {
            AccessorTypes = accessorTypes;
            GenericSources = genericSource;
            GenericIndex = genericIndex;
        }
    }
}
