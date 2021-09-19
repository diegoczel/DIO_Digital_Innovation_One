using System;
using System.Collections.Generic;

namespace Revisao
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // ArrayList tem que fazer boxing e unboxing
            // List<T> não precisa
            var alunos = new List<Aluno>();
            string opcao;
            
            do
            {
                ShowMenu();
                opcao = Console.ReadLine();
                switch(opcao)
                {
                    case "0":
                        Console.WriteLine("Finalizando....\nAplicação finalizada com sucesso.");
                        AnyKey();
                        break;
                    case "1":
                        Console.WriteLine("Adicionar aluno.");

                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno  = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine($"Informe a nota do {aluno.Nome}");
                        decimal nota;
                        string notaPedir = Console.ReadLine();
                        while(true)
                        {
                            if (decimal.TryParse(notaPedir, out nota))
                            {
                                if (nota < (decimal)0.0 || nota > (decimal)10.0){
                                    Console.Write("Nota ");
                                    WriteColor(nota.ToString(), ConsoleColor.Red);
                                    Console.Write(" fora do range. Nota deve ser >= ");
                                    WriteColor("0.0", ConsoleColor.Green);
                                    Console.Write(" e <= ");
                                    WriteColor("10.0", ConsoleColor.Green);
                                    Console.WriteLine();
                                }
                                else 
                                { 
                                    aluno.Nota = nota; 
                                    break;
                                }

                            }
                            else
                            {
                                Console.Write("A nota ");
                                WriteColor(notaPedir, ConsoleColor.Red);
                                Console.WriteLine(" esta incorreta, pois não é um número");
                            }
                            Console.WriteLine($"Informe a nota do {aluno.Nome}");
                            notaPedir = Console.ReadLine();
                        }
                        Console.Write("Aluno ");
                        WriteColor(aluno.Nome, ConsoleColor.Green);
                        Console.Write(" com média ");
                        WriteColor(aluno.Nota.ToString(), ConsoleColor.Green);
                        Console.WriteLine(" adicionado com sucesso!");
                        alunos.Add(aluno);
                        AnyKey();

                        break;
                    case "2":
                        Console.WriteLine("Listar alunos.");
                        if(alunos.Count == 0)
                        {
                            Console.WriteLine("NÃO existe alunos cadastrados.");
                        }
                        else
                        {
                            for (int i = 0; i < alunos.Count; i++)
                            {
                                
                                //Console.WriteLine($"Aluno(a) {alunos[i].Nome} | Nota {alunos[i].Nota}");
                                Console.Write("Aluno(a) ");
                                WriteColor(alunos[i].Nome, ConsoleColor.Green);
                                Console.Write(" | Nota ");
                                WriteColor(alunos[i].Nota.ToString(), ConsoleColor.Green);
                                Console.WriteLine();
                            }
                        }

                        AnyKey();
                        break;
                    case "3":
                        Console.WriteLine("Calcular média.");
                        decimal media = 0.0M;
                        if(alunos.Count == 0)
                        {
                            Console.WriteLine("NÃO existe alunos cadastrados.");
                        }
                        else
                        {
                            for (int i = 0; i < alunos.Count; i++)
                            {
                                
                                media += alunos[i].Nota;
                            }
                            media = media / alunos.Count;

                            // calcular conceito
                            Conceito conceito;
                            if (media < 2) { conceito = Conceito.E; }
                            else if (media < 4) { conceito = Conceito.D; }
                            else if (media < 6) { conceito = Conceito.C; }
                            else if (media < 8) { conceito = Conceito.B; }
                            else { conceito = Conceito.A; }
                            //Console.WriteLine($"Média é {media} com Conceito {conceito}");
                            Console.Write("Média é ");
                            WriteColor(media.ToString(), ConsoleColor.Green);
                            Console.Write(" com Conceito ");
                            WriteColor(conceito.ToString(), ConsoleColor.Green);
                            Console.WriteLine();
                        }

                        

                        AnyKey();
                        break;
                    default:
                        WriteColor(opcao, ConsoleColor.Red);
                        Console.WriteLine(" é uma escolha inválida!");
                        Console.WriteLine("Por favor, informe uma opção correta.");
                        AnyKey();
                        break;
                }
                Console.Clear();
            } while (opcao != "0");
        }
        private static void ShowMenu()
        {
            Console.WriteLine("Informe a opção desejada:");
            
            WriteColor("1", ConsoleColor.Green);
            Console.WriteLine(" - Inserir novo aluno.");

            WriteColor("2", ConsoleColor.Green);
            Console.WriteLine(" - Listar alunos.");

            WriteColor("3", ConsoleColor.Green);
            Console.WriteLine(" - Calcular média geral.");

            WriteColor("0", ConsoleColor.Green);
            Console.WriteLine(" - Sair");
            Console.WriteLine("");
        }
        private static void AnyKey()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
        }
        private static void WriteColor(string txt, ConsoleColor color)
        {
            // backup of text color
            ConsoleColor defaultFC = Console.ForegroundColor;

            // change text color
            Console.ForegroundColor = color;

            Console.Write(txt);

            // restore text color default
            Console.ForegroundColor = defaultFC;
        }
    }
}
