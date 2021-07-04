using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discussion
{
    public partial class demande : Form
    {
       srv.ws_chatSoapClient srvChat = new srv.ws_chatSoapClient();
        public demande()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                srv.Participant[] participants = srvChat.Participer(txtPseudo.Text);


                if (participants == null) Text = "votre pseudo est déja utilisé , veuillez choisir un autre identifiant pour se connecter";
                else
                {
                    Participation participation = new Participation(txtPseudo.Text, participants.ToList());
                    participation.Show();

                }
            }
            catch(Exception E) { }
            
        }
    }
}
