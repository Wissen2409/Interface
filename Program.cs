//  Interface , yapısı itibariyle, kalıtım gibi görünse de, aslında  miras alıp verme durumu yada sınıfların
// kendi içlerinde hiyerarşisi yoktur!!!


// Interface : Yazılacak olan sınıflara yön göstermek ve yazılacak olan sınıfların şablonu olmak için vardır!!!
// Interface yazılırken kesinlikle ön eki I olmak zorundadır
// Örnek : IAraba, IOgrenci vb.


// bir interface pointeri kendisi implement etmiş tüm sınıfları işaret edebilir!!

using System.Reflection.Metadata;
IAraba araba = new Mercedes();

Calis(new Mercedes());
Calis(new Audi());
Calis(new Peugeot());
// Interface : 



static void Calis(IAraba araba){
    
    araba.Calis();
}