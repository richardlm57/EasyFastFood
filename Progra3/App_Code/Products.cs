using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Products
{
       public int tiempoRealizacion { get; set; }
       public int precio { get; set; }
       public String descripcion { get; set; }
       public int cantidad { get; set; }
       public int id { get; set; }
       
    public Products (int tiempoRealizacion , int precio, String descripcion, int cantidad, int id)
    {
        this.tiempoRealizacion = tiempoRealizacion;
        this.precio = precio;
        this.descripcion = descripcion;
        this.cantidad = cantidad;
        this.id = id;
    }
}