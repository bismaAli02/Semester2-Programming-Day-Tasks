using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Controls
{
    public partial class ComboBoxControl : UserControl
    {
        private List<string> dataList;
        public ComboBoxControl()
        {
            InitializeComponent();
        }

        public List<string> DataList { get => dataList; set => dataList = value; }

        private void ccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccTxtbox.Text = ccComboBox.SelectedItem.ToString();
        }

        private void ComboBoxControl_Load(object sender, EventArgs e)
        {
            ccComboBox.DataSource = dataList;
        }
    }
}
