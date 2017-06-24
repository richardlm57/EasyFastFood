using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace App_Code
{
    public class ProductList
    {
        public static ArrayList products;

        public ProductList() {
        }

        public void createProductList()
        {
            if (products == null)
            {
                products = new ArrayList();
                products.Add(new Product(1, "Hamburguesa Titan de pescado\n.Lechuga, Tomate, Salsa de tomate, torta de pescado, todo esto acompanado de pan italiano.", 2500, 5, 4));
                products.Add(new Product(2, "Papas a la francesa clasicas.Acompañadas de salsa de tomate y una salsa especial hecha en casa", 1500, 2, 2));
                products.Add(new Product(3, "Hot dog salva tandas.Salchicha de 30 cm , pan americano, papas y una gaseosa.", 3500, 2, 2));
                products.Add(new Product(4, "Combo muerto de hambre.Esta opcion incluye: papas, hamburguesa con torta de carne, lechuga, pepina y salsa BBQ.Junto a una deliciosa gaseosa.", 4500, 8, 2));
            }                                  
        }

    }
}