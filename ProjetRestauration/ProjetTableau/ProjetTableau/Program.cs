/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 01/08/2023
 * Time: 10:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

//Une fonction qui remplit un tableau de float de taille n  
//trier les elemnts du tableau par ordre croissant ou decroissant sans utiliser la fonction short

namespace ProjetTableau
{
	
	using System;

public class Program
{
    public static void Main()
    {
     
         
  double[] tableau, tableau2;
        SaisirTableau(out tableau);
         AfficherTableau(tableau);
        SaisirTableau(out tableau2);        
         AfficherTableau(tableau2);
         
          double[] tableauFusionne = FusionnerTableaux(tableau, tableau2);

        Console.WriteLine("Tableau fusionné :");
        AfficherTableau(tableauFusionne);
        
        TrierTableauCroissant( tableau);
          Console.WriteLine("Tableau trié par ordre croissant :");
        AfficherTableau(tableau);
        
           TrierTableauDecroissant( tableau);
          Console.WriteLine("Tableau trié par ordre decroissant :");
        AfficherTableau(tableau);
        
        
        InverserTableau( tableau);
            Console.WriteLine("Tableau inverse :");
        AfficherTableau(tableau);
        
			Console.WriteLine("Hello World!");
	
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
    }

    public static void SaisirTableau(out double[] tab)
    {
        int n;
        Console.WriteLine("Veuillez saisir la taille du tableau :");
        n = int.Parse(Console.ReadLine());

        tab = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Saisir une valeur " + i + " : ");
            tab[i] = double.Parse(Console.ReadLine());
        }
    }
    
    public static void SaisirTableauDeuxieme(out double[] tab)
    {
        int n;
        Console.WriteLine("Veuillez saisir la taille du tableau :");
        n = int.Parse(Console.ReadLine());

        tab = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Saisir une valeur " + i + " : ");
            tab[i] = double.Parse(Console.ReadLine());
        }
    }
    
    
  public static void TrierTableauCroissant(double[] tab)
    {
        for (int i = 0; i < tab.Length - 1; i++)
        {
            for (int j = 0; j < tab.Length - i - 1; j++)
            {
                if (tab[j] < tab[j + 1])
                {
                    // Échanger les éléments
                    double temp = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = temp;
                }
            }
        }
    }
  
  public static void TrierTableauDecroissant(double[] tab)
{
    for (int i = 0; i < tab.Length - 1; i++)
    {
        for (int j = 0; j < tab.Length - i - 1; j++)
        {
            if (tab[j] > tab[j + 1]) // Changement ici
            {
                // Échanger les éléments
                double temp = tab[j];
                tab[j] = tab[j + 1];
                tab[j + 1] = temp;
            }
        }
    }
}
public static void InverserTableau(double[] tab)
{
    int left = 0;
    int right = tab.Length - 1;

    while (left < right)
    {
        // Échanger les éléments
        double temp = tab[left];
        tab[left] = tab[right];
        tab[right] = temp;

        // Déplacer les indices vers le milieu du tableau
        left++;
        right--;
    }
}


public static double[] FusionnerTableaux(double[] tab1, double[] tab2)
    {
        int tailleTab1 = tab1.Length;
        int tailleTab2 = tab2.Length;
        int tailleFusion = tailleTab1 + tailleTab2;

        double[] tabFusionne = new double[tailleFusion];

        Array.Copy(tab1, tabFusionne, tailleTab1);
        Array.Copy(tab2, 0, tabFusionne, tailleTab1, tailleTab2);

        
        return tabFusionne;
    }

//Crer ne fction qui recoit deux tablaeux puis créer un tableau d'union 

    public static void AfficherTableau(double[] tab)
    {
        Console.WriteLine("Contenu du tableau :");
        foreach (double nombre in tab)
        {
            Console.Write(nombre + " ");
        }
        Console.WriteLine();
    }
}


	
}