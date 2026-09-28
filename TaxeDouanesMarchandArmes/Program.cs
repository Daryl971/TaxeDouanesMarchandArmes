namespace TaxeDouanesMarchandArmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal prixArme;
            int taxeSaisie;
            const decimal taxeRoyal = 0.2m;
            const decimal taxeMiniere = 0.1m;
            const decimal taxeReduite = 0.055m;
            const decimal taxeArtisanat = 0.021m;

            Console.WriteLine("Quels est le prix de base de l'arme");
            prixArme = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Ou avez vous acheté votre arme :" +
                $"1 - Forges de la Capitale" +
                $"2 - Ateliers des Nains des Montagnes" +
                $"3 - Port des Contrebandiers" +
                $"4 - Terres Sacrées du Temple");
            taxeSaisie = int.Parse(Console.ReadLine());

            switch (taxeSaisie) {
                case 1: Console.WriteLine($"Le prix fianl a payer est de {Convert.ToInt16(taxeRoyal * prixArme + prixArme)} pièce d'or"); break;
                case 2: Console.WriteLine($"Le prix fianl a payer est de {Convert.ToInt16(taxeMiniere * prixArme + prixArme)} pièce d'or"); break;
                case 3: Console.WriteLine($"Le prix fianl a payer est de {Convert.ToInt16(taxeReduite * prixArme + prixArme)} pièce d'or"); break;
                case 4: Console.WriteLine($"Le prix fianl a payer est de {Convert.ToInt16(taxeArtisanat * prixArme + prixArme)} pièce d'or"); break;
            }
        }
    }
}
