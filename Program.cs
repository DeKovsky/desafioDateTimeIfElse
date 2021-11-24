using System;

namespace uc03Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            DateTime dataNascimento, dataAtual;
            dataAtual = DateTime.Now;

            Console.WriteLine("Olá. Seja bem vindo ao Desafio 01 da UC03 do curso de Técnico de Informática para Internet!");
             Console.WriteLine("Por gentileza, me informe o seu nome:");
             nome = Console.ReadLine();

            Console.WriteLine("Qual a data do seu nascimento dd/mm/aaaa?");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            idade = dataAtual.Year - dataNascimento.Year;

            Console.WriteLine(nome +  " você tem " + idade + " anos!");

            
            if (idade>=18){
                Console.WriteLine(nome + ", você já pode tirar sua carteira de motorista e tirar seu título de eleitor>!");
            }

            else if(idade >= 16 && idade<18)
            {
                Console.WriteLine(nome + ", você ainda não pode sua carteira de motorista, mas já pode tirar seu título de eleitor!");
            }
               
             else{
                Console.WriteLine(nome +", você não pode tirar a sua carteira de motorista ou título de eleitor. Não fique triste, pelo menos você tem o seu Cadastro de Pessoa Física (CPF)!");
            }
        }
    }
}
