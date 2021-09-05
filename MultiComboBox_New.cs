using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControl
{
    public partial class MultiComboBox_New: UserControl
    {
        public MultiComboBox_New()
        {
            InitializeComponent();
        }
        public CheckedListBox.ObjectCollection Items
        {
            get
            {

                return checkedListBox?.Items;
            
            }
            set
            {
                


                
            }
        
        
        
        
        }

        public override string Text 
        
        
        {
            get
            {
                return comboBox?.Text;
             }
            set
            { 
            
            
            }
        
        }

        //定义委托
        public delegate void UserControlHandle(object sender, EventArgs e);
        //定义事件
        public event UserControlHandle TextUpdate;
        private void comboBox_TextUpdate(object sender, EventArgs e)
        {
            if (TextUpdate != null)
                TextUpdate(sender, new EventArgs());//把按钮自身作为参数传递
        }
        public event UserControlHandle checkedListBoxMouseUp;
        private void checkedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkedListBoxMouseUp != null)
                checkedListBoxMouseUp(sender, new EventArgs());//把按钮自身作为参数传递

        }
        public event UserControlHandle DropDown;
        private void comboBox_DropDown(object sender, EventArgs e)
        {
            this.checkedListBox.Location = new System.Drawing.Point(this.comboBox.Left, this.comboBox.Height + this.comboBox.Location.Y);
            this.checkedListBox.ItemHeight = this.comboBox.ItemHeight;
            this.checkedListBox.Width = this.comboBox.Width;
            this.checkedListBox.Height = this.checkedListBox.ItemHeight * 10 + 2;
            this.Height = this.comboBox.Height + this.checkedListBox.Height;
            this.checkedListBox.Visible = true;

            if (DropDown != null)
                DropDown(sender, new EventArgs());//把按钮自身作为参数传递


        }

        private void checkedListBox_MouseLeave(object sender, EventArgs e)
        {
            this.checkedListBox.Visible = false;
            this.Size = this.comboBox.Size;



        }

        private void comboBox_MouseLeave(object sender, EventArgs e)
        {

            var curMousePos = this.PointToClient(Control.MousePosition);
            var downArea = checkedListBox.Location;
            if (curMousePos.X < downArea.X || curMousePos.X > (downArea.X + checkedListBox.Width)
                || curMousePos.Y < downArea.Y || curMousePos.Y > (downArea.Y + checkedListBox.Height))
            {

                checkedListBox.Visible = false;
                this.Size = this.comboBox.Size;
            }

        }


        private void comboBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.comboBox.Focus();
        }

    }



}
