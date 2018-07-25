using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace supervisorio3
{
    internal class Trasmitir
    {
        private SerialPort porta;
       

        public void pegarPorta(SerialPort serialPort)
        {
            this.porta = serialPort;
        }

        public bool enviarOuMensagem(String dados)
        {
            if (this.porta.IsOpen == true)
            {
                this.porta.Write(dados);
                return true;
            }
            else
            {
                
                MessageBox.Show("Nenhuma porta serial aberta!");
                return false;
            }
          
        }

        public bool enviarOuMensagem(String dados, string mensagem)
        {
            if (this.porta.IsOpen == true)
            {
                this.porta.Write(dados);
                return true;
            }
            else
            {

                MessageBox.Show(mensagem);
                return false;
            }

        }

        public bool fechaConexao()
        {
            porta.Close();
            if (porta.IsOpen == true)
            {
                return true;
            }
            return false;

        }

    }
}
