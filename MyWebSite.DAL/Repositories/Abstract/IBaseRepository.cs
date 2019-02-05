using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DAL.Repositories
{
    public interface IBaseRepository<T> where T : class //Referance type constraint
    {
        int AddItem(T item);
        int DeleteItem(T item);
        int UpdateItem(T item);
        T GetItem(Expression<Func<T,bool>> Lambda = null);
        ICollection<T> GetAllItem(Expression<Func<T, bool>> Lambda = null);        


    }
}
