namespace CustomMediator.Net.Contracts
{
    public readonly struct CustomVoid : IEquatable<CustomVoid>, IComparable<CustomVoid>, IComparable
    {
        private static readonly CustomVoid _value = new();

        /// <summary>
        /// Default and only value of the <see cref="Unit"/> type.
        /// </summary>
        public static ref readonly CustomVoid Value => ref _value;

        /// <summary>
        /// Compares the current instance with another object of the same type 
        /// and returns an integer that indicates whether the current instance precedes, follows, 
        /// or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object? obj) => 0;

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns></returns>
        public int CompareTo(CustomVoid other) => 0;

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Return always true</returns>
        public bool Equals(CustomVoid other) => true;
    }
}
