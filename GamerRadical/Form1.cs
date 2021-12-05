using System;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamerRadical
{
    public partial class Form1 : Form
    {
        int saavedra = 420; // junk code OMG undetectable hash bruteforce generator
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\souteuamigo.wav";
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0,num2 = 0;
            bool gay = true;
            bool gaming = false;
            List<string> listaOriginal = new List<string>();
            foreach (string lol in comboBox1.Items) listaOriginal.Add(lol);
            List<string> listaNova = new List<string>(listaOriginal);
            while (gay)
            {
                num1 = random.Next(listaOriginal.Count);
                num2 = random.Next(listaOriginal.Count);
                string placeholder = "";
                placeholder = listaNova[num1];
                listaNova[num1] = listaNova[num2];
                listaNova[num2] = placeholder;


                gaming = false;
                for(int i = 0; i < listaOriginal.Count; i++)
                {
                    if (listaOriginal[i] == listaNova[i]) gaming = true;
                }
                gay = gaming;
            }
            for(int i = 0; i < listaOriginal.Count; i++)
            {
                string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, listaOriginal[i]);
                System.IO.File.WriteAllText(destPath+".txt", listaNova[i]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            comboBox1.SelectedItem = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
