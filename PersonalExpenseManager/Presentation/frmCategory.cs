using PersonalExpenseManager.DAL;
using PersonalExpenseManager.Entity;
using PersonalExpenseManager.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseManager
{
    public partial class frmCategory : frmMainLayout
    {
        ICategoryDAL categoryDAL = new CategoryDAL();
        string selectedId = "";
        public frmCategory()
        {
            InitializeComponent();
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;
            dgvCategories.ReadOnly = true;

            btnCategory.FillColor = Color.FromArgb(239, 196, 85);
            btnCategory.ForeColor = Color.FromArgb(47, 93, 80);
            LoadCategories();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedId = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtCategoryName.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbType.Text = dgvCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbIcon.Text = dgvCategories.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void LoadCategories()
        {
            dgvCategories.Rows.Clear();

            foreach (Category c in categoryDAL.ReadAll())
            {
                dgvCategories.Rows.Add(
                    c.Id,
                    c.Name,
                    c.Type,
                    c.Description,
                    c.Icon
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category c = new Category();

            c.Id = categoryDAL.GenerateID();
            c.Name = txtCategoryName.Text;
            c.Type = cmbType.Text;
            c.Description = txtDescription.Text;
            c.Icon = cmbIcon.Text;

            if (categoryDAL.Create(c))
            {
                MessageBox.Show("Add successful!");

                LoadCategories();
                ResetForm();
            }
            else
            {
                MessageBox.Show(categoryDAL.GetError());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Please select a category!");
                return;
            }

            Category c = new Category();

            c.Id = selectedId;
            c.Name = txtCategoryName.Text;
            c.Type = cmbType.Text;
            c.Description = txtDescription.Text;
            c.Icon = cmbIcon.Text;

            if (categoryDAL.Update(c))
            {
                MessageBox.Show("Update successful!");
                LoadCategories();
                ResetForm();
            }
            else
            {
                MessageBox.Show(categoryDAL.GetError());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Please select a category!");
                return;
            }

            if (categoryDAL.Delete(selectedId))
            {
                MessageBox.Show("Delete successful!");

                LoadCategories();
                ResetForm();
            }
            else
            {
                MessageBox.Show(categoryDAL.GetError());
            }
        }
        private void ResetForm()
        {
            selectedId = "";

            txtCategoryName.Clear();
            txtDescription.Clear();

            cmbType.SelectedIndex = -1;
            cmbIcon.SelectedIndex = -1;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void pnlIncome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbIcon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
