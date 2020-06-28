using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huobi.Net.Objects
{
    /// <summary>
    /// Best Bid/Offer
    ///While any of best bid, best ask, best bid size, best ask size is changing, subscriber can receive BBO(Best Bid/Offer) update in tick by tick mode.
    /// </summary>
    public class HuobiBookTicker
    {
        /// <summary>
        /// The symbol
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; } = "";

        /// <summary>
        /// Quote time
        /// </summary>
        [JsonProperty("quoteTime"), JsonConverter(typeof(TimestampConverter))]
        public DateTime Time { get; set; }

        /// <summary>
        /// Best bid
        /// </summary>
        [JsonProperty("bid")]
        public decimal BestBidPrice { get; set; }

        /// <summary>
        /// Best bid size
        /// </summary>
        [JsonProperty("bidSize")]
        public decimal BestBidQuantity { get; set; }

        /// <summary>
        /// Best ask
        /// </summary>
        [JsonProperty("ask")]
        public decimal BestAskPrice { get; set; }

        /// <summary>
        /// Best ask size
        /// </summary>
        [JsonProperty("askSize")]
        public decimal BestAskQuantity { get; set; }

        /// <summary>
        /// Sequence number
        /// </summary>
        [JsonProperty("seqId")]
        public long LastUpdateId { get; set; }
    }
}
