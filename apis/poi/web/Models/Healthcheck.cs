﻿using System;
using Newtonsoft.Json;

namespace poi.Models
{
    public class Healthcheck
    {
        // This is the HealthCheck
        public Healthcheck()
        {
            Message = "POI Service Healthcheck";
            Status = "Healthy as fuck";
        }
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get;set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
