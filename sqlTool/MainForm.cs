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
        private static string SELECT = "取得";
        private static string FIXED_CONDITION = "固定的パラメータ";
        private static string DYNAMIC_CONDITION = "動的パラメータ";
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            switch (this.tab2.SelectedTab.Text)
            {
                case "取得":
                    forSelect();
                    break;
                case "固定的パラメータ":
                    forFixedCondition();
                    break;
                case "動的パラメータ":
                    forDynamicCondition();
                    break;
                default:
                    MessageBox.Show("タブを選択してください。");
                    break;
            }
        }



        /// <summary> 
        /// 取得値カラム用メソッド
        /// </summary> 
        private void forSelect()
        {
            TreeNode NodeCondition = new TreeNode();
            NodeCondition.Name = this.cbx_fixWhere.Text;
            NodeCondition.Text = this.cbx_fixWhere.Text;
            TreeNode NodeValue = new TreeNode();
            NodeValue.Name = this.txt_fixedParmName.Text;
            NodeValue.Text = this.txt_fixedValue.Text;
            NodeCondition.Nodes.Add(NodeValue);
            this.tv_fixedParmName.Nodes.Add(NodeCondition);
        }

        /// <summary> 
        /// 静的検索条件用メソッド
        /// </summary> 
        private void forFixedCondition()
        {
            TreeNode NodeCondition = new TreeNode();
            NodeCondition.Name = this.cbx_fixWhere.Text;
            NodeCondition.Text = this.cbx_fixWhere.Text;
            TreeNode NodeValue = new TreeNode();
            NodeValue.Name = this.txt_fixedParmName.Text;
            NodeValue.Text = this.txt_fixedValue.Text;
            NodeCondition.Nodes.Add(NodeValue);
            this.tv_fixedParmName.Nodes.Add(NodeCondition);
        }

        /// <summary> 
        /// 動的検索条件用メソッド
        /// </summary> 
        private void forDynamicCondition()
        {

        }
        //        public void AddTree(int ParentID, TreeNode pNode)
        //        {
        //            DataView dvTree = new DataView(dtTree); //就是dtTree = dsFrame.Tables[0]; 
        //            string Fstr = "[f_front] =" + ParentID;
        //            dvTree.RowFilter = Fstr;  
        //            foreach (DataRowView Row in dvTree)
        //            {
        //                TreeNode Node = new TreeNode();
        //                if (pNode == null)                  //处理主节点                        {     
        //                    Node.Name = Row["f_id"].ToString(); //这里+了2个值分别到Name和Text，可随便                            
        //                Node.Text = Row["f_name"].ToString();
        //                tvDept.Nodes.Add(Node);    //加入 
        //                AddTree(Int32.Parse(Row["f_id"].ToString()), Node); //递归                        
        //            } 
        //                       else //处理子节点                        
        //{       
        //                           Node.Name = Row["f_id"].ToString();
        //                Node.Text = Row["f_name"].ToString();
        //                pNode.Nodes.Add(Node); AddTree(Int32.Parse(Row["f_id"].ToString()), Node);
        //            }
        //        }
    }
}
