using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Tienda
{
    static class Validaciones
    {
        public static int LeerInt(int min, int max)
        {
            bool pudo = false;
            int val = 0;
            while (!pudo)
            {
                pudo = int.TryParse(Console.ReadLine(), out val);
                if (!pudo || val < min || val > max)
                {
                    pudo = false;
                    Console.WriteLine(string.Concat("Valor incorrecto, solo números enteros entre ", min, " y ", max, ".\nIntente nuevamente: "));
                }
            }
            return val;
        }

        public static bool LeerSiNo()
        {
            bool pudo = false;
            while (!pudo)
            {
                string tmp = Console.ReadLine();
                if (tmp.Trim().ToLower().Replace('í', 'i') == "si" || tmp.Trim().ToLower() == "s" || tmp.Trim().ToLower() == "yes" || tmp.Trim().ToLower() == "y")
                {
                    return true;
                }
                else
                {
                    if (tmp.Trim().ToLower() == "no" || tmp.Trim().ToLower() == "n")
                    {
                        return false;
                    }
                }

                if (!pudo)
                    Console.WriteLine("Valor incorrecto, ingrese si o no");
            }
            return false;
        }

        public static double LeerDouble(double min, double max)
        {
            bool pudo = false;
            double val = 0;
            while (!pudo)
            {
                pudo = double.TryParse(Console.ReadLine(), out val);
                if (!pudo || val < min || val > max)
                {
                    pudo = false; 
                    Console.WriteLine(string.Concat("Valor incorrecto, solo números entre ", min, " y ", max, ".\nIntente nuevamente: "));
                }
            }
            return val;
        }
        public static DateTime LeerFecha()
        {
            bool pudo = false;
            DateTime val = DateTime.Today;
            while (!pudo)
            {
                pudo = DateTime.TryParse(Console.ReadLine(), out val);
                if (!pudo)
                {
                    Console.WriteLine(string.Concat("Valor incorrecto, solo fechas válidas.\nIntente nuevamente: "));
                }
            }
            return val;
        }
    }
}
