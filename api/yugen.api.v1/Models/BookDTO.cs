﻿using yugen.api.v1.Services.Repositories;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yugen.api.v1.Models
{
    /// <summary>
    /// Book DTO object for the API to use.
    /// </summary>
    /// <example>var book = new Book();</example>
    public class BookDTO : IEntity<string>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("worldId")]
        public string WorldId { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("authors")]
        public string Authors { get; set; }
        [BsonElement("genre")]
        public string Genre { get; set; }

        //public string Publisher { get; set; }
        //public int Published { get; set; }
        [BsonElement("words")]
        public int Words { get; set; }
        [BsonElement("pages")]
        public int Pages { get; set; }
        [BsonElement("chapters")]
        public int Chapters { get; set; }
        [BsonElement("cover")]
        public string Cover { get; set; }
        [BsonElement("created")]
        public DateTime Created { get; set; }
        [BsonElement("modified")]
        public DateTime Modified { get; set; }

    }
}
