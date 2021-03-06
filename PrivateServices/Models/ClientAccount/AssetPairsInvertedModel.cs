// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace LykkeAutomationPrivate.Models.ClientAccount.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AssetPairsInvertedModel
    {
        /// <summary>
        /// Initializes a new instance of the AssetPairsInvertedModel class.
        /// </summary>
        public AssetPairsInvertedModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssetPairsInvertedModel class.
        /// </summary>
        public AssetPairsInvertedModel(IList<string> invertedAssetIds = default(IList<string>), string clientId = default(string))
        {
            InvertedAssetIds = invertedAssetIds;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvertedAssetIds")]
        public IList<string> InvertedAssetIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public string ClientId { get; set; }

    }
}
