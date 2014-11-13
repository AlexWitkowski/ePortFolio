using EPortfolioAlexWitkowski.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPortfolioAlexWitkowski.Controllers
{
    public class ePortfolioController : Controller
    {
        // GET: ePortfolio
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Resume()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Additional()
        {
            return View();
        }


        public FileResult DisplayPDF()
        {
            return File("/Temp.pdf", "application/pdf");
        }

        public FileResult PDFDisplay()
        {
            string filepath = Server.MapPath("/Temp.pdf");
            byte[] pdfByte = Helper.GetBytesFromFile(filepath);
            return File(pdfByte, "application/pdf");
        }
      
    }
}