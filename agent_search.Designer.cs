namespace WindowsFormsApp1
{
    partial class agent_search
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbsubtype = new System.Windows.Forms.ComboBox();
            this.txtpropertytype = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.realEstateDataSet = new WindowsFormsApp1.RealEstateDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp1.RealEstateDataSetTableAdapters.ClientTableAdapter();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sublocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertySubtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.leaseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rentamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accommodationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedBackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbsubtype);
            this.groupBox1.Controls.Add(this.txtpropertytype);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 232);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent Search";
            // 
            // cmbsubtype
            // 
            this.cmbsubtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubtype.ForeColor = System.Drawing.Color.Black;
            this.cmbsubtype.FormattingEnabled = true;
            this.cmbsubtype.Location = new System.Drawing.Point(180, 114);
            this.cmbsubtype.Name = "cmbsubtype";
            this.cmbsubtype.Size = new System.Drawing.Size(121, 23);
            this.cmbsubtype.TabIndex = 113;
            // 
            // txtpropertytype
            // 
            this.txtpropertytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpropertytype.ForeColor = System.Drawing.Color.Black;
            this.txtpropertytype.FormattingEnabled = true;
            this.txtpropertytype.Items.AddRange(new object[] {
            "Residential",
            "Gated Community Layout",
            "Commercial",
            "Industrial",
            "Agricultural",
            "Service apartment",
            "Joint venture"});
            this.txtpropertytype.Location = new System.Drawing.Point(180, 73);
            this.txtpropertytype.Name = "txtpropertytype";
            this.txtpropertytype.Size = new System.Drawing.Size(121, 23);
            this.txtpropertytype.TabIndex = 112;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(36, 117);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 16);
            this.label22.TabIndex = 111;
            this.label22.Text = "Property Sub Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(57, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 16);
            this.label21.TabIndex = 110;
            this.label21.Text = "Property Type";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Wilson Garden",
            "ponnambur",
            "Dollars Colony",
            "jayanagar"});
            this.comboBox2.Location = new System.Drawing.Point(439, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 109;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bangalore",
            "Mangalore",
            "Bagepally",
            "Malur"});
            this.comboBox1.Location = new System.Drawing.Point(439, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(319, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "Sub Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(338, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 106;
            this.label6.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(502, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(436, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Results";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(396, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 101;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(279, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 100;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(164, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 99;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(72, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 93;
            this.label14.Text = "Agent Name";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(180, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 21);
            this.textBox4.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 84;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.workAddressDataGridViewTextBoxColumn,
            this.residenceAddressDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.sublocationDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.propertytypeDataGridViewTextBoxColumn,
            this.propertySubtypeDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.rentDataGridViewCheckBoxColumn,
            this.leaseDataGridViewCheckBoxColumn,
            this.saleDataGridViewCheckBoxColumn,
            this.rentamtDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.accommodationDataGridViewTextBoxColumn,
            this.furnishedDataGridViewTextBoxColumn,
            this.feedBackDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 236);
            this.dataGridView1.TabIndex = 5;
            // 
            // realEstateDataSet
            // 
            this.realEstateDataSet.DataSetName = "RealEstateDataSet";
            this.realEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.realEstateDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // workAddressDataGridViewTextBoxColumn
            // 
            this.workAddressDataGridViewTextBoxColumn.DataPropertyName = "Work_Address";
            this.workAddressDataGridViewTextBoxColumn.HeaderText = "Work_Address";
            this.workAddressDataGridViewTextBoxColumn.Name = "workAddressDataGridViewTextBoxColumn";
            // 
            // residenceAddressDataGridViewTextBoxColumn
            // 
            this.residenceAddressDataGridViewTextBoxColumn.DataPropertyName = "Residence_Address";
            this.residenceAddressDataGridViewTextBoxColumn.HeaderText = "Residence_Address";
            this.residenceAddressDataGridViewTextBoxColumn.Name = "residenceAddressDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // sublocationDataGridViewTextBoxColumn
            // 
            this.sublocationDataGridViewTextBoxColumn.DataPropertyName = "Sub_location";
            this.sublocationDataGridViewTextBoxColumn.HeaderText = "Sub_location";
            this.sublocationDataGridViewTextBoxColumn.Name = "sublocationDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // propertytypeDataGridViewTextBoxColumn
            // 
            this.propertytypeDataGridViewTextBoxColumn.DataPropertyName = "Property_type";
            this.propertytypeDataGridViewTextBoxColumn.HeaderText = "Property_type";
            this.propertytypeDataGridViewTextBoxColumn.Name = "propertytypeDataGridViewTextBoxColumn";
            // 
            // propertySubtypeDataGridViewTextBoxColumn
            // 
            this.propertySubtypeDataGridViewTextBoxColumn.DataPropertyName = "Property_Subtype";
            this.propertySubtypeDataGridViewTextBoxColumn.HeaderText = "Property_Subtype";
            this.propertySubtypeDataGridViewTextBoxColumn.Name = "propertySubtypeDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // rentDataGridViewCheckBoxColumn
            // 
            this.rentDataGridViewCheckBoxColumn.DataPropertyName = "Rent";
            this.rentDataGridViewCheckBoxColumn.HeaderText = "Rent";
            this.rentDataGridViewCheckBoxColumn.Name = "rentDataGridViewCheckBoxColumn";
            // 
            // leaseDataGridViewCheckBoxColumn
            // 
            this.leaseDataGridViewCheckBoxColumn.DataPropertyName = "Lease";
            this.leaseDataGridViewCheckBoxColumn.HeaderText = "Lease";
            this.leaseDataGridViewCheckBoxColumn.Name = "leaseDataGridViewCheckBoxColumn";
            // 
            // saleDataGridViewCheckBoxColumn
            // 
            this.saleDataGridViewCheckBoxColumn.DataPropertyName = "Sale";
            this.saleDataGridViewCheckBoxColumn.HeaderText = "Sale";
            this.saleDataGridViewCheckBoxColumn.Name = "saleDataGridViewCheckBoxColumn";
            // 
            // rentamtDataGridViewTextBoxColumn
            // 
            this.rentamtDataGridViewTextBoxColumn.DataPropertyName = "Rent_amt";
            this.rentamtDataGridViewTextBoxColumn.HeaderText = "Rent_amt";
            this.rentamtDataGridViewTextBoxColumn.Name = "rentamtDataGridViewTextBoxColumn";
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "Client_Type";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "Client_Type";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            // 
            // accommodationDataGridViewTextBoxColumn
            // 
            this.accommodationDataGridViewTextBoxColumn.DataPropertyName = "Accommodation";
            this.accommodationDataGridViewTextBoxColumn.HeaderText = "Accommodation";
            this.accommodationDataGridViewTextBoxColumn.Name = "accommodationDataGridViewTextBoxColumn";
            // 
            // furnishedDataGridViewTextBoxColumn
            // 
            this.furnishedDataGridViewTextBoxColumn.DataPropertyName = "Furnished";
            this.furnishedDataGridViewTextBoxColumn.HeaderText = "Furnished";
            this.furnishedDataGridViewTextBoxColumn.Name = "furnishedDataGridViewTextBoxColumn";
            // 
            // feedBackDataGridViewTextBoxColumn
            // 
            this.feedBackDataGridViewTextBoxColumn.DataPropertyName = "FeedBack";
            this.feedBackDataGridViewTextBoxColumn.HeaderText = "FeedBack";
            this.feedBackDataGridViewTextBoxColumn.Name = "feedBackDataGridViewTextBoxColumn";
            // 
            // agent_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "agent_search";
            this.Text = "agent_search";
            this.Load += new System.EventHandler(this.agent_search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbsubtype;
        private System.Windows.Forms.ComboBox txtpropertytype;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RealEstateDataSet realEstateDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RealEstateDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sublocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertySubtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn leaseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accommodationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedBackDataGridViewTextBoxColumn;
    }
}