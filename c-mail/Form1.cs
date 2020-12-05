using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace c_mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
 _        _                                           
| |      | |                                          
| |_ ___ | | __ _  __ _ _ __   ___   __ _  __ _ _   _ 
| __/ _ \| |/ _` |/ _` | '_ \ / _ \ / _` |/ _` | | | |
| || (_) | | (_| | (_| | | | | (_) | (_| | (_| | |_| |
 \__\___/|_|\__, |\__,_|_| |_|\___/ \__, |\__,_|\__, |
             __/ |                   __/ |       __/ |
            |___/                   |___/       |___/ 
        
        */

        /*
                             
                     
  ___ ___  _ __ ___  
 / __/ _ \| '_ ` _ \ 
| (_| (_) | | | | | |
 \___\___/|_| |_| |_|
                     
                    


        */



        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();

            istemci.Credentials = new System.Net.NetworkCredential("edit@tolganogay.com", "password");
            istemci.Port = 465;
            istemci.Host = "mail.tolganogay.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(textBoxMail.Text);
            mesajim.From = new MailAddress("edit@tolganogay.com");
            mesajim.Subject = textBoxBaslik.Text;
            mesajim.Body = textBoxİcerik.Text;
            istemci.Send(mesajim);

            // Bu içerik 𝐓𝐨𝐥𝐠𝐚 𝐍𝐨𝐠𝐚𝐲 (tolganogay.com / github.com/TolgaNogay) tarafından oluşturulmuştur. 
            // Kopyalanması yasaktır.

            // This content was created by 𝐓𝐨𝐥𝐠𝐚 𝐍𝐨𝐠𝐚𝐲 (tolganogay.com / github.com/TolgaNogay).
            // Copying is prohibited.


        }
    }
}
