using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        Regex vinRule = new Regex(@"^([a-z1-9-[oiq]]{3})([a-z0-9-[oiq]]{5})([0-9x]{1})([a-y1-9-[oiqu]]{1})([a-z0-9-[oiq]]{7})$");
        Dictionary<Regex, string> regions = new Dictionary<Regex, string>
        {
            {new Regex(@"[a-h]"),"Африка"},
            {new Regex(@"[j-r]"),"Азия"},
            {new Regex(@"[s-z]"),"Европа"},
            {new Regex(@"[1-5]"),"Северная Америка"},
            {new Regex(@"[6-7]"),"Океания"},
            {new Regex(@"[8-9]"),"Южная Америка"}

        };

        Dictionary<char, int> chartoint = new Dictionary<char, int>
        {
            {'a',1},
            {'b',2},
            {'c',3},
            {'d',4},
            {'e',5},
            {'f',6},
            {'g',7},
            {'h',8},
            {'j',1},
            {'k',2},
            {'l',3},
            {'m',4},
            {'n',5},
            {'p',7},
            {'r',9},
            {'s',2},
            {'t',3},
            {'u',4},
            {'v',5},
            {'w',6},
            {'x',7},
            {'y',8},
            {'z',9}
        };

        int[] weight = { 8, 7, 6, 5, 4, 3, 2, 10, 0, 9, 8, 7, 6, 5, 4, 3, 2 };
        public bool CheckVIN(string vin)
        {
            vin = vin.ToLower();
            char[] v = vin.ToCharArray();
            for (int i = 0; i < v.Length; i++)
            {
                if (new Regex(@"[a-z]").Match(v[i].ToString()).Success)
                {
                    foreach (var item in chartoint)
                    {
                        if (item.Key == v[i])
                            v[i] = (char)item.Value;

                    }
                }
            }
            int cnk = 0;
            for (int i = 0; i < v.Length; i++)
            {
                cnk += (int)v[i] * weight[i];
            }
            return vinRule.Match(vin).Success;
        }

        public string GetVINCountry(string vin)
        {
            vin = vin.ToLower();
            foreach (var region in regions)
            {
                if (region.Key.Match(vin[0].ToString()).Success)
                    return region.Value;
            }
            return null;
        }
    }
}
