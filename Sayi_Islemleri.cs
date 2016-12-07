using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayi_Yazi_Ile
{
    class Sayi_Islemleri
    {
        private string Sayi;
        private bool Kontrol0;
        private int Uzunluk;
        public void Basamak_Kontrol(ref int Basamak)
        {
            if (Basamak == 1 || Basamak == 2 || Basamak == 3)
                Basamak = 1;
            else if (Basamak == 4 || Basamak == 5 || Basamak == 6)
                Basamak = 4;
            else if (Basamak == 7 || Basamak == 8 || Basamak == 9)
                Basamak = 7;
            else if (Basamak == 10 || Basamak == 11 || Basamak == 12)
                Basamak = 10;
            else if (Basamak == 13 || Basamak == 14 || Basamak == 15)
                Basamak = 13;
            else if (Basamak == 16 || Basamak == 17 || Basamak == 18)
                Basamak = 16;
            else if (Basamak == 19 || Basamak == 20 || Basamak == 21)
                Basamak = 19;
            else if (Basamak == 22 || Basamak == 23 || Basamak == 24)
                Basamak = 22;
            else if (Basamak == 25 || Basamak == 26 || Basamak == 27)
                Basamak = 25;
            else if (Basamak == 28 || Basamak == 29 || Basamak == 30)
                Basamak = 28;
            else if (Basamak == 31 || Basamak == 32 || Basamak == 33)
                Basamak = 31;
            else if (Basamak == 34 || Basamak == 35 || Basamak == 36)
                Basamak = 34;
            else if (Basamak == 37 || Basamak == 38 || Basamak == 39)
                Basamak = 37;
            else if (Basamak == 40 || Basamak == 41 || Basamak == 42)
                Basamak = 40;
            else if (Basamak == 43 || Basamak == 44 || Basamak == 45)
                Basamak = 43;
            else if (Basamak == 46 || Basamak == 47 || Basamak == 48)
                Basamak = 46;
            else if (Basamak == 49 || Basamak == 50 || Basamak == 51)
                Basamak = 49;
            else if (Basamak == 52 || Basamak == 53 || Basamak == 54)
                Basamak = 52;
            else if (Basamak == 55 || Basamak == 56 || Basamak == 57)
                Basamak = 55;
            else if (Basamak == 58 || Basamak == 59 || Basamak == 60)
                Basamak = 58;
            else if (Basamak == 61 || Basamak == 62 || Basamak == 63)
                Basamak = 61;
            else if (Basamak == 64 || Basamak == 65 || Basamak == 66)
                Basamak = 64;
            else if (Basamak == 67 || Basamak == 68 || Basamak == 66)
                Basamak = 67;
            else if (Basamak == 70 || Basamak == 71 || Basamak == 72)
                Basamak = 70;
            else if (Basamak == 73 || Basamak == 74 || Basamak == 75)
                Basamak = 73;
            else if (Basamak == 76 || Basamak == 77 || Basamak == 78)
                Basamak = 76;
            else if (Basamak == 79 || Basamak == 80 || Basamak == 81)
                Basamak = 79;
            else if (Basamak == 82 || Basamak == 83 || Basamak == 84)
                Basamak = 82;
            else if (Basamak == 85 || Basamak == 86 || Basamak == 87)
                Basamak = 85;
            else if (Basamak == 88 || Basamak == 89 || Basamak == 90)
                Basamak = 88;
            else if (Basamak == 91 || Basamak == 92 || Basamak == 93)
                Basamak = 91;
            else if (Basamak == 94 || Basamak == 95 || Basamak == 96)
                Basamak = 94;
            else if (Basamak == 97 || Basamak == 98 || Basamak == 99)
                Basamak = 97;
            else if (Basamak == 100 || Basamak == 101 || Basamak == 102)
                Basamak = 100;
            else if (Basamak == 103 || Basamak == 104 || Basamak == 105)
                Basamak = 103;
            else if (Basamak == 106 || Basamak == 107 || Basamak == 108)
                Basamak = 106;
            else if (Basamak == 109 || Basamak == 110 || Basamak == 111)
                Basamak = 109;
            else if (Basamak == 112 || Basamak == 113 || Basamak == 114)
                Basamak = 112;
            else if (Basamak == 115 || Basamak == 116 || Basamak == 117)
                Basamak = 115;
            else if (Basamak == 118 || Basamak == 119 || Basamak == 120)
                Basamak = 118;
            else if (Basamak == 121 || Basamak == 122 || Basamak == 123)
                Basamak = 121;
            else if (Basamak == 124 || Basamak == 125 || Basamak == 126)
                Basamak = 124;
            else if (Basamak == 127 || Basamak == 128 || Basamak == 129)
                Basamak = 127;
            else if (Basamak == 130 || Basamak == 131 || Basamak == 132)
                Basamak = 130;
            else if (Basamak == 133 || Basamak == 134 || Basamak == 135)
                Basamak = 133;
            else if (Basamak == 136 || Basamak == 137 || Basamak == 138)
                Basamak = 136;
            else if (Basamak == 139 || Basamak == 140 || Basamak == 141)
                Basamak = 139;
            else if (Basamak == 142 || Basamak == 143 || Basamak == 144)
                Basamak = 142;
            else if (Basamak == 145 || Basamak == 146 || Basamak == 147)
                Basamak = 145;
            else if (Basamak == 148 || Basamak == 149 || Basamak == 150)
                Basamak = 148;
            else if (Basamak == 151 || Basamak == 152 || Basamak == 153)
                Basamak = 151;
            else if (Basamak == 154 || Basamak == 155 || Basamak == 156)
                Basamak = 154;
            else if (Basamak == 157 || Basamak == 158 || Basamak == 159)
                Basamak = 157;
            else if (Basamak == 160 || Basamak == 161 || Basamak == 162)
                Basamak = 160;
            else if (Basamak == 163 || Basamak == 164 || Basamak == 165)
                Basamak = 163;
            else if (Basamak == 166 || Basamak == 167 || Basamak == 168)
                Basamak = 166;
            else if (Basamak == 169 || Basamak == 170 || Basamak == 171)
                Basamak = 169;
            else if (Basamak == 172 || Basamak == 173 || Basamak == 174)
                Basamak = 172;
            else if (Basamak == 175 || Basamak == 176 || Basamak == 177)
                Basamak = 175;
            else if (Basamak == 178 || Basamak == 179 || Basamak == 180)
                Basamak = 178;
            else if (Basamak == 181 || Basamak == 182 || Basamak == 183)
                Basamak = 181;
            else if (Basamak == 184 || Basamak == 185 || Basamak == 186)
                Basamak = 184;
            else if (Basamak == 187 || Basamak == 188 || Basamak == 189)
                Basamak = 187;
        }
        public bool Sifir_Kontrol(ref string Sayi0, ref int Basamak)
        {
            Sayi = null;
            Uzunluk = Sayi0.Length - 1;
            for (int i = 0; i <= Uzunluk; i++)
                Sayi += Sayi0[Uzunluk - i];
            Kontrol0 = false;
            try
            {
                Kontrol0 = Sayi[Basamak - 1] != '0' || Sayi[Basamak] != '0';
            }
            catch (Exception)
            {
                Kontrol0 = Sayi[Basamak - 1] != '0';
                throw;
            }
            try
            {
                Kontrol0 = Sayi[Basamak - 1] != '0' || Sayi[Basamak] != '0' || Sayi[Basamak + 1] != '0';
            }
            catch (Exception)
            {
                Kontrol0 = Sayi[Basamak - 1] != '0' || Sayi[Basamak] != '0';
                throw;
            }
            return Kontrol0;
        }
        public string Sayilar(char Sayi0, ref int Basamak, ref int Basamak3)
        {
            Sayi = null;
            if (Sayi0 == '1')
            {
                if (Basamak3 == 0)
                    Sayi = "Yüz ";
                else if (Basamak3 == 1 && Basamak != 4)
                    Sayi = "Bir ";
                else if (Basamak3 == 2)
                    Sayi = "On ";
            }
            else if (Sayi0 == '2')
            {
                if (Basamak3 == 0)
                    Sayi = "İki Yüz ";
                else if (Basamak3 == 1)
                    Sayi = "İki ";
                else if (Basamak3 == 2)
                    Sayi = "Yirmi ";
            }
            else if (Sayi0 == '3')
            {
                if (Basamak3 == 0)
                    Sayi = "Üç Yüz ";
                else if (Basamak3 == 1)
                    Sayi = "Üç ";
                else if (Basamak3 == 2)
                    Sayi = "Otuz ";
            }
            else if (Sayi0 == '4')
            {
                if (Basamak3 == 0)
                    Sayi = "Dört Yüz ";
                else if (Basamak3 == 1)
                    Sayi = "Dört ";
                else if (Basamak3 == 2)
                    Sayi = "Kırk ";
            }
            else if (Sayi0 == '5')
            {
                if (Basamak3 == 0)
                    Sayi = "Beş Yüz ";
                else if (Basamak3 == 1)
                    Sayi = "Beş ";
                else if (Basamak3 == 2)
                    Sayi = "Elli ";
            }
            else if (Sayi0 == '6')
            {
                if (Basamak3 == 0)
                    Sayi = "Altı Yüz ";
                else if (Basamak3 == 1)
                    Sayi = "Altı ";
                else if (Basamak3 == 2)
                    Sayi = "Altmış ";
            }
            else if (Sayi0 == '7')
            {
                if (Basamak3 == 0)
                    Sayi = "Yedi Yüz ";
                else if (Basamak3 == 1)
                    Sayi = "Yedi ";
                else if (Basamak3 == 2)
                    Sayi = "Yetmiş ";
            }
            else if (Sayi0 == '8')
            {
                if (Basamak3 == 0)
                    Sayi = "Sekiz Yüz ";
                else if (Basamak3 == 1)
                    Sayi = "Sekiz ";
                else if (Basamak3 == 2)
                    Sayi = "Seksen ";
            }
            else if (Sayi0 == '9')
            {
                if (Basamak3 == 0)
                    Sayi = "Dokuz Yüz ";
                else if (Basamak3 == 1)
                    Sayi = "Dokuz ";
                else if (Basamak3 == 2)
                    Sayi = "Doksan ";
            }
            return Sayi;
        }
    }
}
