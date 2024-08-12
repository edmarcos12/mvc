using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
       Cliente cliente1 =  new Cliente(01, "Edmarcos A. Pacheco", "857.032.950-41", "edmarcos.araujo@hotmail.com", "Marcos");
       Cliente cliente2 =  new Cliente(02, "Bil M. Soares", "001.134.700-00", "bil@hotmail.com", "Bil");
       Cliente cliente3 =  new Cliente(03, "Max Miliano", "200.001.002-01", "maxxx@gmail.com", "Max");
       Cliente cliente4 =  new Cliente(04, "Ali Mendes", "019.400.400-10", "alimendes01@live.com", "Ali");
       Cliente cliente5 =  new Cliente(05, "Fernanda C. Alves", "500.031.360-19", "fernanda.alves@uol.com", "Feh");

        // lista de clientes e atribui os clientes
       List<Cliente> listaClientes = new List<Cliente>();
       listaClientes.Add(cliente1);
       listaClientes.Add(cliente2);
       listaClientes.Add(cliente3);
       listaClientes.Add(cliente4);
       listaClientes.Add(cliente5);

       ViewBag.listaClientes = listaClientes ;

       // instancias do tipo fornecedor
       Fornecedor fornecedor1 =  new Fornecedor(01, "Guardian Pet", "14.182.102/0001-00", "guardianPet@hotmail.com");
       Fornecedor fornecedor2 =  new Fornecedor(02, "Fish Master", "16.829.300/0002-21", "Fish.Master@hotmail.com");
       Fornecedor fornecedor3 =  new Fornecedor(03, "Tik Tok", "01.200.300/5000-30", "Tiktok@gmail.com");
       Fornecedor fornecedor4 =  new Fornecedor(04, "Clinica Alvorada", "01.111.222/0004-29", "Clinica.Alvorada@live.com");
       Fornecedor fornecedor5 =  new Fornecedor(05, "Master", "50.222.000/0009-55", "Master@master.uol.com");
        
     // lista de fornecedores e atribui os fornecedores
     List<Fornecedor> listaFornecedores = new List<Fornecedor>();
    listaFornecedores.Add(fornecedor1);
    listaFornecedores.Add(fornecedor2);
    listaFornecedores.Add(fornecedor3);
    listaFornecedores.Add(fornecedor4);
    listaFornecedores.Add(fornecedor5);
        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
