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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Курсова_работа
{
    public partial class Form1 : Form
    {
        public const string FILE_NAME = "Stoka.dat";
        public List<Stoka> Stoki = new List<Stoka>();
        public BinaryFormatter bf = new BinaryFormatter();
        public FileStream fs;
        public Form1()
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

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Stoka stoka = new Stoka();
            stoka.ID = (int)iDNumericUpDown.Value;
            bool unique = true;
            foreach (var a in Stoki)
            {
                if (a.ID == stoka.ID) unique = false;
            }
            stoka.Cena = (int)cenaNumericUpDown.Value;
            stoka.Kolichestvo = (int)kolichestvoNumericUpDown.Value;
            stoka.Name = nameTextBox.Text;
            if (unique)
            {
                Stoki.Add(stoka);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Stoki;
            }
            else
            {
                MessageBox.Show("There is already a card with that card number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fs = new FileStream(FILE_NAME, FileMode.OpenOrCreate);
            bf.Serialize(fs, Stoki);
            fs.Close();
            MessageBox.Show("saved");
        }
    }
    }

