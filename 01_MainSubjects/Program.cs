using System;
using System.ComponentModel;

namespace _01_MainSubjects
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Yazdırma Komutları
			//Console.WriteLine("*************** Yemek Kategorileri ***************");
			//Console.WriteLine();
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Ana Yemekler");
			//Console.WriteLine("3-Soğuk Başlangıçlar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("6-İçecekler");
			//Console.WriteLine();
			//Console.WriteLine("*************** Yemek Kategorileri ***************");

			#endregion

			#region String Değişkenler
			//string
			//değişken_türü değişken_adı;

			//string name;
			//name = "Özge";
			//Console.Write(name);

			//string customerName;//camelcase
			//string customerSurname;
			//string customerPhone;
			//string customerEmail, district, city;

			//customerName = "Özge";
			//customerSurname = "Kuzucu";
			//customerPhone = "+90 500 600 60 60";
			//customerEmail = "deneme@hotmail.com";
			//district = "Merkez";
			//city = "Karaman";

			//Console.WriteLine("************** Rezervasyon Kartı **************");
			//Console.WriteLine();
			//Console.WriteLine("------------------------------------------------");
			//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("Email Adresi: "+customerEmail);
			//Console.WriteLine("Adres: " + district+"/" + city);
			//Console.WriteLine("------------------------------------------------");

			//customerName = "Ayşegül";
			//customerSurname = "Kaya";
			//customerPhone = "+90 800 630 36 63";
			//customerEmail = "test@gmail.com";
			//district = "Sapanca";
			//city = "Sakarya";

			//Console.WriteLine();
			//Console.WriteLine("------------------------------------------------");
			//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres: " + district + "/" + city);
			//Console.WriteLine("------------------------------------------------");

			#endregion

			#region Int Değişkenler

			int hamburgerPrice = 300;
			int cokePrice = 35;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 250;
			int lemonadePrice = 30;

			Console.WriteLine("**** Restoran Menü Fiyatı ****");
			Console.WriteLine();
			Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
			Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
			Console.WriteLine("----Kola: " + cokePrice + " TL");
			Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
			Console.WriteLine("----Kızartma: " + friesPrice + " TL");
			Console.WriteLine("----Su: " + waterPrice + " TL");
			Console.WriteLine();
			Console.WriteLine("**** Restoran Menü Fiyatı ****");
			Console.WriteLine();


			int hamburgerCount;
			int cokeCount;
			int waterCount;
			int friesCount;
			int pizzaCount;
			int lemonadeCount;

			int totalHamburgerPrice = 0;
			int totalCokePrice;
			int totalWaterPrice;
			int totalFriesPrice;
			int totalPizzaPrice;
			int totalLemonadePrice;

			hamburgerCount = 3;
			cokeCount = 3;
			waterCount = 3;
			friesCount = 1;
			pizzaCount = 0;
			lemonadeCount = 0;


			totalHamburgerPrice = hamburgerPrice * hamburgerCount;
			totalCokePrice = cokePrice * cokeCount;
			totalWaterPrice = waterPrice * waterCount;
			totalFriesPrice = friesPrice * friesCount;
			totalPizzaPrice = pizzaPrice * pizzaCount;
			totalLemonadePrice = lemonadePrice * lemonadeCount;

			Console.WriteLine("-----------------------------------");
			Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
			Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
			Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
			Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
			Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
			Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
			Console.WriteLine();

			int totalPrice = totalPizzaPrice + totalLemonadePrice + totalWaterPrice + totalFriesPrice + totalCokePrice + totalHamburgerPrice;
			Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

			#endregion


			Console.Read();
		}
	}
}
