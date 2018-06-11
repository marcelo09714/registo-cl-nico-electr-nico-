using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terapeutica
{
   public enum GenderType { Masculino, Feminino };
   
   public class Client
    {
        List<Medication> medication;

        String name;
        String nutente;
        String ncc;
        String morada;
        String email;
        String contacto;
        String subsistema;


        DateTime dateTime;

        long id;

        GenderType gender;

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

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
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

        public GenderType Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public List<Medication> Medication
        {
            get
            {
                return medication;
            }

            set
            {
                medication = value;
            }
        }

        public string Nutente
        {
            get
            {
                return nutente;
            }

            set
            {
                nutente = value;
            }
        }

        public string Ncc
        {
            get
            {
                return ncc;
            }

            set
            {
                ncc = value;
            }
        }

        public string Morada
        {
            get
            {
                return morada;
            }

            set
            {
                morada = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Contacto
        {
            get
            {
                return contacto;
            }

            set
            {
                contacto = value;
            }
        }

        public string Subsistema
        {
            get
            {
                return subsistema;
            }

            set
            {
                subsistema = value;
            }
        }

        public Client(String name, DateTime dateTime, GenderType gender, String nutente, String ncc, String morada, String email, String contacto, String subsistema)
        {
            this.name = name;
            this.dateTime = dateTime;
            this.gender = gender;
            this.nutente = nutente;
            this.ncc = ncc;
            this.morada = morada;
            this.email = email;
            this.contacto = contacto;
            this.Subsistema = subsistema;

            this.id = Utils.CurrentTimeMillis();
        }

        public Client(String name, DateTime dateTime, GenderType gender, long id,String nutente, String ncc, String morada, String email, String contacto, String subsistema)
        {
            this.name = name;
            this.dateTime = dateTime;
            this.gender = gender;
            this.nutente = nutente;
            this.ncc = ncc;
            this.morada = morada;
            this.email = email;
            this.contacto = contacto;
            this.Subsistema = subsistema;
            this.id = id;
        }

        //CRUD

        //CREATE
        public static void addToDataBase(DataHelper datahelper, Client client)
        {
            DataRow datarow = datahelper.TableClients.NewRow();

            datarow[DataHelper.CLIENTS_NAME] = client.Name;
            datarow[DataHelper.CLIENTS_BIRTHDAY] = client.DateTime;
            datarow[DataHelper.CLIENTS_GENDER] = client.Gender;
            datarow[DataHelper.CLIENTS_ID] = client.Id;
            datarow[DataHelper.CLIENTS_NUTENTE] = client.Nutente;
            datarow[DataHelper.CLIENTS_NCC     ] = client.Ncc;
            datarow[DataHelper.CLIENTS_MORADA  ] = client.Morada;
            datarow[DataHelper.CLIENTS_EMAIL   ] = client.Email;
            datarow[DataHelper.CLIENTS_CONTACTO] = client.Contacto;
            datarow[DataHelper.CLIENTS_SUBSISTEMA] = client.Subsistema;

            datahelper.TableClients.Rows.Add(datarow);
            datahelper.save();
        }

        //READ
        public static Client readOnDataBase(DataHelper datahelper, int index)
        {
            Client client;

            DataRow datarow = datahelper.TableClients.Rows[index];

            client = new Client(

            (String)datarow[DataHelper.CLIENTS_NAME],
             DateTime.Parse((String)datarow[DataHelper.CLIENTS_BIRTHDAY]),
            parseGender((String)datarow[DataHelper.CLIENTS_GENDER]),
            long.Parse((String)datarow[DataHelper.CLIENTS_ID]),
            (String)datarow[DataHelper.CLIENTS_NUTENTE ],
            (String)datarow[DataHelper.CLIENTS_NCC     ],
            (String)datarow[DataHelper.CLIENTS_MORADA  ],
            (String)datarow[DataHelper.CLIENTS_EMAIL   ],
            (String)datarow[DataHelper.CLIENTS_CONTACTO],
            (String)datarow[DataHelper.CLIENTS_SUBSISTEMA]
            );

            return client;
        }

        //update
        public static void editOnDataBase(DataHelper datahelper, Client client, int indexEditar)
        {
            DataRow datarow = datahelper.TableClients.Rows[indexEditar];

            datarow[DataHelper.CLIENTS_NAME] = client.Name;
            datarow[DataHelper.CLIENTS_BIRTHDAY] = client.DateTime;
            datarow[DataHelper.CLIENTS_GENDER] = client.Gender;
            datarow[DataHelper.CLIENTS_ID] = client.Id;

            datahelper.TableClients.Rows.Add(datarow);
            datahelper.save();
        }

        //DELETE
        public static void removeFromDataBase(DataHelper dataHelper, int indexToRemove)
        {
            dataHelper.TableClients.Rows.RemoveAt(indexToRemove);
            dataHelper.save();
        }
       

        public static List<Client> getClientsList(DataHelper datahelper)
        {
            List<Client> clients = new List<Client>();

            foreach(DataRow dataRow in datahelper.TableClients.Rows)
            {
                String name = (String)dataRow[DataHelper.CLIENTS_NAME];
                DateTime birthday = (DateTime)dataRow[DataHelper.CLIENTS_BIRTHDAY];
                GenderType gender = (GenderType)dataRow[DataHelper.CLIENTS_GENDER];
                String nutente = (String)dataRow[DataHelper.CLIENTS_NUTENTE ];
                String ncc = (String)dataRow[DataHelper.    CLIENTS_NCC     ];
                String morada = (String)dataRow[DataHelper. CLIENTS_MORADA  ];
                String email = (String)dataRow[DataHelper.  CLIENTS_EMAIL   ];
                String contacto= (String)dataRow[DataHelper.CLIENTS_CONTACTO];
                String subsistema = (String)dataRow[DataHelper.CLIENTS_SUBSISTEMA];

                clients.Add(new Client(name,birthday,gender,nutente,ncc,morada,email,contacto,subsistema));
            }
            return clients;
        }

        public static GenderType parseGender(String strGender)
        {
            if (strGender.CompareTo("Masculino") == 0)
            {
                return GenderType.Masculino;
            }
            else
            {
                return GenderType.Feminino;
            }
           
        }
       
    }
}
