﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Web_Services.Models
{
    public class User
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("username")]
        public string UserName { get; set; } = String.Empty;

        [BsonElement("NIC")]
        public string NIC { get; set; } = String.Empty;


        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;

        [BsonElement("phone")]
        public int Phone { get; set; }

        [BsonElement("address")]
        public string Address { get; set; } = String.Empty;

        [BsonElement("status")]
        public string Status { get; set; } = String.Empty;

       
    }
}
