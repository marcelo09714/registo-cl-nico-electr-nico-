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
    public partial class Enfermeiro : Form
    {
       

        DataHelper dataHelper;
        
        public Enfermeiro()
        {
            InitializeComponent();

            dataHelper = new DataHelper();
            //clients = Client.getClientsList(dataHelper);
            dataGridViewClient.DataSource = dataHelper.DataSet;
            dataGridViewClient.DataMember = DataHelper.DATATABLE_CLIENTS;
            dataGridViewClient.AutoGenerateColumns = true;
            dataGridViewClient.AutoResizeColumns();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login adm = new Login();
            this.Hide();
            adm.ShowDialog();
        }

        private void DataGridViewClient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridViewClient.CurrentCell.RowIndex;

            if (index > -1)
            {

                Client client = Client.readOnDataBase(dataHelper, index);

                Tratamento tratamento = new Tratamento(client);

                tratamento.Show();

            }
        }
        /*
        private void button4_Click(object sender, EventArgs e)
        {
            Login adm = new Login();
            this.Hide();
            adm.ShowDialog();
        }*/
    }
    
}
