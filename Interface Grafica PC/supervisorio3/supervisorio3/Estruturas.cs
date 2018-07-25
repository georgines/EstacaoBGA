using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supervisorio3
{
    internal class Estruturas
    {
        
        public string EnviaRef(string endereco, string referencia, string saidaManual, string Modo)
        {
            string saida = "1\t" + endereco + "\t" + referencia + "\t" + saidaManual + "\t" + Modo + "\t0\t0\t0\r\n";
            return saida;
        }

        public string EnviaTune(string endereco, string kp, string ki, string kd, string direcao, string periodo)
        {
            string saida = "2\t" + endereco + "\t" + kp + "\t"+ki+"\t"+kd+"\t"+direcao+"\t"+periodo+"\t0\r\n";
            return saida;
        }

        public string EnviaAutoTune(string endereco, string passo, string ruido, string lookBack, string estado)
        {
            string saida = "3\t" + endereco + "\t" + passo + "\t" + ruido + "\t" + lookBack + "\t" + estado + "\t0\t0\r\n";
            return saida;
        }

        public string EnviaPwm(string endereco, string valor)
        {
            string saida = "4\t" + endereco + "\t" + valor + "\t0\t0\t0\t0\t0\r\n";
            return saida;
        }

        public string EnviaBotaoSaida(string endereco, string valor)
        {
            string saida = "5\t" + endereco + "\t" + valor + "\t0\t0\t0\t0\t0\r\n";
            return saida;
        }


    }
}
