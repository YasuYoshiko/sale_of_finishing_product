using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColumnAttribute = Supabase.Postgrest.Attributes.ColumnAttribute;
using TableAttribute = Supabase.Postgrest.Attributes.TableAttribute;

namespace sale_of_finishing_product.Models
{
    internal class Products
    {
        [Table("Products")]
        class Product : BaseModel
        {
            [PrimaryKey("id")]
            public int Id { get; set; }

            [Column("name")]
            public string? Name { get; set; }

            [Column("wholesale_price")]
            public float? WPrice { get; set; }

            [Column("retail_price")]
            public float? RPrice { get; set; }

            [Column("background_information")]
            public string? Info { get; set; }

            [ForeignKey("id_warehouse")]
            public int IdWh {  get; set; }
        }
    }
}
