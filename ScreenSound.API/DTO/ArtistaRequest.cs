using System.ComponentModel.DataAnnotations;

public record ArtistaRequest([Required]string Nome, [Required] string Bio, string FotoPerfil);