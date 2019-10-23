using Microsoft.AspNetCore.Mvc;

using Dojodachi.Models;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("dojodachi")]
        public IActionResult Dojodachi()
        {
            Pet pet = new Pet();
            return View(pet);
        }

        [HttpPut("feed")]
        public JsonResult Feed(Pet obj)
        {
            Pet updatedPet = new Pet(
                obj.Fullness,
                obj.Happiness,
                obj.Meals,
                obj.Energy
            );

            updatedPet.Message = updatedPet.Feed();

            return Json(updatedPet);
        }

        [HttpPut("play")]
        public JsonResult Play(Pet obj)
        {
            Pet updatedPet = new Pet(
                obj.Fullness,
                obj.Happiness,
                obj.Meals,
                obj.Energy
            );

            updatedPet.Message = updatedPet.Play();

            return Json(updatedPet);
        }

        [HttpPut("work")]
        public JsonResult Work(Pet obj)
        {
            Pet updatedPet = new Pet(
                obj.Fullness,
                obj.Happiness,
                obj.Meals,
                obj.Energy
            );

            updatedPet.Message = updatedPet.Work();

            return Json(updatedPet);
        }

        [HttpPut("sleep")]
        public JsonResult Sleep(Pet obj)
        {
            Pet updatedPet = new Pet(
                obj.Fullness,
                obj.Happiness,
                obj.Meals,
                obj.Energy
            );

            updatedPet.Message = updatedPet.Sleep();

            return Json(updatedPet);
        }



        [HttpGet("GetStats")]
        public JsonResult GetStats()
        {
            Pet pet = new Pet();
            return Json(pet);
        }
    }
}