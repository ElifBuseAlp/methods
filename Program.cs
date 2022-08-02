// ----------------methodlar--------------------


int a = 3;
int b = 2;

Console.WriteLine(a+b);

int sonuc = Topla(a,b); //method ile topladım
Console.WriteLine(sonuc);


methodlar ornek = new methodlar();
ornek.EkranaYazdir( Convert.ToString(sonuc) + " classlı");


methodlar ornek2 = new methodlar();
int sonuc2 = ornek2.ArtirveTopla(ref a,ref b);
ornek2.EkranaYazdir(Convert.ToString(sonuc2));



static int Topla (int deger1, int deger2)
{
    return deger1+deger2;
}


Console.ReadLine();

class methodlar ////yeni class oluşturdum
{
    public void EkranaYazdir(string veri)
    {
            Console.WriteLine(veri);

    }

    public int ArtirveTopla (ref int deger1,ref int deger2)
    {
        deger1 += 1;
        deger2 +=1;
        return deger1+deger2;        
    }
}


