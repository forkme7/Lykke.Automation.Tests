// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OwnershipMsgModel
    {
        /// <summary>
        /// Initializes a new instance of the OwnershipMsgModel class.
        /// </summary>
        public OwnershipMsgModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OwnershipMsgModel class.
        /// </summary>
        public OwnershipMsgModel(string message = default(string))
        {
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

    }
}
