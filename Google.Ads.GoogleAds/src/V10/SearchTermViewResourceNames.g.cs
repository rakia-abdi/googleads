// Copyright 2022 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V10.Resources
{
    /// <summary>Resource name for the <c>SearchTermView</c> resource.</summary>
    public sealed partial class SearchTermViewName : gax::IResourceName, sys::IEquatable<SearchTermViewName>
    {
        /// <summary>The possible contents of <see cref="SearchTermViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>.
            /// </summary>
            CustomerCampaignAdGroupQuery = 1,
        }

        private static gax::PathTemplate s_customerCampaignAdGroupQuery = new gax::PathTemplate("customers/{customer_id}/searchTermViews/{campaign_id_ad_group_id_query}");

        /// <summary>Creates a <see cref="SearchTermViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SearchTermViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SearchTermViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SearchTermViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SearchTermViewName"/> with the pattern
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queryId">The <c>Query</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SearchTermViewName"/> constructed from the provided ids.</returns>
        public static SearchTermViewName FromCustomerCampaignAdGroupQuery(string customerId, string campaignId, string adGroupId, string queryId) =>
            new SearchTermViewName(ResourceNameType.CustomerCampaignAdGroupQuery, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), queryId: gax::GaxPreconditions.CheckNotNullOrEmpty(queryId, nameof(queryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchTermViewName"/> with pattern
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queryId">The <c>Query</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SearchTermViewName"/> with pattern
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string adGroupId, string queryId) =>
            FormatCustomerCampaignAdGroupQuery(customerId, campaignId, adGroupId, queryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchTermViewName"/> with pattern
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queryId">The <c>Query</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SearchTermViewName"/> with pattern
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>.
        /// </returns>
        public static string FormatCustomerCampaignAdGroupQuery(string customerId, string campaignId, string adGroupId, string queryId) =>
            s_customerCampaignAdGroupQuery.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(queryId, nameof(queryId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="searchTermViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SearchTermViewName"/> if successful.</returns>
        public static SearchTermViewName Parse(string searchTermViewName) => Parse(searchTermViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchTermViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchTermViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SearchTermViewName"/> if successful.</returns>
        public static SearchTermViewName Parse(string searchTermViewName, bool allowUnparsed) =>
            TryParse(searchTermViewName, allowUnparsed, out SearchTermViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="searchTermViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchTermViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchTermViewName, out SearchTermViewName result) =>
            TryParse(searchTermViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchTermViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchTermViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchTermViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchTermViewName, bool allowUnparsed, out SearchTermViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(searchTermViewName, nameof(searchTermViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignAdGroupQuery.TryParseName(searchTermViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignAdGroupQuery(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(searchTermViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private SearchTermViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string campaignId = null, string customerId = null, string queryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            CampaignId = campaignId;
            CustomerId = customerId;
            QueryId = queryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SearchTermViewName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queryId">The <c>Query</c> ID. Must not be <c>null</c> or empty.</param>
        public SearchTermViewName(string customerId, string campaignId, string adGroupId, string queryId) : this(ResourceNameType.CustomerCampaignAdGroupQuery, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), queryId: gax::GaxPreconditions.CheckNotNullOrEmpty(queryId, nameof(queryId)))
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
        /// The <c>AdGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdGroupId { get; }

        /// <summary>
        /// The <c>Campaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CampaignId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>Query</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QueryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignAdGroupQuery: return s_customerCampaignAdGroupQuery.Expand(CustomerId, $"{CampaignId}~{AdGroupId}~{QueryId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SearchTermViewName);

        /// <inheritdoc/>
        public bool Equals(SearchTermViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SearchTermViewName a, SearchTermViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SearchTermViewName a, SearchTermViewName b) => !(a == b);
    }

    public partial class SearchTermView
    {
        /// <summary>
        /// <see cref="SearchTermViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal SearchTermViewName ResourceNameAsSearchTermViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : SearchTermViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="AdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName AdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(AdGroup) ? null : AdGroupName.Parse(AdGroup, allowUnparsed: true);
            set => AdGroup = value?.ToString() ?? "";
        }
    }
}
