using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeställningsApp5.Models
{
   public sealed class VarukorgSingleton
    {
        private static readonly VarukorgSingleton instance = new VarukorgSingleton();

        private List<Product> items = new List<Product>();

        private VarukorgSingleton()
        {
        }

        public static VarukorgSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void AddItem(Product item)
        {
            items.Add(item);
        }

        public void RemoveItemm(Product item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
            }
        }
        public void ClearItems()
        {
            items.Clear();
        }
        public List<Product> GetItems()
        {
            return items;
        }
    }
}
