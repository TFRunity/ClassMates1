using Microsoft.AspNetCore.Mvc;
using ClassMates.Models;
using ClassMates.InterFaces;

namespace ClassMates.Controllers
{
    public class MainHubController : Controller
    {
        private readonly IAllPerson allPerson;
        public MainHubController(IAllPerson _allPerson)
        {
            allPerson = _allPerson;
        }

        [Route("MainHub/MainPage")]
        public ViewResult MainPage()
        {
            List<string> ObshPho = new List<string>
            {
                "/images/Obchie/17.jpg","/images/Obchie/17.jpg","/images/Obchie/17.jpg"
            };
            string Servername = "";
            ViewBag.Title = "Раздел";
            ViewBag.Ttile = "Главная страница";
            ViewBag.Obshie = ObshPho;
            var students = allPerson.ReturnObj;
            return View(students);
        }
        public ViewResult PersonPage(int id)
        {
            if (id == 30)
            {
                ViewBag.Id = 30;
                ViewBag.Title = "Персональная страница создателя";
            }
            else
            {
                ViewBag.Id = id;
                ViewBag.Title = "Персональная страница";
            }
            ViewBag.Ttile = "Персональная страница";
            List<Student> students = (List<Student>)allPerson.ReturnObj;
            return View(students);
        }
        public ViewResult ListPage()
        {
            ViewBag.Ttile = "Весь 9 <Б>";
            List<Student> students = (List<Student>)allPerson.ReturnObj;
            return View(students);
        }

    }
}
