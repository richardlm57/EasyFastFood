using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Order
{
    public int tiempoEstimado;
    public int total;
    public String tipoPago;
    public String status;
    public int id;

    public Order(int tiempoEstimado, int total, String tipoDePago, String status, int id)
    {
        this.tiempoEstimado = tiempoEstimado;
        this.total = total;
        this.tipoPago = tipoDePago;
        this.status = status;
        this.id = id;
    }
    public static ArrayList UserOrder;
}