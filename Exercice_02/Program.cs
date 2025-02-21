namespace Exercice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer le nom de votre fichier Matrice : ");
            string nomFichier = Console.ReadLine();
            Console.WriteLine("--- Matrice ---");
            Matrice A = new Matrice(nomFichier);
            A.ChargerFichier();
            A.AfficherMatrice();
            Console.WriteLine();

            Console.Write("Entrer le nom de votre fichier Vecteur : ");
            string nomFichierVecteur = Console.ReadLine();
            Console.WriteLine("--- Vecteur ---");

            Vecteur B = new Vecteur(nomFichierVecteur);
            B.ChargerVecteur();
            B.AfficherVecteur();
            Console.WriteLine();

            // Appel de la fonction pour effectuer la multiplication
            Console.WriteLine("--- Multiplication ---");
            Vecteur C = A.MultiplierMatriceParVecteur(B);
            C.AfficherVecteur();
            Console.WriteLine();

            Console.WriteLine("--- Sorti Fichier ---");
            C.EcritureFichier();
        }
    }
}
