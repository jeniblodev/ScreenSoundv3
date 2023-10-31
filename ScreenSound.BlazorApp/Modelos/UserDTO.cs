using System.ComponentModel.DataAnnotations;

namespace ScreenSound.BlazorApp.Modelos;

public record UserDTO
{
    [Required]
    public string Email { get; set; } = string.Empty;
    [Required]
    public string Senha { get; set; } = string.Empty;
}
