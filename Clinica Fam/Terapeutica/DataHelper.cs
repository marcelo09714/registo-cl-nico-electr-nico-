using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Terapeutica
{
    public class DataHelper
    {
        public static string DATATABLE_CLIENTS      = "datatable_clients";
        public static string CLIENTS_NAME           = "name";
        public static string CLIENTS_BIRTHDAY       = "birthday";
        public static string CLIENTS_GENDER         = "gender";
        public static string CLIENTS_ID             = "id";
        public static string CLIENTS_NUTENTE        = "nutente";
        public static string CLIENTS_NCC            = "CC";
        public static string CLIENTS_MORADA         = "morada";
        public static string CLIENTS_CONTACTO       = "contacto";
        public static string CLIENTS_EMAIL          = "email";
        public static string CLIENTS_SUBSISTEMA     = "subsistema";

        public static string DATATABLE_TERAPIES     = "datatable_medications";
        public static string MEDICATIONS_QTD        = "qtd";
        public static string MEDICATIONS_POSOLOGY   = "posology";
        public static string MEDICATIONS_CLIENT_ID  = "client_id";
        public static string MEDICATIONS_ID         = "id";
        public static string MEDICATIONS_NAME       = "name";

        public static string DATATABLE_TRATAMENTO    = "datatable_tratamento";

        DataSet dataSet;
        DataTable tableClients;
        DataTable tableMedicactions;
        DataTable tableTratamento;

        String filePath = "therapies.xml";
        

        public DataTable TableClients
        {
            get
            {
                return tableClients;
            }

            set
            {
                tableClients = value;
            }
        }

        public DataTable TableMedicactions
        {
            get
            {
                return tableMedicactions;
            }

            set
            {
                tableMedicactions = value;
            }
        }

        public DataSet DataSet
        {
            get
            {
                return dataSet;
            }

            set
            {
                dataSet = value;
            }
        }

        public DataTable TableTratamento
        {
            get
            {
                return tableTratamento;
            }

            set
            {
                tableTratamento = value;
            }
        }

        public DataHelper()
        {
            DataSet = new DataSet("therapies_dataset");

            TableClients = new DataTable(DATATABLE_CLIENTS);
            TableClients.Columns.Add(CLIENTS_NAME);
            TableClients.Columns.Add(CLIENTS_BIRTHDAY);
            TableClients.Columns.Add(CLIENTS_GENDER);
            TableClients.Columns.Add(CLIENTS_ID);
            TableClients.Columns.Add(CLIENTS_NUTENTE);
            TableClients.Columns.Add(CLIENTS_NCC       );
            TableClients.Columns.Add(CLIENTS_MORADA    );
            TableClients.Columns.Add(CLIENTS_CONTACTO  );
            TableClients.Columns.Add(CLIENTS_EMAIL     );
            TableClients.Columns.Add(CLIENTS_SUBSISTEMA);

            TableMedicactions = new DataTable(DATATABLE_TERAPIES );
            TableMedicactions.Columns.Add(MEDICATIONS_NAME       );
            TableMedicactions.Columns.Add(MEDICATIONS_QTD        );
            TableMedicactions.Columns.Add(MEDICATIONS_POSOLOGY   );
            TableMedicactions.Columns.Add(MEDICATIONS_CLIENT_ID  );
            TableMedicactions.Columns.Add(MEDICATIONS_ID         );

            TableTratamento = new DataTable(DATATABLE_TRATAMENTO );
            TableTratamento.Columns.Add(CLIENTS_ID               );

            DataSet.Tables.Add(TableClients);
            DataSet.Tables.Add(TableMedicactions);
            DataSet.Tables.Add(TableTratamento);

            load();
        }



        public void save()
        {
            DataSet.WriteXml(filePath);
        }

        public void load()
        {
            try
            {
                DataSet.ReadXml(filePath);
            }
            catch (FileNotFoundException e)
            {

            }
        }
    }
}