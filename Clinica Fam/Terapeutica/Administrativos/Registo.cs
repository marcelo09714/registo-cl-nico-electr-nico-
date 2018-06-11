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
    public partial class Registo : Form
    {
        //modelo de dados
        //List <Client> clients = new List<Client>();
        DataHelper dataHelper;


        public Registo()
        {
            InitializeComponent();
            dataHelper = new DataHelper();
            //clients = Client.getClientsList(dataHelper);
            dataGridViewClient.DataSource = dataHelper.DataSet;
            dataGridViewClient.DataMember = DataHelper.DATATABLE_CLIENTS;
            dataGridViewClient.AutoGenerateColumns = true;
            dataGridViewClient.AutoResizeColumns();

            labelData.BackColor = Color.Transparent;
            labelHora.BackColor = Color.Transparent;
            labelData.Text = DateTime.Now.ToLongDateString();

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            Client clientToAdd = new Client(textBoxName.Text, dateTimePickerBirthDate.Value, getCheckedGender(), textBox3.Text, textBox5.Text, textBox4.Text, textBox2.Text, textBox1.Text, textBox6.Text);
           
            //clients.Add(clientToAdd);
            Client.addToDataBase(dataHelper, clientToAdd);
            
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            int indexToRemove = dataGridViewClient.CurrentCell.RowIndex;//listBoxClientes.SelectedIndex;

            if (indexToRemove > -1)//faz com que se quisermos apagar algo que nao esta selecionado nao deie erro
            {
                DialogResult result = MessageBox.Show("Tem certeza que quer apagar o cliente selecionado?", "Atenção", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //clients.RemoveAt(indexToRemove);
                    Client.removeFromDataBase(dataHelper, indexToRemove);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente!");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int indexEditar;
            indexEditar = dataGridViewClient.CurrentCell.RowIndex;// listBoxClientes.SelectedIndex;

            if (indexEditar > -1)
            {
                DialogResult result = MessageBox.Show("Tem certeza que quer editar o cliente selecionado?", "Atenção", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Client clientToEdit = new Client(textBoxName.Text, dateTimePickerBirthDate.Value, getCheckedGender(), textBox3.Text, textBox5.Text, textBox4.Text, textBox2.Text, textBox1.Text, textBox6.Text);

                    /*
                    clientToEdit.Name = textBoxName.Text;
                    clientToEdit.DateTime = dateTimePickerBirthDate.Value;
                    clientToEdit.Gender = getCheckedGender();
                    */
                    Client.editOnDataBase(dataHelper, clientToEdit, indexEditar);
                }
            }
            else
                MessageBox.Show("Por favor selecione um cliente!");
        }

        GenderType getCheckedGender()
        {
            bool isMasculino = radioButtonMasculino.Checked;
            GenderType gender;
            if (isMasculino) gender = GenderType.Masculino;
            else gender = GenderType.Feminino;
            return gender;
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Administrativo adm = new Administrativo();
            this.Hide();
            adm.ShowDialog();
        }
    }
}
