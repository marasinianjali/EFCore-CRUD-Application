using System;
using CRUDWeb.Models;
using Microsoft.AspNetCore.MVC;
using System.Linq;

namespace CRUDWeb.Controllers
{
	public class ProductController : Controller
	{
		private readonly AppDbContext _context;
		public ProductController(AppDbContext context)
		{
			_context = context;
		}
	

		// Create
		public IActionResult Create(Product product)
		{
			if (ModelState.IsValid)
			{
				_context.Products.Add(product);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(product);
		}

		// Read
		public IActionResult Index()
		{
			var products = _context.Proudcts.ToList();
			return View(products);
		}

		// Update
		public IActionResult Edit(int id)
		{
			var product = _context.Products.Find(id);
		}

		[HttpPost]
		public IActionResult Edit(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		// Delete
		public IActionResult Delete(int id)
		{
			var product = _context.Products.Find(id);
			if (product != null)
			{
				_context.Products.Remove(product);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
