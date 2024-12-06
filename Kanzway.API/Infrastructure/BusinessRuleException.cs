using System.Runtime.Serialization;

namespace Kanzway.API.Infrastructure
{
    /// <summary>
    /// Class to be used for business rules exceptions
    /// </summary>
    [Serializable]
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException() { }
        public BusinessRuleException(string message) : base(message) { }

        protected BusinessRuleException(SerializationInfo info,
        StreamingContext context) : base(info, context)
        {
        }
    }
}
