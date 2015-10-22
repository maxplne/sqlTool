namespace sqlTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_Header = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jAVAファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jAVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menu_Header.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Header
            // 
            this.menu_Header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menu_Header.Location = new System.Drawing.Point(0, 0);
            this.menu_Header.Name = "menu_Header";
            this.menu_Header.Size = new System.Drawing.Size(913, 25);
            this.menu_Header.TabIndex = 0;
            this.menu_Header.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jAVAファイルToolStripMenuItem,
            this.classファイルToolStripMenuItem,
            this.出力ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // jAVAファイルToolStripMenuItem
            // 
            this.jAVAファイルToolStripMenuItem.Name = "jAVAファイルToolStripMenuItem";
            this.jAVAファイルToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.jAVAファイルToolStripMenuItem.Text = "JAVAファイル";
            // 
            // classファイルToolStripMenuItem
            // 
            this.classファイルToolStripMenuItem.Name = "classファイルToolStripMenuItem";
            this.classファイルToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.classファイルToolStripMenuItem.Text = "*.classファイル";
            // 
            // 出力ToolStripMenuItem
            // 
            this.出力ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXCELToolStripMenuItem,
            this.jAVAToolStripMenuItem});
            this.出力ToolStripMenuItem.Name = "出力ToolStripMenuItem";
            this.出力ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.出力ToolStripMenuItem.Text = "出力";
            // 
            // eXCELToolStripMenuItem
            // 
            this.eXCELToolStripMenuItem.Name = "eXCELToolStripMenuItem";
            this.eXCELToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eXCELToolStripMenuItem.Text = "EXCEL";
            // 
            // jAVAToolStripMenuItem
            // 
            this.jAVAToolStripMenuItem.Name = "jAVAToolStripMenuItem";
            this.jAVAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jAVAToolStripMenuItem.Text = "JAVA";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(12, 28);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(889, 547);
            this.tab1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DDG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SDG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(412, 509);
            this.textBox1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(424, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(451, 443);
            this.treeView1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(465, 455);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(410, 21);
            this.textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(465, 482);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 630);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.menu_Header);
            this.MainMenuStrip = this.menu_Header;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu_Header.ResumeLayout(false);
            this.menu_Header.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Header;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jAVAファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jAVAToolStripMenuItem;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

