using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Encapsulation_Prop_Get_Set.Models
{
    public class Encapsulation
    {

        public Encapsulation()
        {
            int test = number1;
            number1 = 10;
        }

        int _number;

        public int number1
        {


            get
            {
                return _number; // get özelliği burada bir değeri çağırmak için kullanılıyor.   
            }

            set
            {
                _number = value; // set özelliği ise atadığımız değeri değiştirmek için kullanılıyor.
            }

        }

    }
}
