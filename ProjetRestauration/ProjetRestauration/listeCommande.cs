/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 21/08/2023
 * Time: 22:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of listeCommande.
	/// </summary>
	public class listeCommande
	{
		
		
		
		
		public int id { get; set; }
		public int idCommande { get; set; }
		public int  idProduit{ get; set; }
		public int etatCommande { get; set; }
		public int idRestaurateur { get; set; }
		public int quantite { get; set; }
		public decimal prixUnitaire { get; set; }
	//	public string image { get; set; }
		
		
		
		public listeCommande()
		{
		}
		
		public listeCommande(int id, int idCommande , int etatCommande, int idProduit, int idRestaurateur, int quantite,decimal prixUnitaire )
		{
			this.id = id;
			this.idCommande = idCommande;
			this.etatCommande = etatCommande;
			this.idProduit= idProduit;
			this.idRestaurateur = idRestaurateur;
			this.quantite = quantite;
			this.prixUnitaire= prixUnitaire;
		
		}
	}
}
