using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,enum,boolean gibi tipler değer tiplerdir(value types).
            //int sayi1 = 10;//Değer tiplerde her şey stack'te referans tiplerde ise başlangıçta stack sonra heap'te gerçekleşir.
            //int sayi2 = 20;
            //sayi1 = sayi2;//Sayi1'in değeri sadece sayi2'nin değeridir. Bu da değer tipi ifade eder.
            //sayi2 = 100;
            //Console.WriteLine("Sayı 1 : "+sayi1);
            ////Array,class,interface'ler referans tiplerdir. Bundan dolayı Sayılar1[0] değeri 1000 olmuştur.
            //int[] sayilar1 = new int[] { 1, 2, 3 };//new 'lendiği zaman heapte veri oluşuyor ve bellekte tutuluyor.
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar1[0] ="+sayilar1[0]);
            //Person person1 = new Person();
            //Person person2 = new Person();
            //person1.FirstName = "Eser";
            //person2 = person1;//Referans tip olduğu için adres eşitlemesinden kaynaklı person2'nin de adı Elçim'dir.
            //person1.FirstName = "Elçim";
            //Console.WriteLine(person2.FirstName);
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";
            Person person3 = customer;//Customer bir Person olduğu için atama yapabildim.
            customer.FirstName = "Ahmet";
            Employee employee = new Employee();
            employee.FirstName = "Veli";
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);//Person yerine customer ve employee gönderebildim.Çünkü ebeveynleri Person'dır.
            personManager.Add(employee);
        }
    }
    class Person//Base Class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)//Customer ve Employee'nin Ana sınıfı Perosn olduğu için iki türlüde kullanabilir.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
