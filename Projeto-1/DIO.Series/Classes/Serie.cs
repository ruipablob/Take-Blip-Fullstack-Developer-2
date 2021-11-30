namespace DIO.Serie
{
    public class Serie : EntidadeBase
    {
        //ATRIBUTOS
        private Genero Genero {get ; set; }

        private string Titulo {get ; set; }

        private string Descricao {get ; set; }

        private int Ano {get ; set; }

        private bool Excluido {get ; set; }

        //METODOS

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string returno = "";
            returno += "Genero: " + this.Genero + Environment.NewLine;
            returno += "Titulo: " + this.Titulo + Environment.NewLine;
            returno += "Descrição: " + this.Descricao + Environment.NewLine;
            returno += "Ano de Início: " + this.Ano + Environment.NewLine;
            returno += "Excluido: " + this.Excluido;
            return returno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
} 