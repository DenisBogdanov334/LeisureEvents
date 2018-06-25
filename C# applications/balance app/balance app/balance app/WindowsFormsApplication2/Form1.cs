using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Database db;
        public Form1()
        {
            InitializeComponent();
            db = new Database();
        }   
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> logfilee;
            logfilee = db.LogFile();

            this.listBox1.Items.Clear();
            foreach (string s in logfilee)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
