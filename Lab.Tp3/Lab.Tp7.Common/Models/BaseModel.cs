using System.ComponentModel.DataAnnotations;

namespace Lab.Tp7.Common.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Porfavor ingrese un nombre")]
        [StringLength(20, ErrorMessage = "El nombre no puede tener mas de veinte letras.")]
        public string Name { get; set; }
    }
}
