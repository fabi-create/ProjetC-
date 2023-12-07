/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/08/2023
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of Utilisateur.
	/// </summary>
	public class Utilisateur
	{
		
		
		public int id { get; set; }
		public string nom_utilisateur { get; set; }
		public string mot_de_passe { get; set; }
		public string type_utilisateur { get; set; }
		public string email { get; set; }
		public string Number { get; set; }
		
		
		public Utilisateur()
		{
		}
		
		public Utilisateur(int id, string nom_utilisateur, string mot_de_passe, string type_utilisateur, string email, string Number)
		{
			this.id = id;
			this.nom_utilisateur = nom_utilisateur;
			this.mot_de_passe = mot_de_passe;
			this.type_utilisateur = type_utilisateur;
			this.email = email;
			this.Number = Number;
		}
	}
}
