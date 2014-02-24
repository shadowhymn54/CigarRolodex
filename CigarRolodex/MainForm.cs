using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using Microsoft.VisualBasic;

namespace CigarRolodex {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void cigarsBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.cigarsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cigarListDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'cigarListDataSet.cigars' table. You can move, or remove it, as needed.
            this.cigarsTableAdapter.Fill(this.cigarListDataSet.cigars);

        }

        private void selectBtn_Click(object sender, EventArgs e) {
            OpenFileDialog imageSelect = new OpenFileDialog();
            imageSelect.Filter = "image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            imageSelect.InitialDirectory = @"C:\";
            imageSelect.Title = "Select Image";
            if (imageSelect.ShowDialog() == DialogResult.OK) {
                labelPictureBox.ImageLocation = imageSelect.FileName;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            byte[] imgData = File.ReadAllBytes(labelPictureBox.ImageLocation);

            cmd = new SqlCeCommand("UPDATE cigars SET label = @DATA where ID = @ID", con);
            cmd.Parameters.Add("@DATA", imgData);
            cmd.Parameters.Add("@ID", iDTextBox.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void topQueryBtn_Click(object sender, EventArgs e) {
            rpt.TopRating();
        }

        private void priceQueryBtn_Click(object sender, EventArgs e) {
            rpt.LowToHighPrice();
        }

        Report rpt = new Report();
        SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.cigarListConnection);
        SqlCeCommand cmd = new SqlCeCommand();
    }
}