using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Infrastructure.Binders{
    public class CartModelBinder:IModelBinder{
        private const string sessionKey = "Cart";

        public object BindModel(ControllerContext controllerContext,
            ModelBindingContext bindingContext){

            //pega o carrinho da sessao
            Cart cart = null;
            if (controllerContext.HttpContext.Session != null){
                cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
            }

            //cria um carrinho se nao existir nenhum na sessao
            if (cart == null){
                cart = new Cart();
                if (controllerContext.HttpContext.Session != null){
                    controllerContext.HttpContext.Session[sessionKey] = cart;
                }
            }
            //retorna o carrinho
            return cart;
        }
    }
}