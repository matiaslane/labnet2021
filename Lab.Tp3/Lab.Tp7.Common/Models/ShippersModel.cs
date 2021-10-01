using System.ComponentModel.DataAnnotations;

namespace Lab.Tp7.Common.Models
{
    public class ShippersModel : BaseModel
    {
        [Required(ErrorMessage ="El telefono no puede estar vacio.")]
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Formato de numero invalido!")]
        public string Phone { get; set; }
    }
}
