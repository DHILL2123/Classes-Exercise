namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            Car carOne = new Car();
            {
                carOne.Make = "Ram";
                carOne.Model = "Laramie";
                carOne.Year = 2022;

                Console.WriteLine($"My favorite car is a {carOne.Make} {carOne.Model} {carOne.Year}!");
                
            }

            







        }





    }
}
