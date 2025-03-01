namespace AllatkertOOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Allatkert allatkert = new Allatkert();
            allatkert.Beolvas();
            allatkert.Verseny();
            Console.WriteLine();
            Console.WriteLine("Az állatkert kapacitása, telítettsége");
            allatkert.KibolMennyi();
            Console.WriteLine();
            allatkert.Lakosok();
        }
    }
}
