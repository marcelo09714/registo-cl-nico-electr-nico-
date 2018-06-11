using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terapeutica
{
    public partial class Doente : Form
    {
        Client clientToEdit;

        public Client ClientToEdit
        {
            get
            {
                return clientToEdit;
            }

            set
            {
                clientToEdit = value;
            }
        }

        DataHelper dataHelper;

        public Doente(Client client)
        {
            this.clientToEdit = client;
            InitializeComponent();
            this.Text = client.Name;
            dataHelper = new DataHelper();

           
            DataView dataView = dataHelper.DataSet.Tables[DataHelper.DATATABLE_TERAPIES].DefaultView;
            dataView.RowFilter = string.Format("[{0}] = '{1}'", DataHelper.MEDICATIONS_CLIENT_ID, client.Id);
            dataGridViewClient.DataSource = dataView;

            dataGridViewClient.AutoGenerateColumns = true;
            dataGridViewClient.AutoResizeColumns();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Medico adm = new Medico();
            this.Hide();
            adm.ShowDialog();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            FormTerapeutica adm = new FormTerapeutica(clientToEdit);
            this.Hide();
            adm.ShowDialog();
        }
    }
}
