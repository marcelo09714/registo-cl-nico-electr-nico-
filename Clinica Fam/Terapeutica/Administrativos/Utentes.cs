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
    public partial class Utentes : Form
    {
        DataHelper dataHelper;

        public Utentes()
        {
            InitializeComponent();
            labelData.BackColor = Color.Transparent;
            labelHora.BackColor = Color.Transparent;
            labelData.Text = DateTime.Now.ToLongDateString();

            dataHelper = new DataHelper();
            //clients = Client.getClientsList(dataHelper);
            dataGridViewClient.DataSource = dataHelper.DataSet;
            dataGridViewClient.DataMember = DataHelper.DATATABLE_CLIENTS;
            dataGridViewClient.AutoGenerateColumns = true;
            dataGridViewClient.AutoResizeColumns();

            //conta o tempo
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrativo adm = new Administrativo();
            this.Hide();
            adm.ShowDialog();
        }

        private void Utentes_Load(object sender, EventArgs e)
        {

        }
    }
}
