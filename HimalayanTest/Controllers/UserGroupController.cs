using HimalayanTest.DAO;
using HimalayanTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanTest.Controllers
{
    public class UserGroupController : Controller
    {
        ApplicationDbContext _context;
        public UserGroupController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //UserGroup ug = new UserGroup();
            //ug.UserGroupName = "Verstappen";
            //ug.UserGroupCode = "F1";
            //ug.IsActive = true;

            //_context.UserGroups.Add(ug);
            //_context.SaveChanges();

            List<UserGroup> groups = _context.UserGroups.ToList();

            return View(groups);
        }
    }
}
