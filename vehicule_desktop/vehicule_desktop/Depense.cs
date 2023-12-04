using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Depense
{
	public Depense()
    {
    public DateTime Date { get; set; }
    public double Montant { get; set; }
    public string Libelle { get; set; }

    public Dépense(DateTime date, double montant, string libelle)
    {
        Date = date;
        Montant = montant;
        Libelle = libelle;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
