using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RotaSeguraWeb.Models;
using static RotaSeguraWeb.Models.Enuns.Enum;

namespace RotaSeguraWeb.Controllers
{
    public class VehicleController : Controller
    {
        // GET: VehicleController
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            int pageSize = 10; // Número de itens por página

            // Substitua a lógica abaixo para buscar os dados do seu repositório ou banco de dados
            var vehicles = BuscarVeiculos();

            var model = vehicles.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalPages = (int)Math.Ceiling(vehicles.Count / (double)pageSize);

            return View(model);
        }

        private static List<VehicleDTO> BuscarVeiculos()
        {
            // Create a list of vehicles with fake data
            return new List<VehicleDTO>
            {
                new VehicleDTO
                {
                    VId = 1,
                    VRegistrationNo = "ABC123",
                    VName = "Carro A",
                    VModel = "Modelo A",
                    VChassisNo = "CHASSISA",
                    VEngineNo = "ENGINEA",
                    VManufacturedBy = "Fabricante A",
                    VType = "Sedan",
                    VColor = "Azul",
                    VMileagePerLitre = "15",
                    VIsActive = VehicleIsActive.Ativo,
                    VGroup = 1,
                    VRegExpDate = "2024-01-01",
                    VApiUrl = "https://api.example.com",
                    VApiUsername = "userA",
                    VApiPassword = "passwordA",
                    VCreatedBy = "Usuario A",
                    VCreatedDate = DateTime.Now,
                    VModifiedDate = DateTime.Now
                },
                new VehicleDTO
                {
                    VId = 2,
                    VRegistrationNo = "XYZ789",
                    VName = "Carro B",
                    VModel = "Modelo B",
                    VChassisNo = "CHASSISB",
                    VEngineNo = "ENGINEB",
                    VManufacturedBy = "Fabricante B",
                    VType = "Hatchback",
                    VColor = "Vermelho",
                    VMileagePerLitre = "18",
                    VIsActive = VehicleIsActive.Inativo,
                    VGroup = 2,
                    VRegExpDate = "2025-02-01",
                    VApiUrl = "https://api.example2.com",
                    VApiUsername = "userB",
                    VApiPassword = "passwordB",
                    VCreatedBy = "Usuario B",
                    VCreatedDate = DateTime.Now,
                    VModifiedDate = DateTime.Now
                }
            };
        }
        private static VehicleDTO BuscarVeiculoPorId(int id)
        {
            var vehicles = BuscarVeiculos();
            return vehicles.FirstOrDefault(v => v.VId == id);
        }

        // GET: VehicleController/Details/5
        public ActionResult Details(int id)
        {
            var vehicle = BuscarVeiculoPorId(id);

            if (vehicle == null)
            {
                return NotFound(); // Ou RedirectToAction("Index") para redirecionar ao índice caso não encontre o veículo
            }

            return View(vehicle);
        }

        // GET: VehicleController/Create
        public ActionResult Create()
        {
            ViewBag.Types = new List<SelectListItem>
            {
                new SelectListItem { Value = "Car", Text = "Car" },
                new SelectListItem { Value = "Truck", Text = "Truck" },
                new SelectListItem { Value = "Motorcycle", Text = "Motorcycle" },
                // adicione aqui outras opções que desejar
            };

            ViewBag.Groups = new List<SelectListItem>
            {
                new SelectListItem { Value = "Group A", Text = "Group A" },
                new SelectListItem { Value = "Group B", Text = "Group B" },
                new SelectListItem { Value = "Group C", Text = "Group C" },
                // adicione aqui outras opções que desejar
            };

            return View();
        }

        // POST: VehicleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VehicleDTO collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleController/Edit/5
        public ActionResult Edit(int id)
        {
            var vehicle = BuscarVeiculoPorId(id);
            ViewBag.Types = new List<SelectListItem>
            {
                new SelectListItem { Value = "Car", Text = "Car" },
                new SelectListItem { Value = "Truck", Text = "Truck" },
                new SelectListItem { Value = "Motorcycle", Text = "Motorcycle" },
                // adicione aqui outras opções que desejar
            };

            ViewBag.Groups = new List<SelectListItem>
            {
                new SelectListItem { Value = "Group A", Text = "Group A" },
                new SelectListItem { Value = "Group B", Text = "Group B" },
                new SelectListItem { Value = "Group C", Text = "Group C" },
                // adicione aqui outras opções que desejar
            };



            if (vehicle == null)
            {
                return NotFound(); // Ou RedirectToAction("Index") para redirecionar ao índice caso não encontre o veículo
            }

            return View(vehicle);
        }

        // POST: VehicleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehicleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
