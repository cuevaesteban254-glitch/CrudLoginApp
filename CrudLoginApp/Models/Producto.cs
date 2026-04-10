using System.ComponentModel.DataAnnotations;

namespace CrudLoginApp.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public double Precio { get; set; }
    }

}
