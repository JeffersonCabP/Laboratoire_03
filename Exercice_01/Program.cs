namespace Exercice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valeurs nouvelleValeur = new Valeurs(); // Fait appel au constructeur par défaut
            nouvelleValeur.LectureFichier(); // Fait appel à la lecture du fichier pour charger les dobbées dans nos listes
            nouvelleValeur.CalculerVitesse(); // Fait appel à la méthode pour complèter la liste de vitesse
            nouvelleValeur.EcritureFichier(); // Fait appel à la méthode pour sauvegarder dans le fichier
        }
    }
}
