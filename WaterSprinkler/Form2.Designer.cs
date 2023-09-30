
namespace WaterSprinkler
{
    partial class Form2
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
            this.pnl_Simulation = new System.Windows.Forms.Panel();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lbl_Clock2 = new System.Windows.Forms.Label();
            this.tmr_Clock2 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Simulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Simulation
            // 
            this.pnl_Simulation.Controls.Add(this.btn_Return);
            this.pnl_Simulation.Controls.Add(this.lbl_Clock2);
            this.pnl_Simulation.Location = new System.Drawing.Point(1, 2);
            this.pnl_Simulation.Name = "pnl_Simulation";
            this.pnl_Simulation.Size = new System.Drawing.Size(781, 513);
            this.pnl_Simulation.TabIndex = 0;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(11, 10);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(130, 40);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.Text = "RETURN";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // lbl_Clock2
            // 
            this.lbl_Clock2.AutoSize = true;
            this.lbl_Clock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clock2.Location = new System.Drawing.Point(628, 19);
            this.lbl_Clock2.Name = "lbl_Clock2";
            this.lbl_Clock2.Size = new System.Drawing.Size(132, 30);
            this.lbl_Clock2.TabIndex = 1;
            this.lbl_Clock2.Text = "00:00:00   ";
            // 
            // tmr_Clock2
            // 
            this.tmr_Clock2.Tick += new System.EventHandler(this.tmr_Clock2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 516);
            this.Controls.Add(this.pnl_Simulation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_Simulation.ResumeLayout(false);
            this.pnl_Simulation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Simulation;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lbl_Clock2;
        private System.Windows.Forms.Timer tmr_Clock2;
    }
}