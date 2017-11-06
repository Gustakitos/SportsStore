using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers{

    [Authorize]
    public class AdminController : Controller{
        private IProductRepository repository;

        public AdminController(IProductRepository repo){
            repository = repo;
        }
        public ActionResult Index(){
            return View(repository.Products);
        }

        public ViewResult Create(){
            return View("Edit", new Product());
        }

        public ViewResult Edit(int productId){
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product){
            if (ModelState.IsValid){
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} foi salvo", product.Name);
                return RedirectToAction("Index");
            }else{
                //ha algo errado com os valores
                return View(product);
            }
        }


        [HttpPost]
        public ActionResult Delete(int productID){
            Product deletedProduct = repository.DeleteProduct(productID);
            if (deletedProduct != null){
                TempData["message"] = string.Format("{0} foi apagado",deletedProduct.Name);
            }
            return RedirectToAction("Index");
        }
    }
}