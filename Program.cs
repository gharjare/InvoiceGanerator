namespace CabInvoiceGenerator2
{
    class progrma
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to cab invoice generator");
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoice.CalculateFare(2.0, 5);
            Console.WriteLine($"FARE : {fare}");
        }
    }

}
