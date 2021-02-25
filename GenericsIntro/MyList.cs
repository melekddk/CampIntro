namespace GenericsIntro
{
    class MyList<T>
    {
        //class ın tüm elemanlarının ulaşabileceği bir dizi tanımlama işlemi yapıyoruz.
        T[] items;
        //Bu bloga contructor deniliyor.Aslında bir metottur.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            //Length = eleman sayısını verir.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {//tempArray e emaneten verdiğimiz elemanları tekrar kendi üstümüze geri alıyoruz.
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length //eleman sayısını verir.
        {
            get { return items.Length;  }
        }

        public T[] Items //eleman sayısını verir.
        {
            get { return items; }
        }

    }
}
