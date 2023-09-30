using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WaterSprinkler
{
    public partial class Form1 : Form
    {

        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        //DateTime clock = new DateTime();
        
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            bool hasCheck = false;
           
            //Checking if there are input in groupbox
            foreach (Control c in gbx_Days.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Checked == true)
                    {
                        hasCheck = true;
                    }
                }
            }

            string time = tbx_Hour.Text.ToString() + ":" + tbx_Minute.Text.ToString() + " " + cbx_Meridiem.Text;

            if (tbx_Name.Text.Length != 0 && tbx_Hour.Text.Length != 0 && tbx_Minute.Text.Length != 0 && tbx_Water.Text.Length != 0 &&cbx_Meridiem.Text.Length != 0 && pbx_Image.Image != null && hasCheck)
            {
                //Enumeration of days in the groupbox
                foreach (Control c in gbx_Days.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;

                        if (cb.Checked == true)
                        {
                            tbx_Days.Text = cb.Text + ", " + tbx_Days.Text;
                        }
                    }
                }

                //Adding of values into sql database
                cmd = new MySqlCommand("insert into watersprinkler.schedule" +
                    "(ID, plantName, timeall, timeDay, waterVolume, plantImage)" +
                    "values(NULL, @plantname, @timeall, @timeday, @watervolume, @plantimage)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@plantname", tbx_Name.Text);
                cmd.Parameters.AddWithValue("@timeall", time);
                cmd.Parameters.AddWithValue("@timeday", tbx_Days.Text);
                cmd.Parameters.AddWithValue("@watervolume", tbx_Water.Text);
                cmd.Parameters.AddWithValue("@plantimage", pbx_Image.Image);
                cmd.ExecuteNonQuery();
                con.Close();
                
                //Clearing of input fields after button click
                tbx_Name.Text = "";
                tbx_Water.Text = "";
                tbx_Hour.Text = "";
                tbx_Minute.Text = "";
                tbx_Days.Text = "";
                cbx_Meridiem.Text = "";
                pbx_Image.Image = null;
                foreach (Control c in gbx_Days.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;

                        if (cb.Checked == true)
                        {
                            cb.Checked = false;
                            hasCheck = false;
                        }
                    }
                }
            }
            else
            {
                //Shows a dialog box warning when there is a missing input
                DialogResult dia = MessageBox.Show("Missing input fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

        }

        private void pbx_Image_Click(object sender, EventArgs e)
        {
            //Opens a window to search for image in device
            OpenFileDialog open = new OpenFileDialog();
            
            //Limits the picture format that can be used
            open.Filter = "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";

            //Displays the image in picturebox
            if (open.ShowDialog() == DialogResult.OK)
            { 
                pbx_Image.Image = new Bitmap(open.FileName);

            }

            //Resizes the image to fit the picturebox while keeping the same ratio
            pbx_Image.SizeMode = PictureBoxSizeMode.Zoom;

        }
       
        //Method for displaying the database into the program
        private void DisplayData()
        {
            try
            {

                con.Open();
                DataTable dt = new DataTable();
                adapt = new MySqlDataAdapter("select ID, plantName, timeAll, timeDay, waterVolume from watersprinkler.schedule", con);
                adapt.Fill(dt);
                dgv_Table.DataSource = dt;
                dgv_Table.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_Table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_Table.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_Table.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_Table.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            pnl_AddSched.Visible = true;
            pnl_AddSched.Enabled = true;

            pnl_EditSched.Visible = false;
            pnl_EditSched.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            pnl_AddSched.Visible = false;
            pnl_AddSched.Enabled = false;

            pnl_EditSched.Visible = true;
            pnl_EditSched.Enabled = true;

            InitializeComponent();
            DisplayData();

        }

        private void dgv_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Get the index of row and column of selected cell
                int rowIndex = dgv_Table.CurrentCell.RowIndex;
                int columnIndex = dgv_Table.CurrentCell.ColumnIndex;

                tbx_EName.Text = dgv_Table.Rows[rowIndex].Cells[1].Value.ToString();

                String hour = dgv_Table.Rows[rowIndex].Cells[2].Value.ToString().Split(':', ' ').First();
                tbx_EHour.Text = hour;

                String minute = dgv_Table.Rows[rowIndex].Cells[2].Value.ToString().Split(':', ' ').GetValue(1).ToString();
                tbx_EMinute.Text = minute;

                String meridiem = dgv_Table.Rows[rowIndex].Cells[2].Value.ToString().Split(':', ' ').Last();
                cbx_EMeridiem.Text = meridiem;

                tbx_EWater.Text = dgv_Table.Rows[rowIndex].Cells[4].Value.ToString();

                String[] dayArr = dgv_Table.Rows[rowIndex].Cells[3].Value.ToString().Split(' ');

                foreach (Control c in gbx_EDays.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;

                        if (cb.Checked == true)
                        {
                            cb.Checked = false;
                        }
                    }
                }

                for (int i = 0; i < dayArr.Length - 1; i++)
                {
                    if (dayArr[i] == "Sun,")
                    {
                        chk_ESun.Checked = true;
                    }
                    else if (dayArr[i] == "Mon,")
                    {
                        chk_EMon.Checked = true;
                    }
                    else if (dayArr[i] == "Tue,")
                    {
                        chk_ETue.Checked = true;
                    }
                    else if (dayArr[i] == "Wed,")
                    {
                        chk_EWed.Checked = true;
                    }
                    else if (dayArr[i] == "Thu,")
                    {
                        chk_EThu.Checked = true;
                    }
                    else if (dayArr[i] == "Fri,")
                    {
                        chk_EFri.Checked = true;
                    }
                    else if (dayArr[i] == "Sat,")
                    {
                        chk_ESat.Checked = true;
                    }
                    else
                    {
                        chk_ESun.Checked = false;
                        chk_EMon.Checked = false;
                        chk_ETue.Checked = false;
                        chk_EWed.Checked = false;
                        chk_EThu.Checked = false;
                        chk_EFri.Checked = false;
                        chk_ESat.Checked = false;
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Field selected, please select a vaid data.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("delete from watersprinkler.schedule where ID = '" + dgv_Table.Rows[dgv_Table.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            DisplayData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string time = tbx_EHour.Text.ToString() + ":" + tbx_EMinute.Text.ToString() + " " + cbx_EMeridiem.Text;

            tbx_EDays.Text = "";

            foreach (Control c in gbx_EDays.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Checked == true)
                    {
                        if (cb.Text == "S")
                        {
                            tbx_EDays.Text += "Sun, ";
                        }
                        else if (cb.Text == "M")
                        {
                            tbx_EDays.Text += "Mon, ";
                        }
                        else if (cb.Text == "T")
                        {
                            tbx_EDays.Text += "Tue, ";
                        }
                        else if (cb.Text == "W")
                        {
                            tbx_EDays.Text += "Wed, ";
                        }
                        else if (cb.Text == "Th")
                        {
                            tbx_EDays.Text += "Thu, ";
                        }
                        else if (cb.Text == "F")
                        {
                            tbx_EDays.Text += "Fri, ";
                        }
                        else if (cb.Text == "Sa")
                        {
                            tbx_EDays.Text += "Sat, ";
                        }
                    }
                }
            }

            cmd = new MySqlCommand("update watersprinkler.schedule set plantName = @plantname, timeAll = @timeall, timeDay = @timeday, waterVolume = @watervolume where ID = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", dgv_Table.Rows[dgv_Table.CurrentCell.RowIndex].Cells[0].Value);
            cmd.Parameters.AddWithValue("@plantname", tbx_EName.Text);
            cmd.Parameters.AddWithValue("@timeall", time);
            cmd.Parameters.AddWithValue("@timeday", tbx_EDays.Text);
            cmd.Parameters.AddWithValue("@watervolume", tbx_EWater.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            DisplayData();
        }

        private void tmr_Clock_Tick(object sender, EventArgs e)
        {
            lbl_Clock.Text = DateTime.Now.ToString("T");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            System.Timers.Timer clock = new System.Timers.Timer();
            clock.Interval = 1000;
            clock.Elapsed += Clock_Elapsed;
            clock.Start();
        }

        private void Clock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lbl_Clock.Text = DateTime.Now.ToString("T");
            }));
        }

        private void btn_Simulate_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}