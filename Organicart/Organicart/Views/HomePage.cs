﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Views;

namespace Organicart
{
    public partial class HomePage : Base
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        public HomePage()
        {
            InitializeComponent();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterHome = new HomePage();
            enterHome.Show();
            this.Hide();
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            var enterCart = new Cart();
            enterCart.Show();
            this.Hide();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            var enterProfile = new Profile();
            enterProfile.Show();
            this.Hide();
        }

        private void btnFrutas_Click_1(object sender, EventArgs e)
        {
            var enterProducts = new Products(1);
            enterProducts.Show();
            this.Hide();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            var enterProducts = new Products(2);
            enterProducts.Show();
            this.Hide();
        }

        private void btnVegetales_Click(object sender, EventArgs e)
        {
            var enterProducts = new Products(3);
            enterProducts.Show();
            this.Hide();
        }

        private void btnGranos_Click(object sender, EventArgs e)
        {
            var enterProducts = new Products(4);
            enterProducts.Show();
            this.Hide();
        }

        private void btnLacteos_Click(object sender, EventArgs e)
        {
            var enterProducts = new Products(5);
            enterProducts.Show();
            this.Hide();
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            var enterProducts = new Products(6);
            enterProducts.Show();
            this.Hide();
        }
    }
}
