using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;
using System;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          List<Contact> allContacts = Contact.GetAll();
          return View(allContacts);
        }
        [HttpGet("/form")]
        public ActionResult FormFill()
        {
            return View("form");
        }
        [HttpPost("/contact/new")]
        public ActionResult FormPost()
        {
            Contact myContact = new Contact();
            myContact.SetName(Request.Form["name"]);
            myContact.SetNumber(Request.Form["number"]);
            myContact.SetAddress(Request.Form["address"]);

            return View("new", myContact);

        }
        // [HttpGet("/list")]
        // public ActionResult List()
        // {
        //     List<Contact> allContacts = Contact.GetAll();
        //     return View(allContacts);
        // }



        [HttpGet("/contact/details/{id}")]
        public ActionResult ContactInstance(int id)
        {
            return View(Contact.Find(id));

        }
    }
}
