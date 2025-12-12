using SistemaEmprestimosConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimosConsole.Service
{
    class GerenciarLivrosService
    {
        private List<Livro> livros = new List<Livro>();

        private int livroIdCounter = 1;

        public void AdcionarLivros()
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            livros.Add(new Livro { Id = livroIdCounter++, Titulo = titulo, Autor = autor, Disponivel = true });
            Console.WriteLine("Livro adicionado com sucesso!!");
        }

        public void ListarLivros()
        {
            Console.WriteLine("\nLista de Livros");

            foreach (Livro livro in livros)
            {
                string status = livro.Disponivel ? "Dísponivel" : "Emprestado";
                Console.WriteLine($"ID: {livro.Id} | Título: {livro.Titulo} | Autor: {livro.Autor} | {status} ");
            }
        }

        public void Atualizarlivros()
        {
            Console.Write("Informe o ID do livro que será atualizado: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var livro = livros.FirstOrDefault(l => l.Id == id);

            if (livro != null)
            {
                Console.Write("Novo Título: ");
                livro.Titulo = Console.ReadLine();
                Console.Write("Novo Autor: ");
                livro.Autor = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Livro não localizado!");
            }
        }

        public void Removerlivros()
        {
            Console.Write("Informe o ID do livro que será deletado: ");
            int id = Convert.ToInt32(Console.ReadLine());

            livros.RemoveAll(l => l.Id == id);
            Console.WriteLine("Livro deletado!");
        }
    }
}
