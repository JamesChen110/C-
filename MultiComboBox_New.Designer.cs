namespace WindowsFormsControl
{
    partial class MultiComboBox_New
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox.DropDownHeight = 1;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.IntegralHeight = false;
            this.comboBox.Location = new System.Drawing.Point(0, 0);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 31);
            this.comboBox.TabIndex = 0;
            this.comboBox.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBox.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.comboBox.MouseLeave += new System.EventHandler(this.comboBox_MouseLeave);
            this.comboBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.comboBox_MouseUp);
            // 
            // checkedListBox
            // 
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(121, 29);
            this.checkedListBox.TabIndex = 1;
            this.checkedListBox.Visible = false;
            this.checkedListBox.MouseLeave += new System.EventHandler(this.checkedListBox_MouseLeave);
            this.checkedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseUp);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comboBox);
            this.panel.Controls.Add(this.checkedListBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(121, 31);
            this.panel.TabIndex = 2;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(121, 31);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Panel panel;
    }
}
