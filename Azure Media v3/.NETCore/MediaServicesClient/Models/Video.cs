// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for all video codecs.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.Video")]
    public partial class Video : Codec
    {
        /// <summary>
        /// Initializes a new instance of the Video class.
        /// </summary>
        public Video()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Video class.
        /// </summary>
        /// <param name="label">Gets or sets the codec label.</param>
        /// <param name="preserveResolutionAfterRotation">Gets or sets a value
        /// indicating whether to disable resolution change rotation.</param>
        /// <param name="keyFrameInterval">Gets or sets the distance between
        /// two key frames.</param>
        /// <param name="stretchMode">Gets or sets the Resolution Mode.
        /// Possible values include: 'None', 'AutoSize', 'AutoFit'</param>
        /// <param name="syncMode">Gets or sets the Video Sync Mode. Possible
        /// values include: 'Auto', 'Passthrough', 'Cfr', 'Vfr', 'Drop'</param>
        public Video(string label = default(string), bool? preserveResolutionAfterRotation = default(bool?), System.TimeSpan? keyFrameInterval = default(System.TimeSpan?), StretchMode? stretchMode = default(StretchMode?), VideoSyncMode? syncMode = default(VideoSyncMode?))
            : base(label)
        {
            PreserveResolutionAfterRotation = preserveResolutionAfterRotation;
            KeyFrameInterval = keyFrameInterval;
            StretchMode = stretchMode;
            SyncMode = syncMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether to disable resolution
        /// change rotation.
        /// </summary>
        [JsonProperty(PropertyName = "preserveResolutionAfterRotation")]
        public bool? PreserveResolutionAfterRotation { get; set; }

        /// <summary>
        /// Gets or sets the distance between two key frames.
        /// </summary>
        [JsonProperty(PropertyName = "keyFrameInterval")]
        public System.TimeSpan? KeyFrameInterval { get; set; }

        /// <summary>
        /// Gets or sets the Resolution Mode. Possible values include: 'None',
        /// 'AutoSize', 'AutoFit'
        /// </summary>
        [JsonProperty(PropertyName = "stretchMode")]
        public StretchMode? StretchMode { get; set; }

        /// <summary>
        /// Gets or sets the Video Sync Mode. Possible values include: 'Auto',
        /// 'Passthrough', 'Cfr', 'Vfr', 'Drop'
        /// </summary>
        [JsonProperty(PropertyName = "syncMode")]
        public VideoSyncMode? SyncMode { get; set; }

    }
}
