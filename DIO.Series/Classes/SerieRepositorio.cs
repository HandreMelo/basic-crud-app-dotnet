using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        //private List<Serie> listaSerie = new List<Serie>();
        private Dictionary<int, Serie> listaSerie = new Dictionary<int, Serie>();
        public Dictionary<int, Serie> Lista(){
            return listaSerie;
        }
        public Serie buscaPorId(int Id){
            return listaSerie[Id];
        }
        public void Insere(Serie entidade){
            listaSerie.Add(entidade.Id,entidade);
        }
        public void Atualiza(int Id, Serie entidade){
            listaSerie[Id] = entidade;
        }
        public void Exclui(int Id){
            listaSerie[Id].MarcarDisponibilidade(false);
        }
        public int ProximoId()
		{
			return listaSerie.Count;
		}
    }
}