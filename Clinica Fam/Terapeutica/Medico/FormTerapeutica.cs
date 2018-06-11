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
    public partial class FormTerapeutica : Form
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

        public FormTerapeutica(Client client)
        {
            this.clientToEdit = client;
            InitializeComponent();
            this.Text = client.Name;
            dataHelper = new DataHelper();

           // dataGridViewTerapies.DataSource = dataHelper.DataSet;
           // dataGridViewTerapies.DataMember = DataHelper.DATATABLE_TERAPIES;

            DataView dataView = dataHelper.DataSet.Tables[DataHelper.DATATABLE_TERAPIES].DefaultView;
            dataView.RowFilter = string.Format ("[{0}] = '{1}'", DataHelper.MEDICATIONS_CLIENT_ID,client.Id);
            dataGridViewTerapies.DataSource = dataView;

            dataGridViewTerapies.AutoGenerateColumns = true;
            dataGridViewTerapies.AutoResizeColumns();
        }

       private void ButtonAdd_click(object sender, EventArgs e)
        {

            Medication med = new Medication (textBoxMedName.Text, (float)numericUpDownQtd.Value, textBoxPosology.Text, clientToEdit.Id);

            
            Medication.addToDataBase(dataHelper, med);
            
        }
        
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            int indexToRemove = dataGridViewTerapies.CurrentCell.RowIndex;

            if (indexToRemove > -1)//faz com que se quisermos apagar algo que nao esta selecionado nao deie erro
            {
                DialogResult result = MessageBox.Show("Tem certeza que quer apagar o medicamento selecionado?", "Atenção!!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //clients.RemoveAt(indexToRemove);
                    Medication.removeFromDataBase(dataHelper, indexToRemove);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um Medicamento!");
            }
        }

       private void buttonEditar_Click(object sender, EventArgs e)
        {
            int indexEditar;
            indexEditar = dataGridViewTerapies.CurrentCell.RowIndex;

            if (indexEditar > -1)
            {
                DialogResult result = MessageBox.Show("Tem certeza que quer editar o medicamento selecionado?", "Atenção!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                   // Medication clientToEdit = new Medication (textBoxMedName.Text, (float)numericUpDownQtd.Value, textBoxPosology.Text);
                    /*
                    clientToEdit.Name = textBoxName.Text;
                    clientToEdit.DateTime = dateTimePickerBirthDate.Value;
                    clientToEdit.Gender = getCheckedGender();
                    */
                    //Medication.editOnDataBase(dataHelper, clientToEdit, indexEditar);
                }
            }
            else
                MessageBox.Show("Por favor selecione um cliente!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Doente adm = new Doente(clientToEdit);
            this.Hide();
            adm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "http://www.infarmed.pt/web/infarmed/servicos-on-line/pesquisa-do-medicamento";
            System.Diagnostics.Process.Start(url);
        }

        
    }
}
