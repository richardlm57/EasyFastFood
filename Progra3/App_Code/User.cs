﻿using System;
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
    public String address { get; set; }

    public User(String name, String surname, String email, String password, String telephone, String address){
        this.name = name;
        this.surname = surname;
        this.username = email;
        this.password = password;
        this.telephone = telephone;
        this.address = address;
    }
}