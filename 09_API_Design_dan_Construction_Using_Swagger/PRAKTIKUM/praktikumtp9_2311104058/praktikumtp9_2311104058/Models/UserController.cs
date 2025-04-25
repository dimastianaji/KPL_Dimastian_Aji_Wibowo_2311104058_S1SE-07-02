using Microsoft.AspNetCore.Mvc;

namespace praktikumtp9_2311104058.Models
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        static List<User> users = new List<User>
        {
            new User{id = 1, name = "Dimastian Aji Wibowo", email = "dimasanjaymabar@gmail.com" },
            new User{id = 2, name = "Ryan Gosling", email = "ryangoslingganteng@gmail.com" }
        };
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(users);
        }
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public ActionResult<User> CreateUser(UserDTO userCreate)
        {
            int new_id = users.Count + 1;
            User user = new User
            {
                id = new_id,
                name = userCreate.name,
                email = userCreate.email
            };
            users.Add(user);
            return Ok(user);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserDTO userUpdate)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            user.name = userUpdate.name;
            user.email = userUpdate.email;
            return Ok(user);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (id == null)
            {
                return NotFound();
            }
            users.Remove(user);
            return NoContent();
        }
    }
}
