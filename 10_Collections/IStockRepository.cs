using System.Collections;

namespace _10_Collections
{
    public interface IStockRepository
    {
        long NextId();
        void SaveStock(Stock stock);
        Stock LoadStock(long id);
        ICollection FindAllStocks();
        void Clear();
    }
}