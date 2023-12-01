﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoecoleEF
{
    public partial class FrmValiderLecon : Form
    {
        private autoEcoleEntities mesDonneesEF;
        public FrmValiderLecon(autoEcoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = new autoEcoleEntities();
            this.bdgSlecon.DataSource = mesDonneesEF.lecon.ToList();
            this.bdgSvehicule.DataSource = mesDonneesEF.vehicule.ToList();
        }

        private void FrmValiderLecon_Load(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.mesDonneesEF.SaveChanges();
            MessageBox.Show("Enregistrement validé :)");
        }
    }
}