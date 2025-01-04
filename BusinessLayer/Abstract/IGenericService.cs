using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public void TAdd(T t);
        public void TUpdate(T t);
        public void TDelete(T t);
        public List<T> TGetAll(T t);
        public T TGetById(int id);
    }
}
