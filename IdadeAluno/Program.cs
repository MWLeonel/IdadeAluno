using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNascimento;
            DateTime aniversario;

            string dataNascLonga;
            string niverLonga;

            Console.WriteLine("Digite Sua Data de Nascimento");
            dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("\n");

            dataNascLonga = dataNascimento.ToLongDateString();
            Console.Write($"Você nasceu em: ");
            Console.WriteLine(dataNascLonga);

            aniversario = dataNascimento.AddYears(18);
            niverLonga = aniversario.ToLongDateString();
            Console.Write("Seu aniversario de 18 anos é em: ");
            Console.WriteLine(niverLonga);
            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
