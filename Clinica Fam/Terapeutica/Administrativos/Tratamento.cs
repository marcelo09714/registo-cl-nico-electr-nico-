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

    public partial class Tratamento : Form
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

        public Tratamento(Client client)
        {
            this.clientToEdit = client;
            InitializeComponent();
            this.Text = client.Name;
            dataHelper = new DataHelper();

            DataView dataView = dataHelper.DataSet.Tables[DataHelper.DATATABLE_TRATAMENTO].DefaultView;
           // dataView.RowFilter = string.Format("[{0}] = '{1}'", DataHelper.DATATABLE_TRATAMENTO);
            dataGridViewTratamento.DataSource = dataView;

            dataGridViewTratamento.AutoGenerateColumns = true;
            dataGridViewTratamento.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tratamento adm = new Tratamento(clientToEdit);
            this.Hide();
            adm.ShowDialog();
        }

        /*
                private void button6_Click(object sender, EventArgs e)
                {
                    Doente adm = new Doente(clientToEdit);
                    this.Hide();
                    adm.ShowDialog();
                }*/

    }
}
