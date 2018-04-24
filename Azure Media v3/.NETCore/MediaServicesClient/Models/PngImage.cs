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
    /// This class represents a video encoder which outputs a sequence of Png
    /// images.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.PngImage")]
    public partial class PngImage : Image
    {
        /// <summary>
        /// Initializes a new instance of the PngImage class.
        /// </summary>
        public PngImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PngImage class.
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
        /// <param name="start">Gets or sets the start position in the input
        /// from where to generate the thumbnails. Can be either absolute
        /// duration (e.g: PT05S) or relative value (e.g: 100%) Can also be a
        /// value like {Best} to select the best thumbnail.</param>
        /// <param name="step">Gets or sets the step condition attribute for
        /// the thumbnails. Can be either absolute duration (e.g: PT05S) or
        /// relative value (e.g: 10%)</param>
        /// <param name="range">Gets or sets the Duration till which to
        /// generate the thumbnails. Can be either absolute duration (e.g:
        /// PT05S) or relative value (e.g: 100%)</param>
        /// <param name="layers">Gets the list of image layers.</param>
        public PngImage(string label = default(string), bool? preserveResolutionAfterRotation = default(bool?), System.TimeSpan? keyFrameInterval = default(System.TimeSpan?), StretchMode? stretchMode = default(StretchMode?), VideoSyncMode? syncMode = default(VideoSyncMode?), string start = default(string), string step = default(string), string range = default(string), IList<PngLayer> layers = default(IList<PngLayer>))
            : base(label, preserveResolutionAfterRotation, keyFrameInterval, stretchMode, syncMode, start, step, range)
        {
            Layers = layers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of image layers.
        /// </summary>
        [JsonProperty(PropertyName = "layers")]
        public IList<PngLayer> Layers { get; set; }

    }
}
