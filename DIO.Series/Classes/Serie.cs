using System;
namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Disponivel {get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano){
            this.Genero=genero;
            this.Titulo=titulo;
            this.Descricao=descricao;
            this.Ano=ano;
            this.Id=id;
            this.Disponivel = true;
        }
        //Sobrecarga de método para retornar uma string ao invés do objeto
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Disponivel: " + (this.Disponivel ? "Sim" : "Não") + Environment.NewLine;
            return retorno;
        }
        public string retornaTitulo(){
            return this.Titulo;
        }
        public int retornaPorId(){
            return this.Id;
        }

        public void MarcarDisponibilidade(bool disponivel){
            this.Disponivel = disponivel;// melhor que =true porq da para alterar o estado do objeto para disponível novamente
        }
        public bool retornaDisponibilidade(){
            return this.Disponivel;
        }
    }
}