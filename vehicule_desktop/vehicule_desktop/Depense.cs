using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Depense
{
	public Depense()
    {
   public string code { get; set; }
    public DateTime date { get; set; }
    public decimal dontant { get; set; }
    public string libelle { get; set; }
    public string stationService { get; set; }
    public User agentMaintenance { get; set; }

    public Dépense(DateTime date, double montant, string libelle, string code)
    {
        date = date;
        code = code;
        montant = montant;
        libelle = libelle;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
