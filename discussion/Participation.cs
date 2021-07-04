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
    public partial class Participation : Form
    {
        public string MyPseudo { get; set; }
        public List<srv.Participant> Participants { get; set; }
        public Participation()
        {
            InitializeComponent();
        }
        public Participation(string pseudo, List<srv.Participant> participants)
        {
            InitializeComponent();
            MyPseudo = pseudo;
            Participants = participants.ToList();
            
        }

        private void Participation_Load(object sender, EventArgs e)
        {
            Text = "Mon pseudo est :" + MyPseudo;
            lstParticipants.DisplayMember = "Pseudo";
            lstParticipants.DataSource = Participants.Where(p=> !p.Pseudo.Equals(MyPseudo)).ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MessageTo = lstParticipants.GetItemText(lstParticipants.SelectedItem);
            //MessageTo = "hello ???";
            TextBox textControl = new TextBox();
            textControl.Size = new System.Drawing.Size(539, 100);


            //textControl.AutoSizeChanged(false);
            String Messag = txtMessage.Text;
            DateTime date = DateTime.Now;
            string AllMessage= "Message To " + MessageTo + " : " + Messag + "    ." +date ;
            textControl.Text =AllMessage;
            //if (MyPseudo== MessageTo)
            MRecusPanel.Controls.Add(textControl); 
        }
    }
}
