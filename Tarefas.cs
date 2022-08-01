namespace Tarefas
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool Concluida { get; set; }

        public Tarefa() { }

        public Tarefa(string nome, string descricao, DateTime data, bool concluida)
        {
            Nome = nome;
            Descricao = descricao;
            Data = data;
            Concluida = concluida;
        }

        internal void Concluir()
        {
            Concluida = true;
        }

        internal void Desconcluir()
        {
            Concluida = false;
        }

        public override string ToString()
        {
            return $"{Nome} - {Descricao} - {Data} - {Concluida}";
        }
    }

    public class TarefaService
    {
        public List<Tarefa> Tarefas { get; set; }

        public TarefaService()
        {
            Tarefas = new List<Tarefa>();
        }

        public void Adicionar(Tarefa tarefa)
        {
            Tarefas.Add(tarefa);
        }

        public void Alterar(int index, Tarefa tarefa)
        {
            Tarefas[index] = tarefa;
        }

        public void Concluir(int index)
        {
            Tarefas[index].Concluir();
        }

        public void Desconcluir(int index)
        {
            Tarefas[index].Desconcluir();
        }

        public void Excluir(int index)
        {
            Tarefas.RemoveAt(index);
        }

        public void Listar()
        {
            foreach (var tarefa in Tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }
    }
}