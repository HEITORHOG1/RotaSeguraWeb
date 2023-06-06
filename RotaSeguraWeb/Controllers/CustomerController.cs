using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RotaSeguraWeb.Models;

namespace RotaSeguraWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            int pageSize = 10; // Número de itens por página

            // Substitua a lógica abaixo para buscar os dados do seu repositório ou banco de dados
            List<CustomerDTO> fake = GetFakeCustomer();

            var model = fake.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalPages = (int)Math.Ceiling(fake.Count / (double)pageSize);

            return View(fake);
        }
        public List<CustomerDTO> GetFakeCustomer()
        {
            List<CustomerDTO> fakeCustomers = new List<CustomerDTO>
    {
        new CustomerDTO
        {
            Id = 1,
            Name = "João Silva",
            Mobile = "11912345678",
            Email = "joao.silva@email.com",
            Address = "Rua das Flores, 123, São Paulo, SP",
            CreatedDate = DateTime.Now.AddDays(-5),
            Password = "senha123",
            IsActive = true,
            ModifiedDate = DateTime.Now.AddDays(-2)
        },
        new CustomerDTO
        {
            Id = 2,
            Name = "Maria Souza",
            Mobile = "11987654321",
            Email = "maria.souza@email.com",
            Address = "Avenida das Orquídeas, 456, Rio de Janeiro, RJ",
            CreatedDate = DateTime.Now.AddDays(-8),
            Password = "senha456",
            IsActive = false,
            ModifiedDate = DateTime.Now.AddDays(-1)
        },
        new CustomerDTO
        {
            Id = 3,
            Name = "Pedro Costa",
            Mobile = "11978901234",
            Email = "pedro.costa@email.com",
            Address = "Praça das Margaridas, 789, Belo Horizonte, MG",
            CreatedDate = DateTime.Now.AddDays(-3),
            Password = "senha789",
            IsActive = true,
            ModifiedDate = DateTime.Now.AddDays(-1)
        }
    };

            return fakeCustomers;
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Name, Mobile, Email, Address, CreatedDate, Password, IsActive, ModifiedDate")] CustomerDTO customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Substitua pelo método de adicionar do seu repositório ou serviço
                    //_customerRepository.AddCustomer(customer);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    // Trate os erros ocorridos durante a adição do cliente e exiba uma mensagem apropriada
                    ModelState.AddModelError("", "Ocorreu um erro ao adicionar o cliente.");
                    return View(customer);
                }
            }
            else
            {
                // Se o modelo não for válido, retorne a View com o objeto customer para exibir os erros de validação
                return View(customer);
            }
        }


        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
