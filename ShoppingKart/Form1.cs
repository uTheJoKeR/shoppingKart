using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ShoppingKart
{
    public partial class ShoppingKart : Form
    {
        string[,] Appdata = new string[,] {
              { "ThighParts","200" },
              { "ShinParts","185" },
              { "ArcReactor","80" },
              { "Mark43Helm","150" },
              { "ShoulderParts","120" },
              { "GloveParts","160" }

        };

        ArrayList cart = new ArrayList();

        public ShoppingKart()
        {
            InitializeComponent();
        }

        private void ThighCheckoutAdd_Click(object sender, EventArgs e)
        {
            Cart.Items.Add("ThighParts");
            cart.Add(Appdata[0, 1]);
        }

        private void Checkout_Click(object sender, EventArgs e)
        {//CHECKOUT BOX
            double totalPrice = 0.00;
            foreach (string price in cart)
            {
                totalPrice += Convert.ToDouble(price);

                CheckoutPage CP = new CheckoutPage();
                CP.Show();
            }
        }//CHECKOUT BOX

        private void ShinCheckoutAdd_Click(object sender, EventArgs e)
        {
            Cart.Items.Add("ShinParts");
            cart.Add(Appdata[1, 1]);
        }

        private void ArcCheckoutAdd_Click(object sender, EventArgs e)
        {
            Cart.Items.Add("ArcReactor");
            cart.Add(Appdata[2, 1]);
        }

        private void HelmCheckoutAdd_Click(object sender, EventArgs e)
        {
            Cart.Items.Add("Mark43Helm");
            cart.Add(Appdata[3, 1]);
        }

        private void ShoulderCheckoutAdd_Click(object sender, EventArgs e)
        {
            Cart.Items.Add("ShoulderParts");
            cart.Add(Appdata[4, 1]);
        }

        private void GloveCheckoutAdd_Click(object sender, EventArgs e)
        {
            Cart.Items.Add("GloveParts");
            cart.Add(Appdata[5, 1]);
        }
    }
}