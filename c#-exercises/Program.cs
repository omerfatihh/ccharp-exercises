 int Hesapla (int siparişAdedi)
{
    int pizzaPrice = siparişAdedi *150;
    if (siparişAdedi >= 4)
    {
        pizzaPrice = (pizzaPrice* 90) / 100;
    }
        return pizzaPrice;
}
Console.Write(" Almak istediğiniz pizza adedini giriniz: ");
int adet =(int.Parse(Console.ReadLine()));
int ücret =Hesapla(adet);
Console.WriteLine($"Pizzanızın fiyatı: {ücret} TL"); 
Console.ReadKey();