using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RotaSeguraWeb.Models;
using static RotaSeguraWeb.Models.Enuns.Enum;

namespace RotaSeguraWeb.Controllers
{
    public class DriverController : Controller
    {
        // GET: DriverController
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            int pageSize = 10; // Número de itens por página

            // Substitua a lógica abaixo para buscar os dados do seu repositório ou banco de dados
            List<DriverDTO> fakeDrivers = GetFakeDrivers();

            var model = fakeDrivers.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalPages = (int)Math.Ceiling(fakeDrivers.Count / (double)pageSize);

            return View(fakeDrivers);
        }
        public  List<DriverDTO> GetFakeDrivers()
        {
            return new List<DriverDTO>
    {
        new DriverDTO
        {
            DId = 1,
            DName = "João Silva",
            DMobile = "123-456-7890",
            DAddress = "Rua das Flores, 123",
            DAge = 35,
            DLicenseno = "A123456",
            DLicenseExpDate = new DateTime(2025, 12, 31),
            DTotalExp = 10,
            DDoj = new DateTime(2018, 06, 01),
            DRef = "REF001",
            IsActive = DriveIsActive.Ativo,
            DFile = "file1.jpg",
            DFile1 = "file2.jpg",
            DCreatedBy = "Usuário A",
            DCreatedDate = DateTime.Now,
            DModifiedDate = DateTime.Now
        },
        new DriverDTO
        {
            DId = 2,
            DName = "Maria Santos",
            DMobile = "098-765-4321",
            DAddress = "Avenida Brasil, 456",
            DAge = 28,
            DLicenseno = "B789012",
            DLicenseExpDate = new DateTime(2024, 05, 15),
            DTotalExp = 5,
            DDoj = new DateTime(2020, 03, 01),
            DRef = "REF002",
            IsActive = DriveIsActive.Ativo,
            DFile = "file3.jpg",
            DFile1 = "file4.jpg",
            DCreatedBy = "Usuário B",
            DCreatedDate = DateTime.Now,
            DModifiedDate = DateTime.Now
        },
        new DriverDTO
        {
            DId = 3,
            DName = "Pedro Costa",
            DMobile = "321-654-9870",
            DAddress = "Rua Nova, 789",
            DAge = 45,
            DLicenseno = "C345678",
            DLicenseExpDate = new DateTime(2023, 10, 30),
            DTotalExp = 20,
            DDoj = new DateTime(2015, 11, 01),
            DRef = "REF003",
            IsActive = DriveIsActive.Inativo,
            DFile = "file5.jpg",
            DFile1 = "file6.jpg",
            DCreatedBy = "Usuário C",
            DCreatedDate = DateTime.Now,
            DModifiedDate = DateTime.Now
        }
        ,
        new DriverDTO
        {
            DId = 4,
            DName = "Pedro2 Costa",
            DMobile = "321-654-9870",
            DAddress = "Rua Nova, 789",
            DAge = 45,
            DLicenseno = "C345678",
            DLicenseExpDate = new DateTime(2023, 10, 30),
            DTotalExp = 20,
            DDoj = new DateTime(2015, 11, 01),
            DRef = "REF003",
            IsActive = DriveIsActive.Inativo,
            DFile = "file5.jpg",
            DFile1 = "file6.jpg",
            DCreatedBy = "Usuário C",
            DCreatedDate = DateTime.Now,
            DModifiedDate = DateTime.Now
        }
    };
        }


        // GET: DriverController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DriverController/Create
        public ActionResult Create()
        {
            ViewBag.IsActive = new List<SelectListItem>
            { new SelectListItem { Value = "", Text = "" },
             new SelectListItem { Value = "0", Text = "Inativo" },
             new SelectListItem { Value = "0", Text = "Ativo" },
            };
            return View();
        }

        // POST: DriverController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DriverDTO collection)
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
        private DriverDTO GetFakeDriversPorId(int id)
        {
            var vehicles = GetFakeDrivers();
            return vehicles.FirstOrDefault(v => v.DId == id);
        }
        // GET: DriverController/Edit/5
        public ActionResult Edit(int id)
        {
            var vehicle = GetFakeDriversPorId(id);
            return View(vehicle);
        }

        // POST: DriverController/Edit/5
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

        // GET: DriverController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DriverController/Delete/5
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
