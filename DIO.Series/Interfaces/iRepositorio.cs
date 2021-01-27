using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface iRepositorio<T>
    {
        //Troquei o List<T> por chave valor, assim, não é preciso se preocupar com a sequência na lista.
         Dictionary<int, T> Lista();
         T buscaPorId(int Id);
         void Insere(T entidade);
         void Atualiza(int Id, T entidade);
         void Exclui(int Id);
    }
}