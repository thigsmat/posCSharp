using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWpThiagoDaMatta.Dao
{
    interface IDao<T>
    {
        bool Inserir(T t);
        bool Alterar(T t);
        bool Excluir(int id);
        ObservableCollection<T> ListaTodos();
        T BuscaPorId(int id);
    }
}
