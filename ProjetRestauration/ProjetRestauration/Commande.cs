/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 21/08/2023
 * Time: 00:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of Commande.
	/// </summary>
	public class Commande
	{
		
		public int id { get; set; }
		public string libelleCommande { get; set; }
		public string nomPrenomClient { get; set; }
		public int telephoneClient { get; set; }
		public int etatCommande { get; set; }
	//	public string image { get; set; }
		
		public Commande()
{
    // Constructeur sans arguments
}

	
		public Commande (int id, string libelleCommande, string nomPrenomClient,int telephoneClient,int etatCommande  )
		{
			this.id = id;
			this.libelleCommande = libelleCommande;
			this.nomPrenomClient= nomPrenomClient;
			this.telephoneClient = telephoneClient;
			this.etatCommande = etatCommande;
		
		}
	}
}
