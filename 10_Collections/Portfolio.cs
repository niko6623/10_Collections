using System;
using System.Collections.Generic;

namespace _10_Collections
{
    public class Portfolio
    {
        public List<IAsset> _assets
        {
            set;
            get;
        }
        public Portfolio()
        {
            _assets = new List<IAsset>();

        }
        public Portfolio(List<IAsset> something)
        {
            _assets = something;
        }
        public double GetTotalValue()
        {
            double totalvalue = 0;
            foreach (IAsset a in _assets)
            {
                totalvalue += a.GetValue();
            }

            return totalvalue;
        }
        public void AddAsset(IAsset a)
        {
            _assets.Add(a);
        }

        public IList<IAsset> GetAssets()
        {
            
            return _assets.AsReadOnly();
        }

        public Stock GetAssetByName(string name)
        {
            Stock s = null;
            foreach (IAsset a in _assets)
            {
                if (a.Name == name) s = (Stock)a;
            }
            return s;
        }

        public IList<IAsset> GetAssetsSortedByName()
        {
            _assets.Sort(new StockNameComparator());
            return _assets;
        }

        public IList<IAsset> GetAssetsSortedByValue()
        {
            _assets.Sort(new StockValueComparator());
            return _assets;
        }
    }
}