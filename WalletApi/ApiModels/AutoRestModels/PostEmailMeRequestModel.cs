// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PostEmailMeRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the PostEmailMeRequestModel class.
        /// </summary>
        public PostEmailMeRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PostEmailMeRequestModel class.
        /// </summary>
        public PostEmailMeRequestModel(string assetId = default(string), string bcnAddress = default(string))
        {
            AssetId = assetId;
            BcnAddress = bcnAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BcnAddress")]
        public string BcnAddress { get; set; }

    }
}
