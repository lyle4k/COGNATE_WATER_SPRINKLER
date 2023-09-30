
namespace WaterSprinkler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.btn_Simulate = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_AddSched = new System.Windows.Forms.Panel();
            this.pnl_EditSched = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_EDays = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tbx_EWater = new System.Windows.Forms.TextBox();
            this.gbx_EDays = new System.Windows.Forms.GroupBox();
            this.chk_ESat = new System.Windows.Forms.CheckBox();
            this.chk_EFri = new System.Windows.Forms.CheckBox();
            this.chk_EThu = new System.Windows.Forms.CheckBox();
            this.chk_EWed = new System.Windows.Forms.CheckBox();
            this.chk_ETue = new System.Windows.Forms.CheckBox();
            this.chk_EMon = new System.Windows.Forms.CheckBox();
            this.chk_ESun = new System.Windows.Forms.CheckBox();
            this.cbx_EMeridiem = new System.Windows.Forms.ComboBox();
            this.tbx_EMinute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_EHour = new System.Windows.Forms.TextBox();
            this.tbx_EName = new System.Windows.Forms.TextBox();
            this.dgv_Table = new System.Windows.Forms.DataGridView();
            this.tbx_Days = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.pbx_Image = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Water = new System.Windows.Forms.TextBox();
            this.gbx_Days = new System.Windows.Forms.GroupBox();
            this.chk_Sat = new System.Windows.Forms.CheckBox();
            this.chk_Fri = new System.Windows.Forms.CheckBox();
            this.chk_Thu = new System.Windows.Forms.CheckBox();
            this.chk_Wed = new System.Windows.Forms.CheckBox();
            this.chk_Tue = new System.Windows.Forms.CheckBox();
            this.chk_Mon = new System.Windows.Forms.CheckBox();
            this.chk_Sun = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Meridiem = new System.Windows.Forms.ComboBox();
            this.tbx_Minute = new System.Windows.Forms.TextBox();
            this.tbx_Hour = new System.Windows.Forms.TextBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.tmr_Clock = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnl_Title.SuspendLayout();
            this.pnl_AddSched.SuspendLayout();
            this.pnl_EditSched.SuspendLayout();
            this.gbx_EDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Image)).BeginInit();
            this.gbx_Days.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.tabControl1);
            this.pnl_Title.Controls.Add(this.lbl_Clock);
            this.pnl_Title.Controls.Add(this.btn_Simulate);
            this.pnl_Title.Controls.Add(this.btn_Edit);
            this.pnl_Title.Controls.Add(this.btn_Add);
            this.pnl_Title.Controls.Add(this.label1);
            this.pnl_Title.Location = new System.Drawing.Point(3, 2);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(779, 130);
            this.pnl_Title.TabIndex = 0;
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clock.Location = new System.Drawing.Point(635, 7);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(132, 30);
            this.lbl_Clock.TabIndex = 0;
            this.lbl_Clock.Text = "00:00:00   ";
            // 
            // btn_Simulate
            // 
            this.btn_Simulate.Location = new System.Drawing.Point(337, 75);
            this.btn_Simulate.Name = "btn_Simulate";
            this.btn_Simulate.Size = new System.Drawing.Size(130, 40);
            this.btn_Simulate.TabIndex = 3;
            this.btn_Simulate.Text = "SIMULATION";
            this.btn_Simulate.UseVisualStyleBackColor = true;
            this.btn_Simulate.Click += new System.EventHandler(this.btn_Simulate_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(173, 75);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(130, 40);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "EDIT SCHEDULE";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(9, 75);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(130, 40);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "ADD PLANT";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "WATER SPRINKLER";
            // 
            // pnl_AddSched
            // 
            this.pnl_AddSched.Controls.Add(this.pnl_EditSched);
            this.pnl_AddSched.Controls.Add(this.tbx_Days);
            this.pnl_AddSched.Controls.Add(this.btn_Clear);
            this.pnl_AddSched.Controls.Add(this.btn_Confirm);
            this.pnl_AddSched.Controls.Add(this.pbx_Image);
            this.pnl_AddSched.Controls.Add(this.label6);
            this.pnl_AddSched.Controls.Add(this.label5);
            this.pnl_AddSched.Controls.Add(this.label4);
            this.pnl_AddSched.Controls.Add(this.label2);
            this.pnl_AddSched.Controls.Add(this.tbx_Water);
            this.pnl_AddSched.Controls.Add(this.gbx_Days);
            this.pnl_AddSched.Controls.Add(this.label3);
            this.pnl_AddSched.Controls.Add(this.cbx_Meridiem);
            this.pnl_AddSched.Controls.Add(this.tbx_Minute);
            this.pnl_AddSched.Controls.Add(this.tbx_Hour);
            this.pnl_AddSched.Controls.Add(this.tbx_Name);
            this.pnl_AddSched.Location = new System.Drawing.Point(3, 134);
            this.pnl_AddSched.Name = "pnl_AddSched";
            this.pnl_AddSched.Size = new System.Drawing.Size(779, 380);
            this.pnl_AddSched.TabIndex = 1;
            // 
            // pnl_EditSched
            // 
            this.pnl_EditSched.Controls.Add(this.label8);
            this.pnl_EditSched.Controls.Add(this.tbx_EDays);
            this.pnl_EditSched.Controls.Add(this.btn_Delete);
            this.pnl_EditSched.Controls.Add(this.btn_Update);
            this.pnl_EditSched.Controls.Add(this.tbx_EWater);
            this.pnl_EditSched.Controls.Add(this.gbx_EDays);
            this.pnl_EditSched.Controls.Add(this.cbx_EMeridiem);
            this.pnl_EditSched.Controls.Add(this.tbx_EMinute);
            this.pnl_EditSched.Controls.Add(this.label7);
            this.pnl_EditSched.Controls.Add(this.tbx_EHour);
            this.pnl_EditSched.Controls.Add(this.tbx_EName);
            this.pnl_EditSched.Controls.Add(this.dgv_Table);
            this.pnl_EditSched.Location = new System.Drawing.Point(0, 0);
            this.pnl_EditSched.Name = "pnl_EditSched";
            this.pnl_EditSched.Size = new System.Drawing.Size(779, 380);
            this.pnl_EditSched.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "mL";
            // 
            // tbx_EDays
            // 
            this.tbx_EDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_EDays.Location = new System.Drawing.Point(85, 227);
            this.tbx_EDays.Name = "tbx_EDays";
            this.tbx_EDays.Size = new System.Drawing.Size(124, 26);
            this.tbx_EDays.TabIndex = 12;
            this.tbx_EDays.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(123, 273);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 30);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(8, 273);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 30);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tbx_EWater
            // 
            this.tbx_EWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_EWater.Location = new System.Drawing.Point(9, 227);
            this.tbx_EWater.Name = "tbx_EWater";
            this.tbx_EWater.Size = new System.Drawing.Size(50, 26);
            this.tbx_EWater.TabIndex = 9;
            // 
            // gbx_EDays
            // 
            this.gbx_EDays.Controls.Add(this.chk_ESat);
            this.gbx_EDays.Controls.Add(this.chk_EFri);
            this.gbx_EDays.Controls.Add(this.chk_EThu);
            this.gbx_EDays.Controls.Add(this.chk_EWed);
            this.gbx_EDays.Controls.Add(this.chk_ETue);
            this.gbx_EDays.Controls.Add(this.chk_EMon);
            this.gbx_EDays.Controls.Add(this.chk_ESun);
            this.gbx_EDays.Location = new System.Drawing.Point(8, 147);
            this.gbx_EDays.Name = "gbx_EDays";
            this.gbx_EDays.Size = new System.Drawing.Size(219, 69);
            this.gbx_EDays.TabIndex = 8;
            this.gbx_EDays.TabStop = false;
            // 
            // chk_ESat
            // 
            this.chk_ESat.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_ESat.Location = new System.Drawing.Point(186, 21);
            this.chk_ESat.Name = "chk_ESat";
            this.chk_ESat.Size = new System.Drawing.Size(29, 36);
            this.chk_ESat.TabIndex = 6;
            this.chk_ESat.Text = "Sa";
            this.chk_ESat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_ESat.UseVisualStyleBackColor = true;
            // 
            // chk_EFri
            // 
            this.chk_EFri.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_EFri.Location = new System.Drawing.Point(156, 21);
            this.chk_EFri.Name = "chk_EFri";
            this.chk_EFri.Size = new System.Drawing.Size(29, 36);
            this.chk_EFri.TabIndex = 5;
            this.chk_EFri.Text = "F";
            this.chk_EFri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_EFri.UseVisualStyleBackColor = true;
            // 
            // chk_EThu
            // 
            this.chk_EThu.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_EThu.Location = new System.Drawing.Point(126, 21);
            this.chk_EThu.Name = "chk_EThu";
            this.chk_EThu.Size = new System.Drawing.Size(29, 36);
            this.chk_EThu.TabIndex = 4;
            this.chk_EThu.Text = "Th";
            this.chk_EThu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_EThu.UseVisualStyleBackColor = true;
            // 
            // chk_EWed
            // 
            this.chk_EWed.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_EWed.Location = new System.Drawing.Point(96, 21);
            this.chk_EWed.Name = "chk_EWed";
            this.chk_EWed.Size = new System.Drawing.Size(29, 36);
            this.chk_EWed.TabIndex = 3;
            this.chk_EWed.Text = "W";
            this.chk_EWed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_EWed.UseVisualStyleBackColor = true;
            // 
            // chk_ETue
            // 
            this.chk_ETue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_ETue.Location = new System.Drawing.Point(66, 21);
            this.chk_ETue.Name = "chk_ETue";
            this.chk_ETue.Size = new System.Drawing.Size(29, 36);
            this.chk_ETue.TabIndex = 2;
            this.chk_ETue.Text = "T";
            this.chk_ETue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_ETue.UseVisualStyleBackColor = true;
            // 
            // chk_EMon
            // 
            this.chk_EMon.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_EMon.Location = new System.Drawing.Point(36, 21);
            this.chk_EMon.Name = "chk_EMon";
            this.chk_EMon.Size = new System.Drawing.Size(29, 36);
            this.chk_EMon.TabIndex = 1;
            this.chk_EMon.Text = "M";
            this.chk_EMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_EMon.UseVisualStyleBackColor = true;
            // 
            // chk_ESun
            // 
            this.chk_ESun.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_ESun.Location = new System.Drawing.Point(6, 21);
            this.chk_ESun.Name = "chk_ESun";
            this.chk_ESun.Size = new System.Drawing.Size(29, 36);
            this.chk_ESun.TabIndex = 0;
            this.chk_ESun.Text = "S";
            this.chk_ESun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_ESun.UseVisualStyleBackColor = true;
            // 
            // cbx_EMeridiem
            // 
            this.cbx_EMeridiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_EMeridiem.FormattingEnabled = true;
            this.cbx_EMeridiem.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbx_EMeridiem.Location = new System.Drawing.Point(149, 113);
            this.cbx_EMeridiem.Name = "cbx_EMeridiem";
            this.cbx_EMeridiem.Size = new System.Drawing.Size(60, 25);
            this.cbx_EMeridiem.TabIndex = 7;
            // 
            // tbx_EMinute
            // 
            this.tbx_EMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_EMinute.Location = new System.Drawing.Point(85, 112);
            this.tbx_EMinute.Name = "tbx_EMinute";
            this.tbx_EMinute.Size = new System.Drawing.Size(50, 26);
            this.tbx_EMinute.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(65, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = ":";
            // 
            // tbx_EHour
            // 
            this.tbx_EHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_EHour.Location = new System.Drawing.Point(9, 112);
            this.tbx_EHour.Name = "tbx_EHour";
            this.tbx_EHour.Size = new System.Drawing.Size(50, 26);
            this.tbx_EHour.TabIndex = 2;
            // 
            // tbx_EName
            // 
            this.tbx_EName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_EName.Location = new System.Drawing.Point(9, 71);
            this.tbx_EName.Name = "tbx_EName";
            this.tbx_EName.Size = new System.Drawing.Size(200, 26);
            this.tbx_EName.TabIndex = 1;
            // 
            // dgv_Table
            // 
            this.dgv_Table.AllowUserToResizeColumns = false;
            this.dgv_Table.AllowUserToResizeRows = false;
            this.dgv_Table.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Table.Location = new System.Drawing.Point(250, 71);
            this.dgv_Table.Name = "dgv_Table";
            this.dgv_Table.RowHeadersWidth = 49;
            this.dgv_Table.RowTemplate.Height = 24;
            this.dgv_Table.Size = new System.Drawing.Size(498, 232);
            this.dgv_Table.TabIndex = 0;
            this.dgv_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Table_CellClick);
            // 
            // tbx_Days
            // 
            this.tbx_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Days.Location = new System.Drawing.Point(235, 222);
            this.tbx_Days.Name = "tbx_Days";
            this.tbx_Days.ReadOnly = true;
            this.tbx_Days.Size = new System.Drawing.Size(119, 26);
            this.tbx_Days.TabIndex = 13;
            this.tbx_Days.Visible = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(173, 330);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 30);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(56, 330);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(100, 30);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // pbx_Image
            // 
            this.pbx_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Image.Location = new System.Drawing.Point(462, 44);
            this.pbx_Image.Name = "pbx_Image";
            this.pbx_Image.Size = new System.Drawing.Size(250, 250);
            this.pbx_Image.TabIndex = 11;
            this.pbx_Image.TabStop = false;
            this.pbx_Image.Click += new System.EventHandler(this.pbx_Image_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Water Volume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time and Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plant Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "mL";
            // 
            // tbx_Water
            // 
            this.tbx_Water.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Water.Location = new System.Drawing.Point(55, 263);
            this.tbx_Water.Name = "tbx_Water";
            this.tbx_Water.Size = new System.Drawing.Size(50, 26);
            this.tbx_Water.TabIndex = 6;
            this.tbx_Water.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbx_Days
            // 
            this.gbx_Days.Controls.Add(this.chk_Sat);
            this.gbx_Days.Controls.Add(this.chk_Fri);
            this.gbx_Days.Controls.Add(this.chk_Thu);
            this.gbx_Days.Controls.Add(this.chk_Wed);
            this.gbx_Days.Controls.Add(this.chk_Tue);
            this.gbx_Days.Controls.Add(this.chk_Mon);
            this.gbx_Days.Controls.Add(this.chk_Sun);
            this.gbx_Days.Location = new System.Drawing.Point(56, 147);
            this.gbx_Days.Name = "gbx_Days";
            this.gbx_Days.Size = new System.Drawing.Size(300, 69);
            this.gbx_Days.TabIndex = 5;
            this.gbx_Days.TabStop = false;
            // 
            // chk_Sat
            // 
            this.chk_Sat.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Sat.Location = new System.Drawing.Point(261, 21);
            this.chk_Sat.Name = "chk_Sat";
            this.chk_Sat.Size = new System.Drawing.Size(37, 36);
            this.chk_Sat.TabIndex = 6;
            this.chk_Sat.Text = "Sat";
            this.chk_Sat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_Sat.UseVisualStyleBackColor = true;
            // 
            // chk_Fri
            // 
            this.chk_Fri.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Fri.Location = new System.Drawing.Point(220, 21);
            this.chk_Fri.Name = "chk_Fri";
            this.chk_Fri.Size = new System.Drawing.Size(37, 36);
            this.chk_Fri.TabIndex = 5;
            this.chk_Fri.Text = "Fri";
            this.chk_Fri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_Fri.UseVisualStyleBackColor = true;
            // 
            // chk_Thu
            // 
            this.chk_Thu.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Thu.Location = new System.Drawing.Point(179, 21);
            this.chk_Thu.Name = "chk_Thu";
            this.chk_Thu.Size = new System.Drawing.Size(37, 36);
            this.chk_Thu.TabIndex = 4;
            this.chk_Thu.Text = "Thu";
            this.chk_Thu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_Thu.UseVisualStyleBackColor = true;
            // 
            // chk_Wed
            // 
            this.chk_Wed.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Wed.Location = new System.Drawing.Point(134, 21);
            this.chk_Wed.Name = "chk_Wed";
            this.chk_Wed.Size = new System.Drawing.Size(41, 36);
            this.chk_Wed.TabIndex = 3;
            this.chk_Wed.Text = "Wed";
            this.chk_Wed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_Wed.UseVisualStyleBackColor = true;
            // 
            // chk_Tue
            // 
            this.chk_Tue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Tue.Location = new System.Drawing.Point(93, 21);
            this.chk_Tue.Name = "chk_Tue";
            this.chk_Tue.Size = new System.Drawing.Size(37, 36);
            this.chk_Tue.TabIndex = 2;
            this.chk_Tue.Text = "Tue";
            this.chk_Tue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_Tue.UseVisualStyleBackColor = true;
            // 
            // chk_Mon
            // 
            this.chk_Mon.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Mon.Location = new System.Drawing.Point(47, 21);
            this.chk_Mon.Name = "chk_Mon";
            this.chk_Mon.Size = new System.Drawing.Size(42, 36);
            this.chk_Mon.TabIndex = 1;
            this.chk_Mon.Text = "Mon";
            this.chk_Mon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_Mon.UseVisualStyleBackColor = true;
            // 
            // chk_Sun
            // 
            this.chk_Sun.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Sun.Location = new System.Drawing.Point(6, 21);
            this.chk_Sun.Name = "chk_Sun";
            this.chk_Sun.Size = new System.Drawing.Size(37, 36);
            this.chk_Sun.TabIndex = 0;
            this.chk_Sun.Text = "Sun";
            this.chk_Sun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_Sun.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(113, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // cbx_Meridiem
            // 
            this.cbx_Meridiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Meridiem.FormattingEnabled = true;
            this.cbx_Meridiem.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbx_Meridiem.Location = new System.Drawing.Point(195, 116);
            this.cbx_Meridiem.Name = "cbx_Meridiem";
            this.cbx_Meridiem.Size = new System.Drawing.Size(60, 25);
            this.cbx_Meridiem.TabIndex = 3;
            // 
            // tbx_Minute
            // 
            this.tbx_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Minute.Location = new System.Drawing.Point(136, 115);
            this.tbx_Minute.Name = "tbx_Minute";
            this.tbx_Minute.Size = new System.Drawing.Size(50, 26);
            this.tbx_Minute.TabIndex = 2;
            this.tbx_Minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Hour
            // 
            this.tbx_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Hour.Location = new System.Drawing.Point(56, 115);
            this.tbx_Hour.Name = "tbx_Hour";
            this.tbx_Hour.Size = new System.Drawing.Size(50, 26);
            this.tbx_Hour.TabIndex = 1;
            this.tbx_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Name
            // 
            this.tbx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Name.Location = new System.Drawing.Point(56, 44);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(200, 26);
            this.tbx_Name.TabIndex = 0;
            // 
            // tmr_Clock
            // 
            this.tmr_Clock.Tick += new System.EventHandler(this.tmr_Clock_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 384);
            this.tabControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 516);
            this.Controls.Add(this.pnl_AddSched);
            this.Controls.Add(this.pnl_Title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Sprinkler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.pnl_AddSched.ResumeLayout(false);
            this.pnl_AddSched.PerformLayout();
            this.pnl_EditSched.ResumeLayout(false);
            this.pnl_EditSched.PerformLayout();
            this.gbx_EDays.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Image)).EndInit();
            this.gbx_Days.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Simulate;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pnl_AddSched;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Meridiem;
        private System.Windows.Forms.TextBox tbx_Minute;
        private System.Windows.Forms.TextBox tbx_Hour;
        private System.Windows.Forms.GroupBox gbx_Days;
        private System.Windows.Forms.CheckBox chk_Wed;
        private System.Windows.Forms.CheckBox chk_Tue;
        private System.Windows.Forms.CheckBox chk_Mon;
        private System.Windows.Forms.CheckBox chk_Sun;
        private System.Windows.Forms.CheckBox chk_Fri;
        private System.Windows.Forms.CheckBox chk_Thu;
        private System.Windows.Forms.CheckBox chk_Sat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Water;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbx_Image;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox tbx_Days;
        private System.Windows.Forms.Panel pnl_EditSched;
        private System.Windows.Forms.DataGridView dgv_Table;
        private System.Windows.Forms.TextBox tbx_EName;
        private System.Windows.Forms.TextBox tbx_EHour;
        private System.Windows.Forms.GroupBox gbx_EDays;
        private System.Windows.Forms.CheckBox chk_ESat;
        private System.Windows.Forms.CheckBox chk_EFri;
        private System.Windows.Forms.CheckBox chk_EThu;
        private System.Windows.Forms.CheckBox chk_EWed;
        private System.Windows.Forms.CheckBox chk_ETue;
        private System.Windows.Forms.CheckBox chk_EMon;
        private System.Windows.Forms.CheckBox chk_ESun;
        private System.Windows.Forms.ComboBox cbx_EMeridiem;
        private System.Windows.Forms.TextBox tbx_EMinute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_EWater;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tbx_EDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Clock;
        private System.Windows.Forms.Timer tmr_Clock;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

