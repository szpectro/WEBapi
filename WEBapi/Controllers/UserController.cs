using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using WEBapi.Models;

namespace WEBapi.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        //CONTROLADORES CON METODO AUTHORIZE
        [Authorize(Roles = "admin")]
        [HttpGet("Admins")]
        public IActionResult AdminsEndpoint()
        {
            var currentUser = GetCurrentUser();

            return Ok($"Hi {currentUser.GivenName}, you are an {currentUser.Role}");
        }

        [Authorize(Roles = "Common")]
        [HttpGet("Common")]
        public IActionResult CommonEndpoint()
        {
            var currentUser = GetCurrentUser();

            return Ok($"Hi {currentUser.GivenName}, you are an {currentUser.Role}");
        }
       

        [HttpGet("Public")]
        public IActionResult Public() 
        {
            return Ok("hi you're on pulbic property");
        }

        [HttpGet("Informacion")]
        public IActionResult GetInformation()
        {
            return Ok("hi you're on pulbic property");
        }

        [HttpGet("Usuarios")]
        public IActionResult UsuariosGet()
        {
            var listaUsuarios = GetUsers();
            return Ok(listaUsuarios);
        }
        //devuelve el usuario actual
        private UserModel GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;
                return new UserModel
                {
                    Username = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                    EmailAddress = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
                    GivenName = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.GivenName)?.Value,
                    Surname = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Surname)?.Value,
                    Role = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value
                };
                
            }
            return null;
        }

        //devuelve lista de usuarios
        private UserModel GetUsers()
        {
            List<UserModel> listaUsuarios = new List<UserModel>();
            listaUsuarios = UserConstants.Users;
            foreach(var usuarios in listaUsuarios) {
                return new UserModel
            {
                Username = listaUsuarios.First().Username,
                EmailAddress = listaUsuarios.First().EmailAddress,
                Role = listaUsuarios.First().Role

               
            }; 
            }
            
            
            return null;
        }



    }
}
