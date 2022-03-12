using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PathConverter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1Q.Text = checkBox1.Checked ? textBox1Q.Text.Replace('\\', '/') : textBox1Q.Text.Replace('/', '\\');
            textBox1M.Text = checkBox1.Checked ? textBox1M.Text.Replace('\\', '/') : textBox1M.Text.Replace('/', '\\');
            textBox1X.Text = checkBox1.Checked ? textBox1X.Text.Replace('\\', '/') : textBox1X.Text.Replace('/', '\\');
            textBox2M.Text = checkBox1.Checked ? textBox2M.Text.Replace('\\', '/') : textBox2M.Text.Replace('/', '\\');
            textBox2X.Text = checkBox1.Checked ? textBox2X.Text.Replace('\\', '/') : textBox2X.Text.Replace('/', '\\');
            textBox2Q.Text = checkBox1.Checked ? textBox2Q.Text.Replace('\\', '/') : textBox2Q.Text.Replace('/', '\\');
        }

        private string FitPath(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                return "";
            }
            p = p.Replace('\\', '/');
            string[] s1 = p.Split('/');
            List<string> lst = new List<string>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == ".." && i != s1.Length - 1)
                {
                    if (lst.Count > 0)
                    {
                        lst.RemoveAt(lst.Count - 1);
                    }
                    else
                    {
                        return "";
                    }
                }
                else if (s1[i] != "." && s1[i] != "")
                {
                    lst.Add(s1[i]);
                }
            }
            string pnew = p.StartsWith("/") ? "/" : "";
            if (lst.Count > 0)
            {
                pnew += string.Join("/", lst);
                if (p.EndsWith("/"))
                {
                    pnew += "/";
                }
            }
            return pnew;
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            if (sender == button1ms)
            {
                textBox1M.Text = checkBox1.Checked ? FitPath(textBox1M.Text) : FitPath(textBox1M.Text).Replace('/', '\\');
            }
            else if (sender == button1qs)
            {
                textBox1Q.Text = checkBox1.Checked ? FitPath(textBox1Q.Text) : FitPath(textBox1Q.Text).Replace('/', '\\');
            }
            else if (sender == button2ms)
            {
                textBox2M.Text = checkBox1.Checked ? FitPath(textBox2M.Text) : FitPath(textBox2M.Text).Replace('/', '\\');
            }
        }

        private void Buttonf_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string f = checkBox1.Checked ? openFileDialog.FileName.Replace('\\', '/') : openFileDialog.FileName;

            if (sender == button1mf)
            {
                textBox1M.Text = f;
            }
            else if (sender == button1qf)
            {
                textBox1Q.Text = f;
            }
            else if (sender == button2mf)
            {
                textBox2M.Text = f;
            }
        }

        private void Buttond_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string p = folderBrowserDialog.SelectedPath.Replace('\\', '/');
            if (!p.EndsWith("/"))
            {
                p += "/";
            }
            if (!checkBox1.Checked)
            {
                p = p.Replace('/', '\\');
            }
            if (sender == button1md)
            {
                textBox1M.Text = p;
            }
            else if (sender == button1qd)
            {
                textBox1Q.Text = p;
            }
            else if (sender == button2md)
            {
                textBox2M.Text = p;
            }
        }

        private void Button1x_Click(object sender, EventArgs e)
        {
            string xd= ToXiangdui(textBox1M.Text, textBox1Q.Text);
            textBox1X.Text = xd == null ? "无效" : checkBox1.Checked ? xd : xd.Replace('/', '\\');
            return;
        }

        private string ToXiangdui(string textM, string textQ)
        {
            string pM = FitPath(textM);
            string pQ = FitPath(textQ);
            if (string.IsNullOrEmpty(pM) || string.IsNullOrEmpty(pQ))
            {
                return null;
            }
            string[] sM = pM.Split('/');
            string[] sQ = pQ.Split('/');
            int len = Math.Min(sM.Length, sQ.Length);
            int sameIndex = -1;
            for (int i = 0; i < len - 1; i++)
            {
                if (sM[i].ToLower() == sQ[i].ToLower())
                {
                    sameIndex = i;
                }
                else
                {
                    break;
                }
            }
            if (sameIndex < 0)
            {
                return null;
            }
            string s1 = "";
            for (int i = sameIndex + 1; i < sM.Length - 1; i++)
            {
                s1 += "../";
            }
            for (int i = sameIndex + 1; i < sQ.Length - 1; i++)
            {
                s1 += sQ[i] + "/";
            }
            s1 += sQ[sQ.Length - 1];
            return s1;
        }

        private void Button2q_Click(object sender, EventArgs e)
        {
            textBox2Q.Text = ToJuedui(textBox2M.Text, textBox2X.Text);
            string jd = ToJuedui(textBox2M.Text, textBox2X.Text);
            textBox2Q.Text = jd == null ? "无效" : checkBox1.Checked ? jd : jd.Replace('/', '\\');
        }

        private string ToJuedui(string textM, string texX)
        {
            if (string.IsNullOrEmpty(textM) || string.IsNullOrEmpty(texX))
            {                
                return null;
            }           
            string pathFull = FitPath(textM + "/" + texX);
            return string.IsNullOrEmpty(pathFull) ? null : pathFull;
        }
    }
}
