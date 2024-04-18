using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_работа
{
    public partial class Form3 : Form
    {
        public const string FILE_NAME = "Stoka.dat";
        public List<Stoka> Stoki = new List<Stoka>();
        public BinaryFormatter bf = new BinaryFormatter();
        public FileStream fs;
        public Form3()
        {
            InitializeComponent();
            if (File.Exists(FILE_NAME))
            {
                fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                if (fs.Position != fs.Length)
                    Stoki = (List<Stoka>)bf.Deserialize(fs);
                fs.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Stoki;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Stoki = Stoki.OrderBy(x => -x.Total).ToList();
            foreach(Stoka st in Stoki) 
            {
                string b = "";
                b += st.ID.ToString() + " " + st.Name;
                listBox1.Items.Add(b);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Stoki = Stoki.OrderBy(x => -x.Kolichestvo).ToList();
            foreach (Stoka st in Stoki)
            {
                string b = "";
                b += st.ID.ToString() + " " + st.Name;
                listBox2.Items.Add(b);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
