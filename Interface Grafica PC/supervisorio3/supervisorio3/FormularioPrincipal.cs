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
using System.Windows.Forms.DataVisualization.Charting;

namespace supervisorio3
{
    public partial class FormularioPrincipal : Form
    {
        private delegate void FuncaoRecepcao();

        private Grafico ObjGrafico = new Grafico();
        private Estruturas ObjEstruturaEnvio = new Estruturas();
        private Trasmitir ObjSerial = new Trasmitir() ;
        private long tempoX = 0;

        public FormularioPrincipal()
        {            
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1RecebimentoDeDados);
            CarregarPersonalizacaoDeGrafico();
            ObjSerial.pegarPorta(serialPort1);
            ObjGrafico.setaGrafico(chart1);
            ObjGrafico.Configurar();

        }

        private void buttonFechar_Click(object sender, EventArgs e) => Application.Exit();

        private void ButtonMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void ButtonMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
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
            catch (Exception)
            {

            }
            #endregion
        }

        private bool estado_do_botao = false;
        private void ButtonConectar_Click(object sender, EventArgs e)
        {
            #region conexao serial
            try
            {

                

                if (serialPort1.IsOpen == false && estado_do_botao == false)
                {
                    serialPort1.PortName = comboBoxPorta.Text;
                    serialPort1.BaudRate = int.Parse(comboBoxBaud.Text);
                    serialPort1.Open();
                    buttonConectar.Text = "Desconectar";
                    estado_do_botao = true;
                    comboBoxBaud.Enabled = false;
                    comboBoxPorta.Enabled = false;
                    serialPort1.Write("0\t0\t0\t1853\t0\t0\t0\t0\r\n");
                  
                }
                else
                {
                    serialPort1.Close();
                    buttonConectar.Text = "Conectar";
                    estado_do_botao = false;
                    comboBoxBaud.Enabled = true;
                    comboBoxPorta.Enabled = true;
                    //CHART
                    for (int i = 0; i < 3; i++)
                    {
                        chart1.Series[i].Points.Clear();
                    }
                    //TEMPO
                    tempoX = 0;
                    //TEXT AREA
                    textBoxRecebido.Clear();
                    textBoxEnviado.Clear();
                   
                }

            }
            catch (InvalidOperationException ex)
            {
               
                //TODO remover
                MessageBox.Show("Erro: " + ex.Message);
              
            }
            catch (UnauthorizedAccessException ex)
            {
               
                //TODO remover
                MessageBox.Show("Erro: " + ex.Message);
               
            }
            #endregion
        }

        private void buttonEnviarPelaSerial_Click(object sender, EventArgs e)
        {
            #region EviarPelaSerial
            try
            {
                String dadosParaEnvio;
                if (serialPort1.IsOpen == true)
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
                    textBoxEnviado.AppendText(dadosParaEnvio);
                    textBoxTrasmitido.Clear();                  
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
                string dadosBrutos = serialPort1.ReadLine();            
              
               // textBoxRecebido.AppendText(dadosBrutos);
                #region dados do grafico
                textBoxRecebido.AppendText(dadosBrutos + "\n");

                Protocolo ObjDados = new Protocolo(dadosBrutos);                

                ObjDados.SeparaDados(new char[] { '\t' });                
                TratarDadosRecebidos(ObjDados.TodosOsDoubles());              
                
                #endregion
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erro na recepção serial!");           
            }
            catch (TimeoutException e)
            {
                MessageBox.Show("Tempo esgotado, nenhum byte foi lido!");
            }
            catch (Exception e)
            {
                //TODO remover
                MessageBox.Show("Erro: "+e.Message);              
            }
            #endregion            
        }

       //Eventos
        private void ButtonLimparRecebido_Click(object sender, EventArgs e)
        {
            textBoxRecebido.Clear();
            textBoxEnviado.Clear();
        }

        private void CarregarPersonalizacaoDeGrafico()
        {
            textBoxValMaxY1.Text =  ObjGrafico.ValorMaximoY1.ToString();
            textBoxValMaxY2.Text = ObjGrafico.ValorMaximoY2.ToString();
            textBoxIntervaloY1.Text = ObjGrafico.IntervaloY1.ToString();
            textBoxIntervaloY2.Text = ObjGrafico.IntervaloY2.ToString(); ;
            textBoxIntervaloX.Text = ObjGrafico.IntervaloX.ToString();
            textBoxNomeEixoY1.Text = ObjGrafico.NomeEixoY1.ToString();
            textBoxNomeEixoY2.Text = ObjGrafico.NomeEixoY2.ToString();
            textBoxNomeEixoX.Text = ObjGrafico.NomeEixoX.ToString();
            textBoxIdentGraf.Text = ObjGrafico.IdentificadorGrafico.ToString();
        }

        private void buttonSalvarConfig_Click(object sender, EventArgs e)
        {
            try
            {
               
                ObjGrafico.ValorMaximoY1 = int.Parse(textBoxValMaxY1.Text.ToString());
                ObjGrafico.ValorMaximoY2 = int.Parse(textBoxValMaxY2.Text.ToString());
                ObjGrafico.IntervaloY1 = int.Parse(textBoxIntervaloY1.Text.ToString());
                ObjGrafico.IntervaloY2 = int.Parse(textBoxIntervaloY2.Text.ToString());
                ObjGrafico.IntervaloX = int.Parse(textBoxIntervaloX.Text.ToString());
                ObjGrafico.NomeEixoY1 = textBoxNomeEixoY1.Text.ToString();
                ObjGrafico.NomeEixoY2 = textBoxNomeEixoY2.Text.ToString();
                ObjGrafico.NomeEixoX = textBoxNomeEixoX.Text.ToString();
                ObjGrafico.IdentificadorGrafico = textBoxIdentGraf.Text.ToString();
                ObjGrafico.Configurar();
            }
            catch
            {
                MessageBox.Show("Erro no preenchimento do formulário, verifique se colocou caractere no lugar de numeros!");
            }
            
            
        }

        private bool estadoCheckBoxModo = false;
        private string valEstadoCheckBoxModo = "0";
        private bool estadoT1;
        private bool estadoT2;
        private void checkBoxModo_CheckedChanged(object sender, EventArgs e)
        {
            estadoCheckBoxModo = !estadoCheckBoxModo;
            if(estadoCheckBoxModo == false)
            {
                checkBoxModo.Text = "Manual";
                textBoxSaida.Enabled = true;
                textBoxReferencia.Enabled = false;
                valEstadoCheckBoxModo = "0";
                estadoT1 = true;
                estadoT2 = false;
            }
            else
            {
                textBoxSaida.Enabled = false;
                textBoxReferencia.Enabled = true;
                estadoT1 = false;
                estadoT2 = true;
                valEstadoCheckBoxModo = "1";
                checkBoxModo.Text = "Automático";
            }
        }
        
        private void buttonEnviarConfiguracoes_Click(object sender, EventArgs e)
        {
            
            string endereco = "1";
            string referencia = textBoxReferencia.Text.ToString();
            string saidaManual = textBoxSaida.Text.ToString();
            string modo = valEstadoCheckBoxModo;
            string dados = ObjEstruturaEnvio.EnviaRef(endereco, referencia, saidaManual, modo);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                textBoxEnviado.AppendText(dados);
            }
        }

        private bool estadoCheckBoxSentido = false;
        private string valEstadoCheckBoxSentido = "1";
        private void checkBoxSentido_CheckedChanged(object sender, EventArgs e)
        {
            estadoCheckBoxSentido = !estadoCheckBoxSentido;
            if (estadoCheckBoxSentido == false)
            {
                valEstadoCheckBoxSentido = "1";
                checkBoxSentido.Text = "Direto";                
            }
            else
            {
                valEstadoCheckBoxSentido = "0";
                checkBoxSentido.Text = "Reverso";
            }
        }

        private void buttonEnviarManualTune_Click(object sender, EventArgs e)
        {
            string endereco = "1";
            string kp = textBoxKp.Text.ToString();
            string ki = textBoxKi.Text.ToString();
            string kd = textBoxKd.Text.ToString();
            string direcao = valEstadoCheckBoxSentido;
            string periodo = textBoxPeriodoSaida.Text.ToString();
            string dados = ObjEstruturaEnvio.EnviaTune(endereco, kp, ki, kd, direcao, periodo);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                textBoxEnviado.AppendText(dados);
            }


        }

        private bool estadoCheckBoxAutoTune = true;
        private String valEstadoCheckBoxAutoTune = "0";

        private void checkBoxEstadoAutoTune_CheckedChanged(object sender, EventArgs e)
        {
            estadoCheckBoxAutoTune = !estadoCheckBoxAutoTune;
            if (estadoCheckBoxAutoTune == false)
            {
                textBoxSaida.Enabled = estadoT1;
                textBoxReferencia.Enabled = estadoT2;
                checkBoxModo.Enabled = true;
                buttonEnviarConfiguracoes.Enabled = true;

                textBoxKp.Enabled = true;
                textBoxKi.Enabled = true;
                textBoxKd.Enabled = true;
                textBoxPeriodoSaida.Enabled = true;
                checkBoxSentido.Enabled = true;
                buttonEnviarManualTune.Enabled = true;               
                


                valEstadoCheckBoxAutoTune = "0";
                checkBoxEstadoAutoTune.Text = "Desligado";
            }
            else
            {
                textBoxSaida.Enabled = false;
                textBoxReferencia.Enabled = false;
                checkBoxModo.Enabled = false;
                buttonEnviarConfiguracoes.Enabled = false;

                textBoxKp.Enabled = false;
                textBoxKi.Enabled = false;
                textBoxKd.Enabled = false;
                textBoxPeriodoSaida.Enabled = false;
                checkBoxSentido.Enabled = false;
                buttonEnviarManualTune.Enabled = false;

                valEstadoCheckBoxAutoTune = "1";
                checkBoxEstadoAutoTune.Text = "Ligado";
            }
        }

        private void buttonEnviarAutoTune_Click(object sender, EventArgs e)
        {
            string endereco = "1";
            string passo = textBoxPassoSaida.Text.ToString();
            string ruido = textBoxNivelRuido.Text.ToString();
            string lookback = textBoxLookBack.Text.ToString();
            string estado = valEstadoCheckBoxAutoTune;
            string dados = ObjEstruturaEnvio.EnviaAutoTune(endereco, passo, ruido, lookback, estado);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                textBoxEnviado.AppendText(dados);
            }
        }

        private bool statusBotaoSaida1 = true;
        private void buttonSaida1_Click(object sender, EventArgs e)
        {
            #region Botao de saida 1
            string valor;
            string endereco = "1";
            string dados;



            if (statusBotaoSaida1 == false)
            {
                buttonSaida1.Text = "Desligado";
                valor = "0";
            }
            else
            {
                valor = "1";
                buttonSaida1.Text = "ligado";
            }
            dados = ObjEstruturaEnvio.EnviaBotaoSaida(endereco, valor);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                statusBotaoSaida1 = !statusBotaoSaida1;
                textBoxEnviado.AppendText(dados);
            }

            #endregion
        }

        private void trackBarPwm1_Scroll(object sender, EventArgs e)
        {
            
            string valor = trackBarPwm1.Value.ToString();
            string endereco = "1";
            string dados = ObjEstruturaEnvio.EnviaPwm(endereco, valor);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                textBoxEnviado.AppendText(dados);
            }
        }

        private void trackBarPwm1_MouseUp(object sender, MouseEventArgs e)
        {
            string valor = trackBarPwm1.Value.ToString();
            string endereco = "1";
            string dados = ObjEstruturaEnvio.EnviaPwm(endereco, valor);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                textBoxEnviado.AppendText(dados);
            }
        }

        private bool statusBotaoSaida2 = false;
        private void buttonSaida2_Click(object sender, EventArgs e)
        {
            #region Botao de saida 2
            string valor;
            string endereco = "2";
            string dados;

            if (statusBotaoSaida2 == false)
            {
                buttonSaida2.Text = "Desligado";
                valor = "0";
            }
            else
            {
                valor = "1";
                buttonSaida2.Text = "Ligado";
            }
            dados = ObjEstruturaEnvio.EnviaBotaoSaida(endereco, valor);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                statusBotaoSaida2 = !statusBotaoSaida2;
                textBoxEnviado.AppendText(dados);
            }

            #endregion
        }

        private void trackBarPwm2_Scroll(object sender, EventArgs e)
        {
            string valor = trackBarPwm2.Value.ToString();
            string endereco = "2";
            string dados = ObjEstruturaEnvio.EnviaPwm(endereco, valor);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                textBoxEnviado.AppendText(dados);
            }
            
        }

        private void trackBarPwm2_MouseUp(object sender, MouseEventArgs e)
        {
            string valor = trackBarPwm2.Value.ToString();
            string endereco = "2";
            string dados = ObjEstruturaEnvio.EnviaPwm(endereco, valor);
            if (ObjSerial.enviarOuMensagem(dados))
            {
                textBoxEnviado.AppendText(dados);
            }
        }

        private void TratarDadosRecebidos(double[] dados)
        {
            if (dados.Count() == 8)
            {
                switch (dados[0])
                {
                    case 1:
                        PegarValoresPID(dados);
                        break;
                    case 2:
                        PegarValoresTune(dados);
                        break;
                    case 3:
                        PegarValoresAutoTune(dados);
                        break;
                    case 4:
                        PegarValoresPwm(dados);
                        break;
                    case 5:
                        PegarValoresSaidasDigitais(dados);
                        break;
                    case 967:
                        PegarValoresGrafico(dados);
                        tempoX++;
                        break;
                    default:
                        textBoxRecebido.AppendText("Nenhum identificador conhecido\r\n");
                        break;
                }
            }
            else
            {
                //MessageBox.Show("");
                textBoxRecebido.AppendText("Nada Encontrado\r\n");
            }
            
        }


        private void PegarValoresPID(double[] dados)
        {
            
           /* labelRef.Text = "Ref: " +dados[2].ToString();
            labelEntrada.Text = "Entrada: " + dados[3].ToString();
            labelSaida.Text = "Saida: " + dados[4].ToString();*/
            if(dados[5] == 1)
            {
                labelModo.Text = "Modo: " + "A";
            }
            else
            {
                labelModo.Text = "Modo: "+"M";
            }
            
        }

        private void PegarValoresTune(double[] dados)
        {
            labelKp.Text = "Kp: " + dados[2].ToString();
            labelKi.Text = "Ki: " + dados[3].ToString();
            labelKd.Text = "Kd: " + dados[4].ToString();
            if (dados[5] == 1)
            {
                labelSentido.Text = "Sentido: " + "D";
            }
            else
            {
                labelSentido.Text = "Sentido: " + "R";
            }
            labelPeriodo.Text = "Periodo: " + dados[6].ToString();
        }
        private void PegarValoresAutoTune(double[] dados)
        {
            labelPasso.Text = "Passo: " + dados[2].ToString();
            labelRuido.Text = "Ruido: " + dados[3].ToString();
            labelLookBack.Text = "Look Back: " + dados[4].ToString();
            if (dados[5] == 1)
            {
                labelEstado.Text = "Estado: " + "L";
            }
            else
            {
                labelEstado.Text = "Estado: " + "D";
            }
         
        }

        private void PegarValoresPwm(double[] dados)
        {
            if(dados[1] == 1)
            {
                labelValorPwm.Text =  dados[2].ToString();

            }
            else if (dados[1] == 2)
            {
                labelValorPwm2.Text = dados[2].ToString();
            }
         
           
            
        }

        private void PegarValoresSaidasDigitais(double[] dados)
        {
            if (dados[1] == 1)
            {
                if (dados[2] == 1)
                {
                    buttonSaida1.Text = "Ligado";
                    statusBotaoSaida1 = false;
                }
                else
                {
                    buttonSaida1.Text = "Desligado";
                    statusBotaoSaida1 = true;
                }


            }
            else if (dados[1] == 2)
            {
                if (dados[2] == 1)
                {
                    buttonSaida2.Text = "Ligado";
                    statusBotaoSaida2 = false;
                }
                else
                {
                    buttonSaida2.Text = "Desligado";
                    statusBotaoSaida2 = true;
                }
            }
        }

        private void PegarValoresGrafico(double[] dados)
        {
            double[] temporario  = new double[3] {0,0,0};
            labelRef.Text = "Ref: " + dados[2].ToString();
            labelEntrada.Text = "Entrada: " + dados[3].ToString();
            labelSaida.Text = "Saida: " + dados[4].ToString();
            temporario[0] = dados[2];
             temporario[1] = dados[3];
             temporario[2] = dados[4];
            ObjGrafico.AdicionarPontosXYSeries(tempoX, temporario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("André");
        }
    }
}
