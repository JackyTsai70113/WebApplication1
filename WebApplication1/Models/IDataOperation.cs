using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IDataOperation<T> where T : class, new()
    {
        // 為了讓CRUD四個動作分給不同的class進行, 
        // 因此將CRUD四個動作定義成一個泛型接口 IDataOperation<T>
        IEnumerable<T> Get();
        void Create(T Item);
        void Update(T Item);
        void Delete(T Item);
    }
}
