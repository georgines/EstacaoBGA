using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;

namespace supervisorio3
{
	public partial class Form1 : Form
	{
        private delegate void FuncaoRecepcao();

        private Decodificar Objdecodificar  = new Decodificar();
        private bool estado_do_botao = false;
        private long tempo = 0 ;

		public Form1()
		{
			InitializeComponent();
			serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1RecebimentoDeDados);

			/*dataGridViewComandos.ColumnCount = 2;
			dataGridViewComandos.Columns[0].Name = "Evento";
			dataGridViewComandos.Columns[1].Name = "Parametros";

			var rows = new List<string[]>();

			string[] linha1 = new string[] { "Botao Enviar", "#enviar>valor" };
			rows.Add(linha1);

			string[] linha2 = new string[] { "Variavel Ki", "#Kp>valor" };
			rows.Add(linha2);

			foreach(string[] rowsArray in rows)
			{
				dataGridViewComandos.Rows.Add(rowsArray);
			}*/

		}

        private void SerialPort1RecebimentoDeDados(object sender, SerialDataReceivedEventArgs e)
		{
			FuncaoRecepcao teste = new FuncaoRecepcao(RecepcaoSerial);
			Invoke(teste);
		}

		private void CarregarTodoContedudo(object sender, EventArgs e)
		{
			#region ConfigiracaoPortaSerial
			try
			{
				comboBoxPorta.Items.Clear();
				comboBoxBaud.Items.Clear();
				String[] NomesPortas = SerialPort.GetPortNames();

				for (int i = 0; i < NomesPortas.Length; i++)
				{
					comboBoxPorta.Items.Add(NomesPortas[i]);
				}
				comboBoxPorta.Text = NomesPortas[0];

				int[] baudRates = { 9600, 115200 };

				for (int i = 0; i < baudRates.Length; i++)
				{
					comboBoxBaud.Items.Add(baudRates[i].ToString());
				}
				comboBoxBaud.Text = baudRates[0].ToString();
				
			}
			catch
			{
				
			}
			#endregion			
		}

		private void buttonConectar_Click(object sender, EventArgs e)
		{
			#region conexao serial
			try
			{

				serialPort1.ReadTimeout = 1000;

				if (serialPort1.IsOpen == false && estado_do_botao == false)
				{
					serialPort1.PortName = comboBoxPorta.Text;
					serialPort1.BaudRate = int.Parse(comboBoxBaud.Text);
					serialPort1.Open();
					buttonConectar.Text = "Desconectar";
					estado_do_botao = true;
					comboBoxBaud.Enabled = false;
					comboBoxPorta.Enabled = false;
					
					
				}
				else
				{
					serialPort1.Close();
					buttonConectar.Text = "Conectar";
					estado_do_botao = false;
					comboBoxBaud.Enabled = true;
					comboBoxPorta.Enabled = true;
					
					//CHART
					Objdecodificar.apagarTodosOsPontoDoGrafico();
					//TEMPO
					tempo = 0;
					//TEXT AREA
					textBoxRecebido.Text = null;
					//TAB PAGE
					
				}
			    
			}
			catch(InvalidOperationException a)
			{
				
				serialPort1.Close();
				MessageBox.Show(a.ToString());
				a.GetBaseException();

			}
			catch (UnauthorizedAccessException a)
			{

				serialPort1.Close();
				MessageBox.Show(a.ToString());
				a.GetBaseException();

			}
			#endregion
		}

		private void buttonEnviarPelaSerial_Click(object sender, EventArgs e)
		{
			#region EviarPelaSerial
			try
			{
				String dadosParaEnvio;
				if(serialPort1.IsOpen == true)
				{

					dadosParaEnvio = textBoxTrasmitido.Text;
					if (checkBoxCR.Checked == true)
					{
						dadosParaEnvio += "\r";
					}					
					if (checkBoxCR.Checked == true)
					{
						dadosParaEnvio += "\n";
					}
					

					serialPort1.Write(dadosParaEnvio);
					textBoxTrasmitido.Text = null;
					dadosParaEnvio = null;
				}
				else
				{

					MessageBox.Show("Nenhuma porta serial aberta!");
				}
				

			}
			catch
			{
				MessageBox.Show("Erro enviar pela serial!");
			}
			#endregion
		}

		public void RecepcaoSerial()
		{
			#region DadosRecebidosPelaSerial
			try
			{
				
				Objdecodificar.DadosRecebidos(serialPort1.ReadLine());
				textBoxRecebido.AppendText(Objdecodificar.ExibirTexto());	
				Objdecodificar.AdicionarPontoNoGrafico(chart1, tempo);
				Objdecodificar.PegarFloatValidos();
						
				
			}
			catch(InvalidOperationException e)
			{
				MessageBox.Show("Erro na recepção serial!");
				serialPort1.Close();
				e.GetBaseException();
			}
			catch(TimeoutException e)
			{
				MessageBox.Show("Tempo esgotado, nenhum byte foi lido!");				
				serialPort1.Close();
				e.GetBaseException();
			}


			#endregion

			tempo++;
		}

		private void checkBoxModo_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxModo.Checked == false)
			{
				textBoxReferencia.Enabled = false;
				textBoxEntrada.Enabled = false;
				textBoxSaida.Enabled = true;
				checkBoxModo.Text = "Manual";
			}
			else
			{
				checkBoxModo.Text = "Automático";
				textBoxReferencia.Enabled = true;
				textBoxEntrada.Enabled = false;
				textBoxSaida.Enabled = false;
			}
		}
	}
}
