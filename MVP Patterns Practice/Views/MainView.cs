using MVP_Patterns_Practice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Patterns_Practice.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            gasCmbbx.DisplayMember="Name";
            gasCmbbx.Items.Add(new Payment
            {
                Name = "Diesel",
                PricePerLiter = "0.8"
            });
            gasCmbbx.Items.Add(new Payment
            {
                Name = "A-92",
                PricePerLiter = "1"
            });
            gasCmbbx.Items.Add(new Payment
            {
                Name = "A-95",
                PricePerLiter = "1.20"
            });
        }

        public EventHandler<EventArgs> AddButtonClick { get; set; }
        public EventHandler<EventArgs> LoadButtonClick { get; set; }
        public List<Payment> payments
        {
            set
            {
                paymentListBox.DataSource = null;
                paymentListBox.DataSource = value;
            }
        }
        public string NameText { get => gasCmbbx.Text; set => gasCmbbx.Text = value; }
        public string LiterText { get => literTxtb.Text; set => literTxtb.Text = value; }
        public string PriceText { get => priceTxtb.Text; set => priceTxtb.Text = value; }
        public string PricePerLiterText { get => pricePerLiterTxtb.Text; set => pricePerLiterTxtb.Text = value; }


        private void addBtn_Click(object sender, EventArgs e)
        {
            AddButtonClick.Invoke(sender, e);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadButtonClick.Invoke(sender, e);
        }

        private void literRbtn_CheckedChanged(object sender, EventArgs e)
        {
            TotalLbl.Text = "[Total]";
            if (literRbtn.Checked)
            {
                literTxtb.Enabled = true;
                priceTxtb.Enabled = false;
            }
            else literTxtb.Enabled = false;
        }

        private void priceRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            TotalLbl.Text = "[Total]";
            if (priceRdbtn.Checked)
            {
                priceTxtb.Enabled = true;
                literTxtb.Enabled = false;
            }
            else priceTxtb.Enabled = false;
        }

        private void gasCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            literRbtn.Enabled = true;
            priceRdbtn.Enabled = true;
            if (gasCmbbx.SelectedIndex == 0) pricePerLiterTxtb.Text = "0.80";
            else if (gasCmbbx.SelectedIndex == 1) pricePerLiterTxtb.Text = "1";
            else if (gasCmbbx.SelectedIndex == 2) pricePerLiterTxtb.Text = "1.20";
        }

        private void literTxtb_TextChanged(object sender, EventArgs e)
        {
            TotalLbl.Text = $"{(double.Parse(literTxtb.Text) * double.Parse(pricePerLiterTxtb.Text)).ToString()}USD";
        }

        private void priceTxtb_TextChanged(object sender, EventArgs e)
        {
            TotalLbl.Text = $"{(double.Parse(priceTxtb.Text) / double.Parse(pricePerLiterTxtb.Text)).ToString()}L";
        }
    }
}
