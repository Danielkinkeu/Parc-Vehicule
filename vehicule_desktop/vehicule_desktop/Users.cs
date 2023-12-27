using System;
using System.Diagnostics;

class Users
{
    public string Code { get; set; }
    public string Nom { get; set; }
    public List<Vehicle> Vehicles { get; set; }

    public Users(string code, string nom)
    {
        Code = code;
        Nom = nom;
        Vehicles = new List<Vehicle>();
    }
}