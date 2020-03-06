using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_MailAyristirma
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> mail = new List<string>();

        private void metroButton1_Click(object sender, EventArgs e)
        {
            mail.Add(metroTextBox1.Text);
            metroTextBox1.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            lstHotmailCom.Items.Clear();
            lstHotmailComTr.Items.Clear();
            lstHotmailNet.Items.Clear();
            lstGmailCom.Items.Clear();
            lstGmailComTr.Items.Clear();
            lstGmailNet.Items.Clear();
            lstCopKutusu.Items.Clear();
            metroTextBox1.Clear();
            foreach (var item in mail)
            {
                int atIndex = item.IndexOf('@');

                string deger = item.Remove(0, atIndex + 1).ToString();

                switch (deger)
                {
                    case "hotmail.com":
                        int index = item.IndexOf('@');
                        lstHotmailCom.Items.Add(item.Remove(index));
                        int hotmail = lstHotmailCom.Items.Count;
                        lbl1.Text = hotmail.ToString();
                        break;
                    case "hotmail.com.tr":
                        int index1 = item.IndexOf('@');
                        lstHotmailComTr.Items.Add(item.Remove(index1));
                        int hotmail1 = lstHotmailComTr.Items.Count;
                        lbl2.Text = hotmail1.ToString();
                        break;
                    case "hotmail.net":
                        int index2 = item.IndexOf('@');
                        lstHotmailNet.Items.Add(item.Remove(index2));
                        int hotmail2 = lstHotmailNet.Items.Count;
                        lbl3.Text = hotmail2.ToString();
                        break;
                    case "gmail.com":
                        int index3 = item.IndexOf('@');
                        lstGmailCom.Items.Add(item.Remove(index3));
                        int hotmail3 = lstGmailCom.Items.Count;
                        lbl4.Text = hotmail3.ToString();
                        break;

                    case "gmail.com.tr":
                        int index4 = item.IndexOf('@');
                        lstGmailComTr.Items.Add(item.Remove(index4));
                        int hotmail4 = lstGmailComTr.Items.Count;
                        lbl5.Text = hotmail4.ToString();
                        break;
                    case "gmail.net":
                        int index5 = item.IndexOf('@');
                        lstGmailNet.Items.Add(item.Remove(index2@hotmail.com5));
                        int hotmail5 = lstGmailNet.Items.Count;
                        lbl6.Text = hotmail5.ToString();
                        break;
                    default:
                        int index6 = item.IndexOf('@');
                        lstCopKutusu.Items.Add(item.Remove(index6));
                        break;
                }
                //if (item.EndsWith("hotmail.com"))
                //{

                //}
                //if (item.EndsWith("hotmail.com.tr"))
                //{
                //    int index = item.IndexOf('@');
                //    lstHotmailComTr.Items.Add(item.Remove(index));

                //}
                //if (item.EndsWith("hotmail.net"))
                //{
                //    int index = item.IndexOf('@');
                //    lstHotmailNet.Items.Add(item.Remove(index));
                //}
                //if (item.EndsWith("gmail.com"))
                //{
                //    int index = item.IndexOf('@');
                //    lstGmailCom.Items.Add(item.Remove(index));
                //}
                //if (item.EndsWith("gmail.com.tr"))
                //{
                //    int index = item.IndexOf('@');
                //    lstGmailComTr.Items.Add(item.Remove(index));
                //}
                //if (item.EndsWith("gmail.net"))
                //{
                //    int index = item.IndexOf('@');
                //    lstGmailNet.Items.Add(item.Remove(index));
                //}
                //else
                //{
                //    int index = item.IndexOf('@');
                //    lstCopKutusu.Items.Add(item.Remove(index));
                //}
            }
        }
    }
}
