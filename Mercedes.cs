public class Mercedes : IAraba
{
    public void BakimYap(int sure)
    {
        throw new NotImplementedException();
    }


    // aşağıdaki metotlar, interface implementasyonu sonrasında, sınıfa geldiler
    // interfaceden gelen metotların imzasında değişlik yapmamak gerekmektedir!!!

    public void BakimYap()
    {
        throw new NotImplementedException();
    }
    public void BenzinAl()
    {


    }

    public void Calis()
    {
        Console.WriteLine("Mercedes Çalıştı");
    }

    public void Dur()
    {
        throw new NotImplementedException();
    }
}