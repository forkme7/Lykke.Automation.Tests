// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OffchainLimitCancelModel
    {
        /// <summary>
        /// Initializes a new instance of the OffchainLimitCancelModel class.
        /// </summary>
        public OffchainLimitCancelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OffchainLimitCancelModel class.
        /// </summary>
        public OffchainLimitCancelModel(string orderId = default(string))
        {
            OrderId = orderId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderId")]
        public string OrderId { get; set; }

    }
}
