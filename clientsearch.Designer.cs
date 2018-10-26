namespace WindowsFormsApp1
{
    partial class clientsearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbsubtype = new System.Windows.Forms.ComboBox();
            this.cmbpropertytype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbsubtype);
            this.groupBox1.Controls.Add(this.cmbpropertytype);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(596, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "0";
            // 
            // cmbsubtype
            // 
            this.cmbsubtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubtype.ForeColor = System.Drawing.Color.Black;
            this.cmbsubtype.FormattingEnabled = true;
            this.cmbsubtype.Location = new System.Drawing.Point(340, 66);
            this.cmbsubtype.Name = "cmbsubtype";
            this.cmbsubtype.Size = new System.Drawing.Size(121, 23);
            this.cmbsubtype.TabIndex = 103;
            // 
            // cmbpropertytype
            // 
            this.cmbpropertytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpropertytype.ForeColor = System.Drawing.Color.Black;
            this.cmbpropertytype.FormattingEnabled = true;
            this.cmbpropertytype.Items.AddRange(new object[] {
            "Residential",
            "Gated Community Layout",
            "Commercial",
            "Industrial",
            "Agricultural",
            "Service apartment",
            "Joint venture"});
            this.cmbpropertytype.Location = new System.Drawing.Point(340, 30);
            this.cmbpropertytype.Name = "cmbpropertytype";
            this.cmbpropertytype.Size = new System.Drawing.Size(121, 23);
            this.cmbpropertytype.TabIndex = 102;
            this.cmbpropertytype.SelectedIndexChanged += new System.EventHandler(this.cmbpropertytype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(530, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Results";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(233, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 29);
            this.button1.TabIndex = 99;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(340, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 29);
            this.button2.TabIndex = 100;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(441, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 29);
            this.button3.TabIndex = 101;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(202, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 16);
            this.label22.TabIndex = 92;
            this.label22.Text = "Property Sub Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(230, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 16);
            this.label21.TabIndex = 91;
            this.label21.Text = "Property Type";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 224);
            this.dataGridView1.TabIndex = 6;
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
            // clientsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "clientsearch";
            this.Text = "clientsearch";
            this.Load += new System.EventHandler(this.clientsearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsubtype;
        private System.Windows.Forms.ComboBox cmbpropertytype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
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