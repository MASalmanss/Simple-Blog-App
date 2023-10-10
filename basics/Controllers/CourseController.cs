using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller{

    // course / index
    public IActionResult Index(){
        var kurs = new Course();
        kurs.id = 1;
        kurs.Title = "F1 bloguma hoş geldiniz";
        kurs.Description = "Bu bir açıklamadır";
        return View(kurs);
    }

     public IActionResult Details(int? id){

        if(id == null){
           // return Redirect("/course/list");
           return RedirectToAction("List","Course");

        }
        else{

            var kurs = Repository.GetById(id);
            return View(kurs);
        }

        
    }


    //course / list
    public IActionResult List(){

        
        
        return View("CourseList" , Repository.Courses);
    }
}