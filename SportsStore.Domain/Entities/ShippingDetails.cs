using System.ComponentModel.DataAnnotations;


namespace SportsStore.Domain.Entities{
    public class ShippingDetails{

        [Required(ErrorMessage = "Por favor digite o Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor digite o primeiro Endereço")]
        [Display(Name="Linha 1")]
        public string Line1 { get; set; }
        [Display(Name = "Linha 2")]
        public string Line2 { get; set; }
        [Display(Name = "Linha 3")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Por favor digite o nome da Cidade")]
        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Required(ErrorMessage = "Por favor digite o nome do Estado")]
        [Display(Name = "Estado")]
        public string State { get; set; }

        [Display(Name = "CEP")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Por favor digite o nome do País")]
        [Display(Name = "País")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

    }
}
