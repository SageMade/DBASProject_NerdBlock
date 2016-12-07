﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Backend.Models
{
    [DataModel("tblgenre")]
    public class Genre
    {
        [DataField("genreid", QueryParamType.Integer), AutoGenerated, PrimaryKey]
        public int? GenreId { get; set; }

        [DataField("title", QueryParamType.VarChar)]
        public string Title { get; set; }

        [DataField("description", QueryParamType.Text)]
        public string Description { get; set; }

        public override string ToString()
        {
            return Title;
        }

        public override int GetHashCode()
        {
            return Title == null ? 0 : Title.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is Genre && (obj as Genre).Title == Title;
        }
    }
}
