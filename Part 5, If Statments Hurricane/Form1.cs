using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5__If_Statments_Hurricane
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        int category;



        private void txtWindSpeed_TextChanged(object sender, EventArgs e)
        {
            //
            
        }

       


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtCat.Text, out category))
            {
                switch (category)
                {
                    case 1:
                        lblKPH.Text = ("119-153 km/h");
                        lblMPH.Text = ("74-95 mph");
                        lblKNOTS.Text = ("64-82 kt");
                        break;
                    case 2:
                        lblKPH.Text = ("154-177 km/h");
                        lblMPH.Text = ("96-110 mph");
                        lblKNOTS.Text = ("83-95 kt");
                        break;
                    case 3:
                        lblKPH.Text = ("178-209 km/h");
                        lblMPH.Text = ("111-130 mph");
                        lblKNOTS.Text = ("96-113 kt");
                        break;
                    case 4:
                        lblKPH.Text = ("210-249 km/h");
                        lblMPH.Text = ("113-155 mph");
                        lblKNOTS.Text = ("114-135 kt");
                        break;
                    case 5:
                        lblKPH.Text = ("249+ km/h");
                        lblMPH.Text = ("155+ mph");
                        lblKNOTS.Text = ("135+ kt");
                        break;
                    default:
                        lblKPH.Text = ("Not a valid catagory");
                        lblMPH.Text = ("Not a valid catagory");
                        lblKNOTS.Text = ("Not a valid catagory");
                        break;
                }
            }
            else
            {
                lblKPH.Text = ("Please enter a valid number");
                lblMPH.Text = ("Please enter a valid number");
                lblKNOTS.Text = ("Please enter a valid number");
            }
        }
    }
}
