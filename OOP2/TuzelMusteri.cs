using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate(Tüzel Müşteri)
    //miras(TuzelMusteri:Musteri)
    class TuzelMusteri :Musteri
    {
       
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }


    }
}
