using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_02
{
    internal class Matrice
    {
        string nomFichier;
        //public string NomFichier { get; set; }

        // Définition de la propriété qui en dessous fait la déclaration de l'attribut
        public double[,] Valeur {  get; set; }
        
        // Définition du constructeur paramétré 
        public Matrice(string nomFichier)
        {
            this.nomFichier = nomFichier;
        }

        // Méthode qui permet de charger le fichier en mémoire
        public void ChargerFichier()
        {
            string[] ligne = File.ReadAllLines(nomFichier); // Place toutes les lignes du fichier dans le tableau
            int nombreLignes = ligne.Length; // Length retourne la taille du tableau
            int nombreColonnes = ligne[0].Split(';').Length; // Ligne[0].Split(';') retourne un tableau contenant les éléments de la cellule 0. Length donne la taille de ce tableau.

            Valeur = new double[nombreLignes, nombreColonnes]; // Allocation mémoire pour contenir notre tableau

            for (int i = 0; i < nombreLignes; i++)
            {
                string[] elements = ligne[i].Split(';');
                for (global::System.Int32 j = 0; j < nombreColonnes; j++)
                {
                    Valeur[i, j] = double.Parse(elements[j]);
                }
            }
        }

        public void AfficherMatrice()
        {
            int taille = Valeur.GetLength(0); // GetLength(0) : Donne la taille du nombre de lignes du 2D Array
                                              // GetLength(1) : Donne la taille du nombre de colonnes du 2D Array
            for (int i = 0; i < taille; i++)
            {
                for (global::System.Int32 j = 0; j < taille; j++)
                {
                    Console.Write($"{Valeur[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        
        // Fonction pour effectuer la multiplication de la Matrice A par un vecteur B
        public Vecteur MultiplierMatriceParVecteur(Vecteur vecteur)
        {
            int tailleMatrice = Valeur.GetLength(0);
            double[] resultat = new double[tailleMatrice];

            if ( tailleMatrice != vecteur.ValeurVecteur.Length )
            {
                Console.WriteLine("Les dimensions de la matrice et du vecteur ne sont pas compatibles!");
            }
            else
            {
                for (global::System.Int32 i = 0; i < tailleMatrice; i++)
                {
                    double somme = 0;
                    for (global::System.Int32 j = 0; j < tailleMatrice; j++)
                    {
                        somme += Valeur[i, j] * vecteur.ValeurVecteur[j];
                    }
                    resultat[i] = somme;
                }
            }
            return new Vecteur(resultat);
            
        }
        
        
    }
}
