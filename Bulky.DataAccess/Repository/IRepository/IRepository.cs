using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    //when we are working with IRepository generics we dont know the class type so we can define with T.
    public interface IRepository<T> where T : class 
    {
        //Define the methods here what we can implement inside Repository class
        //Need to retrieve all the catagories from the table
        IEnumerable<T> GetAll();
        //Retrieve single id from the catagories table
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        //Update not using here because while we are updating everytime we are saving the data that many times in this case updating and save the data code will be different because we are using generic type class T.
        //void Update(T entity);
        void Remove(T entity);
        //Delete multiple entities in single column
        void RemoveRange(IEnumerable<T> entity);
    }
}
