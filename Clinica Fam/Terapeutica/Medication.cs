using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terapeutica
{
   public class Medication
    {
        //propriedades 

        String name;

        float quantity;

        String posology;

        long id;

        long clientId;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string Posology
        {
            get
            {
                return posology;
            }

            set
            {
                posology = value;
            }
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public long ClientID
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }


        //construtor

        public Medication( String name, float quantity, String posology, long clientId)
        {
            this.name = name;
            this.quantity = quantity;
            this.posology = posology;
            this.clientId = clientId;
            this.id = Utils.CurrentTimeMillis();
        }
        public Medication(String name, float quantity, String posology, long clientId, long id)
        {
            this.name = name;
            this.quantity = quantity;
            this.posology = posology;
            this.clientId = clientId;
            this.id = id;
        }


        //CRUD

        //CREATE
        public static void addToDataBase(DataHelper datahelper, Medication medication)
        {
            DataRow datarow = datahelper.TableMedicactions.NewRow();

            datarow[DataHelper.MEDICATIONS_NAME       ] = medication.Name;
            datarow[DataHelper.MEDICATIONS_QTD        ] = medication.Quantity;
            datarow[DataHelper.MEDICATIONS_POSOLOGY   ] = medication.Posology;
            datarow[DataHelper.MEDICATIONS_CLIENT_ID  ] = medication.ClientID;
            datarow[DataHelper.MEDICATIONS_ID         ] = medication.Id;

            datahelper.TableMedicactions.Rows.Add(datarow);
            datahelper.save();
        }

        //Read
        public static Medication readOnDataBase(DataHelper datahelper, int index)
        {
            Medication medication;

            DataRow datarow = datahelper.TableMedicactions.NewRow();

            medication = new Medication (

                 (String)datarow[DataHelper.MEDICATIONS_NAME],
                 float.Parse((String)datarow[DataHelper.MEDICATIONS_QTD]),
                 ((String)datarow[DataHelper.MEDICATIONS_POSOLOGY]),
                 long.Parse((String)datarow[DataHelper.MEDICATIONS_CLIENT_ID]),
                 long.Parse((String)datarow[DataHelper.MEDICATIONS_ID]));

            return medication;

        }

        //Update
        public static void editOnDataBase(DataHelper datahelper, Medication medication, int index)
        {
            DataRow datarow = datahelper.TableMedicactions.Rows[index];

            datarow[DataHelper.MEDICATIONS_NAME       ] = medication.Name;
            datarow[DataHelper.MEDICATIONS_QTD        ] = medication.Quantity;
            datarow[DataHelper.MEDICATIONS_POSOLOGY   ] = medication.Posology;
            datarow[DataHelper.MEDICATIONS_CLIENT_ID  ] = medication.ClientID;
            datarow[DataHelper.MEDICATIONS_ID         ] = medication.Id;
            
            datahelper.save();
        }

        //Delete
        public static void removeFromDataBase(DataHelper datahelper, int indexToRemove)
        {
            datahelper.TableMedicactions.Rows.RemoveAt(indexToRemove);
            datahelper.save();
        }

        public static List<Medication> getMedicationsList(DataHelper datahelper)
        {

            List<Medication> medications = new List<Medication>();

            foreach (DataRow datarow in datahelper.TableMedicactions.Rows)
            {

                String name     = (String)datarow[DataHelper.MEDICATIONS_NAME];
                float quantity   = float.Parse((String)datarow[DataHelper.MEDICATIONS_QTD]);
                String posology = ((String)datarow[DataHelper.MEDICATIONS_POSOLOGY]);
                long clientId = long.Parse((String)datarow[DataHelper.MEDICATIONS_CLIENT_ID]);
                long id         = long.Parse((String)datarow[DataHelper.MEDICATIONS_ID]);
                

                medications.Add(new Medication(name,quantity,posology,clientId, id));
            }

            return medications;
        }
        
    }
}
