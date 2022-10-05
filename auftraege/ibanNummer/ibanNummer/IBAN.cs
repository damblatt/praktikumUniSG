using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace IBANNUmmer
{
    public class IBAN
    {
        public int Bankleitzahl { get; }
        public int Kontonummer { get; }
        public string Laendererkennung { get; }

        public string BBAN { get; }
        public string NumerischeLaendererkennung { get; }

        public BigInteger Pruefsumme { get; }
        public BigInteger PruefsummeModulo { get; }

        public string Pruefziffer { get; }

        public string IBANNumber { get; }

        public IBAN(int bankleitzahl, int kontonummer, string laendererkennung)
        {
            Bankleitzahl = bankleitzahl;
            Kontonummer = kontonummer;
            Laendererkennung = laendererkennung;

            BBAN = SetBBAN();
            NumerischeLaendererkennung = SetNumerischeLaendererkennung();

            Pruefsumme = SetPruefsumme();
            PruefsummeModulo = Pruefsumme % 97;

            Pruefziffer = SetPruefziffer();

            IBANNumber = SetIBAN();
        }

        // BBAN
        public string SetBBAN()
        {
            var bban = Bankleitzahl.ToString() + Kontonummer.ToString();
            return bban;
        }

        // Ländererkennung
        public string SetNumerischeLaendererkennung()
        {
            var firstLetterValue = (int)Laendererkennung[0] - 'A' + 10;
            var secondLetterValue = (int)Laendererkennung[1] - 'A' + 10;
            string numerischeLaendererkennung = $"{firstLetterValue}{secondLetterValue}00";
            return numerischeLaendererkennung;
        }

        // Prüfsumme
        public BigInteger SetPruefsumme()
        {
            string pruefsumme = $"{BBAN}{NumerischeLaendererkennung}";
            return BigInteger.Parse(pruefsumme);
        }

        // Prüfziffer
        public string SetPruefziffer()
        {
            if (98 - PruefsummeModulo < 10)
            {
                return $"0{98 - PruefsummeModulo}";
            }
            return $"{98 - PruefsummeModulo}";
        }

        // IBAN
        public string SetIBAN()
        {
            return $"{Laendererkennung}{Pruefziffer}{BBAN}";
        }

        public static string IsIBANValid(string iban)
        {
            iban = iban.Trim().ToUpper();
            var firstLetterValue = (int)iban[0] - 'A' + 10;
            var secondLetterValue = (int)iban[1] - 'A' + 10;
            string numerischeLaendererkennung = $"{firstLetterValue}{secondLetterValue}";

            string IBANOhneLaendererkennung = iban.Remove(0, 2);

            bool isNumber = BigInteger.TryParse(IBANOhneLaendererkennung, out var n);
            if (isNumber)
            {
                string thirdAndFourthLetter = iban.Substring(2, 2);

                string IBANWithoutFirstFourLetters = iban.Remove(0, 4);

                string newIBAN = IBANWithoutFirstFourLetters + numerischeLaendererkennung + thirdAndFourthLetter;

                BigInteger.Parse(newIBAN);

                if (BigInteger.Parse(newIBAN) % 97 == 1)
                {
                    return "This IBAN is valid.";
                }
                else
                {
                    return "This IBAN is not valid.";
                }
            }
            else
            {
                return "This IBAN is not valid.";
            }

            //Die Prüfung der IBAN erfolgt, indem ihre ersten vier Stellen ans Ende verschoben und die Buchstaben wieder durch 1314 ersetzt werden.
            //Die Zahl 700901001234567890131408 Modulo 97 muss 1 ergeben.Dann ist die IBAN gültig, was auf unser Beispiel zutrifft.
        }
    }
}
