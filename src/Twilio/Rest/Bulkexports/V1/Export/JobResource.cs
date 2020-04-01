/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// JobResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Bulkexports.V1.Export
{

    public class JobResource : Resource
    {
        private static Request BuildFetchRequest(FetchJobOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Bulkexports,
                "/v1/Exports/Jobs/" + options.PathJobSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        public static JobResource Fetch(FetchJobOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Job </returns>
        public static async System.Threading.Tasks.Task<JobResource> FetchAsync(FetchJobOptions options,
                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathJobSid"> The job_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        public static JobResource Fetch(string pathJobSid, ITwilioRestClient client = null)
        {
            var options = new FetchJobOptions(pathJobSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathJobSid"> The job_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Job </returns>
        public static async System.Threading.Tasks.Task<JobResource> FetchAsync(string pathJobSid,
                                                                                ITwilioRestClient client = null)
        {
            var options = new FetchJobOptions(pathJobSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteJobOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Bulkexports,
                "/v1/Exports/Jobs/" + options.PathJobSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        public static bool Delete(DeleteJobOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Job </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteJobOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathJobSid"> The unique string that that we created to identify the Bulk Export job </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        public static bool Delete(string pathJobSid, ITwilioRestClient client = null)
        {
            var options = new DeleteJobOptions(pathJobSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathJobSid"> The unique string that that we created to identify the Bulk Export job </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Job </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathJobSid, ITwilioRestClient client = null)
        {
            var options = new DeleteJobOptions(pathJobSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a JobResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> JobResource object represented by the provided JSON </returns>
        public static JobResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<JobResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The type of communication – Messages, Calls
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }
        /// <summary>
        /// The friendly name specified when creating the job
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// This is a list of the completed, pending, or errored dates within the export time range, with one entry for each status with more than one day in that status
        /// </summary>
        [JsonProperty("details")]
        public object Details { get; private set; }
        /// <summary>
        /// The start time for the export specified when creating the job
        /// </summary>
        [JsonProperty("start_day")]
        public string StartDay { get; private set; }
        /// <summary>
        /// The end time for the export specified when creating the job
        /// </summary>
        [JsonProperty("end_day")]
        public string EndDay { get; private set; }
        /// <summary>
        /// The job_sid returned when the export was created
        /// </summary>
        [JsonProperty("job_sid")]
        public string JobSid { get; private set; }
        /// <summary>
        /// The optional webhook url called on completion
        /// </summary>
        [JsonProperty("webhook_url")]
        public string WebhookUrl { get; private set; }
        /// <summary>
        /// This is the method used to call the webhook
        /// </summary>
        [JsonProperty("webhook_method")]
        public string WebhookMethod { get; private set; }
        /// <summary>
        /// The optional email to send the completion notification to
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private JobResource()
        {

        }
    }

}