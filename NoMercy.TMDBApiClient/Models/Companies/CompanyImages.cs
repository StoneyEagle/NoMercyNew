﻿using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Companies;

public class CompanyImages
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("logos")] public Logo[] Logos { get; set; } = Array.Empty<Logo>();
}