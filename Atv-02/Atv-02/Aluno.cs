namespace Atv_02
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }

        public Aluno(int rm, string nome, DateTime nascimento, string email)
        {
            RM = rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

    }
}
