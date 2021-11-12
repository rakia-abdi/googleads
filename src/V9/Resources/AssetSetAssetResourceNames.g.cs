// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>AssetSetAsset</c> resource.</summary>
    public sealed partial class AssetSetAssetName : gax::IResourceName, sys::IEquatable<AssetSetAssetName>
    {
        /// <summary>The possible contents of <see cref="AssetSetAssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c>.
            /// </summary>
            CustomerAssetSetAsset = 1,
        }

        private static gax::PathTemplate s_customerAssetSetAsset = new gax::PathTemplate("customers/{customer_id}/assetSetAssets/{asset_set_id_asset_id}");

        /// <summary>Creates a <see cref="AssetSetAssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetSetAssetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetSetAssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetSetAssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetSetAssetName"/> with the pattern
        /// <c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetSetAssetName"/> constructed from the provided ids.</returns>
        public static AssetSetAssetName FromCustomerAssetSetAsset(string customerId, string assetSetId, string assetId) =>
            new AssetSetAssetName(ResourceNameType.CustomerAssetSetAsset, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetSetAssetName"/> with pattern
        /// <c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetSetAssetName"/> with pattern
        /// <c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c>.
        /// </returns>
        public static string Format(string customerId, string assetSetId, string assetId) =>
            FormatCustomerAssetSetAsset(customerId, assetSetId, assetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetSetAssetName"/> with pattern
        /// <c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetSetAssetName"/> with pattern
        /// <c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c>.
        /// </returns>
        public static string FormatCustomerAssetSetAsset(string customerId, string assetSetId, string assetId) =>
            s_customerAssetSetAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetSetAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetSetAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetSetAssetName"/> if successful.</returns>
        public static AssetSetAssetName Parse(string assetSetAssetName) => Parse(assetSetAssetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetSetAssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetSetAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetSetAssetName"/> if successful.</returns>
        public static AssetSetAssetName Parse(string assetSetAssetName, bool allowUnparsed) =>
            TryParse(assetSetAssetName, allowUnparsed, out AssetSetAssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetSetAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetSetAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetSetAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetSetAssetName, out AssetSetAssetName result) =>
            TryParse(assetSetAssetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetSetAssetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetSetAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetSetAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetSetAssetName, bool allowUnparsed, out AssetSetAssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetSetAssetName, nameof(assetSetAssetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAssetSetAsset.TryParseName(assetSetAssetName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAssetSetAsset(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetSetAssetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private AssetSetAssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string assetSetId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            AssetSetId = assetSetId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetSetAssetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetSetAssetName(string customerId, string assetSetId, string assetId) : this(ResourceNameType.CustomerAssetSetAsset, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Asset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetId { get; }

        /// <summary>
        /// The <c>AssetSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetSetId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerAssetSetAsset: return s_customerAssetSetAsset.Expand(CustomerId, $"{AssetSetId}~{AssetId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetSetAssetName);

        /// <inheritdoc/>
        public bool Equals(AssetSetAssetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AssetSetAssetName a, AssetSetAssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AssetSetAssetName a, AssetSetAssetName b) => !(a == b);
    }

    public partial class AssetSetAsset
    {
        /// <summary>
        /// <see cref="AssetSetAssetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AssetSetAssetName ResourceNameAsAssetSetAssetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AssetSetAssetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AssetSetName"/>-typed view over the <see cref="AssetSet"/> resource name property.
        /// </summary>
        internal AssetSetName AssetSetAsAssetSetName
        {
            get => string.IsNullOrEmpty(AssetSet) ? null : AssetSetName.Parse(AssetSet, allowUnparsed: true);
            set => AssetSet = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }
}
