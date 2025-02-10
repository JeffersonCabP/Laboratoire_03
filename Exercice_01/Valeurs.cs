using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Valeurs
    {
        List<double> temps = new List<double>();
        List<double> hauteur = new List<double>();
        List<double> vitesse = new List<double>() { 0 }; // Initialise notre vecteur de vitesse à 0

        // Méthode pour lire les données à partir du fichier
        public void LectureFichier()
        {
            StreamReader fichier = new StreamReader("Donnees.csv");
            fichier.ReadLine(); // Ignore la ligne d'entête
            string ligne;
            while ((ligne = fichier.ReadLine()) != null)
            {
                string[] mesures = ligne.Split(';'); // Crée un tableau à une dimension. Place les valeurs dans le tableau en utilisant le point-virgule comme séparateur
                temps.Add(double.Parse(mesures[0])); // Ajoute au vecteur de temps
                hauteur.Add(double.Parse(mesures[1])); // Ajoute au vecteur de hauteur
            }


        }
        // Méthode pour calculer la vitesse
        public void CalculerVitesse()
        {
            for (int i = 1; i < temps.Count; i++)
            {
                double deltaT = temps[i] - temps[i - 1];
                double deltaH = hauteur[i] - hauteur[i - 1];

                if (deltaT > 0)
                {
                    vitesse.Add(deltaH / deltaT);
                }
            }
        }

        // Méthode pour écrire dans le fichier
        public void EcritureFichier()
        {
            StreamWriter fichierSortie = new StreamWriter("Resultat.csv");
            fichierSortie.WriteLine("Temps (s), Hauteur (m), Vitesse (m/s)");

            for (int i = 0; i < temps.Count; i++)
            {
                fichierSortie.WriteLine($"{temps[i]};{hauteur[i]};{vitesse[i]}");
            }
            fichierSortie.Close();
            Console.WriteLine("Résultats enregistrés avec succès! Voir fichier Resultat.csv");
        }
    }
}
