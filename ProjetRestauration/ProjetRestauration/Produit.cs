/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 24/08/2023
 * Time: 02:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of Produit.
	/// </summary>
	public class Produit
	{
		
		public int id { get; set; }
		public string libelle { get; set; }
		public string categorie { get; set; }
		public decimal prix { get; set; }
	
		public int quantite { get; set; }
	//	public string image { get; set; }
		
		
		
		public Produit()
		{
		}
		
		public Produit(int id, string libelle , string categorie, decimal prix, int quantite )
		{
			this.id = id;
			this.libelle = libelle;
		
			this.prix = prix;
			this.categorie = categorie;
			this.quantite = quantite;
		
		}
		
	}
}
