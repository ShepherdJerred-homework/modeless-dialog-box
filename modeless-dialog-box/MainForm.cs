using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeless_dialog_box {
    public partial class MainForm : Form {
        private ChangeForm changeForm;

        public MainForm() {
            InitializeComponent();
            changeForm = new ChangeForm();
        }

        private void changeColorButton_Click(object sender, EventArgs e) {
            changeForm.ColorChanged += colorChanged;
            if (changeForm.Visible) {
                changeForm.BringToFront();
            } else {
                changeForm.Show();
            }
        }

        private void colorChanged(System.Drawing.Color color) {
            BackColor = color;
        }
    }
}
