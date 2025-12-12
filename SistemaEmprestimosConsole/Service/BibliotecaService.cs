using SistemaEmprestimosConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimosConsole.Service
{
    class BibliotecaService
    {

        private List<Livro> livros = new List<Livro>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        private int livroIdCounter = 1;
        private int usuarioIdCounter = 1;
        private int emprestimoIdCounter = 1;

        public void MenuPrincipal()
        {
            while (true)
            {
                Console.WriteLine("\n ========== MENU BIBLIOTECA ==========");
                Console.WriteLine("1. Gerenciar Livros");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("3. Gerenciar Empréstimos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha a opção desejada: ");

                string opcao = Console.ReadLine();

                switch (opcao) 
                {

                    case "1": MenuLivros(); break;
                    case "2": MenuUsuarios(); break;
                    case "3": MenuEmprestimos(); break;
                    case "0": return;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }
        }

        private void MenuLivros()
        {
            while (true)
            {
                Console.WriteLine("\n ========== MENU LIVROS ==========");
                Console.WriteLine("1. Adcionar Livros");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Atualizar Livros");
                Console.WriteLine("4. Remover Livros");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha a opção desejada: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1": AdcionarLivros(); break;
                    case "2": ListarLivros(); break;
                    //case "3": atualizarlivros(); break;
                    //case "4": removerlivros(); break;
                    //case "0": return;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }
        }

        private void MenuUsuarios()
        {
            while (true)
            {
                Console.WriteLine("\n ========== MENU USUÁRIOS ==========");
                Console.WriteLine("1. Adcionar Usuários");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Atualizar Usuários");
                Console.WriteLine("4. Remover Usuários");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha a opção desejada: ");

                string opcao = Console.ReadLine();

                //switch (opcao)
                //{

                //    case "1": AdcionarUsuarios(); break;
                //    case "2": ListarUsuarios(); break;
                //    case "3": AtualizarUsuarios(); break;
                //    case "4": RemoverUsuarios(); break;
                //    case "0": return;
                //    default: Console.WriteLine("Opção inválida!"); break;
                //}
            }
        }

        private void MenuEmprestimos()
        {
            while (true)
            {
                Console.WriteLine("\n ========== MENU EMPRESTIMOS ==========");
                Console.WriteLine("1. Adcionar Emprestios");
                Console.WriteLine("2. Listar Emprestios");
                Console.WriteLine("3. Atualizar Emprestios");
                Console.WriteLine("4. Remover Emprestios");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha a opção desejada: ");

                string opcao = Console.ReadLine();

                //switch (opcao)
                //{

                //    case "1": AdcionarEmprestios(); break;
                //    case "2": ListarEmprestiosAtivos(); break;
                //    case "3": DevolverLivros(); break;
                //    case "4": HistoricoEmprestios(); break;
                //    case "0": return;
                //    default: Console.WriteLine("Opção inválida!"); break;
                //}
            }
        }

        private void AdcionarLivros()
        {
            Console.WriteLine("Título: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            livros.Add(new Livro { Id = livroIdCounter++, Titulo = titulo, Autor = autor, Disponivel = true });
            Console.WriteLine("Livro adicionado com sucesso!!");
        }

        private void ListarLivros()
        {
            Console.WriteLine("\nLista de Livros");

            foreach (Livro livro in livros)
            {
                string status = livro.Disponivel ? "Dísponivel" : "Emprestado";
                Console.WriteLine($"ID: {livro.Id} | Título: {livro.Titulo} | Autor: {livro.Disponivel} | {status} ");
            }
        }
    }
}
