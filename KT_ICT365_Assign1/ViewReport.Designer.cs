namespace KT_ICT365_Assign1
{
    partial class ViewReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grid_Rent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grid_Return = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_Customer = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.grid_Car = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 11);
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
            this.label2.Location = new System.Drawing.Point(260, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "|  It\'s easy, in and out!";
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
            this.panel1.TabIndex = 55;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(677, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 35);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grid_Rent
            // 
            this.grid_Rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Rent.Location = new System.Drawing.Point(63, 176);
            this.grid_Rent.Name = "grid_Rent";
            this.grid_Rent.RowHeadersWidth = 51;
            this.grid_Rent.RowTemplate.Height = 29;
            this.grid_Rent.Size = new System.Drawing.Size(674, 150);
            this.grid_Rent.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 31);
            this.label3.TabIndex = 58;
            this.label3.Text = "Rents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 60;
            this.label4.Text = "Returns";
            // 
            // grid_Return
            // 
            this.grid_Return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Return.Location = new System.Drawing.Point(63, 413);
            this.grid_Return.Name = "grid_Return";
            this.grid_Return.RowHeadersWidth = 51;
            this.grid_Return.RowTemplate.Height = 29;
            this.grid_Return.Size = new System.Drawing.Size(674, 150);
            this.grid_Return.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(347, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 31);
            this.label5.TabIndex = 61;
            this.label5.Text = "View Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 31);
            this.label6.TabIndex = 63;
            this.label6.Text = "Customers";
            // 
            // grid_Customer
            // 
            this.grid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Customer.Location = new System.Drawing.Point(63, 654);
            this.grid_Customer.Name = "grid_Customer";
            this.grid_Customer.RowHeadersWidth = 51;
            this.grid_Customer.RowTemplate.Height = 29;
            this.grid_Customer.Size = new System.Drawing.Size(674, 150);
            this.grid_Customer.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 837);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "Cars";
            // 
            // grid_Car
            // 
            this.grid_Car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Car.Location = new System.Drawing.Point(63, 883);
            this.grid_Car.Name = "grid_Car";
            this.grid_Car.RowHeadersWidth = 51;
            this.grid_Car.RowTemplate.Height = 29;
            this.grid_Car.Size = new System.Drawing.Size(674, 150);
            this.grid_Car.TabIndex = 64;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 1074);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grid_Car);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grid_Customer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid_Return);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_Rent);
            this.Controls.Add(this.panel1);
            this.Name = "ViewReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnBack;
        private DataGridView grid_Rent;
        private Label label3;
        private Label label4;
        private DataGridView grid_Return;
        private Label label5;
        private Label label6;
        private DataGridView grid_Customer;
        private Label label7;
        private DataGridView grid_Car;
    }
}