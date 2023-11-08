using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyonu
{
   public class Ebat
    {

        public string Adi { get; set; }
        public double Carpan { get; set; }

        public override string ToString()
        {
            return String.Format("{0}-{1}",Adi,Carpan); //Bu metodu bu şekilde ezersek combobox'a objeyi komple tanımlarız ancak metosu ezmeden de string olarak combobox'ta gösterebilirdik bu sefer ama ne olacaktı combobox'ta üstüne tıkladığımız şey komple gelmeyecekti sadece adı gelecekti.
        }
    }
}
