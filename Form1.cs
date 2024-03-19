using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=" + textBox1.Text + "");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string imgName = DateTime.Now.Year + "_" + DateTime.Now.Month +"_"+ DateTime.Now.Day + '_' + DateTime.Now.Hour +"_"+DateTime.Now.Minute +"_"+DateTime.Now.Second + "." + ImageFormat.Jpeg;
          saveFileDialog.FileName = imgName;
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}
