using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberToWords
{
    class Program
    {
        static void Main()
        {
            // TODO : keiskite FROM..TO skaicius pagal tai kiek spesite padaryt uzduociu. (-19...19, -99..99, ir tt.)
            const int FROM_NUMBER = -9;
            const int TO_NUMBER = 9;

            Console.WriteLine("Sveiki!");

            string numberInput = "";

            while(numberInput != " ")
            {
                Console.WriteLine($"Iveskite skaiciu nuo {FROM_NUMBER} iki {TO_NUMBER}.   (Iveskite Space programai uzbaigti.)");
                numberInput = Console.ReadLine();


                // TODO :au jusu programa!



            }
            Console.WriteLine("Viso gero!");
            Console.ReadKey();
        }

        // bendra funkcija apjungti visom funkcijom kurias jus sukursit.
        // ... ChangeNumberToText()

        // funkcija gauna string skaiciu, patikrina ar skaicius teisingu formatu. Pvz: "123", "-123" grazina true. "12a3", "1-23" grazina false.
        // ... CheckIfGoodNumber(...)

        // funkcija grazina true jei skaicius checkNumber yar tarp fromNumber ir toNumber (imtinai)
        // ... CheckIfNumberInRange(...)

        // idejos kitom funkcijoms
        //ChangeOnesToText(), ChangeTeensToText, ChangeTensToText, ChangeHundredsToText, ChangeThousandsToText, ChangeMillionsToText, ChangeBilllionsToText

        
        //Skaiciai zodziais:  
        // "minus"; 
        // "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni"; 
        // "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"; 
        // "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt"; 
        // "simtas", "tukstantis", "milijonas", "milijardas"; 
        // "simtai", "tukstanciai", "milijonai", "milijardai"; 
        // "simtu", "tukstanciu", "milijonu", "milijardu"; 
    }
}