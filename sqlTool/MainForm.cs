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
using System.Xml;

namespace sqlTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Config.xml"))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("Config.xml");
                XmlNode root = xml.SelectSingleNode("Config");
            }
        }
    }
}
