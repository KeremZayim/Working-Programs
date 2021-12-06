using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingPrograms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            yenile();
        }

        private void SecileniKopyala(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(lbProgramlar.SelectedItem.ToString());
            }
            catch (ArgumentNullException)
            {

            }
        }
        void yenile()
        {
            lbProgramlar.Items.Clear();
            Process[] Memory = Process.GetProcesses();

            foreach (Process prc in Memory)
            {
                lbProgramlar.Items.Add(Convert.ToString(("İşlem: " + (lbProgramlar.Items.Count + 1) + " " + prc.ProcessName)));
            }
        }
        private void timerYenile(object sender, EventArgs e)
        {
            yenile();
        }
        private void YenileButonu(object sender, EventArgs e)
        {
            yenile();
        }

        private void switchYenileme_CheckedChanged(object sender, EventArgs e)
        {
            if (switchYenileme.Checked == true)
            {
                timerYenileme.Enabled = true;
            }
            else if (switchYenileme.Checked == false)
            {
                timerYenileme.Enabled = false;
            }
        }

        private void Kaydet(object sender, EventArgs e)
        {
            /*
            StreamWriter yaz = new StreamWriter("Calisan-Programlar.txt");
            foreach (string yazi in lbProgramlar.Items)
            {
                yaz.WriteLine(yazi);
            }
            yaz.Close();
            */

            SaveFileDialog dosyakaydet = new SaveFileDialog();
            dosyakaydet.Filter = "Metin Dosyası|*.txt";
            if (dosyakaydet.ShowDialog() == DialogResult.OK)
            {
                string metin = "";

                foreach (string yazi in lbProgramlar.Items)
                {
                    metin = metin + yazi;
                    metin = metin + "\n";
                }
                File.WriteAllText(dosyakaydet.FileName, metin, Encoding.UTF8);
            }
        }

        private void Kopyala(object sender, EventArgs e)
        {
            string metin = "";

            foreach (string yazi in lbProgramlar.Items)
            {
                metin = metin + yazi;
                metin = metin + "\n";
            }
            Clipboard.SetText(metin);
        }
    }
}
