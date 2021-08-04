using System.Collections.Generic;

namespace DIO.series.ale.Interface
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnFromId(int id);
        void Add(T entity);
        void Exclude(int id);
        void Update(int id, T entity);
        int NextId();
        
    }
}
