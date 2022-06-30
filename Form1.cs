using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SHSApp
{
    public partial class Form1 : Form
    {
        private Settings sett;
        private static int Count = 0;
        private static string Zeki; 
        private AkusConnect akus;
        public Form1(string[] args)
        {
            InitializeComponent();
            if (args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    Zeki = File.ReadAllText(args[0]);
                    File.Delete(args[0]);
                }
                Count = Zeki.Length / 9;
            }
            
            //SetComboBoxHeight(material.Handle, 25);
            //material.DrawMode = DrawMode.OwnerDrawFixed;
            //material.ItemHeight = 25;
        }

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        private const Int32 CB_SETITEMHEIGHT = 0x153;

        private void SetComboBoxHeight(IntPtr comboBoxHandle, Int32 comboBoxDesiredHeight)
        {
            SendMessage(comboBoxHandle, CB_SETITEMHEIGHT, -1, comboBoxDesiredHeight);
        }

        public static string FirstToUpper(string str)
        {
            if (str.Length > 0) { return Char.ToUpper(str[0]) + str.Substring(1); }
            return "";
        }

        public static string MonthToString(int month)
        {
            string res = "";
            switch (month)
            {
                case 1:
                    res = "января";
                    break;
                case 2:
                    res = "февраля";
                    break;
                case 3:
                    res = "марта";
                    break;
                case 4:
                    res = "апреля";
                    break;
                case 5:
                    res = "мая";
                    break;
                case 6:
                    res = "июня";
                    break;
                case 7:
                    res = "июля";
                    break;
                case 8:
                    res = "августа";
                    break;
                case 9:
                    res = "сентября";
                    break;
                case 10:
                    res = "октября";
                    break;
                case 11:
                    res = "ноября";
                    break;
                case 12:
                    res = "декабря";
                    break;
            }
            return res;
        }

        public static string HoursToString(int hours)
        {
            string res = "";
            switch (hours)
            {
                case 0:
                    res = "00 часов";
                    break;
                case 1:
                    res = "01 час";
                    break;
                case 2:
                    res = "02 часа";
                    break;
                case 3:
                    res = "03 часа";
                    break;
                case 4:
                    res = "04 часа";
                    break;
                case 5:
                    res = "05 часов";
                    break;
                case 6:
                    res = "06 часов";
                    break;
                case 7:
                    res = "07 часов";
                    break;
                case 8:
                    res = "08 часов";
                    break;
                case 9:
                    res = "09 часов";
                    break;
                case 21:
                    res = "21 час";
                    break;
                case 22:
                    res = "22 часа";
                    break;
                case 23:
                    res = "23 часа";
                    break;
                default:
                    res = hours.ToString() + " часов";
                    break;
            }
            return res;
        }

        public static string MinutesToString(int minutes)
        {
            string res = "";
            if (minutes < 10)
            {
                res = "0" + minutes.ToString();
            }
            else
            {
                res = minutes.ToString();
            }
            if ((minutes > 10)&&(minutes < 20))
            {
                res += " минут";
            }
            else
            {
                switch (minutes % 10)
                {
                    case 0:
                        res += " минут";
                        break;
                    case 1:
                        res += " минуту";
                        break;
                    case 2:
                        res += " минуты";
                        break;
                    case 3:
                        res += " минуты";
                        break;
                    case 4:
                        res += " минуты";
                        break;
                    default:
                        res += " минут";
                        break;
                }
            }
            return res;
        }

        private void material_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground(); 
            string text = ((ComboBox)sender).Items[e.Index].ToString();
            if (e.Index % 2 ==0)  
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);
            }   
            if ((e.State & DrawItemState.Selected) != 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.LightCoral), e.Bounds);
                //ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, Color.Gray, Color.Gray);
            }
            e.Graphics.DrawString(text, e.Font, new SolidBrush(Color.Black), e.Bounds.X, e.Bounds.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sett = new Settings();
            akus = new AkusConnect();
            sett.LoadTables();
            akus.SetDbPath(sett.GetParameterByID(0));
            mode.SelectedIndex = 0;
            sett.FillHeadersByID(dpnk, 0);
            sett.FillHeadersByID(material, 1);
            sett.FillHeadersByID(otk_places, 3);
            sett.FillHeadersByID(places, 3);
            sett.FillHeadersByID(sotr1, 2);
            sett.FillHeadersByID(sotr2, 2);
            sotr2.SelectedIndex += 5;
            sett.FillHeadersByID(sotr3, 2);
            sotr3.SelectedIndex += 10;
            hours.Value = DateTime.Now.Hour;
            minutes.Value = DateTime.Now.Minute;
            pvrg.Value = 14;
        }

        private void mode_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (mode.SelectedIndex)
            {
                case 0:
                    label9.Enabled = true;
                    pvrg.Enabled = true;
                    label10.Enabled = false;
                    label11.Enabled = false;
                    pvkvid.Enabled = false;
                    pvkmon.Enabled = false;
                    break;
                case 1:
                    label9.Enabled = false;
                    pvrg.Enabled = false;
                    label10.Enabled = true;
                    label11.Enabled = true;
                    pvkvid.Enabled = true;
                    pvkmon.Enabled = true;
                    break;
                case 2:
                    label9.Enabled = false;
                    pvrg.Enabled = false;
                    label10.Enabled = false;
                    label11.Enabled = false;
                    pvkvid.Enabled = false;
                    pvkmon.Enabled = false;
                    break;
            }
        }

        private void hours_ValueChanged(object sender, EventArgs e)
        {
            otk_hours.Value = hours.Value;
        }

        private void minutes_ValueChanged(object sender, EventArgs e)
        {
            otk_minutes.Value = minutes.Value;
        }

        private void go_Click(object sender, EventArgs e)
        {
            go.Enabled = false;
            pb.Maximum = 100 * Count;
            pb.Step = 10;
            pb.Value = 0;
            for (int i = 0; i < Count; i++)
            {
                string id = Zeki.Substring(i * 9, 9);
                while ((sett.IsExcept(id)))
                {
                    id = akus.GetRandomZekID();
                } 
                akus.Execute(id);
                Tools.ToLog(akus.GetFullFIO(4), sett.GetMST(material.SelectedIndex), hours.Value, minutes.Value, 
                    sett.GetPersonalFIOByID(sotr1.SelectedIndex, true), date.Value);
                int templ = 1;
                int symbCount = 0; string symbPart = "";
                switch (mode.SelectedIndex)
                {
                    case 0:
                        //stage 1
                        pb.PerformStep(); 
                        if (mini.Checked) { templ = 6; } else { templ = 1; }
                        WordDocument wordDoc = new WordDocument(sett.GetParameterByID(0) + sett.GetParameterByID(templ)); pb.PerformStep();
                        wordDoc.ReplaceAllStrings("[Номер отряда1]", FirstToUpper(akus.GetNomerOtryada(0)));
                        wordDoc.ReplaceAllStrings("[Число]", date.Value.Day.ToString());
                        wordDoc.ReplaceAllStrings("[Месяц]", MonthToString(date.Value.Month));
                        wordDoc.ReplaceAllStrings("[Год]", date.Value.Year.ToString());
                        wordDoc.ReplaceAllStrings("[Часов]", HoursToString(Convert.ToInt32(hours.Value)));
                        wordDoc.ReplaceAllStrings("[Минут]", MinutesToString(Convert.ToInt32(minutes.Value)));
                        wordDoc.ReplaceAllStrings("[Часов2]", HoursToString(Convert.ToInt32(otk_hours.Value)));
                        wordDoc.ReplaceAllStrings("[Минут2]", MinutesToString(Convert.ToInt32(otk_minutes.Value)));
                        wordDoc.ReplaceAllStrings("[Преамбула]", sett.GetMaterialPreambulaByID(material.SelectedIndex)); pb.PerformStep();
                        wordDoc.SetSelectionToBookmark("narush1");
                        wordDoc.Selection.Aligment = TextAligment.Justify;
                        wordDoc.Selection.Text = sett.GetMaterialTextByID(material.SelectedIndex);
                        wordDoc.SetSelectionToBookmark("pvr1");
                        wordDoc.Selection.Aligment = TextAligment.Justify;
                        wordDoc.Selection.Text = sett.GetMaterialPvrByID(material.SelectedIndex); pb.PerformStep();
                        wordDoc.SetSelectionToBookmark("video1");
                        wordDoc.Selection.Aligment = TextAligment.Justify;
                        wordDoc.Selection.Text = sett.GetMaterialVideoTextByID(material.SelectedIndex); pb.PerformStep();
                        wordDoc.ReplaceAllStrings("[Устройство фиксации1]", "видеорегистратор «Дозор № " + pvrg.Value.ToString() + "».");
                        wordDoc.ReplaceAllStrings("[Устройство фиксации2]", "видеорегистратора «Дозор № " + pvrg.Value.ToString() + "»");
                        wordDoc.ReplaceAllStrings("[Устройство фиксации3]", "видеорегистратор «Дозор № " + otk_pvrg.Value.ToString() + "»"); pb.PerformStep();
                        //stage2
                        wordDoc.ReplaceAllStrings("[ФИО1]", akus.GetFullFIO(0));
                        wordDoc.ReplaceAllStrings("[ФИО2]", akus.GetFullFIO(1));
                        wordDoc.ReplaceAllStrings("[ФИО3]", akus.GetFullFIO(2));
                        wordDoc.ReplaceAllStrings("[ФИО4]", akus.GetFullFIO(3)); pb.PerformStep();
                        wordDoc.ReplaceAllStrings("[Дата рождения]", akus.GetBirthday());
                        wordDoc.ReplaceAllStrings("[ДПНК]", sett.GetDpnkByID(dpnk.SelectedIndex)); pb.PerformStep();
                        wordDoc.ReplaceAllStrings("[Место нарушения]", sett.GetPlaceByID(places.SelectedIndex));
                        wordDoc.ReplaceAllStrings("[Место отказа]", sett.GetPlaceByID(otk_places.SelectedIndex));
                        wordDoc.ReplaceAllStrings("[Номер отряда2]", akus.GetNomerOtryada(1));
                        wordDoc.ReplaceAllStrings("[Приказ РД]", sett.GetParameterByID(3));
                        wordDoc.ReplaceAllStrings("[Приказ ФО]", sett.GetParameterByID(4));
                        wordDoc.ReplaceAllStrings("[Приказ ФО в ШИЗО]", sett.GetParameterByID(5));
                        while (symbCount < akus.GetZekData().Length)
                        {
                            if (akus.GetZekData().Length - symbCount >= 200)
                                symbPart = akus.GetZekData().Substring(symbCount, 200) + "[Установочные данные]";
                            else symbPart = akus.GetZekData().Substring(symbCount, akus.GetZekData().Length - symbCount);
                            wordDoc.ReplaceAllStrings("[Установочные данные]", symbPart);
                            symbCount += 200;
                        }
                        wordDoc.ReplaceAllStrings("[Текст отказа]", sett.GetMaterialOtkazByID(material.SelectedIndex)); pb.PerformStep();
                        wordDoc.ReplaceAllStrings("[Номер камеры]", shizo.Value.ToString());
                        //stage3
                        wordDoc.ReplaceAllStrings("[ФИО сотрудника полное1]", sett.GetPersonalFullNameByID(sotr1.SelectedIndex, false));
                        wordDoc.ReplaceAllStrings("[ФИО сотрудника полное2]", sett.GetPersonalFullNameByID(sotr1.SelectedIndex, true));
                        wordDoc.ReplaceAllStrings("[ФИО сотрудника полное2 отказ]", sett.GetPersonalFullNameByID(sotr1.SelectedIndex, true));
                        wordDoc.ReplaceAllStrings("[Должность сотрудника1]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr1.SelectedIndex,false)));
                        wordDoc.ReplaceAllStrings("[Звание сотрудника1]", sett.GetPersonalZvanieByID(sotr1.SelectedIndex, false));
                        wordDoc.ReplaceAllStrings("[ФИО сотрудника1]", sett.GetPersonalFIOByID(sotr1.SelectedIndex, false)); 
                        wordDoc.ReplaceAllStrings("[Должность сотрудника2]", sett.GetPersonalDoljnostByID(sotr1.SelectedIndex, true));
                        wordDoc.ReplaceAllStrings("[Звание сотрудника2]", sett.GetPersonalZvanieByID(sotr1.SelectedIndex, true));
                        wordDoc.ReplaceAllStrings("[ФИО сотрудника2]", sett.GetPersonalFIOByID(sotr1.SelectedIndex, true)); 
                        wordDoc.ReplaceAllStrings("[Должность 2 сотрудника]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr2.SelectedIndex, false)));
                        wordDoc.ReplaceAllStrings("[Звание 2 сотрудника]", sett.GetPersonalZvanieByID(sotr2.SelectedIndex, false));
                        wordDoc.ReplaceAllStrings("[ФИО 2 сотрудника]", sett.GetPersonalFIOByID(sotr2.SelectedIndex, false)); 
                        wordDoc.ReplaceAllStrings("[Должность 3 сотрудника]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr3.SelectedIndex, false)));
                        wordDoc.ReplaceAllStrings("[Звание 3 сотрудника]", sett.GetPersonalZvanieByID(sotr3.SelectedIndex, false));
                        wordDoc.ReplaceAllStrings("[ФИО 3 сотрудника]", sett.GetPersonalFIOByID(sotr3.SelectedIndex, false)); 
                        wordDoc.Visible = true;
                        break;
                    case 1:
                        //stage 1
                        pb.PerformStep();
                        if (mini.Checked) { templ = 6; } else { templ = 1; }
                        WordDocument wordDoc2 = new WordDocument(sett.GetParameterByID(0) + sett.GetParameterByID(templ)); pb.PerformStep();
                        wordDoc2.ReplaceAllStrings("[Номер отряда1]", FirstToUpper(akus.GetNomerOtryada(0)));
                        wordDoc2.ReplaceAllStrings("[Число]", date.Value.Day.ToString());
                        wordDoc2.ReplaceAllStrings("[Месяц]", MonthToString(date.Value.Month));
                        wordDoc2.ReplaceAllStrings("[Год]", date.Value.Year.ToString());
                        wordDoc2.ReplaceAllStrings("[Часов]", HoursToString(Convert.ToInt32(hours.Value)));
                        wordDoc2.ReplaceAllStrings("[Минут]", MinutesToString(Convert.ToInt32(minutes.Value)));
                        wordDoc2.ReplaceAllStrings("[Часов2]", HoursToString(Convert.ToInt32(otk_hours.Value)));
                        wordDoc2.ReplaceAllStrings("[Минут2]", MinutesToString(Convert.ToInt32(otk_minutes.Value)));
                        wordDoc2.ReplaceAllStrings("[Преамбула]", sett.GetMaterialPreambulaByID(material.SelectedIndex)); pb.PerformStep();
                        wordDoc2.SetSelectionToBookmark("narush1");
                        wordDoc2.Selection.Aligment = TextAligment.Justify;
                        wordDoc2.Selection.Text = sett.GetMaterialTextByID(material.SelectedIndex);
                        wordDoc2.SetSelectionToBookmark("pvr1");
                        wordDoc2.Selection.Aligment = TextAligment.Justify;
                        wordDoc2.Selection.Text = sett.GetMaterialPvrByID(material.SelectedIndex); pb.PerformStep();
                        wordDoc2.SetSelectionToBookmark("video1");
                        wordDoc2.Selection.Aligment = TextAligment.Justify;
                        wordDoc2.Selection.Text = sett.GetMaterialVideoTextByID(material.SelectedIndex); pb.PerformStep();
                        wordDoc2.ReplaceAllStrings("[Устройство фиксации1]", "видеокамеру № " + pvkvid.Value + ", монитор № " + pvkmon.Value + 
                            ". О данном факте нарушения информирован ДПНК " + sett.GetDpnkByID(dpnk.SelectedIndex));
                        wordDoc2.ReplaceAllStrings("[Устройство фиксации2]", "видеокамеры № " + pvkvid.Value + ", монитора № " + pvkmon.Value);
                        wordDoc2.ReplaceAllStrings("[Устройство фиксации3]", "видеорегистратор «Дозор № " + otk_pvrg.Value.ToString() + "»"); pb.PerformStep();
                        //stage2
                        wordDoc2.ReplaceAllStrings("[ФИО1]", akus.GetFullFIO(0));
                        wordDoc2.ReplaceAllStrings("[ФИО2]", akus.GetFullFIO(1));
                        wordDoc2.ReplaceAllStrings("[ФИО3]", akus.GetFullFIO(2));
                        wordDoc2.ReplaceAllStrings("[ФИО4]", akus.GetFullFIO(3)); pb.PerformStep();
                        wordDoc2.ReplaceAllStrings("[Дата рождения]", akus.GetBirthday());
                        wordDoc2.ReplaceAllStrings("[ДПНК]", sett.GetDpnkByID(dpnk.SelectedIndex)); pb.PerformStep();
                        wordDoc2.ReplaceAllStrings("[Место нарушения]", sett.GetPlaceByID(places.SelectedIndex));
                        wordDoc2.ReplaceAllStrings("[Место отказа]", sett.GetPlaceByID(otk_places.SelectedIndex));
                        wordDoc2.ReplaceAllStrings("[Номер отряда2]", akus.GetNomerOtryada(1));
                        wordDoc2.ReplaceAllStrings("[Приказ РД]", sett.GetParameterByID(3));
                        wordDoc2.ReplaceAllStrings("[Приказ ФО]", sett.GetParameterByID(4));
                        wordDoc2.ReplaceAllStrings("[Приказ ФО в ШИЗО]", sett.GetParameterByID(5));
                        while (symbCount < akus.GetZekData().Length)
                        {
                            if (akus.GetZekData().Length - symbCount >= 200)
                                symbPart = akus.GetZekData().Substring(symbCount, 200) + "[Установочные данные]";
                            else symbPart = akus.GetZekData().Substring(symbCount, akus.GetZekData().Length - symbCount);
                            wordDoc2.ReplaceAllStrings("[Установочные данные]", symbPart);
                            symbCount += 200;
                        }
                        wordDoc2.ReplaceAllStrings("[Текст отказа]", sett.GetMaterialOtkazByID(material.SelectedIndex)); pb.PerformStep();
                        wordDoc2.ReplaceAllStrings("[Номер камеры]", shizo.Value.ToString());
                        //stage3
                        wordDoc2.ReplaceAllStrings("[ФИО сотрудника полное1]", sett.GetPersonalFullNameByID(sotr1.SelectedIndex, false));
                        wordDoc2.ReplaceAllStrings("[ФИО сотрудника полное2]", sett.GetPersonalFullNameByID(sotr1.SelectedIndex, true));
                        wordDoc2.ReplaceAllStrings("[ФИО сотрудника полное2 отказ]", sett.GetPersonalFullNameByID(sotr2.SelectedIndex, true));
                        wordDoc2.ReplaceAllStrings("[Должность сотрудника1]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr1.SelectedIndex,false)));
                        wordDoc2.ReplaceAllStrings("[Звание сотрудника1]", sett.GetPersonalZvanieByID(sotr1.SelectedIndex, false));
                        wordDoc2.ReplaceAllStrings("[ФИО сотрудника1]", sett.GetPersonalFIOByID(sotr1.SelectedIndex, false)); 
                        wordDoc2.ReplaceAllStrings("[Должность сотрудника2]", sett.GetPersonalDoljnostByID(sotr1.SelectedIndex, true));
                        wordDoc2.ReplaceAllStrings("[Звание сотрудника2]", sett.GetPersonalZvanieByID(sotr1.SelectedIndex, true));
                        wordDoc2.ReplaceAllStrings("[ФИО сотрудника2]", sett.GetPersonalFIOByID(sotr1.SelectedIndex, true)); 
                        wordDoc2.ReplaceAllStrings("[Должность 2 сотрудника]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr2.SelectedIndex, false)));
                        wordDoc2.ReplaceAllStrings("[Звание 2 сотрудника]", sett.GetPersonalZvanieByID(sotr2.SelectedIndex, false));
                        wordDoc2.ReplaceAllStrings("[ФИО 2 сотрудника]", sett.GetPersonalFIOByID(sotr2.SelectedIndex, false)); 
                        wordDoc2.ReplaceAllStrings("[Должность 3 сотрудника]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr3.SelectedIndex, false)));
                        wordDoc2.ReplaceAllStrings("[Звание 3 сотрудника]", sett.GetPersonalZvanieByID(sotr3.SelectedIndex, false));
                        wordDoc2.ReplaceAllStrings("[ФИО 3 сотрудника]", sett.GetPersonalFIOByID(sotr3.SelectedIndex, false)); 
                        wordDoc2.Visible = true;
                        break;
                    case 2:
                        //stage 1
                        pb.PerformStep();
                        if (mini.Checked) { templ = 7; } else { templ = 2; }
                        WordDocument wordDoc3 = new WordDocument(sett.GetParameterByID(0) + sett.GetParameterByID(templ)); pb.PerformStep();
                        wordDoc3.ReplaceAllStrings("[Номер отряда1]", FirstToUpper(akus.GetNomerOtryada(0)));
                        wordDoc3.ReplaceAllStrings("[Число]", date.Value.Day.ToString());
                        wordDoc3.ReplaceAllStrings("[Месяц]", MonthToString(date.Value.Month));
                        wordDoc3.ReplaceAllStrings("[Год]", date.Value.Year.ToString());
                        wordDoc3.ReplaceAllStrings("[Часов]", HoursToString(Convert.ToInt32(hours.Value)));
                        wordDoc3.ReplaceAllStrings("[Минут]", MinutesToString(Convert.ToInt32(minutes.Value)));
                        wordDoc3.ReplaceAllStrings("[Часов2]", HoursToString(Convert.ToInt32(otk_hours.Value)));
                        wordDoc3.ReplaceAllStrings("[Минут2]", MinutesToString(Convert.ToInt32(otk_minutes.Value)));
                        wordDoc3.ReplaceAllStrings("[Преамбула]", sett.GetMaterialPreambulaByID(material.SelectedIndex)); pb.PerformStep();
                        wordDoc3.SetSelectionToBookmark("narush1");
                        wordDoc3.Selection.Aligment = TextAligment.Justify;
                        wordDoc3.Selection.Text = sett.GetMaterialTextByID(material.SelectedIndex);
                        wordDoc3.SetSelectionToBookmark("narush2");
                        wordDoc3.Selection.Aligment = TextAligment.Justify;
                        if (sett.GetMaterialText2ByID(material.SelectedIndex) != "")
                        {
                            wordDoc3.Selection.Text = sett.GetMaterialText2ByID(material.SelectedIndex);
                        }
                        else
                        {
                            wordDoc3.Selection.Text = sett.GetMaterialTextByID(material.SelectedIndex);
                        }
                        wordDoc3.SetSelectionToBookmark("pvr1");
                        wordDoc3.Selection.Aligment = TextAligment.Justify;
                        wordDoc3.Selection.Text = sett.GetMaterialPvrByID(material.SelectedIndex); pb.PerformStep();
                        wordDoc3.SetSelectionToBookmark("pvr2");
                        wordDoc3.Selection.Aligment = TextAligment.Justify;
                        wordDoc3.Selection.Text = sett.GetMaterialPvrByID(material.SelectedIndex); pb.PerformStep();
                        wordDoc3.ReplaceAllStrings("[Устройство фиксации3]", "видеорегистратор «Дозор № " + otk_pvrg.Value.ToString() + "»"); pb.PerformStep();
                        //stage2
                        wordDoc3.ReplaceAllStrings("[ФИО1]", akus.GetFullFIO(0));
                        wordDoc3.ReplaceAllStrings("[ФИО2]", akus.GetFullFIO(1));
                        wordDoc3.ReplaceAllStrings("[ФИО3]", akus.GetFullFIO(2));
                        wordDoc3.ReplaceAllStrings("[ФИО4]", akus.GetFullFIO(3)); pb.PerformStep();
                        wordDoc3.ReplaceAllStrings("[Дата рождения]", akus.GetBirthday());
                        wordDoc3.ReplaceAllStrings("[ДПНК]", sett.GetDpnkByID(dpnk.SelectedIndex)); pb.PerformStep();
                        wordDoc3.ReplaceAllStrings("[Место нарушения]", sett.GetPlaceByID(places.SelectedIndex));
                        wordDoc3.ReplaceAllStrings("[Место отказа]", sett.GetPlaceByID(otk_places.SelectedIndex));
                        wordDoc3.ReplaceAllStrings("[Номер отряда2]", akus.GetNomerOtryada(1));
                        wordDoc3.ReplaceAllStrings("[Приказ РД]", sett.GetParameterByID(3));
                        wordDoc3.ReplaceAllStrings("[Приказ ФО]", sett.GetParameterByID(4));
                        wordDoc3.ReplaceAllStrings("[Приказ ФО в ШИЗО]", sett.GetParameterByID(5));
                        while (symbCount < akus.GetZekData().Length)
                        {
                            if (akus.GetZekData().Length - symbCount >= 200)
                                symbPart = akus.GetZekData().Substring(symbCount, 200) + "[Установочные данные]";
                            else symbPart = akus.GetZekData().Substring(symbCount, akus.GetZekData().Length - symbCount);
                            wordDoc3.ReplaceAllStrings("[Установочные данные]", symbPart);
                            symbCount += 200;
                        }
                        wordDoc3.ReplaceAllStrings("[Текст отказа]", sett.GetMaterialOtkazByID(material.SelectedIndex)); pb.PerformStep();
                        wordDoc3.ReplaceAllStrings("[Номер камеры]", shizo.Value.ToString());
                        //stage3
                        wordDoc3.ReplaceAllStrings("[ФИО сотрудника полное1]", sett.GetPersonalFullNameByID(sotr1.SelectedIndex, false));
                        wordDoc3.ReplaceAllStrings("[ФИО сотрудника полное2]", sett.GetPersonalFullNameByID(sotr1.SelectedIndex, true));
                        wordDoc3.ReplaceAllStrings("[ФИО сотрудника полное2 отказ]", sett.GetPersonalFullNameByID(sotr2.SelectedIndex, true));
                        wordDoc3.ReplaceAllStrings("[Должность сотрудника1]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr1.SelectedIndex, false)));
                        wordDoc3.ReplaceAllStrings("[Звание сотрудника1]", sett.GetPersonalZvanieByID(sotr1.SelectedIndex, false));
                        wordDoc3.ReplaceAllStrings("[ФИО сотрудника1]", sett.GetPersonalFIOByID(sotr1.SelectedIndex, false));
                        wordDoc3.ReplaceAllStrings("[Должность сотрудника2]", sett.GetPersonalDoljnostByID(sotr1.SelectedIndex, true));
                        wordDoc3.ReplaceAllStrings("[Звание сотрудника2]", sett.GetPersonalZvanieByID(sotr1.SelectedIndex, true));
                        wordDoc3.ReplaceAllStrings("[ФИО сотрудника2]", sett.GetPersonalFIOByID(sotr1.SelectedIndex, true));
                        wordDoc3.ReplaceAllStrings("[Должность 2 сотрудника]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr2.SelectedIndex, false)));
                        wordDoc3.ReplaceAllStrings("[Звание 2 сотрудника]", sett.GetPersonalZvanieByID(sotr2.SelectedIndex, false));
                        wordDoc3.ReplaceAllStrings("[ФИО 2 сотрудника]", sett.GetPersonalFIOByID(sotr2.SelectedIndex, false));
                        wordDoc3.ReplaceAllStrings("[Должность 3 сотрудника]", FirstToUpper(sett.GetPersonalDoljnostByID(sotr3.SelectedIndex, false)));
                        wordDoc3.ReplaceAllStrings("[Звание 3 сотрудника]", sett.GetPersonalZvanieByID(sotr3.SelectedIndex, false));
                        wordDoc3.ReplaceAllStrings("[ФИО 3 сотрудника]", sett.GetPersonalFIOByID(sotr3.SelectedIndex, false));
                        wordDoc3.Visible = true;
                        break;
                }
                this.Activate();
            }
            go.Enabled = true;
            this.Close();
        }

        private void pvrg_ValueChanged(object sender, EventArgs e)
        {
            otk_pvrg.Value = pvrg.Value;
        }

        private void places_SelectedIndexChanged(object sender, EventArgs e)
        {
            otk_places.SelectedIndex = places.SelectedIndex;
        }
    }
}
