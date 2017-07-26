using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public String name { get; set; }
    public String surname { get; set; }
    public String username { get; set; }
    public String password { get; set; }
    public String telephone { get; set; }
    public String email { get; set; }
    public String address { get; set; }
    public ArrayList orders { get; set; }
    public int balance{ get; set; }

    public User(String name, String surname, String email, String password, String telephone, String address, ArrayList orders,int balance){
        this.name = name;
        this.surname = surname;
        this.username = email;
        this.password = password;
        this.telephone = telephone;
        this.address = address;
        this.orders = orders;
        this.balance = balance;
    }
}