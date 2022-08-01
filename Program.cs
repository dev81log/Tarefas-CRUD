namespace Tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var tarefaService = new TarefaService();

            tarefaService.Adicionar(new Tarefa("Tarefa 1", "Descrição da tarefa 1", DateTime.Now, false));
            tarefaService.Adicionar(new Tarefa("Tarefa 2", "Descrição da tarefa 2", DateTime.Now, false));
            tarefaService.Adicionar(new Tarefa("Tarefa 3", "Descrição da tarefa 3", DateTime.Now, false));

            Console.WriteLine("3 Tarefas criadas:");
            tarefaService.Listar();
            Console.WriteLine();

            Console.WriteLine("Tarefa 3 alterada");
            tarefaService.Alterar(2, new Tarefa("Tarefa 3", "Descrição da tarefa 3 alterada", DateTime.Now, false));
            tarefaService.Listar();
            Console.WriteLine();

            Console.WriteLine("Tarefa 2 excluida");
            tarefaService.Excluir(1);
            tarefaService.Listar();
            Console.WriteLine();

            Console.WriteLine("Tarefa 1 concluída");
            tarefaService.Concluir(0);
            tarefaService.Listar();
        }
    }
}