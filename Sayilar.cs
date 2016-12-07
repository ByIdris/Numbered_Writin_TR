using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayi_Yazi_Ile
{
    class Sayilar
    {
        string Sayi0;
        public string Bir(byte Sayi)
        {
            if (Sayi == 1)
                return "Bir";
            else if (Sayi == 2)
                return "On";
            else
                return "Yüz";
        }
        public string Iki(byte Sayi)
        {
            if (Sayi == 1)
                return "İki";
            else if (Sayi == 2)
                return "Yirmi";
            else
                return "İki Yüz";
        }
        public string Uc(byte Sayi)
        {
            if (Sayi == 1)
                return "Üç";
            else if (Sayi == 2)
                return "Otuz";
            else
                return "Üç Yüz";
        }
        public string Dort(byte Sayi)
        {
            if (Sayi == 1)
                return "Dört";
            else if (Sayi == 2)
                return "Kırk";
            else
                return "Dört Yüz";
        }
        public string Bes(byte Sayi)
        {
            if (Sayi == 1)
                return "Beş";
            else if (Sayi == 2)
                return "Elli";
            else
                return "Beş Yüz";
        }
        public string Alti(byte Sayi)
        {
            if (Sayi == 1)
                return "Altı";
            else if (Sayi == 2)
                return "Altmış";
            else
                return "Altı Yüz";
        }
        public string Yedi(byte Sayi)
        {
            if (Sayi == 1)
                return "Yedi";
            else if (Sayi == 2)
                return "Yetmiş";
            else
                return "Yedi Yüz";
        }
        public string Sekiz(byte Sayi)
        {
            if (Sayi == 1)
                return "Sekiz";
            else if (Sayi == 2)
                return "Seksen";
            else
                return "Sekiz Yüz";
        }
        public string Dokuz(byte Sayi)
        {
            if (Sayi == 1)
                return "Dokuz";
            else if (Sayi == 2)
                return "Doksan";
            else
                return "Dokuz Yüz";
        }
    }
}
