using certificates.Models;
using Certificates.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Certificates.Controllers
{
    public class StudentCertificateController : Controller
    {
        
        public IActionResult Index(string code)
        {

            return View();
        }

        public IActionResult Certificate(string code)
        {
            ViewBag.Student = CertificateProvider.getCertificateByCode(code);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}