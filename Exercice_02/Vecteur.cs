using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_02
{
    internal class Vecteur
    {
        string nomFichierVecteur;

        public double[] ValeurVecteur {  get; set; }
        public Vecteur(double[] valeurs)
        {
            ValeurVecteur = valeurs;
        }
        public Vecteur(string nomFichierVecteur)
        {
            this.nomFichierVecteur = nomFichierVecteur;
        }
        public void ChargerVecteur()
        {
            string[] elements = File.ReadAllLines(nomFichierVecteur);
            string[] val = elements[0].Split(';');
            ValeurVecteur = new double[val.Length]; // Allocation mémoire

            for (int i = 0; i < val.Length; i++)
            {
                ValeurVecteur[i] = double.Parse(val[i]);
            }



        }
        public void AfficherVecteur()
        {
            for (int i = 0; i < ValeurVecteur.Length; i++)
            {
                Console.Write($"{ValeurVecteur[i]}\t");
            }
            Console.WriteLine();
        }
        public void EcritureFichier()
        {
            using (StreamWriter fichierSorti = new StreamWriter("Résultats.csv"))
            {
                for (int i = 0; i < ValeurVecteur.Length; i++)
                {
                    fichierSorti.WriteLine($"{ValeurVecteur[i]}");
                }
            }
            Console.WriteLine("Résultats enregistrés dans Résultats.csv!");
        }
    }
}
