using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceFinder.Model;
using ReferenceFinder.Controller;

namespace ReferenceFinder.View
{
    public partial class Chat : Form
    {
        public String strReferencia;
        public StringBuilder backup;
        public CReferencia ReferenciaController = new CReferencia();
        public CLivro LivroController = new CLivro();
        public MReferencia ReferenciaModel = new MReferencia();

        public Chat()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }

        private void TxtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Enviar();
            }
        }

        /*---------------------------------------------------------------------------------------------*/
        public void Enviar()
        {
            strReferencia = TxtReferencia.Text;
            ListChat.Items.Add(strReferencia);
            TxtReferencia.Text = "";
            ReferenciaModel = ReferenciaController.PopularReferencia(strReferencia);
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            LivroController.PopularLivros();
        }
    }
}
