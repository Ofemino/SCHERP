using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using DAL;

namespace SCHERP.Controllers
{
    public static class HangFireClass
    {
        private static ScherpDbContext _db;

        //public static void ProcessMailing()
        //{
        //    string msgRange = null;
        //    _db = new EnlLogistiicsEntities();
        //    List<MailList> mailList = _db.MailLists.ToList();

        //    foreach (MailList m in mailList)
        //    {
        //        //msgtype = 1
        //        if (m.MailsToRecieve.Contains("Camera Status"))
        //        {

        //            if (m.MsgRange.Contains("Daily"))
        //            {
        //                msgRange = "Daily";
        //            }
        //            else if (m.MsgRange.Contains("Weekly"))
        //            {
        //                msgRange = "Weekly";
        //            }
        //            else
        //            {
        //                msgRange = "Monthly";
        //            }

        //            //send Camera Status mails
        //            string composedMail = ComposeMail(1, msgRange);
        //            string subject = GetMailSubject(1);
        //            SendTheMail(m.Emails, composedMail, subject);
        //        }//msgtype = 2
        //        else if (m.MailsToRecieve.Contains("Transactions"))
        //        {
        //            //send Transactions mails
        //            string composedMail = ComposeMail(2, msgRange);
        //            string subject = GetMailSubject(2);
        //            SendTheMail(m.Emails, composedMail, subject);
        //        }//msgtype = 3
        //        else if (m.MailsToRecieve.Contains("Terminal Status"))
        //        {
        //            //send Terminal Status mails
        //            string composedMail = ComposeMail(3, msgRange);
        //            string subject = GetMailSubject(3);
        //            SendTheMail(m.Emails, composedMail, subject);
        //        }
        //    }
        //}

        private static string GetMailSubject(int i)
        {
            return "";
        }

        public static void SendMailBroadCast(string emails, string composedMessage, string subject)
        {
            try
            {
                _db = new ScherpDbContext();
                var ms = _db.MailSettings;
                foreach (var item in ms)
                {
                    // Command line argument must the the SMTP host.
                    SmtpClient client = new SmtpClient
                    {
                        Port = Convert.ToInt16(item.MailPort),
                        Host = item.MailHost,
                        EnableSsl = Convert.ToBoolean(item.EnableSsl),
                        Timeout = 2000000,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = true,
                        Credentials = new System.Net.NetworkCredential(item.MailFrom, item.MailPwd)
                    };


                    MailMessage mm = new MailMessage(item.MailFrom, emails, subject, composedMessage)
                    {

                        IsBodyHtml = true,
                        BodyEncoding = Encoding.UTF8,
                        DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    };

                    client.Send(mm);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


        }

        public static void SendGroupMailBroadCast(List<string> emails, string composedMessage, string subject)
        {
            try
            {
                _db = new ScherpDbContext();
                var ms = _db.MailSettings;
                foreach (var item in ms)
                {
                    // Command line argument must the the SMTP host.
                    SmtpClient client = new SmtpClient
                    {
                        Port = Convert.ToInt16(item.MailPort),
                        Host = item.MailHost,
                        EnableSsl = Convert.ToBoolean(item.EnableSsl),
                        Timeout = 2000000,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = true,
                        Credentials = new System.Net.NetworkCredential(item.MailFrom, item.MailPwd)
                    };

                    foreach (string m in emails)
                    {
                      MailMessage mm = new MailMessage(item.MailFrom, m, subject, composedMessage)
                    {

                        IsBodyHtml = true,
                        BodyEncoding = Encoding.UTF8,
                        DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    };

                    client.Send(mm);  
                    }
                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


        }


        public static string ComposeMail(int i, string msgRange)
        {


            return "Hello transaction composed";
        }

        public static string GetMessageTemplate(int msgType)
        {
            return "Hello transaction template";
        }


        public static string ComposeTransactionMail(string msgType)
        {
            switch (msgType)
            {
                case "Daily":
                    Console.WriteLine("Do daily");
                    break;
                case "Weekly":
                    Console.WriteLine("Do Weekly");
                    break;
                case "Monthly":
                    Console.WriteLine("Do Monthly");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }

            return null;
        }

        public static string ComposeCameraStatusMail(string msgType)
        {
            switch (msgType)
            {
                case "Daily":
                    Console.WriteLine("Do daily");
                    break;
                case "Weekly":
                    Console.WriteLine("Do Weekly");
                    break;
                case "Monthly":
                    Console.WriteLine("Do Monthly");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }

            return null;
        }
        public static string ComposeTerminalStatusMail(string msgType)
        {
            switch (msgType)
            {
                case "Daily":
                    Console.WriteLine("Do daily");
                    break;
                case "Weekly":
                    Console.WriteLine("Do Weekly");
                    break;
                case "Monthly":
                    Console.WriteLine("Do Monthly");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }

            return null;
        }

     }
}