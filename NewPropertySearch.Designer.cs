namespace WindowsFormsApp1
{
    partial class NewPropertySearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.realEstateDataSet31 = new WindowsFormsApp1.RealEstateDataSet3();
            this.propertyTableAdapter1 = new WindowsFormsApp1.RealEstateDataSet3TableAdapters.PropertyTableAdapter();
            this.propertyTableAdapter2 = new WindowsFormsApp1.RealEstateDataSetTableAdapters.PropertyTableAdapter();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboproperty2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.comboLocation1 = new System.Windows.Forms.ComboBox();
            this.comboLocation2 = new System.Windows.Forms.ComboBox();
            this.comboProperty1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.propertyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // realEstateDataSet31
            // 
            this.realEstateDataSet31.DataSetName = "RealEstateDataSet3";
            this.realEstateDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyTableAdapter1
            // 
            this.propertyTableAdapter1.ClearBeforeFill = true;
            // 
            // propertyTableAdapter2
            // 
            this.propertyTableAdapter2.ClearBeforeFill = true;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataMember = "Property";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboproperty2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtOwnerName);
            this.panel1.Controls.Add(this.comboLocation1);
            this.panel1.Controls.Add(this.comboLocation2);
            this.panel1.Controls.Add(this.comboProperty1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 219);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total Result:";
            // 
            // comboproperty2
            // 
            this.comboproperty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboproperty2.FormattingEnabled = true;
            this.comboproperty2.Location = new System.Drawing.Point(139, 92);
            this.comboproperty2.Name = "comboproperty2";
            this.comboproperty2.Size = new System.Drawing.Size(121, 23);
            this.comboproperty2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Property SubType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "PropertySearch";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(269, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 27);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(172, 171);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 27);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Clear";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(77, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 27);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerName.Location = new System.Drawing.Point(139, 130);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(121, 21);
            this.txtOwnerName.TabIndex = 18;
            // 
            // comboLocation1
            // 
            this.comboLocation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocation1.FormattingEnabled = true;
            this.comboLocation1.Items.AddRange(new object[] {
            "Bangalore",
            "Mangalore",
            "Bagepally",
            "Malur"});
            this.comboLocation1.Location = new System.Drawing.Point(366, 59);
            this.comboLocation1.Name = "comboLocation1";
            this.comboLocation1.Size = new System.Drawing.Size(121, 23);
            this.comboLocation1.TabIndex = 17;
            // 
            // comboLocation2
            // 
            this.comboLocation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocation2.FormattingEnabled = true;
            this.comboLocation2.Items.AddRange(new object[] {
            "Wilson Garden",
            "ponnambur",
            "Dollars Colony",
            "jayanagar"});
            this.comboLocation2.Location = new System.Drawing.Point(366, 95);
            this.comboLocation2.Name = "comboLocation2";
            this.comboLocation2.Size = new System.Drawing.Size(121, 23);
            this.comboLocation2.TabIndex = 16;
            // 
            // comboProperty1
            // 
            this.comboProperty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProperty1.FormattingEnabled = true;
            this.comboProperty1.Items.AddRange(new object[] {
            "Residential",
            "Gated Community Layout",
            "Commercial",
            "Industrial",
            "Agricultural",
            "Service apartment",
            "Joint venture"});
            this.comboProperty1.Location = new System.Drawing.Point(139, 56);
            this.comboProperty1.Name = "comboProperty1";
            this.comboProperty1.Size = new System.Drawing.Size(121, 23);
            this.comboProperty1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "OwnerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "SubLocation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "PropertyType";
            // 
            // NewPropertySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewPropertySearch";
            this.Text = "NewPropertySearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private RealEstateDataSet3 realEstateDataSet31;
        private RealEstateDataSet3TableAdapters.PropertyTableAdapter propertyTableAdapter1;
        private RealEstateDataSetTableAdapters.PropertyTableAdapter propertyTableAdapter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboproperty2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.ComboBox comboLocation1;
        private System.Windows.Forms.ComboBox comboLocation2;
        private System.Windows.Forms.ComboBox comboProperty1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}