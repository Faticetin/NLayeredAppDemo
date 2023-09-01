using Entities.Concrete;
using Northwind.Busines.Abstarct;
using Northwind.Busines.Concrete;
using Northwind.Busines.Ninject;
using Northwind.DataAccess.Concrete.EntitiyFremwork;
using Northwind.DataAccess.Concrete.NHiberNate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norhwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _producService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _producService;
        private ICategoryService _categoryService;

        public void LoadProducts()
        {
            dgwProduct.DataSource = _producService.GelAll();
        }
        private void LoadCategories()
        {
            cmbCategory.DataSource = _categoryService.GetAll();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            cmbCategoryAdd.DataSource = _categoryService.GetAll();
            cmbCategoryAdd.DisplayMember = "CategoryName";
            cmbCategoryAdd.ValueMember = "CategoryId";

            cmbCategoryUpdate.DataSource = _categoryService.GetAll();
            cmbCategoryUpdate.DisplayMember = "CategoryName";
            cmbCategoryUpdate.ValueMember = "CategoryId";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _producService.GetProductsByCategory(Convert.ToInt32(cmbCategory.SelectedValue));
            }
            catch
            {


            }
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtProduct.Text))
            {
                dgwProduct.DataSource = _producService.GetProductsByProductName(txtProduct.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _producService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cmbCategoryAdd.SelectedValue),
                    ProductName = txtProductAdd.Text,
                    QuantityPerUnit = txtQuantityPerUnitAdd.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(txtUnitsInStockAdd.Text)
                });
                MessageBox.Show("Ürün eklendi");
                LoadProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _producService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = txtProductUpdate.Text,
                CategoryId = Convert.ToInt32(cmbCategoryUpdate.SelectedValue),
                QuantityPerUnit = txtQuantityPerUnitUpdate.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text),
                UnitsInStock = Convert.ToInt16(txtUnitsInStockUpdate.Text)
            });
            MessageBox.Show("Ürün güncellendi");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            txtProductUpdate.Text = row.Cells[1].Value.ToString();
            cmbCategoryUpdate.SelectedValue = row.Cells[2].Value;
            txtUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            txtQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            txtUnitsInStockUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                _producService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),

                });
            }


            MessageBox.Show("Ürün Silindi");
            LoadProducts();
        }
    }
}
