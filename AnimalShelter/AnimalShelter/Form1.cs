using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer("Sujin", "Lim", new DateTime(1995, 8, 4));
            cus.Address = "123 Wilhire Blvd.";
            cus.Description = "She wants to adopt a dog.";

            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusIsQualified.Text = cus.IsQualified.ToString();
            CusDescription.Text = cus.Description;
        }
    }
}
