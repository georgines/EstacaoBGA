namespace supervisorio3
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPagePortas = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPorta = new System.Windows.Forms.ComboBox();
            this.tabPageConfiguracoes = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxModo = new System.Windows.Forms.CheckBox();
            this.buttonEnviarConfiguracoes = new System.Windows.Forms.Button();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxReferencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageGanhos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonEnviarGanho1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKd1 = new System.Windows.Forms.TextBox();
            this.textBoxKi1 = new System.Windows.Forms.TextBox();
            this.textBoxKp1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMonitor = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageDadosSeriais = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRecebido = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBoxLF = new System.Windows.Forms.CheckBox();
            this.buttonEnviarPelaSerial = new System.Windows.Forms.Button();
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.textBoxTrasmitido = new System.Windows.Forms.TextBox();
            this.tabPageComandos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewComandos = new System.Windows.Forms.DataGridView();
            this.ColumnEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalvar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPagePortas.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageConfiguracoes.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageGanhos.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageDadosSeriais.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageComandos.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.933434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.06657F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 630);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 630F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1002, 630);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPagePortas);
            this.tabControl2.Controls.Add(this.tabPageConfiguracoes);
            this.tabControl2.Controls.Add(this.tabPageGanhos);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(194, 624);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPagePortas
            // 
            this.tabPagePortas.Controls.Add(this.tableLayoutPanel4);
            this.tabPagePortas.Location = new System.Drawing.Point(4, 22);
            this.tabPagePortas.Name = "tabPagePortas";
            this.tabPagePortas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePortas.Size = new System.Drawing.Size(186, 598);
            this.tabPagePortas.TabIndex = 0;
            this.tabPagePortas.Text = "Portas";
            this.tabPagePortas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(180, 592);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonConectar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxBaud);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxPorta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 586);
            this.panel2.TabIndex = 0;
            // 
            // buttonConectar
            // 
            this.buttonConectar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonConectar.Location = new System.Drawing.Point(78, 96);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(88, 23);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Baud";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(45, 60);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaud.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porta";
            // 
            // comboBoxPorta
            // 
            this.comboBoxPorta.FormattingEnabled = true;
            this.comboBoxPorta.Location = new System.Drawing.Point(45, 23);
            this.comboBoxPorta.Name = "comboBoxPorta";
            this.comboBoxPorta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorta.TabIndex = 0;
            this.comboBoxPorta.Click += new System.EventHandler(this.CarregarTodoContedudo);
            // 
            // tabPageConfiguracoes
            // 
            this.tabPageConfiguracoes.Controls.Add(this.tableLayoutPanel3);
            this.tabPageConfiguracoes.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracoes.Name = "tabPageConfiguracoes";
            this.tabPageConfiguracoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguracoes.Size = new System.Drawing.Size(186, 598);
            this.tabPageConfiguracoes.TabIndex = 1;
            this.tabPageConfiguracoes.Text = "Configurações";
            this.tabPageConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.98602F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.01398F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(180, 592);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.checkBoxModo);
            this.panel3.Controls.Add(this.buttonEnviarConfiguracoes);
            this.panel3.Controls.Add(this.textBoxSaida);
            this.panel3.Controls.Add(this.textBoxEntrada);
            this.panel3.Controls.Add(this.textBoxReferencia);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 224);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(13, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Modo";
            // 
            // checkBoxModo
            // 
            this.checkBoxModo.AutoSize = true;
            this.checkBoxModo.Location = new System.Drawing.Point(60, 108);
            this.checkBoxModo.Name = "checkBoxModo";
            this.checkBoxModo.Size = new System.Drawing.Size(61, 17);
            this.checkBoxModo.TabIndex = 7;
            this.checkBoxModo.Text = "Manual";
            this.checkBoxModo.UseVisualStyleBackColor = true;
            this.checkBoxModo.CheckedChanged += new System.EventHandler(this.checkBoxModo_CheckedChanged);
            // 
            // buttonEnviarConfiguracoes
            // 
            this.buttonEnviarConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnviarConfiguracoes.Location = new System.Drawing.Point(3, 194);
            this.buttonEnviarConfiguracoes.Name = "buttonEnviarConfiguracoes";
            this.buttonEnviarConfiguracoes.Size = new System.Drawing.Size(169, 23);
            this.buttonEnviarConfiguracoes.TabIndex = 6;
            this.buttonEnviarConfiguracoes.Text = "Enviar";
            this.buttonEnviarConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Location = new System.Drawing.Point(60, 82);
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.Size = new System.Drawing.Size(103, 20);
            this.textBoxSaida.TabIndex = 5;
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(60, 56);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(103, 20);
            this.textBoxEntrada.TabIndex = 4;
            // 
            // textBoxReferencia
            // 
            this.textBoxReferencia.Location = new System.Drawing.Point(60, 30);
            this.textBoxReferencia.Name = "textBoxReferencia";
            this.textBoxReferencia.Size = new System.Drawing.Size(103, 20);
            this.textBoxReferencia.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(13, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Saida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(13, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Entrada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(13, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ref";
            // 
            // tabPageGanhos
            // 
            this.tabPageGanhos.Controls.Add(this.tableLayoutPanel5);
            this.tabPageGanhos.Location = new System.Drawing.Point(4, 22);
            this.tabPageGanhos.Name = "tabPageGanhos";
            this.tabPageGanhos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGanhos.Size = new System.Drawing.Size(186, 598);
            this.tabPageGanhos.TabIndex = 2;
            this.tabPageGanhos.Text = "Ganhos";
            this.tabPageGanhos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.32168F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.5035F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(180, 592);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.buttonEnviarGanho1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBoxKd1);
            this.panel4.Controls.Add(this.textBoxKi1);
            this.panel4.Controls.Add(this.textBoxKp1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 161);
            this.panel4.TabIndex = 1;
            // 
            // buttonEnviarGanho1
            // 
            this.buttonEnviarGanho1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnviarGanho1.Location = new System.Drawing.Point(-14, 125);
            this.buttonEnviarGanho1.Name = "buttonEnviarGanho1";
            this.buttonEnviarGanho1.Size = new System.Drawing.Size(169, 23);
            this.buttonEnviarGanho1.TabIndex = 6;
            this.buttonEnviarGanho1.Text = "Enviar";
            this.buttonEnviarGanho1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ganho 1";
            // 
            // textBoxKd1
            // 
            this.textBoxKd1.Location = new System.Drawing.Point(36, 82);
            this.textBoxKd1.Name = "textBoxKd1";
            this.textBoxKd1.Size = new System.Drawing.Size(127, 20);
            this.textBoxKd1.TabIndex = 5;
            // 
            // textBoxKi1
            // 
            this.textBoxKi1.Location = new System.Drawing.Point(36, 56);
            this.textBoxKi1.Name = "textBoxKi1";
            this.textBoxKi1.Size = new System.Drawing.Size(127, 20);
            this.textBoxKi1.TabIndex = 4;
            // 
            // textBoxKp1
            // 
            this.textBoxKp1.Location = new System.Drawing.Point(36, 30);
            this.textBoxKp1.Name = "textBoxKp1";
            this.textBoxKp1.Size = new System.Drawing.Size(127, 20);
            this.textBoxKp1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMonitor);
            this.tabControl1.Controls.Add(this.tabPageDadosSeriais);
            this.tabControl1.Controls.Add(this.tabPageComandos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(203, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 624);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageMonitor
            // 
            this.tabPageMonitor.Controls.Add(this.chart1);
            this.tabPageMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonitor.Name = "tabPageMonitor";
            this.tabPageMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonitor.Size = new System.Drawing.Size(788, 598);
            this.tabPageMonitor.TabIndex = 0;
            this.tabPageMonitor.Text = "Monitor";
            this.tabPageMonitor.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.AxisX.Title = "Tempo";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.Title = "Temperatura";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.Name = "ChartArea1";
            chartArea4.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Entrada";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Set Point";
            series6.ChartArea = "ChartArea2";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Saida";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(782, 592);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // tabPageDadosSeriais
            // 
            this.tabPageDadosSeriais.Controls.Add(this.tableLayoutPanel7);
            this.tabPageDadosSeriais.Location = new System.Drawing.Point(4, 22);
            this.tabPageDadosSeriais.Name = "tabPageDadosSeriais";
            this.tabPageDadosSeriais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosSeriais.Size = new System.Drawing.Size(788, 598);
            this.tabPageDadosSeriais.TabIndex = 1;
            this.tabPageDadosSeriais.Text = "Dados Seriais";
            this.tabPageDadosSeriais.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.textBoxRecebido, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76224F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.23776F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(782, 592);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // textBoxRecebido
            // 
            this.textBoxRecebido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRecebido.Location = new System.Drawing.Point(3, 78);
            this.textBoxRecebido.Multiline = true;
            this.textBoxRecebido.Name = "textBoxRecebido";
            this.textBoxRecebido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecebido.Size = new System.Drawing.Size(776, 511);
            this.textBoxRecebido.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBoxLF);
            this.panel5.Controls.Add(this.buttonEnviarPelaSerial);
            this.panel5.Controls.Add(this.checkBoxCR);
            this.panel5.Controls.Add(this.textBoxTrasmitido);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(776, 69);
            this.panel5.TabIndex = 1;
            // 
            // checkBoxLF
            // 
            this.checkBoxLF.AutoSize = true;
            this.checkBoxLF.Checked = true;
            this.checkBoxLF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLF.Location = new System.Drawing.Point(62, 45);
            this.checkBoxLF.Name = "checkBoxLF";
            this.checkBoxLF.Size = new System.Drawing.Size(38, 17);
            this.checkBoxLF.TabIndex = 3;
            this.checkBoxLF.Text = "LF";
            this.checkBoxLF.UseVisualStyleBackColor = true;
            // 
            // buttonEnviarPelaSerial
            // 
            this.buttonEnviarPelaSerial.Location = new System.Drawing.Point(364, 18);
            this.buttonEnviarPelaSerial.Name = "buttonEnviarPelaSerial";
            this.buttonEnviarPelaSerial.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviarPelaSerial.TabIndex = 2;
            this.buttonEnviarPelaSerial.Text = "Enviar";
            this.buttonEnviarPelaSerial.UseVisualStyleBackColor = true;
            this.buttonEnviarPelaSerial.Click += new System.EventHandler(this.buttonEnviarPelaSerial_Click);
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.Checked = true;
            this.checkBoxCR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCR.Location = new System.Drawing.Point(15, 45);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(41, 17);
            this.checkBoxCR.TabIndex = 1;
            this.checkBoxCR.Text = "CR";
            this.checkBoxCR.UseVisualStyleBackColor = true;
            // 
            // textBoxTrasmitido
            // 
            this.textBoxTrasmitido.Location = new System.Drawing.Point(15, 19);
            this.textBoxTrasmitido.Name = "textBoxTrasmitido";
            this.textBoxTrasmitido.Size = new System.Drawing.Size(343, 20);
            this.textBoxTrasmitido.TabIndex = 0;
            // 
            // tabPageComandos
            // 
            this.tabPageComandos.Controls.Add(this.tableLayoutPanel6);
            this.tabPageComandos.Location = new System.Drawing.Point(4, 22);
            this.tabPageComandos.Name = "tabPageComandos";
            this.tabPageComandos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComandos.Size = new System.Drawing.Size(788, 598);
            this.tabPageComandos.TabIndex = 2;
            this.tabPageComandos.Text = "Comandos";
            this.tabPageComandos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.89514F));
            this.tableLayoutPanel6.Controls.Add(this.dataGridViewComandos, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(782, 592);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // dataGridViewComandos
            // 
            this.dataGridViewComandos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEvento,
            this.ColumnAcao,
            this.ColumnSalvar});
            this.dataGridViewComandos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewComandos.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewComandos.Name = "dataGridViewComandos";
            this.dataGridViewComandos.Size = new System.Drawing.Size(776, 290);
            this.dataGridViewComandos.TabIndex = 13;
            // 
            // ColumnEvento
            // 
            this.ColumnEvento.HeaderText = "Evento";
            this.ColumnEvento.Name = "ColumnEvento";
            this.ColumnEvento.ReadOnly = true;
            // 
            // ColumnAcao
            // 
            this.ColumnAcao.HeaderText = "Ação";
            this.ColumnAcao.Name = "ColumnAcao";
            // 
            // ColumnSalvar
            // 
            this.ColumnSalvar.HeaderText = "Salvar";
            this.ColumnSalvar.Name = "ColumnSalvar";
            this.ColumnSalvar.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tune PID library";
            this.Load += new System.EventHandler(this.CarregarTodoContedudo);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPagePortas.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageConfiguracoes.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageGanhos.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageDadosSeriais.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageComandos.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandos)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPagePortas;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonConectar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxBaud;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxPorta;
		private System.Windows.Forms.TabPage tabPageConfiguracoes;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBoxModo;
		private System.Windows.Forms.Button buttonEnviarConfiguracoes;
		private System.Windows.Forms.TextBox textBoxSaida;
		private System.Windows.Forms.TextBox textBoxEntrada;
		private System.Windows.Forms.TextBox textBoxReferencia;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabPage tabPageGanhos;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button buttonEnviarGanho1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxKd1;
		private System.Windows.Forms.TextBox textBoxKi1;
		private System.Windows.Forms.TextBox textBoxKp1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageMonitor;
		private System.Windows.Forms.TabPage tabPageDadosSeriais;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.TextBox textBoxRecebido;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button buttonEnviarPelaSerial;
		private System.Windows.Forms.CheckBox checkBoxCR;
		private System.Windows.Forms.TextBox textBoxTrasmitido;
		private System.Windows.Forms.CheckBox checkBoxLF;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.TabPage tabPageComandos;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.DataGridView dataGridViewComandos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAcao;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSalvar;
    }
}

