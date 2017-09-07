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
    public partial class ChangeForm : Form {

        public Color color { get; set; }
        public delegate void ChangeColorEvent(System.Drawing.Color color);
        public event ChangeColorEvent ColorChanged;

        public ChangeForm() {
            InitializeComponent();
        }

        private void okayButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void redRadioButton_Click(object sender, EventArgs e) {
            color = Color.FromArgb(255, 0, 0);
            runColorChangedEvent();
        }

        private void greenRadioButton_Click(object sender, EventArgs e) {
            color = Color.FromArgb(0, 255, 0);
            runColorChangedEvent();
        }

        private void blueRadioButton_Click(object sender, EventArgs e) {
            color = Color.FromArgb(0, 0, 255);
            runColorChangedEvent();
        }

        private void customRadioButton_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            color = colorDialog.Color;
            runColorChangedEvent();
        }

        private void runColorChangedEvent() {
            ColorChanged(color);
        }
    }
}
