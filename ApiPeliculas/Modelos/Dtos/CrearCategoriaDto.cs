using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CrearCategoriaDto
    {
        //Esta validacion es importante si no se crea vacio el nombre de la categoria
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(60, ErrorMessage = "El número maximo de caracteres es de 100")]
        public string Nombre { get; set; }
    }
}
