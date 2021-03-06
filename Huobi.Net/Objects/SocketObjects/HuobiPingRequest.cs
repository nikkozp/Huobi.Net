﻿using Newtonsoft.Json;

namespace Huobi.Net.Objects.SocketObjects
{
    internal class HuobiPingRequest
    {
        [JsonProperty("ping")]
        public long Ping { get; set; }
    }

    internal class HuobiPingResponse
    {
        [JsonProperty("pong")]
        public long Pong { get; set; }

        public HuobiPingResponse(long id)
        {
            Pong = id;
        }
    }

    internal class HuobiPingAuthResponse
    {
        [JsonProperty("op")]
        public string Operation { get; set; }
        [JsonProperty("ts")]
        public long Timestamp { get; set; }

        public HuobiPingAuthResponse(long id)
        {
            Operation = "pong";
            Timestamp = id;
        }
    }
}
