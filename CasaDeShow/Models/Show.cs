namespace CasaDeShow.Models
{
    public class Show
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int Capacidade {get; set;}
        public int Data {get; set;}
        public float Preco {get; set;}
        public string Genero {get; set;}
        public CasaDeShow CasaDeShow {get; set;}
        public bool Status {get; set;}

    }
}