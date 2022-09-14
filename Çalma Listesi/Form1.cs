using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Çalma_Listesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string şarkı = "";

            if (comboBox1.Text=="Kerkük Zindanı")
            {
                şarkı = "https://www.youtube.com/watch?v=BqJ-4ePe_Pk&ab_channel=AnadoluRock";
                Process.Start(şarkı);
            }
            else if(comboBox1.Text=="Street Fighter")
            {
                şarkı = "https://www.youtube.com/watch?v=ezkBvenkZ9Y&ab_channel=CharlieParradelRiego-Topic";
                Process.Start(şarkı);
            }
            else if (comboBox1.Text=="No Rival")
            {
                şarkı = "https://www.youtube.com/watch?v=KbC5_JEhqL8&ab_channel=NoCopyrightSounds";
                Process.Start(şarkı);
            }
            else if (comboBox1.Text=="Primo Victoria")
            {
                şarkı = "https://www.youtube.com/watch?v=UQ-Fb90GBhE&ab_channel=Sabaton-Topic";
                Process.Start(şarkı);
            }
            else if (comboBox1.Text=="Sweet Dreams")
            {
                şarkı = "https://www.youtube.com/watch?v=QUvVdTlA23w&ab_channel=MarilynMansonVEVO";
                Process.Start(şarkı);
            }
            else if (comboBox1.Text=="W.Monroe")
            {
                şarkı = "https://www.youtube.com/watch?v=GlKypWn3WLk&ab_channel=Ldrdo-Topic";
                Process.Start(şarkı);
            }
            else if (comboBox1.Text=="Vurdum En Dibe Kadar")
            {
                şarkı = "https://www.youtube.com/watch?v=eyYy1c09dxg&ab_channel=netdm%C3%BCzik";
                Process.Start(şarkı);
            }
            else
            {
                MessageBox.Show("Şarkı Seçilmedi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/YusufUzeyir+");
        }
    }
}
