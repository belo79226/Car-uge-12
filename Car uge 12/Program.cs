namespace Car_uge_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string brand, string model, int year, double kmPerLiter, double tankCapacity, string licensePlate, double price
            FuelCar fc = new FuelCar("Toyota", "Corolla", 2022, 18, 50, "AB12345", 45000);
            //string brand, string model, int year,double batteryCapacity, double kmPerKwh, string licensePlate, double price
            EletricCar ec = new EletricCar("Tesla", "Model 3", 2023, 75, 6.5, "CD67890", 380000);

            House h = new House("Strandvejen 42, 2900 Hellerup", 1965, 4200000, "1234-AB");


           


            List<ISellable> forSale = new List<ISellable> { fc, ec };


            forSale.Add(h);

           


            foreach (ISellable s in forSale)

            {

                Console.WriteLine(s.GetSalesSummary());

            }



            // Beregn samlet salgspris 

            double total = 0;

            foreach (ISellable s in forSale)

                total += s.Price;

            Console.WriteLine($"Samlet beholdningsværdi: {total:N0} kr");

            List<IInsurable> insured = new List<IInsurable> { fc, ec };

            insured.Add(h);


            foreach (IInsurable i in insured)

                Console.WriteLine($"{i.RegistrationNumber}: {i.GetInsuranceRate():F1}%");

            Console.ReadLine();
        }
    }
}
