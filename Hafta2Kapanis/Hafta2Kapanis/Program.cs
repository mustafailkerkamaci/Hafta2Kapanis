////////1 - Aşağıdaki çıktıyı yazan bir program.

////////Merhaba
////////Nasılsın ?
////////İyiyim
////////Sen nasılsın ?

//////Console.WriteLine("Merhaba");
//////Console.WriteLine("Nasilsin?");
//////Console.WriteLine("iyiyim");
//////Console.WriteLine("Sen nasilsin?");

////////2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
//////string metinselDeger = "metinsel deger";
//////int tamSayiDeger = 10;
//////Console.WriteLine(metinselDeger);
//////Console.WriteLine(tamSayiDeger);

////////3 - Rastgele bir sayı üretip , ekrana yazdırınız.
//////Random random = new Random();
//////int randomNumber = random.Next(1, 100);
//////Console.WriteLine( randomNumber);


////////4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

//////Console.WriteLine(randomNumber %3);


////////5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
//////Console.WriteLine("Yasini gir.");
//////int age = Convert.ToInt32(Console.ReadLine());
//////if (age > 18)
//////{
//////    Console.WriteLine("+");
//////}
//////else
//////{
//////    Console.WriteLine("-");
//////}
////////6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
//////for (int i = 0; i < 10; i++)
//////{
//////    Console.WriteLine("Sen vodafone gibi ani yasarken , ben Turkcell gibi seni her yerde cekemem.");
//////}


////////7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
//////Console.WriteLine("ilk ismi giriniz(Gurse birsel)");
//////string ilkDeger = Console.ReadLine();
//////Console.WriteLine("Ikinci ismi giriniz(Demet Evgar)");
//////string ikinciDeger = Console.ReadLine();

//////string yedek = ilkDeger;

//////ilkDeger = ikinciDeger;
//////ikinciDeger = yedek;
//////Console.WriteLine("ilk deger: " + ilkDeger);
//////Console.WriteLine("ikinci deger: " + ikinciDeger);

////////8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
//////void BenDegerDondurmem()
//////{
//////    Console.WriteLine("Ben deger dondurmuyorum, benim bir karsiligim yok, beni degiskene atamaya calisma");
//////}
//////BenDegerDondurmem();

////////9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
////// int Topla(int number1, int number2)
//////{
//////    int sum = number1 + number2;
//////    return sum;

//////}
//////Console.WriteLine(Topla(5, 10));

//////10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
//////string BoolDoner(bool girdi)
//////{

//////    return girdi ? "true" : "false";

//////}
//////Console.WriteLine("Evet yada Hayir yaz.");
//////string girdi = Console.ReadLine();
//////if (girdi == "Evet")
//////{
//////    Console.WriteLine(BoolDoner(true));
//////}
//////else if (girdi == "Hayir")
//////{
//////    Console.WriteLine(BoolDoner(false));
//////}
//////else
//////{
//////    Console.WriteLine("Yanlis deger girdiniz.");
//////}
////// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

////// ilk veriyi en buyuk kabul et yeni gelenlri en ile kiyasla.
//////int EnYasli(int yas1, int yas2, int yas3)
//////{ 
//////   int enBuyukYas= yas1;
//////    if (yas2 > enBuyukYas)
//////    {
//////        enBuyukYas = yas2;
//////    }                              // else if yapmamamizin geregi if dogruysa elseye bakmaz ama biz bakmasini istiyoruz
//////    if (yas3 > enBuyukYas)
//////    {
//////        enBuyukYas = yas3;
//////    }
//////    return enBuyukYas;
//////}

//////EnYasli(20, 30, 40);
//////12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
////void MaxDeger()
////{

////    Console.WriteLine("Bir sayi gir");
////    int sayi = Convert.ToInt32(Console.ReadLine());

////    int max = sayi;
////    while (true)
////    {
////        Console.WriteLine("Max sayi -->" + max);

////        Console.WriteLine("Bir sayi gir");
////        sayi = Convert.ToInt32(Console.ReadLine());

////        if (sayi > max)
////        {
////            max = sayi;
////        }


////    }

////    Console.WriteLine(MaxDeger);
////}


//////13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

//void YerDegistir(ref string isim1, ref string isim2)
//{
//    string yedek = isim1;
//    isim1 = isim2;
//    isim2 = yedek;
//}

//Console.WriteLine("Birinci ismi gir");
//string x = Console.ReadLine();
//Console.WriteLine("Ikinci ismi gir");
//string y = Console.ReadLine();

//Console.WriteLine("Birinci isim -->" + x);
//Console.WriteLine("Ikinci isim -- >" + y) ;

//YerDegistir(ref x, ref y);              // ref gonderilen degisken ve parametre ayni koke baglanr.
//Console.WriteLine("Birinci isim -->" + x);
//Console.WriteLine("Ikinci isim -- >" + y ) ;

//////14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.



//////15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

//double YolHesapla(double hiz, double zaman)
//{
//    double yol = hiz * zaman;
//    return yol;
//}
//Console.WriteLine("50 km hizla 3 saaat yol giden bir aracin aldigi yolo ---> " + YolHesapla(50,3));
//////16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

double DaireAlanHesapla(double yaricap)
{
    double alan = Math.PI * Math.Pow(yaricap, 2);
    return alan;
}


//////17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string cumle = "Zaman bir GeRi SayIm";
Console.WriteLine(cumle.ToUpper());
Console.WriteLine(cumle.ToLower());
Console.WriteLine(cumle);
 //kalaici degisiklik yapmak icin
cumle= cumle.ToUpper();
cumle = cumle.ToLower();

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string metin = "    Selamlar   ";
Console.WriteLine(metin.Trim());
