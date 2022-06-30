namespace SHSApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mini = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dpnk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.places = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.ComboBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.go = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.shizo = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.pvkmon = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.pvkvid = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pvrg = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.otk_minutes = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.otk_hours = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.sotr3 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.sotr2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sotr1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.otk_pvrg = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.otk_places = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shizo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvkmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvkvid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otk_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otk_hours)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otk_pvrg)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mini);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minutes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Когда выявлено нарушение";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // mini
            // 
            this.mini.AutoSize = true;
            this.mini.Checked = true;
            this.mini.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mini.Location = new System.Drawing.Point(9, 123);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(163, 21);
            this.mini.TabIndex = 8;
            this.mini.Text = "Формат рапорта А5";
            this.mini.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "минут";
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(120, 93);
            this.minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(48, 22);
            this.minutes.TabIndex = 6;
            this.minutes.ValueChanged += new System.EventHandler(this.minutes_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "часов";
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(9, 93);
            this.hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(53, 22);
            this.hours.TabIndex = 4;
            this.hours.ValueChanged += new System.EventHandler(this.hours_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время нарушения";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(6, 44);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(207, 22);
            this.date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата нарушения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dpnk);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.places);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.material);
            this.groupBox2.Location = new System.Drawing.Point(237, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Нарушение";
            // 
            // dpnk
            // 
            this.dpnk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dpnk.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dpnk.FormattingEnabled = true;
            this.dpnk.ItemHeight = 17;
            this.dpnk.Location = new System.Drawing.Point(9, 132);
            this.dpnk.Name = "dpnk";
            this.dpnk.Size = new System.Drawing.Size(247, 23);
            this.dpnk.TabIndex = 5;
            this.dpnk.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.material_DrawItem);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Регистрирующий ДПНК";
            // 
            // places
            // 
            this.places.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.places.Font = new System.Drawing.Font("Tahoma", 9F);
            this.places.FormattingEnabled = true;
            this.places.ItemHeight = 17;
            this.places.Location = new System.Drawing.Point(9, 85);
            this.places.Name = "places";
            this.places.Size = new System.Drawing.Size(247, 23);
            this.places.TabIndex = 3;
            this.places.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.material_DrawItem);
            this.places.SelectedIndexChanged += new System.EventHandler(this.places_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Где выявлено";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Вид нарушения";
            // 
            // material
            // 
            this.material.BackColor = System.Drawing.SystemColors.Window;
            this.material.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.material.DropDownHeight = 500;
            this.material.DropDownWidth = 310;
            this.material.Font = new System.Drawing.Font("Tahoma", 9F);
            this.material.IntegralHeight = false;
            this.material.ItemHeight = 17;
            this.material.Location = new System.Drawing.Point(9, 38);
            this.material.MaxDropDownItems = 20;
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(247, 23);
            this.material.TabIndex = 0;
            this.material.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.material_DrawItem);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 374);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(608, 28);
            this.pb.TabIndex = 2;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(626, 371);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(83, 32);
            this.go.TabIndex = 3;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.shizo);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.pvkmon);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.pvkvid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pvrg);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.mode);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 196);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фиксация нарушения";
            // 
            // shizo
            // 
            this.shizo.Location = new System.Drawing.Point(151, 164);
            this.shizo.Name = "shizo";
            this.shizo.Size = new System.Drawing.Size(62, 22);
            this.shizo.TabIndex = 14;
            this.shizo.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 166);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Номер камеры ШИЗО";
            // 
            // pvkmon
            // 
            this.pvkmon.Location = new System.Drawing.Point(151, 134);
            this.pvkmon.Name = "pvkmon";
            this.pvkmon.Size = new System.Drawing.Size(62, 22);
            this.pvkmon.TabIndex = 7;
            this.pvkmon.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Номер монитора";
            // 
            // pvkvid
            // 
            this.pvkvid.Location = new System.Drawing.Point(151, 104);
            this.pvkvid.Name = "pvkvid";
            this.pvkvid.Size = new System.Drawing.Size(62, 22);
            this.pvkvid.TabIndex = 5;
            this.pvkvid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Номер видеокамеры";
            // 
            // pvrg
            // 
            this.pvrg.Location = new System.Drawing.Point(151, 76);
            this.pvrg.Name = "pvrg";
            this.pvrg.Size = new System.Drawing.Size(62, 22);
            this.pvrg.TabIndex = 3;
            this.pvrg.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.pvrg.ValueChanged += new System.EventHandler(this.pvrg_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Номер регистратора";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Устройство фиксации";
            // 
            // mode
            // 
            this.mode.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "Видеорегистратор",
            "Видеокамера ПВК",
            "Рапорт сотрудника"});
            this.mode.Location = new System.Drawing.Point(6, 45);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(207, 26);
            this.mode.TabIndex = 0;
            this.mode.SelectedIndexChanged += new System.EventHandler(this.mode_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "минут";
            // 
            // otk_minutes
            // 
            this.otk_minutes.Location = new System.Drawing.Point(104, 84);
            this.otk_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.otk_minutes.Name = "otk_minutes";
            this.otk_minutes.Size = new System.Drawing.Size(47, 22);
            this.otk_minutes.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "часов";
            // 
            // otk_hours
            // 
            this.otk_hours.Location = new System.Drawing.Point(10, 84);
            this.otk_hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.otk_hours.Name = "otk_hours";
            this.otk_hours.Size = new System.Drawing.Size(48, 22);
            this.otk_hours.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Время отказа";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.sotr3);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.sotr2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.sotr1);
            this.groupBox4.Location = new System.Drawing.Point(237, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(472, 182);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Участвующие сотрудники администрации";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(436, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Если ПВРГ не применяется, то от него составляется 2-й рапорт";
            // 
            // sotr3
            // 
            this.sotr3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sotr3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.sotr3.FormattingEnabled = true;
            this.sotr3.ItemHeight = 17;
            this.sotr3.Location = new System.Drawing.Point(10, 149);
            this.sotr3.MaxDropDownItems = 50;
            this.sotr3.Name = "sotr3";
            this.sotr3.Size = new System.Drawing.Size(454, 23);
            this.sotr3.TabIndex = 5;
            this.sotr3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.material_DrawItem);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(421, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "3-й - сотрудник, подписант в акте отказа от дачи объяснения";
            // 
            // sotr2
            // 
            this.sotr2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sotr2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.sotr2.FormattingEnabled = true;
            this.sotr2.ItemHeight = 17;
            this.sotr2.Location = new System.Drawing.Point(9, 102);
            this.sotr2.MaxDropDownItems = 50;
            this.sotr2.Name = "sotr2";
            this.sotr2.Size = new System.Drawing.Size(454, 23);
            this.sotr2.TabIndex = 3;
            this.sotr2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.material_DrawItem);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(421, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "2-й - сотрудник, подписант в акте отказа от дачи объяснения";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(341, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "1-й - сотрудник, от которого составляется рапорт";
            // 
            // sotr1
            // 
            this.sotr1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sotr1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.sotr1.ItemHeight = 17;
            this.sotr1.Location = new System.Drawing.Point(9, 38);
            this.sotr1.MaxDropDownItems = 45;
            this.sotr1.Name = "sotr1";
            this.sotr1.Size = new System.Drawing.Size(454, 23);
            this.sotr1.TabIndex = 0;
            this.sotr1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.material_DrawItem);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(7, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 17);
            this.label21.TabIndex = 15;
            this.label21.Text = "Номер регистратора";
            // 
            // otk_pvrg
            // 
            this.otk_pvrg.Location = new System.Drawing.Point(12, 134);
            this.otk_pvrg.Name = "otk_pvrg";
            this.otk_pvrg.Size = new System.Drawing.Size(50, 22);
            this.otk_pvrg.TabIndex = 16;
            this.otk_pvrg.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.otk_places);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.otk_pvrg);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.otk_minutes);
            this.groupBox5.Controls.Add(this.otk_hours);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(505, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 168);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Отказ от объяснения";
            // 
            // otk_places
            // 
            this.otk_places.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.otk_places.DropDownWidth = 250;
            this.otk_places.Font = new System.Drawing.Font("Tahoma", 9F);
            this.otk_places.FormattingEnabled = true;
            this.otk_places.ItemHeight = 17;
            this.otk_places.Location = new System.Drawing.Point(10, 38);
            this.otk_places.Name = "otk_places";
            this.otk_places.Size = new System.Drawing.Size(189, 23);
            this.otk_places.TabIndex = 18;
            this.otk_places.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.material_DrawItem);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 17);
            this.label22.TabIndex = 17;
            this.label22.Text = "Место отказа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(721, 408);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.go);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материал на осужденного - SHSApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shizo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvkmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvkvid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otk_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otk_hours)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otk_pvrg)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hours;
        private System.Windows.Forms.ComboBox places;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox material;
        private System.Windows.Forms.ComboBox dpnk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.NumericUpDown pvkmon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown pvkvid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown pvrg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown otk_minutes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown otk_hours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox sotr3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox sotr2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox sotr1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown shizo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown otk_pvrg;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox otk_places;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox mini;
    }
}

