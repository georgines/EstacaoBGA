using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace supervisorio3
{
    internal class Protocolo
    {
        public char[] separador { get; set; }
        private string dadosBrutos;
        private string[] DadosSeparados;


        public Protocolo(string dadosBrutos) {

            this.dadosBrutos = dadosBrutos;
        }

        public string[] SeparaDados(char[] separador)
        {
            return this.DadosSeparados = this.dadosBrutos.Split(separador);  
        }

        public double ConverteParaDouble(string Valor)
        {
            double valoresConvertidos;            
            if (double.TryParse(Valor, NumberStyles.Any, CultureInfo.InvariantCulture, out valoresConvertidos))
            {              
                return valoresConvertidos;
            }
                return -1;
        }    

        public double[] TodosOsDoubles()
        {
            List<double> valores = new List<double>();

            for (int i = 0; i < this.DadosSeparados.Length; i++)
            {
                double valorConvertido = this.ConverteParaDouble(this.DadosSeparados[i]);
                if(valorConvertido != -1)
                {
                    valores.Add(valorConvertido);
                }
            
            }   
            return valores.ToArray();
        }

        public bool VerificarExistenciaDe(String identificador)
        {
            foreach(string palavras in this.DadosSeparados)
            {
                if (palavras.Contains(identificador))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
