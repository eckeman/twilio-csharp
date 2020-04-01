/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Function.FunctionVersion
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a the content of a specific Function Version resource.
    /// </summary>
    public class FetchFunctionVersionContentOptions : IOptions<FunctionVersionContentResource>
    {
        /// <summary>
        /// The SID of the Service to fetch the Function Version content from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the function that is the parent of the Function Version content to fetch
        /// </summary>
        public string PathFunctionSid { get; }
        /// <summary>
        /// The SID that identifies the Function Version content to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchFunctionVersionContentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Function Version content from </param>
        /// <param name="pathFunctionSid"> The SID of the function that is the parent of the Function Version content to fetch
        ///                       </param>
        /// <param name="pathSid"> The SID that identifies the Function Version content to fetch </param>
        public FetchFunctionVersionContentOptions(string pathServiceSid, string pathFunctionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathFunctionSid = pathFunctionSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}