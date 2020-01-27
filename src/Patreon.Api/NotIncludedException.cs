using System;

namespace Patreon.Api
{
    public class NotIncludedException : Exception
    {
        public NotIncludedException() : base("Field is not included.") { }

        public NotIncludedException(string message) : base(message) { }
    }

    /// <summary> The error that occurs when an excluded property gets accessed.</summary>
    /// <typeparam name="T"> The flags used for marking uncluded properies.</typeparam>
    public class NotIncludedException<T> : NotIncludedException
    {
        /// <summary> Initializes a new instance of <see cref="NotIncludedException{T}"/> class with flag information.</summary>
        /// <param name="missingFlag"> The flag requirement that has not been met.</param>
        public NotIncludedException(T missingFlag) :
            base($"Flag {missingFlag} is not included in the object.")
        { }

        /// <summary> Initializes a new instance of <see cref="NotIncludedException{T}"/> class with flag and property information.</summary>
        /// <param name="missingFlag"> The flag requirement that has not been met.</param>
        /// <param name="propertyName"> The property name where the required flag has not been met.</param>
        public NotIncludedException(T missingFlag, string propertyName) :
            base($"{propertyName} requires {missingFlag} to be set in the object")
        { }
    }
}
