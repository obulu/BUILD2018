// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object to represent stream selection.
    /// </summary>
    public partial class StreamSelection
    {
        /// <summary>
        /// Initializes a new instance of the StreamSelection class.
        /// </summary>
        public StreamSelection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StreamSelection class.
        /// </summary>
        /// <param name="fileIndex">Gets the file index where the stream is
        /// present.</param>
        /// <param name="streamIndex">Gets the stream index.</param>
        /// <param name="isAbsoluteStreamIndex">Gets a value indicating whether
        /// the stream index is absolute or relative to the stream
        /// type.</param>
        /// <param name="streamSelectionMode">Gets the stream selection mode.
        /// Possible values include: 'SelectionNotSet',
        /// 'SelectHighestBitrateStream', 'SelectLowestBitrateStream',
        /// 'SelectAllStreams'</param>
        public StreamSelection(int fileIndex, int streamIndex, bool? isAbsoluteStreamIndex = default(bool?), StreamSelectionMode? streamSelectionMode = default(StreamSelectionMode?))
        {
            FileIndex = fileIndex;
            StreamIndex = streamIndex;
            IsAbsoluteStreamIndex = isAbsoluteStreamIndex;
            StreamSelectionMode = streamSelectionMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the file index where the stream is present.
        /// </summary>
        [JsonProperty(PropertyName = "fileIndex")]
        public int FileIndex { get; set; }

        /// <summary>
        /// Gets the stream index.
        /// </summary>
        [JsonProperty(PropertyName = "streamIndex")]
        public int StreamIndex { get; set; }

        /// <summary>
        /// Gets a value indicating whether the stream index is absolute or
        /// relative to the stream type.
        /// </summary>
        [JsonProperty(PropertyName = "isAbsoluteStreamIndex")]
        public bool? IsAbsoluteStreamIndex { get; set; }

        /// <summary>
        /// Gets the stream selection mode. Possible values include:
        /// 'SelectionNotSet', 'SelectHighestBitrateStream',
        /// 'SelectLowestBitrateStream', 'SelectAllStreams'
        /// </summary>
        [JsonProperty(PropertyName = "streamSelectionMode")]
        public StreamSelectionMode? StreamSelectionMode { get; set; }

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
