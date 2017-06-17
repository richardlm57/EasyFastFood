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
       public String Descripcion { get; set; }
       public int Cantidad { get; set; }
       public int ID { get; set; }
       
    public Products (int tiempoRealizacion , int precio, String Descripcion, int Cantidad, int ID)
    {
        this.tiempoRealizacion = tiempoRealizacion;
        this.precio = precio;
        this.Descripcion = Descripcion;
        this.Cantidad = Cantidad;
        this.ID = ID;
    }
}