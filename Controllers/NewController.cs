using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Metadata.Ecma335;
using Tachyon.Areas.Identity.Data;
using Tachyon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Tachyon.Controllers
{
	public class NewController : Controller
	{
		private readonly TachyonDbContext _Context;
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Land()
		{
			return View();
		}
		public NewController(TachyonDbContext dBD)
		{
			_Context = dBD;
		}
		public IActionResult ProcedureList()
		{
			IEnumerable<NewProcedure> list = _Context.NewPro;
			return View(list);
		}
		public IActionResult CreateProcedure()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult CreateNewPro(NewProcedure newPro)
		{
			if (ModelState.IsValid)
			{
				_Context.NewPro.Add(newPro);
				_Context.SaveChanges();
				return RedirectToAction("ProcedureList");
			}
			return View(newPro);
		}
		public IActionResult updateNewPro(int? ID)
		{
			if (ID == null || ID == 0)
			{
				return NotFound();
			}
			var list = _Context.NewPro.Find(ID);
			if (list == null)
			{
				return NotFound();
			}
			return View(list);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult updateFeedBack(NewProcedure newPro)
		{
			_Context.NewPro.Update(newPro);
			_Context.SaveChanges();
			return RedirectToAction("ProcedureList");
		}

		public IActionResult DeleteNewProcedure(int? ID)
		{
			var list = _Context.NewPro.Find(ID);
			if (list == null)
			{
				return NotFound();
			}
			_Context.NewPro.Remove(list);
			_Context.SaveChanges();
			return RedirectToAction("ProcedureList");

		}
	}
}
