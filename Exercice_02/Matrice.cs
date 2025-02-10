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

        }

    }
}
