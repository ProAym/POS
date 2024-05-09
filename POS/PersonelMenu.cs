﻿using POS.View;
using System;
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
    public partial class PersonelMenu : Form
    {
        public PersonelMenu()
        {
            InitializeComponent();
        }

        //for accessing frm main    
        static PersonelMenu _obj;
        public static PersonelMenu Instance
        {
            get { if (_obj == null) { _obj = new PersonelMenu(); } return _obj; }
        }


        private void PersonelMenu_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
            _obj = this;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Method to add controls to main form



        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new frmUrunlerView());
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            AddControls(new frmTableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new frmPersonelView());
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak istediğinizden Emin Misiniz?", "Çıkış Yap",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                PersonelGiris frm = new PersonelGiris();
                frm.Show();
            }
            
        }
    }
}