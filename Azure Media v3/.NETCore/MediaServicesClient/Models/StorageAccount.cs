// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage account properties.
    /// </summary>
    public partial class StorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="type">The type of the storage account. Possible values
        /// include: 'Primary', 'Secondary'</param>
        /// <param name="id">The ID of the storage account resource. Media
        /// Services relies on tables and queues as well as blobs, so the
        /// primary storage account must be a Standard Storage account (either
        /// Microsoft.ClassicStorage or Microsoft.Storage). Blob only storage
        /// accounts can be added as secondary storage accounts.</param>
        public StorageAccount(StorageAccountType type, string id = default(string))
        {
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the storage account resource. Media Services
        /// relies on tables and queues as well as blobs, so the primary
        /// storage account must be a Standard Storage account (either
        /// Microsoft.ClassicStorage or Microsoft.Storage). Blob only storage
        /// accounts can be added as secondary storage accounts.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the storage account. Possible values
        /// include: 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public StorageAccountType Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
