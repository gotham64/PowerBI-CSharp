// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Capacities operations.
    /// </summary>
    public partial interface ICapacities
    {
        /// <summary>
        /// Returns a list of capacities the user has access to.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Capacity.Read.All or
        /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListCapacity>> GetCapacitiesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
