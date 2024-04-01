using System.ComponentModel.DataAnnotations;

namespace AuthApi.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public byte[] SenhaHash { get; set; }
        public byte[] SenhaSalt { get; set; }
        public DateTime TokenDataCricao { get; set; } = DateTime.Now;

    }
}
