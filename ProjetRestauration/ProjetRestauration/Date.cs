/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 23/08/2023
 * Time: 09:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of Date.
	/// </summary>
	public class Date
	{
	
		int jour ;
		public int Jour{
			set { jour = value;}
			get {return jour ;}
		}
		int mois ;
		public int Mois{
			set { mois = value;}
			get {return mois ;}
		}
		int annnee ;
		public int Annnee{
			set { annnee = value;}
			get {return annnee ;}
		}
		public Date()
		{
		}
		public Date(int jour, int mois, int annnee)
		{
			this.jour = jour ;
			this.mois = mois ;
			this.annnee = annnee ;
		}
		public string afficher(){
			return jour + "-" + mois +"-" + annnee ;
		}
		
		
	}
}
