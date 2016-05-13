using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Readers;
using Twilio.Resources;
using Twilio.Resources.Trunking.V1.Trunk;

namespace Twilio.Readers.Trunking.V1.Trunk {

    public class PhoneNumberReader : Reader<PhoneNumberResource> {
        private string trunkSid;
    
        /**
         * Construct a new PhoneNumberReader
         * 
         * @param trunkSid The trunk_sid
         */
        public PhoneNumberReader(string trunkSid) {
            this.trunkSid = trunkSid;
        }
    
        /**
         * Make the request to the Twilio API to perform the read
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return PhoneNumberResource ResourceSet
         */
        public override async Task<ResourceSet<PhoneNumberResource>> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                Domains.TRUNKING,
                "/v1/Trunks/" + this.trunkSid + "/PhoneNumbers"
            );
            
            AddQueryParams(request);
            
            Page<PhoneNumberResource> page = await PageForRequest(client, request);
            
            return new ResourceSet<PhoneNumberResource>(this, client, page);
        }
    
        /**
         * Retrieve the next page from the Twilio API
         * 
         * @param nextPageUri URI from which to retrieve the next page
         * @param client ITwilioRestClient with which to make the request
         * @return Next Page
         */
        public override Page<PhoneNumberResource> NextPage(string nextPageUri, ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                nextPageUri
            );
            
            var task = PageForRequest(client, request);
            task.Wait();
            
            return task.Result;
        }
    
        /**
         * Generate a Page of PhoneNumberResource Resources for a given request
         * 
         * @param client ITwilioRestClient with which to make the request
         * @param request Request to generate a page for
         * @return Page for the Request
         */
        protected async Task<Page<PhoneNumberResource>> PageForRequest(ITwilioRestClient client, Request request) {
            Response response = await client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("PhoneNumberResource read failed: Unable to connect to server");
            } else if (response.GetStatusCode() != HttpStatus.HTTP_STATUS_CODE_OK) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            Page<PhoneNumberResource> result = new Page<PhoneNumberResource>();
            result.deserialize("phone_numbers", response.GetContent());
            
            return result;
        }
    
        /**
         * Add the requested query string arguments to the Request
         * 
         * @param request Request to add query string arguments to
         */
        private void AddQueryParams(Request request) {
            request.AddQueryParam("PageSize", GetPageSize().ToString());
        }
    }
}