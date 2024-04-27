
namespace Infrastructure.DataAccess
{
    public interface IRepositoryBase
    {
        Task<List<T>> FromDataBase<T, U>(string dbSp, U parameters, string dbConnString);
        Task ToDataBase<T>(string dbSp, T parameters, string dbConnString);
    }
}