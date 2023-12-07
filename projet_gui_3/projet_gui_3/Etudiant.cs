/*
 *
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet_gui_3
{
	/// <summary>
	/// Description of Etudiant.
	/// </summary>
	public class Etudiant
	{
		public int matricule { get; set; }
		public string nom { get; set; }
		public string prenom { get; set; }
		public string classe { get; set; }
		public double moyenne { get; set; }
		public string nationalite { get; set; }
		
		
		public Etudiant()
		{
		}
		
		public Etudiant(int matricule, string nom, string prenom, string classe, double moyenne, string nationalite)
		{
			this.matricule = matricule;
			this.nom = nom;
			this.prenom = prenom;
			this.classe = classe;
			this.moyenne = moyenne;
			this.nationalite = nationalite;
		}
		
	}
}
