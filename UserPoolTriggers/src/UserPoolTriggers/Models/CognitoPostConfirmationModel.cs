﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace UserPoolTriggers.Models
{
     
    public class PostConfirmationRequest
    {
        [JsonProperty("userAttributes")]
        public Dictionary<string, string> UserAttributes { get; set; }
    }

    public class PostConfirmationCallerContext
    {
        [JsonProperty("awsSdkVersion")]
        public string AwsSdkVersion { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }
    }

    public class PostConfirmationResponse
    {
        [JsonProperty("smsMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsMessage { get; set; }
        
        [JsonProperty("emailMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailMessage { get; set; }
        
        [JsonProperty("emailSubject", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailSubject { get; set; }
        
    }
    
    public class PostConfirmationBase
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("triggerSource")]
        public string TriggerSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("callerContext")]
        public PostConfirmationCallerContext CallerContext { get; set; }

        [JsonProperty("request")]
        public PostConfirmationRequest Request { get; set; }

        [JsonProperty("response")]
        public PostConfirmationResponse Response { get; set; }
        
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }
    }

}
