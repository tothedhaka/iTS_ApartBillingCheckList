namespace iTS_ApartBillingCheckList.Areas.InterfaceCollection
{
    //public interface IRepositoryBase<T> where T : class
    //{
    //    ICollection<T> FindAll();
    //    T FindById(int id);
    //    bool Create(T entity);
    //    bool Update(T entity);
    //    bool Delete(T entity);
    //    bool Save();

        
    //}


    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        //Task Save();
    }
}
