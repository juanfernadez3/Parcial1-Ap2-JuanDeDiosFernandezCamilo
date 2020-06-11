using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Parcial1_Ap2_JuanDeDiosFernandezCamilo.Models
{
    public class Articulos
    {
        [Key]
        public int ArtiuloId { get; set; }

        [Required (ErrorMessage ="Debe Ingresar la descripcion del producto")]
        [MinLength(4, ErrorMessage ="La Descripcion Es muy corta")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="Debe de ingresar la cantidad de producto para el inventario")]
        public int  Inventario { get; set; }

        [Required(ErrorMessage = "Ingrese costo del articulo")]
        public decimal Costo { get; set; }

        [Required]
        public decimal ExistenciaInventario { get; set; }

        public Articulos()
        {
            ArtiuloId = 0;
            Descripcion = string.Empty;
            Inventario = 0;
            Costo = 0;
            Inventario = 0;
            ExistenciaInventario = 0;
        }
    }
}
