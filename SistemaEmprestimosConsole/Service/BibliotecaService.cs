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
                    case "3": Atualizarlivros(); break;
                    case "4": Removerlivros(); break;
                    case "0": return;
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

                switch (opcao)
                {

                    case "1": AdcionarUsuarios(); break;
                    case "2": ListarUsuarios(); break;
                    case "3": AtualizarUsuarios(); break;
                    case "4": RemoverusUarios(); break;
                    case "0": return;
                    default: Console.WriteLine("opção inválida!"); break;
                }
            }
        }

        private void MenuEmprestimos()
        {
            while (true)
            {
                Console.WriteLine("\n ========== MENU EMPRESTIMOS ==========");
                Console.WriteLine("1. Adcionar Emprestimos");
                Console.WriteLine("2. Listar Emprestimos Ativos");
                Console.WriteLine("3. Devolver Livros");
                Console.WriteLine("4. Historico de Emprestimos");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha a opção desejada: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1": AdcionarEmprestimos(); break;
                    case "2": ListarEmprestiosAtivos(); break;
                    case "3": DevolverLivros(); break;
                    case "4": HistoricoEmprestios(); break;
                    case "0": return;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }
        }
        private void AdcionarLivros()
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
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
                Console.WriteLine($"ID: {livro.Id} | Título: {livro.Titulo} | Autor: {livro.Autor} | {status} ");
            }
        }
        private void Atualizarlivros()
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
        private void Removerlivros()
        {
            Console.Write("Informe o ID do livro que será deletado: ");
            int id = Convert.ToInt32(Console.ReadLine());

            livros.RemoveAll(l => l.Id == id);
            Console.WriteLine("Livro deletado!");
        }
        //--------------------------------------------------------------------------------------------------------
        private void AdcionarUsuarios()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            usuarios.Add(new Usuario { Id = usuarioIdCounter++, Name = nome, Email = email });
            Console.WriteLine("Usúario cadastrado com sucesso!!");
        }
        private void AtualizarUsuarios()
        {
            Console.Write("Informa o ID do usúario que será atualizado: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var usuario = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario != null)
            {
                Console.Write("Novo Nome: ");
                usuario.Name = Console.ReadLine();
                Console.Write("Novo Email: ");
                usuario.Email = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Usúario não localizado!");
            }
        }
        private void ListarUsuarios()
        {
            Console.WriteLine("\nLista de Usúarios");

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"ID: {usuario.Id} | Título: {usuario.Name} | Autor: {usuario.Email} ");
            }
        }
        private void RemoverusUarios()
        {
            Console.Write("Informa o ID do usúario que será deletado: ");
            int id = Convert.ToInt32(Console.ReadLine());

            usuarios.RemoveAll(u => u.Id == id);
            Console.WriteLine("Usário deletado com sucesso!!");
        }
        //--------------------------------------------------------------------------------------------------------
        private void AdcionarEmprestimos()
        {
            Console.Write("Informe o ID do livro: ");
            int livroId = Convert.ToInt32(Console.ReadLine());

            Livro livro = livros.FirstOrDefault(l => l.Id == livroId && l.Disponivel);

            if (livro == null)
            {
                Console.WriteLine("");
                return;
            }

            Console.Write("Informe o ID do Usúario: ");
            int usuarioId = Convert.ToInt32(Console.ReadLine());
            if (!usuarios.Any(u => u.Id == livroId))
            {
                Console.WriteLine("");
                return;
            }

            emprestimos.Add(new Emprestimo { Id = emprestimoIdCounter++, IdLivro = livroId, IdUsuario = usuarioId });

            livro.Disponivel = false;

            Console.WriteLine("");
        }

        private void ListarEmprestiosAtivos()
        {
            List<Emprestimo> ativos = emprestimos.Where(e => e.DataDevolucao == null).ToList();

            foreach (Emprestimo e in ativos) { 
                Livro livro = livros.FirstOrDefault(l => l.Id == e.Id);
                Usuario usuario = usuarios.FirstOrDefault(u  => u.Id == e.Id);

                Console.WriteLine($"ID: {e.Id} | Livro: {livro.Titulo} | Usúario: {usuario.Name} | Data do Emprestimo: {e.DataEmprestimo.ToShortDateString()}");
            }
        }

        private void DevolverLivros()
        {
            Console.Write("Informe o ID do emprestimo: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Emprestimo emprestimo = emprestimos.FirstOrDefault(e => e.Id == id && e.DataDevolucao == null);

            if (emprestimo == null) {
                Console.WriteLine("Emprestimo não encontrado ou livro já devolvido!");
                return;
            }

            emprestimo.DataDevolucao = DateTime.Now;

            Livro livro = livros.FirstOrDefault(l => l.Id == emprestimo.IdLivro);
            livro.Disponivel = true;

            Console.WriteLine("Livro devolvido com sucesso!!");
        }

        private void HistoricoEmprestios()
        {
            Console.Write("Informe o ID do usúario: ");
            int usuarioId = Convert.ToInt32(Console.ReadLine());

            List<Emprestimo> historico = emprestimos.Where(e => e.IdUsuario == usuarioId).ToList();

            foreach (Emprestimo emprestimo in historico)
            {
                Livro livro = livros.FirstOrDefault(l => l.Id == emprestimo.IdLivro);

                string devolucao = emprestimo.DataDevolucao.HasValue ? emprestimo.DataDevolucao?.ToShortDateString() : "Em aberto!" ;

                Console.WriteLine($"Livro: {livro.Titulo} | Emprestimo: {emprestimo.DataEmprestimo.ToShortDateString()} | Devolução: {devolucao}");
            }
        }
    }
}
