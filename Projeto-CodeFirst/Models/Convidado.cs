namespace Projeto_CodeFirst.Models
{
    public class Convidado
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? presence { get; set; }

    }
}
