namespace Domain.Entities
{
    public class Usuario
    {
        public int ID { get; set; }
        public string sNome { get; set; }
        public string sLogin { get; set; }
        public string sSenha { get; set; }
        public bool fAtivo { get; set; }
    }
}
