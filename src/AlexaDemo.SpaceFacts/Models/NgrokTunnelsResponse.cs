﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlexaDemo.SpaceFacts.Models
{
    public class NgrokTunnelsResponse
    {
        [JsonProperty(PropertyName = "tunnels")]
        public List<Tunnel> Tunnels { get; set; }

        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }

    [DebuggerDisplay("Name = {Name}, PublicUrl = {PublicUrl}")]
    [JsonObject(Description = "Details, including metrics, about an active nGrok tunnel", Title = "nGrok Tunnel")]
    public class Tunnel
    {
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Uri")]
        public string uri { get; set; }

        [JsonProperty(PropertyName = "public_url")]
        public string PublicUrl { get; set; }

        [JsonProperty(PropertyName = "proto")]
        public string Proto { get; set; }

        [JsonProperty(PropertyName = "config")]
        public TunnelConfig Config { get; set; }

        [JsonProperty(PropertyName = "metrics")]
        public TunnelMetrics Metrics { get; set; }
    }

    public class TunnelConfig
    {
        [JsonProperty(PropertyName = "addr")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "inspect")]
        public bool Inspect { get; set; }
    }

    public class TunnelConnections
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "gauge")]
        public int Gauge { get; set; }

        [JsonProperty(PropertyName = "rate1")]
        public decimal Rate01 { get; set; }

        [JsonProperty(PropertyName = "rate5")]
        public decimal Rate05 { get; set; }

        [JsonProperty(PropertyName = "rate15")]
        public decimal Rate15 { get; set; }

        [JsonProperty(PropertyName = "p50")]
        public decimal P50 { get; set; }

        [JsonProperty(PropertyName = "p90")]
        public decimal P90 { get; set; }

        [JsonProperty(PropertyName = "p95")]
        public decimal P95 { get; set; }

        [JsonProperty(PropertyName = "p99")]
        public decimal P99 { get; set; }
    }

    public class TunnelHttp
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "rate1")]
        public decimal Rate01 { get; set; }

        [JsonProperty(PropertyName = "rate5")]
        public decimal Rate05 { get; set; }

        [JsonProperty(PropertyName = "rate15")]
        public decimal Rate15 { get; set; }

        [JsonProperty(PropertyName = "p50")]
        public decimal P50 { get; set; }

        [JsonProperty(PropertyName = "p90")]
        public decimal P90 { get; set; }

        [JsonProperty(PropertyName = "p95")]
        public decimal P95 { get; set; }

        [JsonProperty(PropertyName = "p99")]
        public decimal P99 { get; set; }
    }

    [JsonObject(Description = "Reports on tunnel usage data.", Title = "nGrok Tunnel Metrics")]
    public class TunnelMetrics
    {

        [JsonProperty(PropertyName = "conns")]
        public TunnelConnections Connections { get; set; }

        [JsonProperty(PropertyName = "http")]
        public TunnelHttp Http { get; set; }
    }

}
