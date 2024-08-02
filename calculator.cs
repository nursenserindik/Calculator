namespace calculator
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            double num1, num2;
            string operation;

            Console.WriteLine("CALCULATOR");
            Console.WriteLine("------------");

            Console.Write("First number: ");
            num1=Convert.ToDouble(Console.ReadLine());

            Console.Write("Second Number: ");
            num2=Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose your operations: (+ - * /)  : ");
            operation=Console.ReadLine();

            double result = 0;

            switch (operation) 
            {
                case "+":
                    result = num1 + num2;
                    break;
                
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 !=0)
                    {
                        result = num1 / num2;


                    }
                    else
                    {
                        Console.WriteLine("yo, you made a mistake!");
                    }
                   break;

            }
            Console.Write("RESULT: " + result);
        }
        
    }
}