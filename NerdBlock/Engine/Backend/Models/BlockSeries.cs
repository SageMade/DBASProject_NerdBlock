﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Backend.Models
{
    [DataModel("tblblockseries")]
    public class BlockSeries
    {
        [DataField("seriesid", QueryParamType.Integer), AutoGenerated, PrimaryKey]
        public int? SeriesId { get; set; }

        [DataField("genreid", QueryParamType.Integer), ForeignKey("tblgenre", "genreid")]
        public Genre GenreId { get; set; }

        [DataField("title", QueryParamType.VarChar)]
        public string Title { get; set; }

        [DataField("subscriptionprice", QueryParamType.Money)]
        public decimal? SubscriptionPrice { get; set; }

        [DataField("blockvolume", QueryParamType.Integer)]
        public int? BlockVolume { get; set; }
        
        [DataField("startdate", QueryParamType.Date)]
        public DateTime? StartDate { get; set; }

        [DataField("endeddate", QueryParamType.Date), Nullable]
        public DateTime? EndedDate { get; set; }

        public override string ToString()
        {
            return Title;
        }

        public override int GetHashCode()
        {
            return SeriesId == null ? 0 : SeriesId.Value;
        }

        public override bool Equals(object obj)
        {
            return obj is BlockSeries && (obj as BlockSeries).SeriesId == SeriesId;
        }
    }
}
