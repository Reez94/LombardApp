using LombardApp.Interface;
using LombardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LombardApp
{
    public partial class frmAdminPanel : Form
    {

        public frmAdminPanel()
        {
            InitializeComponent();

            using DataBaseContext context = new DataBaseContext();

            IFormFunctions functions = new MockFormFunctions(context);

            foreach (var client in functions.GetAllClients())
            {
                ListViewItem listClients = new ListViewItem(client.Id.ToString());

                listClients.SubItems.Add(client.FirstName.ToString());
                listClients.SubItems.Add(client.LastName.ToString());
                listClients.SubItems.Add(client.PESEL.ToString());
                listClients.SubItems.Add(client.TelNumber.ToString());
                listClients.SubItems.Add(client.Address.ToString());

                listViewClients.Items.Add(listClients);
            }

           
            foreach (var items in functions.GetAllItems()) 
            {
                ListViewItem listItems = new ListViewItem(items.Id.ToString());

                listItems.SubItems.Add(items.ItemName.ToString());
                listItems.SubItems.Add(items.Price.ToString());
                listItems.SubItems.Add(items.ClientId.ToString());
                listItems.SubItems.Add(items.DatePledge.ToString());
                listItems.SubItems.Add(items.EndDatePledge.ToString());

                listViewItems.Items.Add(listItems);
            }
        }

        private void listViewClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewClients.Items.Count > 0)
            {
                this.txtFirstName.Text = listViewClients.SelectedItems[0].SubItems[1].Text.ToString();
                this.txtLastName.Text = listViewClients.SelectedItems[0].SubItems[2].Text.ToString();
                this.txtPesel.Text = listViewClients.SelectedItems[0].SubItems[3].Text.ToString();
                this.txtTel.Text = listViewClients.SelectedItems[0].SubItems[4].Text.ToString();
                this.txtAddress.Text = listViewClients.SelectedItems[0].SubItems[5].Text.ToString();
            }
        }
       
        private void listViewItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewClients.Items.Count > 0)
            {
                this.txtItemName.Text = listViewItems.SelectedItems[0].SubItems[1].Text.ToString();
                this.txtPrice.Text = listViewItems.SelectedItems[0].SubItems[2].Text.ToString();
                this.txtIdClient.Text = listViewItems.SelectedItems[0].SubItems[3].Text.ToString();
            }
        }



        /// <summary>
        /// Adding clients to the database
        /// </summary>
        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            Client newClient = new() { FirstName = txtFirstName.Text, LastName = txtLastName.Text, PESEL = long.Parse(txtPesel.Text), TelNumber = txtTel.Text, Address = txtAddress.Text };

            functions.AddClient(newClient);

            ClearTextBoxClients();
            RefreshPanel();
        }

        //Client edit
        private void btnChange_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            Client updatedClient = new() { Id = int.Parse(listViewClients.SelectedItems[0].Text), FirstName = txtFirstName.Text, LastName = txtLastName.Text, PESEL = long.Parse(txtPesel.Text), TelNumber = txtTel.Text, Address = txtAddress.Text };

            functions.UpdateClient(updatedClient);

            RefreshPanel();
        }

        //Clients clear
        private void btnClearClients_Click(object sender, EventArgs e)
        {
            ClearTextBoxClients();
        }

        /// Items clear
        private void btnClearItems_Click(object sender, EventArgs e)
        {
            ClearTextBoxItems();
        }

        /// <summary>
        /// Adding items to the database
        /// </summary>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            var ExpirationDate = DateTime.Now.AddDays(int.Parse(txtDays.Text)).ToShortDateString();

            PledgedItems item = new() { ItemName = txtItemName.Text, Price = int.Parse(txtPrice.Text), ClientId = int.Parse(txtIdClient.Text), DatePledge = DateTime.Now.ToShortDateString(), EndDatePledge = ExpirationDate };

            functions.AddItem(item);
            ClearTextBoxItems();
            RefreshPanel();
        }

        /// <summary>
        /// Edit item
        /// </summary>
        private void btnChangeItem_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            PledgedItems item = new() { Id = int.Parse(listViewItems.SelectedItems[0].Text), ItemName = txtItemName.Text, Price = int.Parse(txtPrice.Text), ClientId = int.Parse(txtIdClient.Text) };
            ClearTextBoxItems();
            functions.UpdateItem(item);
            RefreshPanel();
        }

        // Clear item box
        private void ClearTextBoxItems()
        {
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtIdClient.Text = "";
            txtDays.Text = "";
        }

        // Clear client box
        private void ClearTextBoxClients()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPesel.Text = "";
            txtTel.Text = "";
            txtAddress.Text = "";
        }
        /// <summary>
        /// Clients import
        /// </summary>
        private void btnImportClients_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki CSV | *.csv";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding());

                string s;
                int j = 0;

                List<Client> clientList = new List<Client>();

                while (!sr.EndOfStream)
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (j > 0)
                        {
                            string[] str = s.Split(',');

                            Client client = new Client();

                            client.FirstName = str[1].ToString();
                            client.LastName = str[2].ToString();
                            client.PESEL = long.Parse(str[3]);
                            client.TelNumber = str[4].ToString();
                            client.Address = str[5].ToString();

                            clientList.Add(client);
                        }
                        j++;
                    }
                }
                functions.ImportClients(clientList);
                RefreshPanel();
                MessageBox.Show("Pomyślnie importowano klientów!");
            }
        }
        /// <summary>
        /// Clients export
        /// </summary>
        private void btnExportClients_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            StringBuilder sb = new StringBuilder();

            sb.Append("Name, \"FirstName\", \"LastName\", \"PESEL\", \"TelNumber\", \"Address\"").AppendLine();

            foreach (var client in functions.GetAllClients())
            {
                sb.Append(client.Id).Append(",");
                sb.Append(client.FirstName).Append(",");
                sb.Append(client.LastName).Append(",");
                sb.Append(client.PESEL).Append(",");
                sb.Append(client.TelNumber).Append(",");
                sb.Append(client.Address);
                sb.AppendLine();
            }

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV | *.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                }
            }

        }
        /// <summary>
        /// Items export
        /// </summary>
        private void btnImportItems_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki CSV | *.csv";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding());

                string s;
                int j = 0;

                List<PledgedItems> itemsList = new List<PledgedItems>();

                while (!sr.EndOfStream)
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (j > 0)
                        {
                            string[] str = s.Split(',');

                            PledgedItems item = new PledgedItems();

                            item.ItemName = str[1].ToString();
                            item.Price = int.Parse(str[2]);
                            item.ClientId = int.Parse(str[3]);
                            item.DatePledge = str[4].ToString();
                            item.EndDatePledge = str[5].ToString();

                            itemsList.Add(item);
                        }
                        j++;
                    }
                }
                functions.ImportItems(itemsList);
                RefreshPanel();
                MessageBox.Show("Pomyślnie importowano przedmioty!");
            }
        }
        /// <summary>
        /// Items import
        /// </summary>
        private void btnExportItems_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            StringBuilder sb = new StringBuilder();

            sb.Append("Name, \"ItemName\", \"Price\", \"ClientId\", \"DatePledge\", \"EndDatePledge\"").AppendLine();

            foreach (var client in functions.GetAllItems())
            {
                sb.Append(client.Id).Append(",");
                sb.Append(client.ItemName).Append(",");
                sb.Append(client.Price).Append(",");
                sb.Append(client.ClientId).Append(",");
                sb.Append(client.DatePledge).Append(",");
                sb.Append(client.EndDatePledge);
                sb.AppendLine();
            }

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV | *.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                }
            }
        }

        /// <summary>
        /// Refresh window
        /// </summary>
        private void RefreshPanel()
        {
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
            this.Close();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            Client removeClient = new()
            {
                Id = int.Parse(listViewClients.SelectedItems[0].Text),
                FirstName = listViewClients.SelectedItems[0].SubItems[1].Text,
                LastName = listViewClients.SelectedItems[0].SubItems[2].Text,
                PESEL = long.Parse(listViewClients.SelectedItems[0].SubItems[3].Text),
                TelNumber = listViewClients.SelectedItems[0].SubItems[4].Text,
                Address = listViewClients.SelectedItems[0].SubItems[5].Text
            };


            functions.RemoveClient(removeClient);
            RefreshPanel();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFormFunctions functions = new MockFormFunctions(context);

            PledgedItems removeItem = new()
            { 
                Id = int.Parse(listViewItems.SelectedItems[0].Text), 
                ItemName = listViewItems.SelectedItems[0].SubItems[1].Text, 
                Price = int.Parse(listViewItems.SelectedItems[0].SubItems[2].Text), 
                ClientId = int.Parse(listViewItems.SelectedItems[0].SubItems[3].Text)
            };


            functions.RemoveItem(removeItem);
            RefreshPanel();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
