int adet, fiyat;
Console.Write("Almak istediğiniz ürün adedini giriniz:");
adet = Convert.ToInt32(Console.ReadLine());
Console.Write("Birim fiyatını giriniz:");
fiyat = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Toplam ödemeniz: " + adet * fiyat + " TL'dir");
Console.ReadKey();