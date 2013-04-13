using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgileDashboardWebUI.Models;
namespace AgileDashboardWebUI.Controllers
{
    public class ProjectsController : Controller
    {
        //
        // GET: /Projects/

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetProjects()
        {
            List<Project> projects = new List<Project>();
            JsonResult listprojects=new JsonResult();
            listprojects.Data=projects;
            
            return listprojects;
            }
    }
}
