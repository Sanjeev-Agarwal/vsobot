﻿using System;
using Newtonsoft.Json;


namespace BotInterfaceApi.Models
{
    public class TokenModel
    {
        public TokenModel()
        {

        }

        [JsonProperty(PropertyName = "access_token")]
        public String accessToken { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public String tokenType { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public String expiresIn { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public String refreshToken { get; set; }

        public String Error { get; set; }
    }

}