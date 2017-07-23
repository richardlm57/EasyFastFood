using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Order
{
    public int tiempoEstimado { get; set; }
    public int total { get; set; }
    public String tipoPago { get; set; }
    public String status { get; set; }
    public int id { get; set; }
    public ArrayList products { get; set;  }

    public Order(int tiempoEstimado, int total, String tipoDePago, String status, int id, ArrayList products)
    {
        this.tiempoEstimado = tiempoEstimado;
        this.total = total;
        this.tipoPago = tipoDePago;
        this.status = status;
        this.id = id;
        this.products = products;
    }

    public void insertOrder(ArrayList userOrder)
    {
        products = userOrder;
      
    }

    public void updateOrder(ArrayList userOrder)
    {
        products = userOrder;

    }

    public ArrayList selectOrder()
    {
        return products;
    }

    public void deleteOrder() {
        products = null;
    }
}