using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_emoji
{
    class Models
    {
    }
    public class Item
    {
        public string name { get; set; }
        public string art { get; set; }
    }

    public class Root
    {
        public string category { get; set; }
        public List<Item> items { get; set; }
    }


}
