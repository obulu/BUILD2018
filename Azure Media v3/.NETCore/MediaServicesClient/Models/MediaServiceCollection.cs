// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A collection of Media Services accounts.
    /// </summary>
    public partial class MediaServiceCollection
    {
        /// <summary>
        /// Initializes a new instance of the MediaServiceCollection class.
        /// </summary>
        public MediaServiceCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaServiceCollection class.
        /// </summary>
        /// <param name="value">A collection of Media Services
        /// accounts.</param>
        /// <param name="odatanextLink">A link to the next page of the
        /// collection (when the collection contains too many results to return
        /// in one response).</param>
        public MediaServiceCollection(IList<MediaService> value = default(IList<MediaService>), string odatanextLink = default(string))
        {
            Value = value;
            OdatanextLink = odatanextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of Media Services accounts.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MediaService> Value { get; set; }

        /// <summary>
        /// Gets or sets a link to the next page of the collection (when the
        /// collection contains too many results to return in one response).
        /// </summary>
        [JsonProperty(PropertyName = "@odata.nextLink")]
        public string OdatanextLink { get; set; }

    }
}
