using System.Collections.Generic;
using System.Linq;
namespace Romanos
{
    public class RomanoConverter
    {
        readonly Dictionary<int, string> mapeo = new Dictionary<int, string>();

        public RomanoConverter()
        {
            mapeo.Add(5, "V");
            mapeo.Add(10, "X");
            mapeo.Add(1, "I");
            mapeo.Add(50, "L");
            mapeo.Add(100, "C");
            mapeo.Add(500, "D");
            mapeo.Add(1000, "M");
        }

        public string Parse(int numero)
        {

            string strResultado = "";

            if (mapeo.ContainsKey(numero))
            {
                return mapeo[numero];
            }
            else if (numero < 4)
            {
                strResultado = GiveMePals(numero);
            }
            else
            {
                switch (numero)
                {
                    case 4:
                        strResultado = "IV";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        strResultado = "V" + Parse(numero - 5);
                        break;
                    case 9:
                        strResultado = "IX";
                        break;
                    default:
                        if (numero > 100)
                            strResultado = "C" + Parse(numero - 100);
                        else
                        if (numero > 90)
                            strResultado = "XC" + Parse(numero - 90);
                        else
                        if (numero > 40)
                            strResultado = "XL" + Parse(numero - 40);
                        else
                            strResultado = "X" + Parse(numero - 10);
                        break;
                }
            }
            return strResultado;
        }
        private static string GiveMePals(int numero)
        {
            string strResultado = "";
            for (int i = 1; i <= numero; i++)
                strResultado += "I";
            return strResultado;
        }
    }
}