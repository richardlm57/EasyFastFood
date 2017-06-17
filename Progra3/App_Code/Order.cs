using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Order
{
    public int tiempoEstimado;
    public int total;
    public String tipoDePago;
    public String Status;
    public int ID;

    public Order(int tiempoEstimado, int total, String tipoDePago, String Status, int ID)
    {
        this.tiempoEstimado = tiempoEstimado;
        this.total = total;
        this.tipoDePago = tipoDePago;
        this.Status = Status;
        this.ID = ID;
    }
    public static ArrayList UserOrder;
}