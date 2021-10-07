using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketversand
{
    class Program
    {
              static void Main(string[] args)
        { 
            //------------------Aufgabe1----------------------------
            //Notification
            Console.WriteLine("Herzlich Wilkommen");
            Console.WriteLine("Dieses Programm berechnet die benötigten Briefmarkenwert");

            //------------------Aufgabe2----------------------------
            //Deklaration
            Int32 iLaenge;
            Int32 iBreite;
            Int32 iMaterialstaerke;

            Double dDichte;
            Double dMasse;

            //Defenition
            iMaterialstaerke = 3; //cm
            dDichte = 0.0007; //cm^3

            //Notification
            Console.Write("Bitte geben Sie die Laenge in cm ein:");
            iLaenge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte geben Sie die Breite in cm ein:");
            iBreite = Convert.ToInt32(Console.ReadLine());

            //------------------Aufgabe3-------------------------
            Console.Write("Die Masze sind(Ixbxh):");
            Console.WriteLine(iLaenge + "x" + iBreite + "x" + iMaterialstaerke);

            //------------------Aufgabe4-------------------------
            dMasse = iBreite * iLaenge * iMaterialstaerke * dDichte; //kg
            Console.WriteLine("Die Masse betraegt:" + dMasse + "kg");
                  
            //------------------Aufgabe5-------------------------
            Int32 iSumme;
            if (iLaenge > iBreite)
            {
                iSumme = iLaenge + iMaterialstaerke;
            }
            else
            {
                iSumme = iBreite + iMaterialstaerke;
            }
            Console.WriteLine(iSumme + "cm");

            //------------------Aufgabe6-------------------------
            if(iSumme<=37)
            {
                Console.WriteLine("Ihr Paket kostet 3,60 Euro");
            }
            else if(iSumme<=50)
            {
                Console.WriteLine("Ihr Paket kostet 4,30 Euro");
            }
            else if(iSumme<=80)
            {
                Console.WriteLine("Ihr Paket kostet 5,25 Euro");
            }
            else if(iSumme<=120)
            {
                Console.WriteLine("Ihr Paket kostet 10,15 Euro");
            }
            else
            {
                Console.WriteLine("Ihr Paket ist zu groß");
            }

            //Don´t Close
            Console.ReadLine();
        }
    }
}
