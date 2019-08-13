using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Hello : Form
    {
        int Age = 21;
        public Hello()
        {
            InitializeComponent();
        }

        private void Hello_Load(object sender, EventArgs e)
        {

        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //lblOutput.Text = txtInput.Text; // The output after clicking the button will appear in the lable whose name is lblOutput.
            //lbxOutput.Items.Add(txtInput.Text);
            string Name = "Bikash Pokhrel"; // variable name is Name and type is string, value for the variable Name is Bikash Pokrel
            Age = Age + 1;
            lbxOutput.Items.Add(Name + " "+Age); // The listbox item is add as the variable
            MessageBox.Show("Hello " + Name + " Welcome to C#, you are " +Age+" years old");//this is the messgae box whichi is like a alert function used in js in level 5
     
        }

        private void LbxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
        }
    }
}
