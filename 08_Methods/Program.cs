using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Void Metotlar

			//geriye değer döndürmeyen metotlar(VOID)
			//customer-listele,ekle,sil,güncelle

			//void CustomerList()
			//{
			//	Console.WriteLine("Veli");
			//	Console.WriteLine("Özge");
			//	Console.WriteLine("Ayşe");
			//	Console.WriteLine("Gizem");
			//}

			//CustomerList();


			//void sum()
			//{
			//	int x = 1;
			//	int y = 2;
			//	int z = x+ y;
			//	Console.WriteLine(z);
			//}
			//sum();


			#endregion

			#region Geriye değer döndürmeyen string parametreli metotlar

			//void writeMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);
			//}

			//writeMethod("özge");

			//void CustomerCard(string name,string surname)
			//{
			//	Console.WriteLine("Müşteri: "+name+" "+surname);
			//}

			//CustomerCard("özge", "kuzucu");
			//CustomerCard("veli", "kuzucu");
			#endregion

			#region Geriye değer döndürmeyen int parametreli metotlar

			//void sum(int num1,int num2,int num3)
			//{
			//	int result = num1 + num2 + num3;
			//	Console.WriteLine(result);
			//}
			//sum(1, 2, 3);

			#endregion

			#region Geriye değer döndüren metotlar

			//string customerName()
			//{
			//	return "Buse Yıldız";
			//}
			//customerName();

			//string studentCard()
			//{
			//	string name = "Veli";
			//	string surname = "Kuzucu";
			//	return name+" " + surname;
			//}

			//Console.WriteLine(studentCard());

			#endregion

			#region Geriye değer string döndüren parametreli metotlar

			//string countryCard(string countryName, string capital, string flagColor)
			//{
			//	string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi:  " + flagColor;
			//	return cardInfo;
			//}
			//string x, y, z;
			//Console.Write("Ülke Adını Giriniz: ");
			//x = Console.ReadLine();

			//Console.Write("Başkenti Giriniz: ");
			//y = Console.ReadLine();

			//Console.Write("Bayrak Rengini Giriniz: ");
			//z = Console.ReadLine();

			//Console.WriteLine(countryCard(x,y,z));	
			#endregion

			#region Geriye değer  döndüren string parametreli metotlar

			//string countryCard(string countryName, string capital, string flagColor)
			//{
			//	string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi:  " + flagColor;
			//	return cardInfo;
			//}
			//string x, y, z;
			//Console.Write("Ülke Adını Giriniz: ");
			//x = Console.ReadLine();

			//Console.Write("Başkenti Giriniz: ");
			//y = Console.ReadLine();

			//Console.Write("Bayrak Rengini Giriniz: ");
			//z = Console.ReadLine();

			//Console.WriteLine(countryCard(x,y,z));	
			#endregion

			#region Geriye değer  döndüren int parametreli metotlar

			//int sum(int num1, int num2)
			//{
			//	int result = num1 + num2;
			//	return result;
			//}
			//Console.WriteLine(sum(45, 98));
			//Console.WriteLine(sum(36, 25));
			//Console.WriteLine(sum(44, 36));
			//Console.WriteLine(sum(14, 20));
			#endregion

			#region Örnek Uygulama
			//string examResult(string student, int exam1, int exam2, int exam3)
			//{
			//	int result = (exam1 + exam2 + exam3) / 3;
			//	if (result >= 50)
			//	{
			//		return student+ " isimli öğrenci sınavı geçti"+ " Ortalama: "+result;
			//	}
			//	else
			//	{
			//		return student + " isimli öğrenci sınavı geçemedi" + " Ortalama: " + result;
			//	}
			//}
			//Console.WriteLine(examResult("ali", 25, 41, 55));
			//Console.WriteLine(examResult("ayşe",36,88,33));
			#endregion
			Console.Read();
			}
		}
	}
