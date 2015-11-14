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

        private void btn_add_Click(object sender, EventArgs e)
        {
            testTab2Label();
        }

        /// <summary> 
        /// 取得値カラム用メソッド
        /// </summary> 
        private void forSelect()
        {
            addNodes(this.cbx_getNameType, this.txt_getName, null, this.tv_getValue,true);
        }

        /// <summary> 
        /// 静的検索条件用メソッド
        /// </summary> 
        private void forFixedCondition()
        {
            addNodes(this.cbx_fixWhere, this.txt_fixedParmName, this.txt_fixedValue, this.tv_fixedParmName,false);
        }

        /// <summary> 
        /// 動的検索条件用メソッド
        /// </summary> 
        private void forDynamicCondition()
        {
            addNodes(this.cbx_dyWhere, this.txt_dyParmName, this.txt_dyValue, this.tv_dyParmNames,false);
        }

        /// <summary> 
        /// ノード選択イベント
        /// </summary>
        private void tv_fixedParmName_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }
        /// <summary>
        /// ノード追加
        /// </summary>
        /// <param name="cbx">whereの条件</param>
        /// <param name="txtName"></param>
        /// <param name="txtValue"></param>
        /// <param name="tv"></param>
        /// <param name="isSelect">true：取得カラムタブ用、false：静的と動的用</param>
        private void addNodes(ComboBox cbx, TextBox txtName, TextBox txtValue, TreeView tv, bool isSelect)
        {
            if (isSelect)
            {
                TreeNode NodeCondition = new TreeNode();
                NodeCondition.Name = txtName.Text;
                NodeCondition.Text = cbx.Text;
                tv.Nodes.Add(NodeCondition);
            }
            else
            {
                TreeNode NodeCondition = new TreeNode();
                NodeCondition.Expand();
                NodeCondition.Name = cbx.Text;
                NodeCondition.Text = cbx.Text;
                TreeNode NodeValue = new TreeNode();
                NodeValue.Name = txtName.Text;
                NodeValue.Text = txtValue.Text;
                NodeCondition.Nodes.Add(NodeValue);
                tv.Nodes.Add(NodeCondition);
            }
        }
        /// <summary>
        /// 選択されたタブ名を判断する
        /// </summary>
        private void testTab2Label()
        {
            switch (this.tab2.SelectedTab.Text)
            {
                case ConstFile.SELECT: //取得値カラム
                    forSelect();
                    break;
                case ConstFile.FIXED_CONDITION: //静的検索条件
                    forFixedCondition();
                    break;
                case ConstFile.DYNAMIC_CONDITION: //動的検索条件
                    forDynamicCondition();
                    break;
                default:
                    MessageBox.Show("タブを選択してください。");
                    break;
            }
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
