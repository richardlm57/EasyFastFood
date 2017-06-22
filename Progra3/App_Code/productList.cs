using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace App_Code
{
    public class productList
    {
        public static ArrayList products = new ArrayList();

        public void getList()
        {
            products.Add(new Products(5, 2500, "Hamburguesa Titan de pescado\n.Lechuga, Tomate, Salsa de tomate, torta de pescado, todo esto acompanado de pan italiano.", 50, 1));
            products.Add(new Products(2, 1500, "Papas a la francesa clasicas.Acompañadas de salsa de tomate y una salsa especial hecha en casa", 50, 2));
            products.Add(new Products(2, 3500, "Hot dog salva tandas.Salchicha de 30 cm , pan americano, papas y una gaseosa.", 5, 3));
            products.Add(new Products(8, 4500, "Combo muerto de hambre.Esta opcion incluye: papas, hamburguesa con torta de carne, lechuga, pepina y salsa BBQ.Junto a una deliciosa gaseosa.", 6, 4));
                                               
        }

    }
}