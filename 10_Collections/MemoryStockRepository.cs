using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    public class MemoryStockRepository : IStockRepository
    {
        List<Stock> _stocks = new List<Stock>();
        long currentId = 0;
        public long NextId()
        {
            currentId++;
            return currentId;
        }

        public void SaveStock(Stock s)
        {
            s.Id = this.NextId();
            _stocks.Add(s);
        }

        public Stock LoadStock(long id)
        {
            Stock s = null;
            foreach (Stock st in _stocks) {
                if (st.Id == id) s = st;
            }
            return s;
        }

        public ICollection FindAllStocks()
        {
            return _stocks;
        }

        public void Clear()
        {
            _stocks.Clear();
        }
    }
}