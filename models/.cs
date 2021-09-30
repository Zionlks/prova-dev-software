namespace API.models
{
    public class livro
    {
        public livro() => CriadoEm = dateTime.now;

        public string Livro {get; set; }
        public string aluno {get; set; }
    
          
        public dateTime CriadoEm {get; set;}

        public override string tostring() =>
            $"livro: {livro} | aluno: {aluno} | criado em: {CriadoEm}";
    }










}