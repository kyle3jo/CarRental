namespace KT_ICT365_Assign1
{
    partial class CarRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboBox_Trans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Engine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.num_RegYear = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Model = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_Color = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RegYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "🚗 Car Rentals";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 77);
            this.panel1.TabIndex = 54;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(677, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 35);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(260, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "|  It\'s easy, in and out!";
            // 
            // cmboBox_Trans
            // 
            this.cmboBox_Trans.AutoCompleteCustomSource.AddRange(new string[] {
            "AT",
            "MT"});
            this.cmboBox_Trans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_Trans.FormattingEnabled = true;
            this.cmboBox_Trans.Items.AddRange(new object[] {
            "AT",
            "MT"});
            this.cmboBox_Trans.Location = new System.Drawing.Point(367, 338);
            this.cmboBox_Trans.Name = "cmboBox_Trans";
            this.cmboBox_Trans.Size = new System.Drawing.Size(85, 28);
            this.cmboBox_Trans.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(298, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "Engine";
            // 
            // txtBox_Engine
            // 
            this.txtBox_Engine.Location = new System.Drawing.Point(367, 157);
            this.txtBox_Engine.Name = "txtBox_Engine";
            this.txtBox_Engine.Size = new System.Drawing.Size(177, 27);
            this.txtBox_Engine.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 31);
            this.label3.TabIndex = 57;
            this.label3.Text = "Car Registration";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(332, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 35);
            this.btnReset.TabIndex = 56;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(450, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Register";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(253, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 53;
            this.label5.Text = "Transmission";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(222, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 61;
            this.label9.Text = "Registration Year";
            // 
            // num_RegYear
            // 
            this.num_RegYear.Location = new System.Drawing.Point(367, 204);
            this.num_RegYear.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_RegYear.Name = "num_RegYear";
            this.num_RegYear.Size = new System.Drawing.Size(85, 27);
            this.num_RegYear.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(298, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "Model";
            // 
            // txtBox_Model
            // 
            this.txtBox_Model.Location = new System.Drawing.Point(367, 247);
            this.txtBox_Model.Name = "txtBox_Model";
            this.txtBox_Model.Size = new System.Drawing.Size(177, 27);
            this.txtBox_Model.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(298, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "Color";
            // 
            // txtBox_Color
            // 
            this.txtBox_Color.Location = new System.Drawing.Point(367, 292);
            this.txtBox_Color.Name = "txtBox_Color";
            this.txtBox_Color.Size = new System.Drawing.Size(177, 27);
            this.txtBox_Color.TabIndex = 65;
            // 
            // CarRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBox_Color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_Model);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.num_RegYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmboBox_Trans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Engine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CarRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarRegistration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RegYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnBack;
        private Label label2;
        private ComboBox cmboBox_Trans;
        private Label label4;
        private TextBox txtBox_Engine;
        private Label label3;
        public Button btnReset;
        private Button btnSave;
        private Label label5;
        private Label label9;
        private NumericUpDown num_RegYear;
        private Label label6;
        private TextBox txtBox_Model;
        private Label label7;
        private TextBox txtBox_Color;
    }
}