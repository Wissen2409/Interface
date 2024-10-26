// ilk interface tanımı
public interface IAraba{

// intarfaceler içerisinde, metot yazılacak ise, metodun sadece imzası yazılır!!

// metot gövdesi olmaz !! : Metot gövdesi, bu interface'i kullanan yani şablon olarak alan sınıflar içerisinde yazılır
// her gövde birbirinden farklı olabilir!!!
// interface içerisinde metodun geri dönüş tipi aldığı parametreler vardır!!

// Erişim belirteç bile yoktur, çünkü belirteç bu interfacenin uygulanacağı sınıf içerisinde belirlenir!!!

  public void Calis();
  public  void Dur();
  public  void BakimYap();
}