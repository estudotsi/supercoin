namespace Wiki.Models.Task
{
    public class Task
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Finalizada { get; set; }
    }
}
