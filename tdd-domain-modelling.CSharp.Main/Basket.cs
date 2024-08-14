using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> _items = new Dictionary<string, int>();

        public bool add(string item, int value)
        {
            if (!_items.ContainsKey(item))
            {
                _items.Add(item, value);
                return true;
            }
            return false;
        }

        public int total()
        {
            int sum = 0;
            foreach (var item in _items.Keys) { sum += _items[item]; }
            return sum;
        }
    }
}
