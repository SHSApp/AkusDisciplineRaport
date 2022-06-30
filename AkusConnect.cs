using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using FSLib.Declension;

namespace SHSApp
{
    class AkusConnect
    {
        private OleDbConnection Conn = null;
        private DataTable result = null;
        public static string ConnectionString = "Provider=VFPOLEDB.1;Data Source=C:\\IK\\Database\\;Password=\"\";Collating Sequence=MACHINE;";
        //public static string ConnectionString = @"DRIVER={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=C:\\IK\\Database;Exclusive=No;BackgroundFetch=No;Collate=Machine;Null=No;Deleted=No;";

        public void SetDbPath(string path)
        {
            ConnectionString = "Provider=VFPOLEDB.1;Data Source=" + path + ";Password=\"\";Collating Sequence=MACHINE;";
        }

        private string GetStatiaFromQualif(string ID, string qualif)
        {
            if (Conn != null)
            {
                try
                {
                    Conn.ConnectionString = ConnectionString;
                    Conn.Open();
                    int IDcount = ID.TrimEnd(' ').Length / 2;
                    DataTable res = new DataTable();
                    OleDbCommand oCmd = Conn.CreateCommand();
                    for (int i = 0; i < IDcount; i++)
                    {
                        oCmd.CommandText = "SELECT item, name FROM Qualif\\" + qualif + " WHERE item LIKE '" + ID.Substring(2 * i, 2) + "'";
                        res.Load(oCmd.ExecuteReader());
                    }
                    Conn.Close();
                    string result = "ст. ";
                    for (int i = 0; i < res.Rows.Count; i++)
                    {
                        if (i == (res.Rows.Count - 1))
                        {
                            result = result + res.Rows[i].ItemArray[1].ToString().TrimEnd(' ') + " УК РФ";
                        }
                        else
                        {
                            result = result + res.Rows[i].ItemArray[1].ToString().TrimEnd(' ') + ", ";
                        }
                    }
                    return result;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return "";
        }

        private string GetOtryadFromQualif(string ID, string qualif)
        {
            ID = ID.TrimEnd(' ');
            if ((Conn != null) && (ID != ""))
            {
                try
                {
                    Conn.Open();
                    DataTable res = new DataTable();
                    OleDbCommand oCmd = Conn.CreateCommand();
                    oCmd.CommandText = "SELECT item, name FROM Qualif\\" + qualif + " WHERE item LIKE '" + ID + "'";
                    res.Load(oCmd.ExecuteReader());
                    Conn.Close();
                    return res.Rows[0].ItemArray[1].ToString().TrimEnd(' ');
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return "Карантин";
        }

        public void Execute(string ID)
        {

            if (Conn != null)
            {
                try
                {
                    Conn.ConnectionString = ConnectionString;
                    Conn.Open();
                    result = new DataTable();
                    OleDbCommand oCmd = Conn.CreateCommand();
                    oCmd.CommandText = "SELECT proper(vfamily), vname, vlastname, vdatar, vosustatia, vsroklet, " +
                        "vsrokmes, vsrokdney, vnachsroka, vkonecsrok, vnomotr FROM Data\\card WHERE itemperson = ?";
                    oCmd.Parameters.Add(new OleDbParameter("itemperson", OleDbType.WChar));
                    oCmd.Parameters["itemperson"].Value = ID;
                    result.Load(oCmd.ExecuteReader());
                    Conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public string GetRandomZekID()
        {
            if (Conn != null)
            {
                try
                {
                    Conn.ConnectionString = ConnectionString;
                    Conn.Open();
                    DataTable res = new DataTable();
                    Random ran = new Random();
                    int s = ran.Next(1, 19);
                    OleDbCommand oCmd = Conn.CreateCommand();
                    oCmd.CommandText = "SELECT itemperson FROM Data\\card WHERE vpr_osv == 0 and vpobeg == 0 and vubylpost == 0 and vumer == 0 and vsroklet == ?";
                    oCmd.Parameters.Add(new OleDbParameter("vsroklet", OleDbType.Numeric));
                    oCmd.Parameters["vsroklet"].Value = s;
                    res.Load(oCmd.ExecuteReader());
                    Conn.Close();
                    if (res.Rows.Count > 0) return res.Rows[ran.Next(0, res.Rows.Count - 1)][0].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return "";
        }

        public AkusConnect()
        {
            Conn = new OleDbConnection();
        }

        public string GetFullFIO(int padej)
        {
            string surname = result.Rows[0].ItemArray[0].ToString().TrimEnd(' ');
            string name = result.Rows[0].ItemArray[1].ToString().TrimEnd(' ');
            string otchestvo = result.Rows[0].ItemArray[2].ToString().TrimEnd(' ');
            string fio = surname + " " + name +  " " + otchestvo;
            switch (padej)
            {
                case 0:
                    return fio;
                case 1:
                    return Declension1251.GetSNPDeclension(surname, name, otchestvo, Gender.MasculineGender, DeclensionCase.Tvorit);
                case 2:
                    return Declension1251.GetSNPDeclension(surname, name, otchestvo, Gender.MasculineGender, DeclensionCase.Rodit);
                case 3:
                    return Declension1251.GetSNPDeclension(surname, name, otchestvo, Gender.MasculineGender, DeclensionCase.Datel);
                case 4:
                    return Declension1251.GetSNPDeclension(surname, name, otchestvo, Gender.MasculineGender, DeclensionCase.Vinit);
                default:
                    return fio;
            }
        }

        public string GetFIO(int padej)
        {
            switch (padej)
            {
                case 0:
                    return result.Rows[0].ItemArray[0].ToString().TrimEnd(' ') +
                        " " + result.Rows[0].ItemArray[1].ToString().TrimEnd(' ').Substring(0,1).ToUpper() + "." +
                        result.Rows[0].ItemArray[2].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + ".";
                case 1:
                    return Declension1251.GetSNPDeclension(result.Rows[0].ItemArray[0].ToString().TrimEnd(' ') +
                        " " + result.Rows[0].ItemArray[1].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + "." +
                        result.Rows[0].ItemArray[2].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + ".",
                        Gender.MasculineGender, DeclensionCase.Tvorit);
                case 2:
                    return Declension1251.GetSNPDeclension(result.Rows[0].ItemArray[0].ToString().TrimEnd(' ') +
                        " " + result.Rows[0].ItemArray[1].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + "." +
                        result.Rows[0].ItemArray[2].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + ".",
                        Gender.MasculineGender, DeclensionCase.Rodit);
                case 3:
                    return Declension1251.GetSNPDeclension(result.Rows[0].ItemArray[0].ToString().TrimEnd(' ') +
                        " " + result.Rows[0].ItemArray[1].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + "." +
                        result.Rows[0].ItemArray[2].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + ".",
                        Gender.MasculineGender, DeclensionCase.Datel);
                default:
                    return result.Rows[0].ItemArray[0].ToString().TrimEnd(' ') +
                        " " + result.Rows[0].ItemArray[1].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + "." +
                        result.Rows[0].ItemArray[2].ToString().TrimEnd(' ').Substring(0, 1).ToUpper() + ".";
            }
        }

        public string GetBirthday()
        {
            return result.Rows[0].ItemArray[3].ToString().TrimEnd(' ');
        }

        private string GetNS()
        {
            return result.Rows[0].ItemArray[8].ToString().TrimEnd(' ');
        }

        private string GetKS()
        {
            return result.Rows[0].ItemArray[9].ToString().TrimEnd(' ');
        }

        public string GetZekData()
        {
            return GetStatiaFromQualif(result.Rows[0].ItemArray[4].ToString(), "pc8") + ", " +
                GetFormattedSrokSimple() + ", начало срока " + GetNS() + " г., конец срока " + GetKS() + " г.";
        }

        public string GetNomerOtryada(int padej)
        {
            string res = "";
            string otrjad = GetOtryadFromQualif(result.Rows[0].ItemArray[10].ToString(), "pc52");
            if (padej == 0)
            {
                if (otrjad == "Карантин")
                {
                    res = "отделение \"Карантин\"";
                }
                else
                {
                    res = "отряд № " + otrjad;
                }
            }
            else
            {
                if (otrjad == "Карантин")
                {
                    res = "отделения \"Карантин\"";
                }
                else
                {
                    res = "отряда № " + otrjad;
                }
            }
            return res;
        }

        private string GetFormattedSrok()
        {
            string res = "срок ";
            string tmp = result.Rows[0].ItemArray[5].ToString().TrimEnd(' ');
            int i = Convert.ToInt32(tmp);
            if ((i > 10) && (i < 20))
            {
                res = res + tmp + " лет ";
            }
            else
            {
                switch (tmp.Substring(tmp.Length - 1, 1))
                {
                    case "1":
                        res = res + tmp + " год ";
                        break;
                    case "2":
                        res = res + tmp + " года ";
                        break;
                    case "3":
                        res = res + tmp + " года ";
                        break;
                    case "4":
                        res = res + tmp + " года ";
                        break;
                    default:
                        res = res + tmp + " лет ";
                        break;
                }
            }
            tmp = result.Rows[0].ItemArray[6].ToString().TrimEnd(' ');
            i = Convert.ToInt32(tmp);
            if (i != 0)
            {
                switch (tmp)
                {
                    case "1":
                        res = res + tmp + " месяц ";
                        break;
                    case "2":
                        res = res + tmp + " месяца ";
                        break;
                    case "3":
                        res = res + tmp + " месяца ";
                        break;
                    case "4":
                        res = res + tmp + " месяца ";
                        break;
                    default:
                        res = res + tmp + " месяцев ";
                        break;
                }
            }
            tmp = result.Rows[0].ItemArray[7].ToString().Trim(' ');
            i = Convert.ToInt32(tmp);
            if (i != 0)
            {
                if ((i > 10) && (i < 20))
                {
                    res = res + tmp + " дней ";
                }
                else
                {
                    switch (tmp.Substring(tmp.Length - 1, 1))
                    {
                        case "1":
                            res = res + tmp + " день ";
                            break;
                        case "2":
                            res = res + tmp + " дня ";
                            break;
                        case "3":
                            res = res + tmp + " дня ";
                            break;
                        case "4":
                            res = res + tmp + " дня ";
                            break;
                        default:
                            res = res + tmp + " дней ";
                            break;
                    }
                }
            }
            return res + "лишения свободы";
        }

        private string GetFormattedSrokSimple()
        {
            string res = "срок ";
            string tmp = result.Rows[0].ItemArray[5].ToString().TrimEnd(' ');
            int i = Convert.ToInt32(tmp);
            if ((i > 10) && (i < 20))
            {
                res = res + tmp + " л. ";
            }
            else
            {
                switch (tmp.Substring(tmp.Length - 1, 1))
                {
                    case "1":
                        res = res + tmp + " г. ";
                        break;
                    case "2":
                        res = res + tmp + " г. ";
                        break;
                    case "3":
                        res = res + tmp + " г. ";
                        break;
                    case "4":
                        res = res + tmp + " г. ";
                        break;
                    default:
                        res = res + tmp + " л. ";
                        break;
                }
            }
            tmp = result.Rows[0].ItemArray[6].ToString().TrimEnd(' ');
            i = Convert.ToInt32(tmp);
            if (i != 0)
            {
                res = res + tmp + " м. ";
            }
            tmp = result.Rows[0].ItemArray[7].ToString().Trim(' ');
            i = Convert.ToInt32(tmp);
            if (i != 0)
            {
                res = res + tmp + " д. ";                
            }
            return res + "л/св.";
        }

    }
}
