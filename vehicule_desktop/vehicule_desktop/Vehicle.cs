using System;
using System.Diagnostics;

class Vehicle
{
    public string Immatriculation { get; set; }
    public DateTime DateAcquisition { get; set; }
    public int Kilometrage { get; set; }
    public string TypeEnergie { get; set; }
    public User User { get; set; }
    public List<Depense> Depenses { get; set; }

    public Vehicle(string immatriculation, DateTime dateAcquisition, int kilometrage, string typeEnergie)
    {
        Immatriculation = immatriculation;
        DateAcquisition = dateAcquisition;
        Kilometrage = kilometrage;
        TypeEnergie = typeEnergie;
        Depenses = new List<Depense>();
    }
}