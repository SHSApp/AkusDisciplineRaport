using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace SHSApp
{
    class Settings
    {
        private OleDbConnection Conn = null;
        //public static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=settings.mdb;";
        public static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=settings.mdb;";
        private DataTable Dpnk = null;
        private DataTable Material = null;
        private DataTable Personal = null;
        private DataTable Places = null;
        private DataTable Options = null;
        private DataTable ExceptZ = null;

        //public string 

        public Settings()
        {
            Conn = new OleDbConnection(ConnectionString);
        }

        public void LoadTables()
        {
            if (Conn != null)
            {
                try
                {
                    Conn.Open();
                    Dpnk = new DataTable();
                    Material = new DataTable();
                    Personal = new DataTable();
                    Places = new DataTable();
                    Options = new DataTable();
                    ExceptZ = new DataTable();
                    //string query = "SELECT * FROM DPNK";
                    //OleDbCommand command = new OleDbCommand(query, Conn);
                    //Dpnk.Load(command.ExecuteReader());
                    OleDbCommand oCmd = Conn.CreateCommand();
                    oCmd.CommandText = "SELECT * FROM DPNK ORDER BY ID";
                    Dpnk.Load(oCmd.ExecuteReader());
                    oCmd.CommandText = "SELECT * FROM Material ORDER BY ID";
                    Material.Load(oCmd.ExecuteReader());
                    oCmd.CommandText = "SELECT * FROM Personal ORDER BY ID";
                    Personal.Load(oCmd.ExecuteReader());
                    oCmd.CommandText = "SELECT * FROM Places ORDER BY ID";
                    Places.Load(oCmd.ExecuteReader());
                    oCmd.CommandText = "SELECT * FROM Options ORDER BY ID";
                    Options.Load(oCmd.ExecuteReader());
                    oCmd.CommandText = "SELECT * FROM ExceptZ";
                    ExceptZ.Load(oCmd.ExecuteReader());
                    Conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public bool IsExcept(string ID)
        {
            foreach (DataRow dr in ExceptZ.Rows)
            {
                if (dr[1].ToString() == ID) return true;
            }
            return false;
        }

        public string GetParameterByID(int ID)
        {
            return Options.Rows[ID].ItemArray[2].ToString();
        }
        public string GetDpnkByID(int ID)
        {
            return Dpnk.Rows[ID].ItemArray[2].ToString() + " в/с " + Dpnk.Rows[ID].ItemArray[1].ToString();
        }

        public void FillHeadersByID(ComboBox cb, int ID)
        {
            switch (ID)
            {
                case 0:
                    for (int i = 0; i < Dpnk.Rows.Count; i++)
                    {
                        cb.Items.Add(Dpnk.Rows[i].ItemArray[1]);
                        cb.SelectedIndex = 0;
                    }
                    break;
                case 1:
                    for (int i = 0; i < Material.Rows.Count; i++)
                    {
                        cb.Items.Add(Material.Rows[i].ItemArray[1]);
                        cb.SelectedIndex = 0;
                    }
                    break;
                case 2:
                    for (int i = 0; i < Personal.Rows.Count; i++)
                    {
                        cb.Items.Add(Personal.Rows[i].ItemArray[2].ToString() + " - " + Personal.Rows[i].ItemArray[1].ToString());
                        cb.SelectedIndex = 0;
                    }
                    break;
                case 3:
                    for (int i = 0; i < Places.Rows.Count; i++)
                    {
                        cb.Items.Add(Places.Rows[i].ItemArray[1]);
                        cb.SelectedIndex = 0;
                    }
                    break;
                case 4:
                    for (int i = 0; i < Options.Rows.Count; i++)
                    {
                        cb.Items.Add(Options.Rows[i].ItemArray[1]);
                        cb.SelectedIndex = 0;
                    }
                    break;
            }               
        }

        public string GetPlaceByID(int ID)
        {
            return Places.Rows[ID].ItemArray[2].ToString();
        }

        public string GetPersonalDoljnostByID(int ID, bool Sklonenie)
        {
            if (!Sklonenie)
            {
                return Personal.Rows[ID].ItemArray[2].ToString();
            }
            else
            {
                return Personal.Rows[ID].ItemArray[5].ToString();
            }
        }

        public string GetPersonalZvanieByID(int ID, bool Sklonenie)
        {
            if (!Sklonenie)
            {
                return Personal.Rows[ID].ItemArray[3].ToString();
            }
            else
            {
                return Personal.Rows[ID].ItemArray[6].ToString();
            }
        }

        public string GetPersonalFIOByID(int ID, bool Sklonenie)
        {
            if (!Sklonenie)
            {
                return Personal.Rows[ID].ItemArray[1].ToString();
            }
            else
            {
                return Personal.Rows[ID].ItemArray[4].ToString();
            }
        }

        public string GetPersonalFullNameByID(int ID, bool Sklonenie)
        {
            if (!Sklonenie)
            {
                return Personal.Rows[ID].ItemArray[2].ToString() + " " 
                    + Personal.Rows[ID].ItemArray[3].ToString() + " внутренней службы " + Personal.Rows[ID].ItemArray[1].ToString();
            }
            else
            {
                return Personal.Rows[ID].ItemArray[5].ToString() + " "
                    + Personal.Rows[ID].ItemArray[6].ToString() + " внутренней службы " + Personal.Rows[ID].ItemArray[4].ToString();
            }
        }

        public string GetMaterialPreambulaByID(int ID)
        {
            return Material.Rows[ID].ItemArray[2].ToString();
        }

        public string GetMaterialTextByID(int ID)
        {
            return Material.Rows[ID].ItemArray[3].ToString();
        }

        public string GetMST(int ID)
        {
            return Material.Rows[ID][1].ToString();
        }

        public string GetMaterialText2ByID(int ID)
        {
            return Material.Rows[ID].ItemArray[4].ToString();
        }

        public string GetMaterialPvrByID(int ID)
        {
            return Material.Rows[ID].ItemArray[5].ToString();
        }

        public string GetMaterialVideoTextByID(int ID)
        {
            return Material.Rows[ID].ItemArray[6].ToString();
        }

        public string GetMaterialOtkazByID(int ID)
        {
            return Material.Rows[ID].ItemArray[7].ToString();
        }

    }
}
