class Program
{
    static void Main(string[] args)
    {
        //Sort
        int[] sayiDizisi = {23,12,4,86,72,3,11,17};
        
        Console.WriteLine("***Sırasız***");
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("***Sıralı***");
        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Clear
        Console.WriteLine("***Array Clear***");
        Array.Clear(sayiDizisi,2,2);                //sayıdizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı sıfırlar
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Reverse
        Console.WriteLine("***Array REVERSE***");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //IndexOf
        Console.WriteLine("***Array INDEXOF***");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        //Resize
        Console.WriteLine("***Array RESIZE***");
        Array.Resize<int>(ref sayiDizisi,9);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
    }
}