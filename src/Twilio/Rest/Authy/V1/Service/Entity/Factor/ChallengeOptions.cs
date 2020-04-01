/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Authy.V1.Service.Entity.Factor
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Create a new Challenge for the Factor
    /// </summary>
    public class CreateChallengeOptions : IOptions<ChallengeResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// Factor Sid.
        /// </summary>
        public string PathFactorSid { get; }
        /// <summary>
        /// The future date in which this Challenge will expire
        /// </summary>
        public DateTime? ExpirationDate { get; set; }
        /// <summary>
        /// Public details provided to contextualize the Challenge
        /// </summary>
        public string Details { get; set; }
        /// <summary>
        /// Hidden details provided to contextualize the Challenge
        /// </summary>
        public string HiddenDetails { get; set; }

        /// <summary>
        /// Construct a new CreateChallengeOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathFactorSid"> Factor Sid. </param>
        public CreateChallengeOptions(string pathServiceSid, string pathIdentity, string pathFactorSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathFactorSid = pathFactorSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ExpirationDate != null)
            {
                p.Add(new KeyValuePair<string, string>("ExpirationDate", Serializers.DateTimeIso8601(ExpirationDate)));
            }

            if (Details != null)
            {
                p.Add(new KeyValuePair<string, string>("Details", Details));
            }

            if (HiddenDetails != null)
            {
                p.Add(new KeyValuePair<string, string>("HiddenDetails", HiddenDetails));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Delete a specific Challenge.
    /// </summary>
    public class DeleteChallengeOptions : IOptions<ChallengeResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// Factor Sid.
        /// </summary>
        public string PathFactorSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Challenge.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteChallengeOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathFactorSid"> Factor Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Challenge. </param>
        public DeleteChallengeOptions(string pathServiceSid, string pathIdentity, string pathFactorSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathFactorSid = pathFactorSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Fetch a specific Challenge.
    /// </summary>
    public class FetchChallengeOptions : IOptions<ChallengeResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// Factor Sid.
        /// </summary>
        public string PathFactorSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Challenge, or `latest`.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchChallengeOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathFactorSid"> Factor Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Challenge, or `latest`. </param>
        public FetchChallengeOptions(string pathServiceSid, string pathIdentity, string pathFactorSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathFactorSid = pathFactorSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of all Challenges for a Factor.
    /// </summary>
    public class ReadChallengeOptions : ReadOptions<ChallengeResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// Factor Sid.
        /// </summary>
        public string PathFactorSid { get; }
        /// <summary>
        /// The Status of theChallenges to fetch
        /// </summary>
        public ChallengeResource.ChallengeStatusesEnum Status { get; set; }

        /// <summary>
        /// Construct a new ReadChallengeOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathFactorSid"> Factor Sid. </param>
        public ReadChallengeOptions(string pathServiceSid, string pathIdentity, string pathFactorSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathFactorSid = pathFactorSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Verify a specific Challenge.
    /// </summary>
    public class UpdateChallengeOptions : IOptions<ChallengeResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// Factor Sid.
        /// </summary>
        public string PathFactorSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Challenge, or `latest`.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// Optional payload to verify the Challenge
        /// </summary>
        public string AuthPayload { get; set; }

        /// <summary>
        /// Construct a new UpdateChallengeOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathFactorSid"> Factor Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Challenge, or `latest`. </param>
        public UpdateChallengeOptions(string pathServiceSid, string pathIdentity, string pathFactorSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathFactorSid = pathFactorSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AuthPayload != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthPayload", AuthPayload));
            }

            return p;
        }
    }

}