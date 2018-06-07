using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace anotaLinks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAnotaLink.Links' table. You can move, or remove it, as needed.
            this.linksTableAdapter.Fill(this.dataSetAnotaLink.Links);



        }
        //busca por nome na tabela 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.linksTableAdapter.FillByNome(dataSetAnotaLink.Links, textBox1.Text);

        }
        //adiciona novo link
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.linksBindingSource.AddNew();
            linkTextBox.ReadOnly = false;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("Deseja realmente excluir o link", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //remove e atualiza
                this.linksBindingSource.RemoveCurrent();

                this.tableAdapterManager.UpdateAll(this.dataSetAnotaLink);

            }

        }
        //salva e atualiza 
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
                this.Validate();
                this.linksBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetAnotaLink);
                        
            {
                {

                    //compara se a entrada de dados está vazia

                    if (linkTextBox.Text == ("") && (descricao_do_linkTextBox.Text == ("")))
                    {
                        MessageBox.Show("Campo do link tem que ser preenchido");

                    }
                    else
                    {
                        MessageBox.Show("Link salvo com sucesso");

                        linkTextBox.Focus();

                    }
                }
            }
        }



        // entranda no link 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkTextBox.Text == ("") && (descricao_do_linkTextBox.Text == ("")))
            {
                MessageBox.Show("Campo do link tem que ser preenchido");
                linkTextBox.Focus();

            }
            else
            {
                System.Diagnostics.Process.Start(linkTextBox.Text);

            }
        }
           

            private void descricao_do_linkTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void linkTextBox_TextChanged(object sender, EventArgs e)
            {

            }
                
                
                
              

         


        }


    }




      
        
  