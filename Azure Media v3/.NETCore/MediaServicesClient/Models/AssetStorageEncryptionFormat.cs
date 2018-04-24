// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for AssetStorageEncryptionFormat.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(AssetStorageEncryptionFormatConverter))]
    public struct AssetStorageEncryptionFormat : System.IEquatable<AssetStorageEncryptionFormat>
    {
        private AssetStorageEncryptionFormat(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// The Asset does not use client-side storage encryption (this is the
        /// only allowed value for new Assets).
        /// </summary>
        public static readonly AssetStorageEncryptionFormat None = "None";

        /// <summary>
        /// The Asset is encrypted with Media Services client-side encryption.
        /// </summary>
        public static readonly AssetStorageEncryptionFormat MediaStorageClientEncryption = "MediaStorageClientEncryption";

        /// <summary>
        /// The Asset is encrypted with static Common Encryption.
        /// </summary>
        public static readonly AssetStorageEncryptionFormat StaticCommonEncryption = "StaticCommonEncryption";

        /// <summary>
        /// The Asset is encrypted with static envelope encryption.
        /// </summary>
        public static readonly AssetStorageEncryptionFormat StaticEnvelopeEncryption = "StaticEnvelopeEncryption";


        /// <summary>
        /// Underlying value of enum AssetStorageEncryptionFormat
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for AssetStorageEncryptionFormat
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type AssetStorageEncryptionFormat
        /// </summary>
        public bool Equals(AssetStorageEncryptionFormat e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to AssetStorageEncryptionFormat
        /// </summary>
        public static implicit operator AssetStorageEncryptionFormat(string value)
        {
            return new AssetStorageEncryptionFormat(value);
        }

        /// <summary>
        /// Implicit operator to convert AssetStorageEncryptionFormat to string
        /// </summary>
        public static implicit operator string(AssetStorageEncryptionFormat e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum AssetStorageEncryptionFormat
        /// </summary>
        public static bool operator == (AssetStorageEncryptionFormat e1, AssetStorageEncryptionFormat e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum AssetStorageEncryptionFormat
        /// </summary>
        public static bool operator != (AssetStorageEncryptionFormat e1, AssetStorageEncryptionFormat e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for AssetStorageEncryptionFormat
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AssetStorageEncryptionFormat && Equals((AssetStorageEncryptionFormat)obj);
        }

        /// <summary>
        /// Returns for hashCode AssetStorageEncryptionFormat
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}