using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EKRLib
{
    class Collection <T> where T : Item
    {
        private List<T> items;

        public IEnumerator<T> CollectionEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Weight != 0)
                {
                    yield return items[i];
                }
            }
        }
    }
}
