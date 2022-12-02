using FullIIstokDesktop.Data;
using FullIIstokDesktop.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullIIstokDesktop
{
    public partial class MenuScreen : Form
    {
        //Contrutor padrão
        public MenuScreen()
        {
            InitializeComponent();
            pnlProducts.Enabled = false;
            lblSalutation.Text = "Bem-vindo!";

        }

        //Com argumentos
        public MenuScreen(string nmUser)
        {
            InitializeComponent();
            pnlProducts.Enabled = false;
            lblSalutation.Text = "Bem-vindo, " + nmUser + ".";

        }

        private void clear()
        {
            txtProductSku.Text = "";
            txtProductName.Text = "";
            txtProductDescription.Text = "";
            txtProductQuantity.Text = "";
            txtProductPrice.Text = "";
            lblSalutation.Text = "";
        }

        private void itmCreateProduct_Click(object sender, EventArgs e)
        {
            pnlProducts.Enabled = true;
            btnCreate.Enabled = true;
            btnRead.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            clear();
        }

        private void itmReadProduct_Click(object sender, EventArgs e)
        {
            pnlProducts.Enabled = true;
            btnCreate.Enabled = false;
            btnRead.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            clear();
        }

        private void itmUpdateProduct_Click(object sender, EventArgs e)
        {
            pnlProducts.Enabled = true;
            btnCreate.Enabled = false;
            btnRead.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            clear();
        }

        private void itmDeleteProduct_Click(object sender, EventArgs e)
        {
            pnlProducts.Enabled = true;
            btnCreate.Enabled = false;
            btnRead.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = true;
            clear();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                product.Sku = txtProductSku.Text;
                product.Name = txtProductName.Text;
                product.Description = txtProductDescription.Text;
                product.Quantity = Convert.ToInt32(txtProductQuantity.Text);
                product.Price = Convert.ToDecimal(txtProductPrice.Text);


                DalHelper.Create(product);

                MessageBox.Show("Data registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clear();

                txtProductSku.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {


            try
            {
                Product product = new Product();

                product.Sku = txtProductSku.Text;

                product = DalHelper.Read(product.Sku);

                if (product != null)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;

                    txtProductName.Text = product.Name;
                    txtProductQuantity.Text = Convert.ToString(product.Quantity);
                    txtProductDescription.Text = product.Description;
                    txtProductPrice.Text = Convert.ToString(product.Price);
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductSku.Focus();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                product.Sku = txtProductSku.Text;
                product.Name = txtProductName.Text;
                product.Description = txtProductDescription.Text;
                product.Quantity = Convert.ToInt32(txtProductQuantity.Text);
                product.Price = Convert.ToDecimal(txtProductPrice.Text);

                DalHelper.Update(product);

                if (product != null)
                {
                    MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    Product product = new Product();
                    product.Sku = txtProductSku.Text;
                    int result = DalHelper.Delete(product.Sku);

                    if (result == 1)
                    {

                        //Confirmando exclusão para o usuário
                        MessageBox.Show("Deleted successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProductSku.Focus();
                    }
                }
                else
                {
                    txtProductSku.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
