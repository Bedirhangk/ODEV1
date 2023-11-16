namespace ODEV1;

class Program
{
    static void Main(string[] args)
    {
        soru4();
    }

    static void soru1()
    {
        Console.Write("Kaç adet sayı girmek istiyorsunuz: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int [] arr = new int [x];
        for (int i = 0; i < x; i++)
        {
            Console.Write("Sayı girin: ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        foreach (var item in arr)
        {
            if(item % 2==0) Console.Write(item+", ");
        }
    }

    static void soru2()
    {
        Console.Write("Kaç adet sayı girmek istersiniz: ");
        int x=int.Parse(Console.ReadLine());
        
        Console.Write("Girilen sayılar kaça bölünsün: ");
        int b=int.Parse(Console.ReadLine());

        int [] arr = new int [x];

        for (int i = 0; i < x; i++)
        {
            Console.Write("Sayı Girin: ");
            arr[i]=int.Parse(Console.ReadLine());
        }

        foreach (var a in arr)
        {
            if(a%b==0)
            {
                Console.Write(a+", ");
            }
        }
    }

    static void soru3()
    {
        Console.Write("Kaç Adet Kelime Girmek istersiniz: ");
        int x = int.Parse(Console.ReadLine());
        List<string> arr=new List<string> ();
        for (int i = 0; i < x; i++)
        {
            Console.Write("Bir Kelime girin: ");
            arr.Add(Console.ReadLine());
        }
        arr.Reverse();
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    static void soru4()
    {
        Console.Write("Bir Cümle Girin: ");
        string? cümle= Console.ReadLine();
        int sayac=0;
        for (int i = 0; i < cümle.Length; i++)
        {
            if(cümle[i]== ' ' ) sayac++;
        }
        Console.WriteLine("cümlede {0} Tane kelime vardır.",sayac+1);
        Console.WriteLine("cümlede {0} Tane harf vardır.",cümle.Length-sayac);
    }    
}
