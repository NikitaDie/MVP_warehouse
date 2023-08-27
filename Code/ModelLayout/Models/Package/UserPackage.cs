using ModelLayout.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayout.Models.Package
{
    public class UserPackage //: IPackageModel
    {
        [JsonProperty("Price")] public double Price { get; set; } 
        [JsonProperty("Name")] public string Name { get; set; } = "null";
        [JsonProperty("SizeDescription")] public Size SizeDescription { get; set; }

        [JsonProperty("ID")] public string ID { get; set; } = "null";
        [JsonProperty("RecipentName")] public string RecipentName { get; set; } = "null";
        [JsonProperty("RecipentPostCode")] public string RecipentPostCode { get; set; } = "null";
        [JsonProperty("RecipentLocation")] public string RecipentLocation { get; set; } = "null";
        [JsonProperty("RecipentStreet")] public string RecipentStreet { get; set; } = "null";
        [JsonProperty("RecipentHouseNumber")] public string RecipentHouseNumber { get; set; } = "null";
        [JsonProperty("RecipentCountry")] public string RecipentCountry { get; set; } = "Germany";
        [JsonProperty("RecipentEmail")] public string RecipentEmail { get; set; } = "null";
        [JsonProperty("SenderName")] public string SenderName { get; set; } = "null";
        [JsonProperty("SenderPostCode")] public string SenderPostCode { get; set; } = "null";
        [JsonProperty("SenderLocation")] public string SenderLocation { get; set; } = "null";
        [JsonProperty("SenderStreet")] public string SenderStreet { get; set; } = "null";
        [JsonProperty("SenderHouseNumber")] public string SenderHouseNumber { get; set; } = "null";

        [JsonProperty("SenderCountry")] public string SenderCountry { get; set; } = "Germany";
        [JsonProperty("SenderEmail")] public string SenderEmail { get; set; } = "null";
        [JsonProperty("CurrentWarehouseID")] public string CurrentWarehouseID { set; get; } = "null";

        public UserPackage() { }
        public UserPackage(string id)
        {
            ID = id;
        }

        public UserPackage(IPackageModel packageBase)
        {
            Price = packageBase.Price;
            Name = packageBase.Name;
            SizeDescription = packageBase.SizeDescription;
        }

        public UserPackage(string id, double price, string name, Size size, 
            string recipentName, string recipentPostCode, string recipentLocation, string recipentStreet, string recipentHouseNumber, string recipentEmail,
            string senderName, string senderPostCode, string senderLocation, string senderStreet, string senderHouseNumber, string senderEmail)
        {
            Price = price;
            Name = name;
            SizeDescription = size;

            ID = id;

            RecipentName = recipentName;
            RecipentPostCode = recipentPostCode;
            RecipentLocation = recipentLocation;
            RecipentStreet = recipentStreet;
            RecipentHouseNumber = recipentHouseNumber;
            RecipentEmail = recipentEmail;

            SenderName = senderName;
            SenderPostCode = senderPostCode;
            SenderLocation = senderLocation;
            SenderStreet = senderStreet;
            SenderHouseNumber = senderHouseNumber;
            SenderEmail = senderEmail;
        }
    }
}
