using ContactsApp.connectionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class NewContactForm : Form
    {
        public NewContactForm()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        ContactController contactController = new ContactController();
        
        private void NewContactForm_Load(object sender, EventArgs e)
        {
            DataTable table = contactController.Select();
            dataGridViewContacts.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            contact.Name = textBoxName.Text;
            contact.Phone = textBoxPhone.Text;
            contact.Email = textBoxEmail.Text;
            contact.Address = textBoxAddress.Text;
            contact.Town = comboBoxTowns.Text;            
            if (contactController.Insert(
                textBoxName.Text,
                textBoxPhone.Text,
                textBoxEmail.Text,
                textBoxAddress.Text,
                comboBoxTowns.Text
                )) 
            {
                MessageBox.Show("New contact has been added to the database");
                Clear();
            }
            else
            {
                MessageBox.Show("Contact was not added to the database.");
            }
            DataTable table = contactController.Select();
            dataGridViewContacts.DataSource = table;
        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            if (contactController.Update( 
                textBoxName.Text,
                textBoxPhone.Text,
                textBoxEmail.Text,
                textBoxAddress.Text,
                comboBoxTowns.Text,
                int.Parse(textBoxID.Text)
                ))           
            {
                MessageBox.Show("Contact has been successfully Updated.");

                
                dataGridViewContacts.DataSource= contactController.Select();
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update Contact.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            contact.id = int.Parse(textBoxID.Text);            
            if (contactController.Delete(int.Parse(textBoxID.Text)))
            {
                MessageBox.Show("Contact has been deleted.");
                DataTable table = contactController.Select();
                dataGridViewContacts.DataSource = table;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete Contact.");
            }
        }

        static string myConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewContacts.DataSource = contactController.Search(textBoxSearch.Text);
        }

        public void Clear()
        {
            textBoxName.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            comboBoxTowns.Text = string.Empty;
            textBoxID.Text = "";
        }

        private void dataGridViewContacts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxID.Text = dataGridViewContacts.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewContacts.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxPhone.Text = dataGridViewContacts.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxEmail.Text = dataGridViewContacts.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridViewContacts.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxTowns.Text = dataGridViewContacts.Rows[rowIndex].Cells[5].Value.ToString();
        }        
    }
}
