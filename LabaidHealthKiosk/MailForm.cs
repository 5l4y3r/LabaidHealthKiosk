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
using System.Net;

namespace LabaidHealthKiosk
{
    public partial class MailForm : Form
    {

        public MailForm()
        {
            InitializeComponent();

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("dractanz@gmail.com");
            mail.To.Add("pialczs@live.com");
            mail.Subject = "Test Mail";
            mail.Body = "mail with attachment";

            Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\Kiosk Reports\report_of_ComplainList_26_01_2018.pdf");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("dractanz@gmail.com", "Nokia2700c");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("Sent success");

        }
        //public MailForm(int x)
        //{
        //    InitializeComponent();

        //    var fromAddress = new MailAddress("Dractanz@gmail.com", "Pial");
        //    var toAddress = new MailAddress("pialczs@live.com", "Tanvir");
        //    const string fromPassword = "Nokia2700c";
        //    const string subject = "Subject";
        //    const string body = "Body";

        //    var smtp = new SmtpClient
        //    {
        //        Host = "smtp.gmail.com",
        //        Port = 587,
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        //    };
        //    using (var message = new MailMessage(fromAddress, toAddress)
        //    {
        //        Subject = subject,
        //        Body = body
        //    })
        //    {
        //        smtp.Send(message);
        //    }
        //}

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

    }
    
}
