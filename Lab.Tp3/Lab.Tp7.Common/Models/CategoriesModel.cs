using System.ComponentModel.DataAnnotations;

namespace Lab.Tp7.Common.Models
{
    public class CategoriesModel : BaseModel
    {
        [Required(ErrorMessage = "La descripcion no puede estar vacia.")]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
