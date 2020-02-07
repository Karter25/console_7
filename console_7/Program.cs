using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_7
{
    public class Children
    {
        string name = "noname";
        string age = "unage";
       
    }
    public class tiles
    {
        public string brand = "мировые";
        public string size_h = "180";
        public string size_w = "190";
        public string price = "1111111";
        public tiles()
        {

        }

        
        public void getData()
        {
            Console.WriteLine($"брэнд:{brand}, размер по высоте:{size_h} , размер по ширине:{size_w} ,цена: {price}");
        }

    }

    public class animal
    {
        public string type = "млекопитающие";
        public string breed = "сиамская";
        public string color = "orange";
        public int agression = 30;


        public animal()
        {

        }

        public animal(string type, string breed)
        {
            this.type = type;
            this.breed = breed;
        }


        // public class Tiles
        // {
        //   public string brand = "мировые";
        //  public string size_h = "180";
        //  public string size_w = "190";
        //  public string price = "1111111";
        //  }


        //   public void  tiles(string brand, string price)
        // {

        // }
        //}
    }

    class Program
    {


        static void Main(string[] args)
        {

            tiles odezhda = new tiles();
            odezhda.getData();

            Console.ReadKey();
        }
    }
}
    

