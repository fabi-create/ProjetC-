/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 22/08/2023
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of Paiement.
	/// </summary>
	public class Paiement
	{
		public int id { get; set; }
		public int idCommande { get; set; }
		public int  idProduit{ get; set; }
		public int etatCommande { get; set; }
		public int idRestaurateur { get; set; }
		public int quantite { get; set; }
		public decimal prixUnitaire { get; set; }
		public decimal total { get; set; }
		public decimal montantVerse { get; set; }
	    public decimal montantRemis { get; set; }
			
	//	public string image { get; set; }
		
		
	private Date datePaiement;
        public Date DatePaiement
        {
            set { datePaiement = value; }
            get { return datePaiement; }
        }
	
	
		
		public Paiement()
		{
		}
		
		public Paiement(int id, int idCommande , int etatCommande, int idProduit, int idRestaurateur, int quantite,decimal prixUnitaire, decimal total,decimal montantVerse,decimal montantRemis )
		{
			this.id = id;
			this.idCommande = idCommande;
			this.etatCommande = etatCommande;
			this.idProduit= idProduit;
			this.idRestaurateur = idRestaurateur;
			this.quantite = quantite;
			this.prixUnitaire= prixUnitaire;
			this.total = total;
			this.montantVerse = montantVerse;
			this.montantRemis= montantRemis;
		
		}
	}
}
