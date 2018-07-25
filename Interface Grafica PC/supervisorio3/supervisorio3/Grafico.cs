using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace supervisorio3
{
    internal class Grafico
    {
        private Chart grafico;
        private TextBoxBase textbox;
        private bool exibir = false;
        public int ValorMaximoY1 { get; set; } = 350;
        public int ValorMaximoY2 { get; set; } = 100;
        public int IntervaloY1 { get; set; } = 10;
        public int IntervaloY2 { get; set; } = 10;
        public int IntervaloX { get; set; } = 60;
        public string NomeEixoY1 { get; set; } = "Temperatura (°C)";
        public string NomeEixoY2 { get; set; } = "Porcentagem (%)";
        public string NomeEixoX { get; set; } = "Tempo (s)";
        public string IdentificadorGrafico { get; set; } = "967";

        public void setaGrafico(Chart grafico)
        {
            this.grafico = grafico;
        }

        public Chart Configurar()
        {
            var ChartA0 = this. grafico.ChartAreas[0];
            ChartA0.AxisX.IntervalType = DateTimeIntervalType.Number;

            ChartA0.AxisX.LabelStyle.Format = "";
            ChartA0.AxisY.LabelStyle.Format = "";
            ChartA0.AxisX.LabelStyle.IsEndLabelVisible = false;

            ChartA0.AxisX.MajorGrid.LineColor = Color.LightGray;
            ChartA0.AxisY.MajorGrid.LineColor = Color.LightGray;

            ChartA0.AxisX.Interval = 1;
            ChartA0.AxisY.Interval = ValorMaximoY1 / IntervaloY1;
            ChartA0.AxisY.Maximum = ValorMaximoY1;
            ChartA0.AxisY.Minimum = 0;

            ChartA0.AxisY.Title = NomeEixoY1;
            ChartA0.AxisY.TitleFont = new Font("Arial", 9, FontStyle.Regular);
            ChartA0.AxisX.Title = "";
            ChartA0.AxisX.TitleFont = new Font("Arial", 9, FontStyle.Regular);


            var ChartA1 = this.grafico.ChartAreas[1];
            ChartA1.AxisX.IntervalType = DateTimeIntervalType.Number;

            ChartA1.AxisX.LabelStyle.Format = "";
            ChartA1.AxisY.LabelStyle.Format = "";
            ChartA1.AxisX.LabelStyle.IsEndLabelVisible = false;

            ChartA1.AxisX.MajorGrid.LineColor = Color.LightGray;
            ChartA1.AxisY.MajorGrid.LineColor = Color.LightGray;

            ChartA1.AxisX.Interval = 1;
            ChartA1.AxisY.Interval = ValorMaximoY2 / IntervaloY2;
            ChartA1.AxisY.Maximum = ValorMaximoY2;
            ChartA1.AxisY.Minimum = 0;

            ChartA1.AxisY.Title = NomeEixoY2;
            ChartA1.AxisY.TitleFont = new Font("Arial", 9, FontStyle.Regular);
            ChartA1.AxisX.Title = NomeEixoX;
            ChartA1.AxisX.TitleFont = new Font("Arial", 9, FontStyle.Regular);
            return this.grafico;
        }

        public void AdicionarPontoXYSerie(double x, double y, int series)
        {
            this.grafico.Series[series].Points.AddXY(x,y);
           
        }

        public void AdicionarPontosXYSeries(double x, double[] y)
        {
            int quantidadeSeries = QuantidadeSeries();
            for (int serie = 0; serie < quantidadeSeries; serie++)
            {
                RemoverPontoSerieApartirDe(IntervaloX, serie);
                AdicionarPontoXYSerie(x, y[serie], serie);
                if (exibir == true)
                {
                    string nomeSerie = this.grafico.Series[serie].Name.ToString();
                    String log = "[ ";
                    log += nomeSerie + " ] X: ";
                    log += x.ToString() + " ; Y: ";
                    log += y[serie].ToString() + "\n";                    
                    this.textbox.AppendText(log);

                }

            }
               

        }

        public void RemoverPontoSerieApartirDe(int quantidadePontos, int series)
        {
            if (this.grafico.Series[series].Points.Count > quantidadePontos)
            {
                this.grafico.Series[series].Points.RemoveAt(0);
                this.grafico.Update();
            }
        }

        public int QuantidadeSeries()
        {
            int quantidade =  this.grafico.Series.Count();
            return quantidade;
        }


        public void ExibirEm(TextBoxBase textbox)
        {

            this.exibir = true;
            this.textbox = textbox;
        }

        public void CancelarExibicao()
        {
            this.exibir = false;          
        }
    }
}
