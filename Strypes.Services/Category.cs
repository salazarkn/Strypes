using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace Strypes.Services
{
    [DataContract]
    public class Category
    {

        [BsonId]
        [DataMember]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}