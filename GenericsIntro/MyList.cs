using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor class ismiyle aynı
        //Classı newlersen otomatik çalışır.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray= items;
            //items referans numarasını tutuyor..
            items = new T[items.Length + 1];
            //items dizisinene ekleyecegimiz yeri ayıyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                //Tuttugu referans numarası ile bilgileri items dizisine aktarıyoruz
                items[i] = tempArray[i];
            }
            //Burada en son eklediğimiz elemanı ekliyoruz Add metoduyla.
            items[items.Length - 1] = item;
        }
    }
}
