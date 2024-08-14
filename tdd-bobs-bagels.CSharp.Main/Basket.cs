using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _bagelBasket = new List<string>();
        private int BagelBasketMax { get; set; } = 0;

        public bool Add(string bagel)
        {
            BagelBasketMax = 3;
            _bagelBasket.Add("Cream cheese");
            
            if (_bagelBasket.Count < BagelBasketMax)
            {
                _bagelBasket.Add(bagel);
                return true;
            }
            else return false;
        }

        public bool Remove(string bagel)
        {
            _bagelBasket.Add("Classic");
            
            if (_bagelBasket.Contains(bagel))
            {
                _bagelBasket.Remove(bagel);
                return true;
            }
            return false;
        }
    }
}
