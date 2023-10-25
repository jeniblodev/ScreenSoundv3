using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.DTO;
using ScreenSound.API.Services;
using ScreenSound.Shared.Banco;
using ScreenSound.Shared.Modelos;

namespace ScreenSound.API.Endpoints;

public static class AuthorizerExtensions
{
    public static void AddEndPointAuthorizer(this WebApplication app)
    {

        app.MapPost("/Registrar", async ([FromBody] UserDTO user,UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) =>
         {
             var identityUser = new IdentityUser
             {
                 UserName = user.Email,
                 Email = user.Email,
                 EmailConfirmed = true

             };
             var result = await userManager.CreateAsync(identityUser, user.Senha);
             if (!result.Succeeded)
             {
                 return Results.BadRequest($"Falha ao criar usuário. Contacte o administrador ===>{result.Errors}");
             }
             await signInManager.SignInAsync(identityUser, false);
             return Results.Ok(user);
         });

        app.MapPost("/Login", async ([FromBody]UserDTO user,SignInManager<IdentityUser> signInManager) =>
        {
            if (user is null)
            {
                return Results.BadRequest("Login inválido.");
            }
            var result = await signInManager.PasswordSignInAsync(user.Email!,
                user.Senha!, isPersistent: false, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                return Results.BadRequest("Login inválido.");
            }          

            user.Senha = string.Empty;
            return Results.Ok(user);
        });
    }
}
