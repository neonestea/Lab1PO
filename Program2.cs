using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Calculator
    {
        public Expression line;
        public double value = 0;
        public Calculator()
        {
            value = 0;
            line = new Expression();
        }
        public double Add(double a)
        {
            line.exp += " + " + a;
            this.value += a;
            return this.value ;
        }
        public double Extract(double a)
        {
            line.exp += " - " + a;
            this.value -= a;
            return this.value ;
        }
        public double Multiply(double a)
        {
            line.exp += " * " + a;
            this.value *= a;
            return this.value ;
        }
        public double Divide(double a)
        {
            if (a == 0) throw new DivideByZeroException();
            line.exp += " / " + a;
            this.value /= a;
            return this.value ;
        }
        public double MakeSqrt()
        {
            line.exp = "( " + line.exp + " ) ^ 1/2";
            this.value = Convert.ToDouble(Math.Round(Math.Sqrt(this.value),2));
            double num = Convert.ToDouble(Math.Sqrt(this.value));
            return num;
        }
        public double MakePow(int a)
        {
            line.exp = "( " + line.exp + " ) ^ " + a;
            this.value = Convert.ToDouble(Math.Pow(this.value, a));
            double num = Convert.ToDouble(Math.Pow(this.value, a));
            return num;
        }
        public double MakeSin()
        {
            line.exp = " sin( " + line.exp + " )";
            this.value = Math.sin(this.value);
            return this.value;
        }
        public double MakeCos()
        {
            line.exp = " cos( " + line.exp + " )";
            this.value = Math.cos(this.value);
            return this.value;
        }

        public void GetResult()
        {
            Console.WriteLine(value);
        }
        public void Delete()
        {
            this.value = 0;
            Console.WriteLine("Result: 0");
        }
    }
    public class Expression
    {
        public string exp;
        public Expression()
        {
            this.exp = "0";
        }
        public void GetExpression()
        {
            Console.WriteLine(exp);
        }
        public void Delete()
        {
            this.exp = "0";
        }
    }
    public class Appearance
    {
        public void GetValue()
        {
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("^");
            Console.WriteLine("sin");
            Console.WriteLine("cos");
            Console.WriteLine("Sqrt");
            Console.WriteLine("Get");
            Console.WriteLine("Cancel");
            Console.WriteLine("Exit");
            Console.WriteLine("----------");
            Console.WriteLine("Result: 0");
            Calculator calc = new Calculator();
            while (true)
            {
                string str;
                str = Console.ReadLine();
                switch (str)
                {
                    case "+": Console.WriteLine("Enter the value: ");
                        double val = Convert.ToDouble(Console.ReadLine());
                        calc.Add(val);
                        Console.Write("Result: ");
                        calc.GetResult();
                        break;
                    case "-":
                        Console.WriteLine("Enter the value: ");
                        val = Convert.ToDouble(Console.ReadLine());
                        calc.Extract(val);
                        Console.Write("Result: ");
                        calc.GetResult();
                        break;
                    case "*":
                        Console.WriteLine("Enter the value: ");
                        val = Convert.ToDouble(Console.ReadLine());
                        calc.Multiply(val);
                        Console.Write("Result: ");
                        calc.GetResult();
                        break;
                    case "/":
                        Console.WriteLine("Enter the value: ");
                        val = Convert.ToDouble(Console.ReadLine());
                        if (val == 0)
                        {
                            Console.WriteLine("Cannot divide by 0");
                        }
                        else
                        {
                            calc.Divide(val);
                            Console.Write("Result: ");
                            calc.GetResult();
                        }
                        break;
                    case "^":
                        Console.WriteLine("Enter the value: ");
                        int val2 = Convert.ToInt32(Console.ReadLine());
                        calc.MakePow(val2);
                        Console.Write("Result: ");
                        calc.GetResult();
                        break;
                    case "Sqrt":
                        calc.MakeSqrt();
                        Console.Write("Result: ");
                        calc.GetResult();
                        break;
                    case "sin":
                        calc.Makesin();
                        Console.Write("Result: ");
                        calc.GetResult();
                        break;
                    case "cos":
                        calc.MakeCos();
                        Console.Write("Result: ");
                        calc.GetResult();
                        break;
                    case "Get":
                        calc.line.GetExpression();
                        break;
                    case "Cancel":
                        calc.line.Delete();
                        calc.Delete();
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Unknown command");
                        break;
                }

            }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
            Appearance app = new Appearance();
            app.GetValue();
            for (int i = 0; i < 56; i++)
            {
                 
            }
            C:\Users\yanko\Documents\Учеба\ИТМО\Инструментальные средства разработки ПО\Lab1;
            



        }
        }
    }
    