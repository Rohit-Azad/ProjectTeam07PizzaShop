using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam07PizzaShop
{
    public partial class PizzaShopForm : Form
    {
        public PizzaShopForm()
        {
            InitializeComponent();

            buttonAdmin.Click += ButtonAdmin_Click;
            buttonUser.Click += ButtonUser_Click;
        }

        private void ButtonUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
