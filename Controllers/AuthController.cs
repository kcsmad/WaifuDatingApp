using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WaifuDatingApp.API.Data;
using WaifuDatingApp.API.DTOs;
using WaifuDatingApp.API.Models;

namespace WaifuDatingApp.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserForRegisterDTO dto)
        {
            dto.Username = dto.Username.ToLower();

            if (await _repo.UserExists(dto.Username))
                ModelState.AddModelError("Username", "Username already exists");


            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userToCreate = new User
            {
                Username = dto.Username
            };

            var createUser = await _repo.Register(userToCreate, dto.Password);

            return StatusCode(201);
        }
    }
}
