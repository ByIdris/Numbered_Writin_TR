using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayi_Yazi_Ile
{
    class Basamak_Islemleri
    {
        private string Sayi;
        public string Uclu_Basamaklar(ref string Sayi0, ref int Basamak, ref int Basamak3)
        {
            Sayi_Islemleri SI0 = new Sayi_Islemleri();
            if (Basamak%3!=1)
                SI0.Basamak_Kontrol(ref Basamak);
            
            Sayi = null;
            if (Basamak3 == 1 && Basamak == 4)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Bin ";
                Basamak = 1;
            }
            else if (Basamak3 == 1 && Basamak == 7)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Milyon ";
                Basamak = 4;
            }
            else if (Basamak3 == 1 && Basamak == 10)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Milyar ";
                Basamak = 7;
            }
            else if (Basamak3 == 1 && Basamak == 13)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Trilyon ";
                Basamak = 10;
            }
            else if (Basamak3 == 1 && Basamak == 16)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Katrilyon ";
                Basamak = 13;
            }
            else if (Basamak3 == 1 && Basamak == 19)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Kentilyon ";
                Basamak = 16;
            }
            else if (Basamak3 == 1 && Basamak == 22)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Seksilyon ";
                Basamak = 19;
            }
            else if (Basamak3 == 1 && Basamak == 25)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Septilyon ";
                Basamak = 22;
            }
            else if (Basamak3 == 1 && Basamak == 28)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Oktilyon ";
                Basamak = 25;
            }
            else if (Basamak3 == 1 && Basamak == 31)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Nonilyon ";
                Basamak = 28;
            }
            else if (Basamak3 == 1 && Basamak == 34)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Desilyon ";
                Basamak = 31;
            }
            else if (Basamak3 == 1 && Basamak == 37)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Undesilyon ";
                Basamak = 34;
            }
            else if (Basamak3 == 1 && Basamak == 40)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Dodesilyon ";
                Basamak = 37;
            }
            else if (Basamak3 == 1 && Basamak == 43)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Tredesilyon ";
                Basamak = 40;
            }
            else if (Basamak3 == 1 && Basamak == 46)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Katordesilyon ";
                Basamak = 43;
            }
            else if (Basamak3 == 1 && Basamak == 49)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Kendesilyon ";
                Basamak = 46;
            }
            else if (Basamak3 == 1 && Basamak == 52)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Seksdesilyon ";
                Basamak = 49;
            }
            else if (Basamak3 == 1 && Basamak == 55)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Septendesilyon ";
                Basamak = 52;
            }
            else if (Basamak3 == 1 && Basamak == 58)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Oktodesilyon ";
                Basamak = 55;
            }
            else if (Basamak3 == 1 && Basamak == 61)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Novemdesilyon ";
                Basamak = 58;
            }
            else if (Basamak3 == 1 && Basamak == 64)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Vigintilyon ";
                Basamak = 61;
            }
            else if (Basamak3 == 1 && Basamak == 67)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Anvigintilyon ";
                Basamak = 64;
            }
            else if (Basamak3 == 1 && Basamak == 70)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Dovigintilyon ";
                Basamak = 67;
            }
            else if (Basamak3 == 1 && Basamak == 73)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Tresvigintilyon ";
                Basamak = 70;
            }
            else if (Basamak3 == 1 && Basamak == 76)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Katorvigintilyon ";
                Basamak = 73;
            }
            else if (Basamak3 == 1 && Basamak == 79)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Kenvigintilyon ";
                Basamak = 76;
            }
            else if (Basamak3 == 1 && Basamak == 82)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Sesvigintilyon ";
                Basamak = 79;
            }
            else if (Basamak3 == 1 && Basamak == 85)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Septemvigintilyon ";
                Basamak = 82;
            }
            else if (Basamak3 == 1 && Basamak == 88)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Oktovigintilyon ";
                Basamak = 85;
            }
            else if (Basamak3 == 1 && Basamak == 91)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Novemvigintilyon ";
                Basamak = 88;
            }
            else if (Basamak3 == 1 && Basamak == 94)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Trigintilyon ";
                Basamak = 91;
            }
            else if (Basamak3 == 1 && Basamak == 97)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Antrigintilyon ";
                Basamak = 94;
            }
            else if (Basamak3 == 1 && Basamak == 100)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Dotrigintilyon ";
                Basamak = 97;
            }
            else if (Basamak3 == 1 && Basamak == 103)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Trestrigintilyon ";
                Basamak = 100;
            }
            else if (Basamak3 == 1 && Basamak == 106)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Katortrigintilyon ";
                Basamak = 103;
            }
            else if (Basamak3 == 1 && Basamak == 109)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Kenkatrigintilyon ";
                Basamak = 106;
            }
            else if (Basamak3 == 1 && Basamak == 112)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Sestrigintilyon ";
                Basamak = 109;
            }
            else if (Basamak3 == 1 && Basamak == 115)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Trestrigintilyon ";
                Basamak = 112;
            }
            else if (Basamak3 == 1 && Basamak == 118)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Trestrigintilyon ";
                Basamak = 115;
            }
            else if (Basamak3 == 1 && Basamak == 121)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Septentrigintilyon ";
                Basamak = 118;
            }
            else if (Basamak3 == 1 && Basamak == 124)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Oktotrigintilyon ";
                Basamak = 121;
            }
            else if (Basamak3 == 1 && Basamak == 127)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Novemtrigintilyon ";
                Basamak = 124;
            }
            else if (Basamak3 == 1 && Basamak == 130)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Katragintilyon ";
                Basamak = 127;
            }
            else if (Basamak3 == 1 && Basamak == 133)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Ankatragintilyon ";
                Basamak = 130;
            }
            else if (Basamak3 == 1 && Basamak == 136)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Dokatragintilyon ";
                Basamak = 133;
            }
            else if (Basamak3 == 1 && Basamak == 139)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Treskatragintilyon ";
                Basamak = 136;
            }
            else if (Basamak3 == 1 && Basamak == 142)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Katorkatragintilyon ";
                Basamak = 139;
            }
            else if (Basamak3 == 1 && Basamak == 145)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Kenkakatragintilyon ";
                Basamak = 142;
            }
            else if (Basamak3 == 1 && Basamak == 148)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Seskatragintilyon ";
                Basamak = 145;
            }
            else if (Basamak3 == 1 && Basamak == 151)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Septenkatragintilyon ";
                Basamak = 148;
            }
            else if (Basamak3 == 1 && Basamak == 154)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Oktokatragintilyon ";
                Basamak = 151;
            }
            else if (Basamak3 == 1 && Basamak == 157)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Novemkatragintilyon ";
                Basamak = 154;
            }
            else if (Basamak3 == 1 && Basamak == 160)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Kenkagintilyon ";
                Basamak = 157;
            }
            else if (Basamak3 == 1 && Basamak == 163)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Ankenkagintilyon ";
                Basamak = 160;
            }
            else if (Basamak3 == 1 && Basamak == 166)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Dokenkagintilyon ";
                Basamak = 163;
            }
            else if (Basamak3 == 1 && Basamak == 169)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Treskenkagintilyon ";
                Basamak = 166;
            }
            else if (Basamak3 == 1 && Basamak == 172)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Katorkenkagintilyon ";
                Basamak = 169;
            }
            else if (Basamak3 == 1 && Basamak == 175)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Kenkenkagintilyon ";
                Basamak = 172;
            }
            else if (Basamak3 == 1 && Basamak == 178)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Seskenkagintilyon ";
                Basamak = 175;
            }
            else if (Basamak3 == 1 && Basamak == 181)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Septenkenkagintilyon ";
                Basamak = 178;
            }
            else if (Basamak3 == 1 && Basamak == 184)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Oktokenkagintilyon ";
                Basamak = 181;
            }
            else if (Basamak3 == 1 && Basamak == 187)
            {
                if (SI0.Sifir_Kontrol(ref Sayi0, ref Basamak))
                    Sayi = "Novemkenkagintilyon ";
                Basamak = 184;
            }
            return Sayi;
        }
    }
}
