using Microsoft.AspNetCore.Mvc;
using demomvcproject.Models;

namespace demomvcproject.Controllers
{
    public class UserController : Controller
    {
        // In-memory data store (for demonstration purposes)
        private static List<User> _Users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
        };

        // GET: /User/
        public IActionResult Index()
        {
            return View(_Users);
        }

        // GET: /User/Details/5
        public IActionResult Details(int id)
        {
            var User = _Users.FirstOrDefault(p => p.Id == id);
            if (User == null)
                return NotFound();

            return View(User);
        }

        // GET: /User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User User)
        {
            if (ModelState.IsValid)
            {
                User.Id = _Users.Max(p => p.Id) + 1;
                _Users.Add(User);
                return RedirectToAction(nameof(Index));
            }
            return View(User);
        }

        // GET: /User/Edit/5
        public IActionResult Edit(int id)
        {
            var User = _Users.FirstOrDefault(p => p.Id == id);
            if (User == null)
                return NotFound();

            return View(User);
        }

        // POST: /User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, User User)
        {
            if (id != User.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                var existingUser = _Users.FirstOrDefault(p => p.Id == id);
                if (existingUser == null)
                    return NotFound();

                existingUser.Name = User.Name;
                existingUser.Email = User.Email;

                return RedirectToAction(nameof(Index));
            }
            return View(User);
        }

        // GET: /User/Delete/5
        public IActionResult Delete(int id)
        {
            var User = _Users.FirstOrDefault(p => p.Id == id);
            if (User == null)
                return NotFound();

            return View(User);
        }

        // POST: /User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            var User = _Users.FirstOrDefault(p => p.Id == id);
            if (User == null)
                return NotFound();

            _Users.Remove(User);
            return RedirectToAction(nameof(Index));
        }
    }
}
