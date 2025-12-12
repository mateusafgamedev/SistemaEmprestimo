using SistemaEmprestimosConsole.Models;

namespace SistemaEmprestimosConsole.Service
{
    internal class GerenciarUsuariosService
    {


        private int usuarioIdCounter = 1;

        private List<Usuario> usuarios = new List<Usuario>();

        public void AdcionarUsuarios()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            usuarios.Add(new Usuario { Id = usuarioIdCounter++, Name = nome, Email = email });
            Console.WriteLine("Usúario cadastrado com sucesso!!");
        }

        public void AtualizarUsuarios()
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
        public void ListarUsuarios()
        {
            Console.WriteLine("\nLista de Usúarios");

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"ID: {usuario.Id} | Título: {usuario.Name} | Autor: {usuario.Email} ");
            }
        }
        public void RemoverusUarios()
        {
            Console.Write("Informa o ID do usúario que será deletado: ");
            int id = Convert.ToInt32(Console.ReadLine());

            usuarios.RemoveAll(u => u.Id == id);
            Console.WriteLine("Usário deletado com sucesso!!");
        }
    }
}