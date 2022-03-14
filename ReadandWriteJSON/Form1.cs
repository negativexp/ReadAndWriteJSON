using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ReadandWriteJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<JSONdata> _JSONDATA = new List<JSONdata>();
        string finalJSON;

        private void button2_Click(object sender, EventArgs e)
        {
            _JSONDATA.Add(new JSONdata()
            {
                Name = textBox1.Text,
                Address = textBox2.Text,
                Number = Convert.ToInt32(textBox3.Text)
            });
            finalJSON = JsonConvert.SerializeObject(_JSONDATA.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = finalJSON;
        }
    }
}
