using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szenzorhalozat
{
	class Program
	{

		static void TelepitSzenzorHalozat(string input, SzenzorHalozat halozat)
		{
			StreamReader sr = new StreamReader(input);

            try
            {
				while (!sr.EndOfStream)
				{
					string sor = sr.ReadLine();
					string[] adatok = sor.Split(';');
					if (adatok[0] == "H")
					{
						Homero homero = new Homero(int.Parse(adatok[1]), int.Parse(adatok[2]),
													int.Parse(adatok[3]), int.Parse(adatok[4]));
						halozat.Telepit(homero);
					}
					else
						throw new NotImplementedException("Nem hőmérő szenzorok szenzorok kezelése nincs implementálva.");
				}
			}
			catch (FileNotFoundException) { throw new FileNotFoundException("A rendszer nem találja a beolvasandó file-t!"); }
			catch (Exception)
            {

                throw;
            }
			finally
            {
				sr.Close();
			}
		}

		static void Main(string[] args)
		{
			SzenzorHalozat halozat = new SzenzorHalozat();
			TelepitSzenzorHalozat("szenzorok.csv", halozat);

			Console.ReadLine();
		}
	}
}