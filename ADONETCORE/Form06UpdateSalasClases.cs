﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADONETCORE.Repositorys;

namespace ADONETCORE
{
    public partial class Form06UpdateSalasClases : Form
    {
        RepositoySalas repo;
        public Form06UpdateSalasClases()
        {
            InitializeComponent();
            this.repo = new RepositoySalas();
            this.LoadSalas();
        }

        private async void LoadSalas()
        {
            List<string> salas = await this.repo.GetNombresSalaAsync();
            foreach (string nombre in salas)
            {
                this.lstSalas.Items.Add(nombre);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            string oldName = this.lstSalas.SelectedItem.ToString();
            string newName = this.txtPlantilla.Text;
            await this.repo.UpdateNombreSalaAsync(oldName, newName);
            this.LoadSalas();

        }
    }
}
