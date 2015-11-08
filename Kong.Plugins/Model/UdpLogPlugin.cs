﻿using Kong.Model;
using Newtonsoft.Json;

namespace Kong.Plugins.Model
{
    public class UdpLogPlugin : Plugin
    {
        [JsonProperty("consumer_id")]
        public string ConsumerId { get; set; }

        [JsonProperty("config")]
        public UdpLogPluginConfig Config { get; set; }
    }
}