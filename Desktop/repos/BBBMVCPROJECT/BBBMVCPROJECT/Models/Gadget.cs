using System.Linq;
using System.Threading.Tasks;


namespace BBBMVCPROJECT.Models

{
    public class Gadget
    {
        public int GadgetID { get; set; }

        public string Name { get; set;}

        public double Price { get; set; }

        public int CategoryID { get; set; }

        public string OnSale { get; set; }

        public int StockLevel { get; set; }

        public IEnumerable<Category> Categories { get; set; }


    }
}
