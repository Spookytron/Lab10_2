using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace Lab10_2.Models
{
    [Table("product")]
    public class Product
    { 
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string category { get; set; }
        public override string ToString()
        {
            return $"{id} {name} {description} {price} {category}";
        }
    }
}
