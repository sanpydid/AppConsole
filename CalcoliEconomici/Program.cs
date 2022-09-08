namespace CalcoliEconomici
{
    internal class Program
    {
        static void Main(string[] args) // entry point
        {
            // MODELLO DEI DATI - VARIABILI 
            decimal PU, PF = 0m, sconto = 0m, perSconto, IVA;
            int N;
            // ALGORITMO
            Console.Write("Prezzo unitario in euro = "); // INPUT
            PU = decimal.Parse(Console.ReadLine());
            Console.Write("Numero di prodotti venduti = ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Sconto in % da applicare = ");
            sconto = decimal.Parse(Console.ReadLine());
            Console.Write("IVA in % da applicare = ");
            IVA = decimal.Parse(Console.ReadLine());
            PF = PU * N; // ELABORAZIONE
            sconto = PF * sconto / 100m;
            PF = PF - sconto;
            PF = PF + PF * IVA / 100m;
            Console.WriteLine($"Sconto applicato = {sconto:N2} euro"); // OUTPUT
            Console.WriteLine($"Prezzo finale = {PF:N2} euro");
        } // fine main
    } // fine class
} // fine namespace