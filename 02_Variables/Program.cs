using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Double Değişkenler
			//double number;
			//number =4.85;
			//Console.WriteLine(number);

			//Console.WriteLine("***** Fiyat Listesi *****");
			//Console.WriteLine();

			//double applePrice, orangePrice, strawberryPrice, patato, tomato;

			//applePrice = 14.85;
			//orangePrice = 20.95;
			//strawberryPrice = 45;
			//patato = 9.47;
			//tomato = 6.88;

			//Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " TL");
			//Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + " TL");
			//Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + " TL");
			//Console.WriteLine("----Patates Birim Fiyatı: " + patato + " TL");
			//Console.WriteLine("----Domates Birim Fiyatı: " + tomato + " TL");

			//Console.WriteLine();
			//Console.WriteLine();

			//double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
			//appleGram = 1.245;
			//orangeGram = 2.650;
			//strawberryGram = 0.750;
			//patatoGram = 4.859;
			//tomatoGram = 3.745;

			//double appleTotalPrice = appleGram * applePrice;
			//double orangeTotalPrice = orangeGram * orangePrice;
			//double strawberryTotalPrice = strawberryGram * strawberryPrice;
			//double patatoTotalPrice = patatoGram * patato;
			//double tomatoTotalPrice = tomatoGram * tomato;

			//Console.WriteLine("Alınan Ürün: Elma -" + " Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " TL");
			//Console.WriteLine("Alınan Ürün: Portakal -" + " Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice  + " TL");
			//Console.WriteLine("Alınan Ürün: Çilek -" + " Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " TL");
			//Console.WriteLine("Alınan Ürün: Patates -" + " Birim Fiyat: " + patato + " - Gramaj: " + patatoGram + " - Toplam Tutar: " + patatoTotalPrice + " TL");
			//Console.WriteLine("Alınan Ürün: Domates -" + " Birim Fiyat: " + tomato + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " TL");


			//double shoppingTotalPrice = appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+patatoTotalPrice+tomatoTotalPrice;
			//Console.WriteLine();
			//Console.WriteLine();
			//Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");
			#endregion

			#region Char Değişkenler
			//char symbol;
			//symbol ='a';
			//Console.WriteLine(symbol);

			#endregion

			#region Klavyeden Veri Girişleri String Değişkenler

			//Console.WriteLine("**** CSharp Hava Yollar Yolcu Bilgisi ****");
			//Console.WriteLine();

			//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

			//Console.Write("Yolcu Adı: ");
			//passengerName = Console.ReadLine();

			//Console.Write("Yolcu Soyadı: ");
			//passengerSurname = Console.ReadLine();

			//Console.Write("İlçe Bilgisi: ");
			//passengerDistrict = Console.ReadLine();

			//Console.Write("Şehir Bilgisi: ");
			//passengerCity = Console.ReadLine();

			//Console.Write("Yolcu Yaş: ");
			//passengerAge = Console.ReadLine();

			//Console.Write("Yolcu TC Kimlik No: ");
			//passengerIdentityNumber = Console.ReadLine();

			//Console.WriteLine();
			//Console.WriteLine("---------------------------------------------------");
			//Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname+ " "+passengerDistrict+"/"+passengerCity+" "+"Yaş: "+passengerAge+" TC Kimlik No: "+passengerIdentityNumber);

			#endregion

			#region Klavyeden Tam Sayı Girişleri ve Dönüşümler

			//int shoesPrice, computerPrice, chairPrice, tvPrice;
			//shoesPrice = 1000;
			//computerPrice = 20000;
			//chairPrice = 5000;
			//tvPrice = 12000;

			//int shoesCount, computerCount, chairCount, tvCount;

			//Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
			//shoesCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
			//computerCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
			//chairCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
			//tvCount = int.Parse(Console.ReadLine());

			//int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice +tvCount * tvPrice;

			//Console.WriteLine();
			//Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);
			#endregion

			#region Klavyeden Ondalıklı Sayı işlemleri
			//double exam1, exam2, exam3, result;

			//Console.Write("Birinci sınav notunu giriniz: ");
			//exam1 = double.Parse(Console.ReadLine());

			//Console.Write("İkinci sınav notunu giriniz: ");
			//exam2 = double.Parse(Console.ReadLine());

			//Console.Write("Üçüncü sınav notunu giriniz: ");
			//exam3 = double.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3;
			//Console.WriteLine("Sınav Ortalamanız: "+result); 
			#endregion

			#region Klavyeden Karakter Girişleri

			//char gender;
			//Console.Write("Lütfen cinsiyet seçiniz: ");
			//gender = char.Parse(Console.ReadLine());
			//Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

			#endregion

			Console.Read();
		}
	}
}
