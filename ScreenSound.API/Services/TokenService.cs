using Microsoft.IdentityModel.Tokens;
using ScreenSound.API.DTO;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ScreenSound.API.Services;

public class TokenService
{
    public UserTokenResponse GenerateJWToken(UserDTO user)
    {
        var myClaims = new[]
            {
               new Claim(JwtRegisteredClaimNames.UniqueName,user.Email),
               new Claim("alura","c#"),
               new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SenhaSuperSecretaChave@1985")); 
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256); 
        var token = new JwtSecurityToken("ScreenSound", "ScreenSound", claims:myClaims, expires: DateTime.Now.AddHours(8), signingCredentials: credentials); 
        return new UserTokenResponse()
        {     
         Token = new JwtSecurityTokenHandler().WriteToken(token),
        };
    }
}
