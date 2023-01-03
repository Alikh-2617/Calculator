
namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // test ww
            CalculatorXunit calculator = new CalculatorXunit();
            bool run = true;
            while (run)
            {
                int[] x;
                int[] y;
                Console.Clear();
                Console.WriteLine("Hej här har du Menu :\n" +
                    "1- för addition\n" +
                    "2- för subtraktion\n" +
                    "3- för multiplikation\n" +
                    "4- för division\n" +
                    "5- för att avsluta programet\n");
                int G = calculator.SetInt();
                switch (G)
                {
                    case 1:
                        Console.WriteLine("Addition");
                        Console.WriteLine("Svart : " + 
                            calculator.sum(calculator.SetInt(), calculator.SetInt()) +
                            //calculator.sum(calculator.SetList(), calculator.SetList()) +
                            "\n\ntryck Inter föratt komma vidare.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Subtraktion");
                        Console.WriteLine("Svart : " + 
                            calculator.sub(calculator.SetInt(), calculator.SetInt()) +
                            //calculator.sub(calculator.SetList(), calculator.SetList()) +
                            "\n\ntryck Inter föratt komma vidare.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Multiplikation");
                        Console.WriteLine("Svart : " + calculator.mul(calculator.SetInt(), calculator.SetInt()) + "\n\ntryck Inter föratt komma vidare.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Division");
                        Console.WriteLine("Svart : " + calculator.div(calculator.SetInt(), calculator.SetInt()) + "\n\ntryck Inter föratt komma vidare.");
                        Console.WriteLine("\n\ntryck Inter föratt komma vidare.");
                        Console.ReadKey();

                        break;
                    case 5:
                        Console.WriteLine("vi avslutar programmet !\n\ntryck Inter föratt komma vidare.");
                        Console.ReadKey();
                        run = false;
                        break;
                }
            }
            }
    }
}