using System;

namespace CalculadoraPR0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Calculadora PR0");
            Console.WriteLine("Login do Usuário:");
            Console.Write("Digite seu nome: ");
            Console.ResetColor();
            string nome=Console.ReadLine();
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Sucesso " + nome + "\nEnter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine(nome + " Lista de operações básicas:\nAdição\nSubtração\nMultiplicação\nDivisão");
            Console.Write("\nEnter para continuar");
            Console.ReadKey();
            Console.Clear();

            
            string sair;
            do
            {
                
                Console.Write(nome + " Digite uma das operações da lista: ");
                string operação=Console.ReadLine().ToLower();
                
                if(operação=="adição")
                Program.CalcularAdição();          
                
                else if(operação=="subtração")
                Program.CalcularSubtração();
                
                else if(operação=="multiplicação")
                Program.CalcularMultiplicação();
                
                else if(operação=="divisão")
                Program.CalcularDivisão();
                
                else
                
                Console.WriteLine(nome + "  Operação Inválida");
                Console.Write("Deseja Sair? SIM ou NÃO: ");
                sair=Console.ReadLine().ToUpper();
                Console.Clear();

            
            } while (sair != "SIM" && sair != "S");

            Console.Write("Deseja ver os créditos do programa?: ");
            string resposta=Console.ReadLine().ToLower();

            if(resposta == "sim" || resposta == "s")
            Console.WriteLine("Olá " +nome+ " meu nome é Igor e eu sou o criador deste programa. Link para Mais atividades https://github.com/IgorPR0?tab=repositories");

            else
            Console.WriteLine("Continuar");
            Console.ReadKey();
            
            Console.Clear();
            Console.WriteLine("Obrigado! " + nome + " \nPressione enter para finalizar");
            Console.ReadKey();
            
        }

        static void CalcularAdição()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("Primeiro Numero: ");
            double soma1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo Numero: ");
            double soma2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{soma1} + {soma2} = " + (soma1+soma2));

        }

        static void CalcularSubtração()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("Primeiro Numero: ");
            double sub1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo Numero: ");
            double sub2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{sub1} - {sub2} = " + (sub1-sub2)); 
        }

        static void CalcularMultiplicação()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("Primeiro Numero: ");
            double mult1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo Numero: ");
            double mult2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{mult1} X {mult2} = " + (mult1*mult2));
        }

        static void CalcularDivisão()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("Primeiro Numero: ");
            double div1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo Numero: ");
            double div2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{div1} / {div2} = " + (div1/div2));
        
        }

    }

}