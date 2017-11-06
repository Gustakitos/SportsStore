using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SportsStore.Domain.Entities{
    public class Product{

        [HiddenInput(DisplayValue =false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Digite o nome do produto")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite a descrição do produto")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage ="Digite um valor de preço valido")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Digite a categoria do produto")]
        public string Category { get; set; }
    }
}
