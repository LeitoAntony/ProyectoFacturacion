using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosFacturacion
{
    class ABMLogic
    {


        internal string Encode(string pass)
        {
            string encode = string.Empty;
            string encode2 = string.Empty;
            for (int i = 0; i < pass.Length; i++)
            {
                encode += (char)(pass[i] + 10);
            }
            encode = encode + encode;
            for (int i = encode.Length-1; i > 0; i--)
            {
                encode2 += (char)(encode[i]);
            }
            encode = encode + encode2;
            return encode;
        }
    }
}
