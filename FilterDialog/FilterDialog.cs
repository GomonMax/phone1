using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterDialog
{
    public partial class FilterDialog : UserControl
    {
        public (string Name, string telNummer, bool? State) DataCortege { get; set; }
        public FilterDialog()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var el = this.DataCortege;
            if (!string.IsNullOrEmpty(this.txtName.Text)) 
            {
                el.Name = this.txtName.Text;
            }
            if (!string.IsNullOrEmpty(this.txtTelNummer.Text)) 
            {
                el.telNummer = this.txtTelNummer.Text;
            }
            if (this.genderCB.SelectedItem != null) 
            {
                string gen = this.genderCB.Text;
                switch (gen) 
                {
                    case "Чоловіча": 
                        {
                            el.State = false;
                            break;
                        }
                    case "Жіноча":
                        {
                            el.State = true;
                            break;
                        }
                }
            }
            this.DataCortege = el;
        }
    }
}
