using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftCore.Security;
using Ext.Net;
using System.Net.Mail;
using WebUI.Interface;
using SoftCore.Utilities;
using ExtMessage;

public partial class Modules_Base_SendMailForm_SendMail : UserControlBase, IControl, IWindow
{
    public string MailTemplateFolder { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!X.IsAjaxRequest)
        {
            txtMailGo.Text = CurrentUser.Email;

        }
    }

    /// <summary>
    /// Thiết lập địa chỉ mail gửi đi
    /// </summary>
    /// <param name="Email"></param>
    public void SetEmailTo(string MailFrom, string Pasword, string MailTo)
    {
        txtMailGo.Text = MailFrom;
        txtPassword.Text = Pasword;
        txtMailTo.Text = MailTo;
    }

    public void SetEmailTo(string MailFrom, string Pasword, string MailTo, string[] AttachFiles, string body)
    {
        txtMailGo.Text = MailFrom;
        txtPassword.Text = Pasword;
        txtMailTo.Text = MailTo;
        htmlMail.Html = body;
        htmlMail.Text = body;
        Modules_Base_SendMailForm_SendMail.AttachFiles = AttachFiles;
    }
    protected void btnSendMail_Click(object sender, DirectEventArgs e)
    {
        //txtMailTo.Text = "";
        //if (Email.SendEmail(txtMailGo.Text, txtPassword.Text, CurrentUser.DisplayName, txtMailTo.Text, txtTieuDe.Text, htmlMail.Text))
        //{
        //    wdSendEmail.Hide();
        //}
        //SendMail("smtp.gmail.com", 587, txtMailGo.Text, txtMailCC.Text.Split(';', ','), txtBcc.Text.Split(';', ','), Modules_Base_SendMailForm_SendMail.AttachFiles, txtPassword.Text, CurrentUser.DisplayName, txtMailTo.Text , txtTieuDe.Text, htmlMail.Text);
        SendMail("smtp.gmail.com", 587, txtMailGo.Text, txtMailCC.Text.Split(';', ','), txtBcc.Text.Split(';', ','), Modules_Base_SendMailForm_SendMail.AttachFiles, txtPassword.Text, CurrentUser.DisplayName, txtMailTo.Text, txtTieuDe.Text, htmlMail.Text);
    }
    //
    /// <summary>
    /// 
    /// </summary>
    /// <param name="host">smtp.gmail.com</param>
    /// <param name="port">587</param>
    /// <param name="mailsend">Địa chỉ mail gửi</param>
    /// <param name="password">Mật khẩu địa chỉ gửi</param>
    /// <param name="MailName">Tên người gửi</param>
    /// <param name="mailto">Mail đến</param>
    /// <param name="titlemail">Tiêu đề mail</param>
    /// <param name="bodymail">Nội dung mail</param>
    public void SendMail(string host, int port, string mailsend, string password, string MailName, string mailto, string titlemail, string bodymail)
    {
        #region[Sendmail]
        System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
        mailMessage.From = (new MailAddress(mailsend, MailName, System.Text.Encoding.UTF8));
        mailMessage.To.Add(mailto);
        mailMessage.Bcc.Add(mailto);
        mailMessage.Subject = titlemail;
        mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
        mailMessage.Body = bodymail;
        mailMessage.IsBodyHtml = true;
        mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
        System.Net.NetworkCredential mailAuthentication = new System.Net.NetworkCredential();
        mailAuthentication.UserName = mailsend;
        mailAuthentication.Password = password;
        System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient(host, port);
        mailClient.EnableSsl = true;
        mailClient.UseDefaultCredentials = false;
        mailClient.Credentials = mailAuthentication;
        try
        {
            mailClient.Send(mailMessage);
            Dialog.ShowNotification(GlobalResourceManager.GetInstance().GetDesktopValue("UpdateComplete"));
        }
        catch (Exception ex)
        {
            //ExtMessage.Dialog.ShowNotification(GlobalResourceManager.GetInstance().GetCommonMessageValue("Error"));
            return;
        }
        #endregion

    }

    /// <summary>
    ///  Thêm CC, BCC, attach file
    /// </summary>
    /// <param name="host">smtp.gmail.com</param>
    /// <param name="port">587</param>
    /// <param name="mailsend">Địa chỉ mail gửi</param>
    /// <param name="password">Mật khẩu địa chỉ gửi</param>
    /// <param name="MailName">Tên người gửi</param>
    /// <param name="mailto">Mail đến</param>
    /// <param name="titlemail">Tiêu đề mail</param>
    /// <param name="bodymail">Nội dung mail</param>
    public void SendMail(string host, int port, string mailsend, string[] CC, string[] Bcc, string[] AttachFiles, string password, string MailName, string mailto, string titlemail, string bodymail)
    {
        #region[Sendmail]
        System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
        mailMessage.From = (new MailAddress(mailsend, MailName, System.Text.Encoding.UTF8));
        mailMessage.To.Add(mailto);

        for (int i = 0; i < CC.Length; i++)
        {
            if (!String.IsNullOrEmpty(CC[i]))
            {
                mailMessage.CC.Add(CC[i]);
            }

        };

        for (int i = 0; i < Bcc.Length; i++)
        {
            if (!String.IsNullOrEmpty(Bcc[i]))
            {
                mailMessage.Bcc.Add(Bcc[i]);
            }
        };

        if (AttachFiles != null)
        {
            for (int i = 0; i < AttachFiles.Length; i++)
            {
                if (!String.IsNullOrEmpty(AttachFiles[i]))
                {
                    mailMessage.Attachments.Add(new Attachment(AttachFiles[i]));
                }

            }
        };


        mailMessage.Subject = titlemail;
        mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
        mailMessage.Body = bodymail;
        mailMessage.IsBodyHtml = true;
        mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
        System.Net.NetworkCredential mailAuthentication = new System.Net.NetworkCredential();
        mailAuthentication.UserName = mailsend;
        mailAuthentication.Password = password;
        System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient(host, port);
        mailClient.EnableSsl = true;
        mailClient.UseDefaultCredentials = false;
        mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        mailClient.Credentials = mailAuthentication;
        try
        {
            mailClient.Send(mailMessage);
            Dialog.ShowNotification(GlobalResourceManager.GetInstance().GetDesktopValue("UpdateComplete"));
        }
        catch (Exception ex)
        {
            //ExtMessage.Dialog.ShowNotification(GlobalResourceManager.GetInstance().GetCommonMessageValue("Error"));
            Dialog.Alert(ex.Message);
            //return;
        }
        #endregion

    }

    private static string[] AttachFiles
    {
        get;
        set;
    }


    public string GetID()
    {
        throw new NotImplementedException();
    }

    public object GetValue()
    {
        throw new NotImplementedException();
    }

    public void SetValue(object value)
    {
        throw new NotImplementedException();
    }

    public void Show()
    {
        wdSendEmail.Show();
    }
}