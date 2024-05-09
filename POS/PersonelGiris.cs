﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(TxtUser.Text, TxtPass.Text) == false)
            {
                MessageBox.Show("Hatali kullanici adi veya sifre!");
            }
            else
            {
                this.Hide();
                PersonelMenu frm = new PersonelMenu();
                frm.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Secme1Ekran frm = new Secme1Ekran();
            frm.Show();
        }
    }
}