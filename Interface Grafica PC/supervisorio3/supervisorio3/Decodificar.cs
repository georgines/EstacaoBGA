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

	public class Decodificar
	{
		private Chart Monitor;
		private int TotalGraficos;
		private String dados;
		private String Saida;
		private String FloatValidos;


		public void DadosRecebidos(String dadosRecebidos)
		{
			this.dados = dadosRecebidos;			
		}
		public String ExibirTexto()
		{
			processarSaida();
			return this.Saida;

		}

		public void limparCache()
		{
			this.Saida = null;
			this.FloatValidos = null;
		}

		public int contarDoublesPorTabulacao(Chart Monitor, long Tempo)
		{
			var ChartA0 = Monitor.ChartAreas[0];
			ChartA0.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

			ChartA0.AxisX.LabelStyle.Format = "";
			ChartA0.AxisY.LabelStyle.Format = "";
			ChartA0.AxisX.LabelStyle.IsEndLabelVisible = false;

			ChartA0.AxisX.MajorGrid.LineColor = Color.LightGray;
			ChartA0.AxisY.MajorGrid.LineColor = Color.LightGray;

			ChartA0.AxisX.Interval = 1;
			ChartA0.AxisY.Interval = 350/10;
			ChartA0.AxisY.Maximum = 350;
			ChartA0.AxisY.Minimum = 0;

			ChartA0.AxisY.Title = "Temperatura (°C)";
			ChartA0.AxisY.TitleFont = new Font("Arial", 9, FontStyle.Regular);
			ChartA0.AxisX.Title = "";
			ChartA0.AxisX.TitleFont = new Font("Arial", 9, FontStyle.Regular);


			var ChartA1 = Monitor.ChartAreas[1];
			ChartA1.AxisX.IntervalType = DateTimeIntervalType.Number;

			ChartA1.AxisX.LabelStyle.Format = "";
			ChartA1.AxisY.LabelStyle.Format = "";
			ChartA1.AxisX.LabelStyle.IsEndLabelVisible = false;

			ChartA1.AxisX.MajorGrid.LineColor = Color.LightGray;
			ChartA1.AxisY.MajorGrid.LineColor = Color.LightGray;

			ChartA1.AxisX.Interval = 1;
			ChartA1.AxisY.Interval = 100 / 10;
			ChartA1.AxisY.Maximum = 100;
			ChartA1.AxisY.Minimum = 0;

			ChartA1.AxisY.Title = "Porcentagem (%)";
			ChartA1.AxisY.TitleFont = new Font("Arial", 9, FontStyle.Regular);
			ChartA1.AxisX.Title = "Tempo (s)";
			ChartA1.AxisX.TitleFont = new Font("Arial",9, FontStyle.Regular);



			String dadosGrafico = this.Saida;

			char[] tabulacaoHorizontal = new char[] { '\t' };			
			string[] StringsDivididas = dadosGrafico.Split(tabulacaoHorizontal, StringSplitOptions.None);

            double dadoFlutuante;
            int indice2 = 0;

			for (int indice = 0; indice < StringsDivididas.Length; indice++)
			{
				if (double.TryParse(StringsDivididas[indice], NumberStyles.Any, CultureInfo.InvariantCulture, out dadoFlutuante))
				{

					if(Monitor.Series[indice2].Points.Count > 20)
					{
						Monitor.Series[indice2].Points.RemoveAt(0);
						Monitor.Update();
					}
					Monitor.Series[indice2].Points.AddXY(Tempo, dadoFlutuante);
					
					this.FloatValidos += dadoFlutuante.ToString()+"#";
					indice2++;
				}

			}
			return indice2;
		}

		public String PegarFloatValidos()
		{
			String resultado = this.FloatValidos;
			limparCache();
			return resultado;
		}

		public void AdicionarPontoNoGrafico(Chart grafico, long tempo)
		{
			this.Monitor = grafico;
			this.TotalGraficos = contarDoublesPorTabulacao(grafico, tempo);
		}

		public void apagarTodosOsPontoDoGrafico()
		{
			for(int i = 0; i < this.TotalGraficos; i++)
			{
				this.Monitor.Series[i].Points.Clear();
			}
		}


		private void processarSaida()
		{
			String textoTotal = "";
			char tabVertical = '\n';

			String[] linha = dados.Split(tabVertical);
			for (int i = 0; i < linha.Length; i++)
			{
				textoTotal += linha[i] + "\n";
			}

			char retornoCarro = '\r';
			String[] retorno = textoTotal.Split(retornoCarro);
			for (int i = 0; i < retorno.Length; i++)
			{
				this.Saida += retorno[i] + "\r";
			}
		}




	}
}
