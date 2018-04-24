// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A class to define de-interlacing settings.
    /// </summary>
    public partial class Deinterlace
    {
        /// <summary>
        /// Initializes a new instance of the Deinterlace class.
        /// </summary>
        public Deinterlace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Deinterlace class.
        /// </summary>
        /// <param name="parity">Gets or sets the parity to use. Possible
        /// values include: 'Auto', 'TopFieldFirst', 'BottomFieldFirst'</param>
        /// <param name="mode">Gets or sets the deinterlace Mode. Possible
        /// values include: 'Off', 'AutoPixelAdaptive'</param>
        public Deinterlace(DeinterlaceParity? parity = default(DeinterlaceParity?), DeinterlaceMode? mode = default(DeinterlaceMode?))
        {
            Parity = parity;
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the parity to use. Possible values include: 'Auto',
        /// 'TopFieldFirst', 'BottomFieldFirst'
        /// </summary>
        [JsonProperty(PropertyName = "parity")]
        public DeinterlaceParity? Parity { get; set; }

        /// <summary>
        /// Gets or sets the deinterlace Mode. Possible values include: 'Off',
        /// 'AutoPixelAdaptive'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DeinterlaceMode? Mode { get; set; }

    }
}