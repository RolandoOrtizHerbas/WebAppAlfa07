using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebAppAlfa07.Herramientas;
using WebAppAlfa07.Models;
using WebAppAlfa07.Models.Common;
using WebAppAlfa07.Models.Request;
using WebAppAlfa07.Models.Resp;


namespace WebAppAlfa07.Services
{
    public class UserService:IUserService
    {
        private readonly AppSettings _appSettings;
        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
         public UserResponce aut(auten model)
        {
            UserResponce userresponse = new UserResponce();
            using (var db = new DBASEALFAContext())
            {
                string spassword = Encryptado.GetSHA256(model.Password);
                var usuario = db.Usuarios.Where(d => d.Usu == model.Usu && d.Password == spassword).FirstOrDefault();
                if (usuario == null) return null;
                userresponse.Usu = usuario.Usu;
                userresponse.Token = GetToken(usuario);
            }
            return userresponse;
        }

       private string GetToken(Usuario usuario)
        {
            var TokenHandler = new JwtSecurityTokenHandler();
            var llave = Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var TokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier,usuario.Id.ToString()),
                        new Claim(ClaimTypes.Email ,usuario.Usu)
                    }
                    ),
                Expires = DateTime.UtcNow.AddDays(30),
                SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
                
            };
            var token = TokenHandler.CreateToken(TokenDescriptor);
            return TokenHandler.WriteToken(token);
        }
    }
            
 }


    

