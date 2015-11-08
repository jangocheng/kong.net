﻿using Newtonsoft.Json;

namespace Kong.Plugins.Model
{
    public class IpRestrictionPluginconfig
    {
        [JsonProperty("whitelist")]
        public string Whitelist { get; set; }

        [JsonProperty("blacklist")]
        public string Blacklist { get; set; }
    }
}