using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Product
{
    public int id { get; set; }
    public String descripcion { get; set; }
    public double precio { get; set; }
    public int tiempoRealizacion { get; set; }
    public int cantidad { get; set; }

    public Product (int id, String descripcion, double precio, int tiempoRealizacion , int cantidad)
    {
        this.id = id;
        this.descripcion = descripcion;
        this.precio = precio;
        this.tiempoRealizacion = tiempoRealizacion;
        this.cantidad = cantidad;
    }
}