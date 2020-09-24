using System;
namespace Claculator
{
    class Program
    {
        static bool validate_option(string op){
            if (op == "1" || op == "2" || op =="3" || op =="4" || op== "5" || op=="y" || op=="n" ||
                op == "+" || op == "-" || op =="*" || op =="/" || op== "%"){
                return true;
            }
            return false;
        }

        static int getResult(string op, Calculate calculator){
            int result =0;
             switch (op)
                {
                    case "1":
                    case "+":
                        result = calculator.add();
                        break;
                    case "2":
                    case "-":
                        result = calculator.substrac();
                        break;
                    case "3":
                    case "*":
                        result = calculator.multiply();
                        break;
                    case "4":
                    case "/":
                        result = calculator.divide();
                        break;
                    case "5":
                    case "%":
                        result = calculator.residue();
                        break;
                    default:
                        Console.Write( "Error de operador");
                        break;
                }
            return result;
        }

        static void play(string operator1, int result, Calculate calculator){
            if (result == 0){
                Console.WriteLine("Enter a numbers: ");
                Console.Write("First number :");
                calculator.numero = int.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                calculator.numero2 = int.Parse(Console.ReadLine());
            }
            else {
                Console.WriteLine("******************");
                Console.WriteLine("Enter number: ");
                calculator.numero2 = int.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();
            int result = 0;
            string operator1;
            do
            {
                Console.Write("Choose an operator: ");
                Console.WriteLine("\n1. +\n2. - \n3. * \n4. / \n5. %");
                operator1 = Console.ReadLine();
                if (validate_option(operator1)){
                    play(operator1, result, calculator);
                    result = getResult(operator1,calculator);
                    Console.WriteLine("Result: {0}", result);
                }
                else{
                    Console.WriteLine("Invalid operator1");
                }
                Console.Write("Do you want to continue? y/n: ");
                operator1 = Console.ReadLine();
                calculator.numero= result;
            } while (operator1 == "y");
        }
    }
}


// Comentarios contraproducentes
// Clase perezosa
// Identiicadores excesivamente cortos
// SOLID S = single
//       O = open
// Nombre incorrecto de las clases
