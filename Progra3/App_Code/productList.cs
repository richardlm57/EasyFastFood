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
                products.Add(new Product(1, "Hamburguesa Titán de Pescado: Lechuga, tomate, salsa de tomate y torta de pescado, todo junto en un pan francés.", 2500, 5, 44));
                products.Add(new Product(2, "Papas a la francesa clásicas, acompañadas de salsa de tomate y una salsa especial secreta de la casa.", 1500, 2, 4));
                products.Add(new Product(3, "Hot dog salva tandas: Salchicha de 30 cm, pan americano, salsas básicas, bbq, papas, repollo, cebolla, maíz, y una gaseosa light.", 3500, 2, 50000));
                products.Add(new Product(4, "Combo muerto de hambre: Papas, hamburguesa con torta de carne, lechuga, pepinillos, huevo y salsa BBQ, con un pichel personal de gaseosa.", 4500, 8, 2));
            }                                  
        }

    }
}