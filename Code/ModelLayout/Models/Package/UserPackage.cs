using ModelLayout.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayout.Models.Package
{
    public class UserPackage //: IPackageModel
    {
        [JsonProperty("Price")]
        public double Price { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("SizeDescription")]
        public Size SizeDescription { get; set; }

        [JsonProperty("ID")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "ID is required")]
        [StringLength(12, ErrorMessage = "Length must have {1} digits"), MinLength(12)]
        public string ID { get; set; }
        [JsonProperty("RecipentName")]
        public string RecipentName { get; set; }
        [JsonProperty("RecipentPostCode")]
        public string RecipentPostCode { get; set; }
        [JsonProperty("RecipentLocation")]
        public string RecipentLocation { get; set; }
        [JsonProperty("RecipentStreet")]
        public string RecipentStreet { get; set; }
        [JsonProperty("RecipentHouseNumber")]
        public string RecipentHouseNumber { get; set; }
        [JsonProperty("RecipentEmail")]
        public string RecipentEmail { get; set; }
        [JsonProperty("SenderName")]
        public string SenderName { get; set; }
        [JsonProperty("SenderPostCode")]
        public string SenderPostCode { get; set; }
        [JsonProperty("SenderLocation")]
        public string SenderLocation { get; set; }
        [JsonProperty("SenderStreet")]
        public string SenderStreet { get; set; }
        [JsonProperty("SenderHouseNumber")]
        public string SenderHouseNumber { get; set; }
        [JsonProperty("SenderEmail")]
        public string SenderEmail { get; set; }
        [JsonProperty("CurrentWarehouseID")]
        public string CurrentWarehouseID { set; get; }

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
    }
}
