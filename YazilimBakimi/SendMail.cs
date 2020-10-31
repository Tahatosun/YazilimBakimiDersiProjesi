using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YazilimBakimi
{
    class SendMail
    {


        public void Send(String ad, String eposta, String sifre) {
      
            String mesaj = "<h1>Yazılım Bakımı CRM Hesabınız Oluşturuldu.</h1> <p>Kullanıcı Epostanız: " + eposta + "</p><p>  Şifreniz: " + sifre + "</p><p>Parolanızı güvenliğiniz için hiç kimseyle Paylaşmayın!</p>"; 

            String MailHesabi = "";
            String MailHesapSifresi = "";
        System.Net.NetworkCredential cred = new System.Net.NetworkCredential(MailHesabi, MailHesapSifresi);
                // mail gönderececk hesaba giriş yapılıyor

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(); // yeni mail oluştur
                mail.From = new System.Net.Mail.MailAddress(MailHesabi, "Yazılım Bakımı CRM."); // mail gönderen adres ve kullanıcı adı
                mail.To.Add(eposta);
                mail.Subject = ad + " aramıza Hoş geldin :) "; // mail konusua
                mail.IsBodyHtml = true; // mail içeriğini html olarak gönder
                mail.Body = mesaj; // mailin içeriği
                mail.Attachments.Clear(); // mail eklerini temizledik     

                string Pop3Host = "smtp.gmail.com";
                int Pop3Port = 587;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(Pop3Host, Pop3Port); // smtp servere bağlandık
                smtp.UseDefaultCredentials = false; // varsayılan girişi kullanma
                smtp.EnableSsl = true; // ssl kullanımına izin ver
                smtp.Credentials = cred; // server üzerindeki oturumumuzu yukarıda belirttiğimiz NetworkCredential üzerinden sağla
                smtp.Send(mail); // maili gönder
     
        }


    }
}
