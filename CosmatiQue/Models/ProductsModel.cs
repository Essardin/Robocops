using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace CosmatiQue.Models
{
    public class ProductsModel
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? ProductName {  get; set; }
        public string? BrandName { get; set; }
        public string? Category {  get; set; }
        public string? Price { get; set; }
        public string? Discount {  get; set; }

        public string[]? Quantity { get; set; } 

        public string[]? Size { get; set; }
        public string[]? Color { get; set; }
        public string? ImageUrl { get; set; }

       


    }
}
