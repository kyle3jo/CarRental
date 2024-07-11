namespace KT_ICT365_Assign1
{
    partial class ReturnForm
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
            this.num_MilesBefore = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.datePicker_Return = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_UniqBookNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_DaysRented = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.num_Discount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmboBox_CarCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.num_MilesAfter = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.num_TotalCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_MilesBefore)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_DaysRented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MilesAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // num_MilesBefore
            // 
            this.num_MilesBefore.Location = new System.Drawing.Point(408, 243);
            this.num_MilesBefore.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_MilesBefore.Name = "num_MilesBefore";
            this.num_MilesBefore.Size = new System.Drawing.Size(132, 27);
            this.num_MilesBefore.TabIndex = 39;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(478, 582);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 35);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(583, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(268, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Miles (Before) *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(195, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Date and Time of Return *";
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
            // datePicker_Return
            // 
            this.datePicker_Return.Location = new System.Drawing.Point(408, 196);
            this.datePicker_Return.Name = "datePicker_Return";
            this.datePicker_Return.Size = new System.Drawing.Size(268, 27);
            this.datePicker_Return.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 77);
            this.panel1.TabIndex = 33;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(193, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Unique booking number *";
            // 
            // txtBox_UniqBookNum
            // 
            this.txtBox_UniqBookNum.Location = new System.Drawing.Point(408, 147);
            this.txtBox_UniqBookNum.Name = "txtBox_UniqBookNum";
            this.txtBox_UniqBookNum.Size = new System.Drawing.Size(268, 27);
            this.txtBox_UniqBookNum.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(381, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Return";
            // 
            // num_DaysRented
            // 
            this.num_DaysRented.Location = new System.Drawing.Point(408, 369);
            this.num_DaysRented.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_DaysRented.Name = "num_DaysRented";
            this.num_DaysRented.Size = new System.Drawing.Size(95, 27);
            this.num_DaysRented.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(285, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Days Rented *";
            // 
            // num_Discount
            // 
            this.num_Discount.Location = new System.Drawing.Point(408, 411);
            this.num_Discount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_Discount.Name = "num_Discount";
            this.num_Discount.Size = new System.Drawing.Size(67, 27);
            this.num_Discount.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(268, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Discount Rate *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(299, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 44;
            this.label10.Text = "Total Cost *";
            // 
            // cmboBox_CarCategory
            // 
            this.cmboBox_CarCategory.FormattingEnabled = true;
            this.cmboBox_CarCategory.Items.AddRange(new object[] {
            "Hatchbak",
            "Sedan",
            "Wagon",
            "12-Seater Van",
            "20-Seater Van",
            "42-Seater Van",
            "5-Seater Charter",
            "7-Seater Charter"});
            this.cmboBox_CarCategory.Location = new System.Drawing.Point(408, 323);
            this.cmboBox_CarCategory.Name = "cmboBox_CarCategory";
            this.cmboBox_CarCategory.Size = new System.Drawing.Size(289, 28);
            this.cmboBox_CarCategory.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(280, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 23);
            this.label11.TabIndex = 47;
            this.label11.Text = "Car Category *";
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTotal.ForeColor = System.Drawing.Color.Black;
            this.btnTotal.Location = new System.Drawing.Point(477, 529);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(199, 35);
            this.btnTotal.TabIndex = 48;
            this.btnTotal.Text = "Calculate Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // num_MilesAfter
            // 
            this.num_MilesAfter.Location = new System.Drawing.Point(408, 281);
            this.num_MilesAfter.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_MilesAfter.Name = "num_MilesAfter";
            this.num_MilesAfter.Size = new System.Drawing.Size(132, 27);
            this.num_MilesAfter.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(280, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 23);
            this.label12.TabIndex = 49;
            this.label12.Text = "Miles (After) *";
            // 
            // num_TotalCost
            // 
            this.num_TotalCost.Location = new System.Drawing.Point(408, 452);
            this.num_TotalCost.Name = "num_TotalCost";
            this.num_TotalCost.Size = new System.Drawing.Size(125, 27);
            this.num_TotalCost.TabIndex = 51;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.num_TotalCost);
            this.Controls.Add(this.num_MilesAfter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmboBox_CarCategory);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.num_Discount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_DaysRented);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num_MilesBefore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePicker_Return);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_UniqBookNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.num_MilesBefore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_DaysRented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MilesAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown num_MilesBefore;
        private Button btnReset;
        private Button btnSave;
        private Label label9;
        private Label label8;
        private Button btnBack;
        private DateTimePicker datePicker_Return;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtBox_UniqBookNum;
        private Label label4;
        private Label label3;
        private NumericUpDown num_DaysRented;
        private Label label6;
        private NumericUpDown num_Discount;
        private Label label7;
        private Label label10;
        private ComboBox cmboBox_CarCategory;
        private Label label11;
        private Button btnTotal;
        private NumericUpDown num_MilesAfter;
        private Label label12;
        private TextBox num_TotalCost;
    }
}