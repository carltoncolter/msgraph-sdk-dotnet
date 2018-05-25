// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ReportRootGetSharePointActivityUserDetailCollectionPage.
    /// </summary>
    public partial class ReportRootGetSharePointActivityUserDetailCollectionPage : CollectionPage<SharePointActivityUserDetail>, IReportRootGetSharePointActivityUserDetailCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootGetSharePointActivityUserDetailRequest"/> instance.
        /// </summary>
        public IReportRootGetSharePointActivityUserDetailRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ReportRootGetSharePointActivityUserDetailRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}