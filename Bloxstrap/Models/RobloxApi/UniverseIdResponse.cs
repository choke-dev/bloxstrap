﻿using System.Text.Json.Serialization;

namespace Bloxstrap.Models.RobloxApi
{
    // lmao its just one property
    internal class UniverseIdResponse
    {
        [JsonPropertyName("universeId")]
        public long UniverseId { get; set; }
    }
}