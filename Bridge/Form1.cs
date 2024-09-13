using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public partial class Form1 : Form
    {
        private MessageController messageController = new MessageController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            
            if (radEmail.Checked)
            {
                messageController.SetMessageType(MessageType.Email);
            }
            else
            {
                messageController.SetMessageType(MessageType.SMS);
            }

            messageController.SendMessage(txtTo.Text, txtMessage.Text);
        }
    }
}
