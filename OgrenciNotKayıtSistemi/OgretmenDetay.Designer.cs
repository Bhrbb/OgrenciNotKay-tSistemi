namespace OgrenciNotKayıtSistemi
{
    partial class OgretmenDetay
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskogrNo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblkalansayi = new System.Windows.Forms.Label();
            this.lblgecensayi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblkalan = new System.Windows.Forms.Label();
            this.lblgecen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciNotOtomasyonuDataSet = new OgrenciNotKayıtSistemi.OgrenciNotOtomasyonuDataSet();
            this.tblogrencidetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ogrencidetayTableAdapter = new OgrenciNotKayıtSistemi.OgrenciNotOtomasyonuDataSetTableAdapters.Tbl_ogrencidetayTableAdapter();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINAV1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINAV2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINAV3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrencidetayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.mskogrNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ögrenci Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(120, 153);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(127, 31);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Ögrenci Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 121);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(127, 26);
            this.txtSoyad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ögrenci No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 89);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(128, 26);
            this.txtAd.TabIndex = 2;
            // 
            // mskogrNo
            // 
            this.mskogrNo.Location = new System.Drawing.Point(120, 57);
            this.mskogrNo.Mask = "0000";
            this.mskogrNo.Name = "mskogrNo";
            this.mskogrNo.Size = new System.Drawing.Size(127, 26);
            this.mskogrNo.TabIndex = 1;
            this.mskogrNo.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSınav1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSınav3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSınav2);
            this.groupBox2.Location = new System.Drawing.Point(272, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(96, 57);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(128, 26);
            this.txtSınav1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sınav3:";
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(96, 121);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(127, 26);
            this.txtSınav3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınav2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sınav1:";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(96, 89);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(128, 26);
            this.txtSınav2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblkalansayi);
            this.groupBox3.Controls.Add(this.lblgecensayi);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblkalan);
            this.groupBox3.Controls.Add(this.lblgecen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(516, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 223);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lblkalansayi
            // 
            this.lblkalansayi.AutoSize = true;
            this.lblkalansayi.Location = new System.Drawing.Point(132, 121);
            this.lblkalansayi.Name = "lblkalansayi";
            this.lblkalansayi.Size = new System.Drawing.Size(28, 18);
            this.lblkalansayi.TabIndex = 9;
            this.lblkalansayi.Text = "00";
            // 
            // lblgecensayi
            // 
            this.lblgecensayi.AutoSize = true;
            this.lblgecensayi.Location = new System.Drawing.Point(132, 89);
            this.lblgecensayi.Name = "lblgecensayi";
            this.lblgecensayi.Size = new System.Drawing.Size(28, 18);
            this.lblgecensayi.TabIndex = 8;
            this.lblgecensayi.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "00";
            // 
            // lblkalan
            // 
            this.lblkalan.AutoSize = true;
            this.lblkalan.Location = new System.Drawing.Point(28, 121);
            this.lblkalan.Name = "lblkalan";
            this.lblkalan.Size = new System.Drawing.Size(98, 18);
            this.lblkalan.TabIndex = 6;
            this.lblkalan.Text = "Kalan Sayısı:";
            // 
            // lblgecen
            // 
            this.lblgecen.AutoSize = true;
            this.lblgecen.Location = new System.Drawing.Point(24, 89);
            this.lblgecen.Name = "lblgecen";
            this.lblgecen.Size = new System.Drawing.Size(102, 18);
            this.lblgecen.TabIndex = 5;
            this.lblgecen.Text = "Gecen Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(765, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRNODataGridViewTextBoxColumn,
            this.sINAV1DataGridViewTextBoxColumn,
            this.sINAV2DataGridViewTextBoxColumn,
            this.sINAV3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblogrencidetayBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 143);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrenciNotOtomasyonuDataSet
            // 
            this.ogrenciNotOtomasyonuDataSet.DataSetName = "OgrenciNotOtomasyonuDataSet";
            this.ogrenciNotOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblogrencidetayBindingSource
            // 
            this.tblogrencidetayBindingSource.DataMember = "Tbl_ogrencidetay";
            this.tblogrencidetayBindingSource.DataSource = this.ogrenciNotOtomasyonuDataSet;
            // 
            // tbl_ogrencidetayTableAdapter
            // 
            this.tbl_ogrencidetayTableAdapter.ClearBeforeFill = true;
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRNODataGridViewTextBoxColumn
            // 
            this.oGRNODataGridViewTextBoxColumn.DataPropertyName = "OGRNO";
            this.oGRNODataGridViewTextBoxColumn.HeaderText = "OGRNO";
            this.oGRNODataGridViewTextBoxColumn.Name = "oGRNODataGridViewTextBoxColumn";
            // 
            // sINAV1DataGridViewTextBoxColumn
            // 
            this.sINAV1DataGridViewTextBoxColumn.DataPropertyName = "SINAV1";
            this.sINAV1DataGridViewTextBoxColumn.HeaderText = "SINAV1";
            this.sINAV1DataGridViewTextBoxColumn.Name = "sINAV1DataGridViewTextBoxColumn";
            // 
            // sINAV2DataGridViewTextBoxColumn
            // 
            this.sINAV2DataGridViewTextBoxColumn.DataPropertyName = "SINAV2";
            this.sINAV2DataGridViewTextBoxColumn.HeaderText = "SINAV2";
            this.sINAV2DataGridViewTextBoxColumn.Name = "sINAV2DataGridViewTextBoxColumn";
            // 
            // sINAV3DataGridViewTextBoxColumn
            // 
            this.sINAV3DataGridViewTextBoxColumn.DataPropertyName = "SINAV3";
            this.sINAV3DataGridViewTextBoxColumn.HeaderText = "SINAV3";
            this.sINAV3DataGridViewTextBoxColumn.Name = "sINAV3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // OgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 469);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OgretmenDetay";
            this.Text = "OgretmenDetay";
            this.Load += new System.EventHandler(this.OgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrencidetayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskogrNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblkalansayi;
        private System.Windows.Forms.Label lblgecensayi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblkalan;
        private System.Windows.Forms.Label lblgecen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciNotOtomasyonuDataSet ogrenciNotOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblogrencidetayBindingSource;
        private OgrenciNotOtomasyonuDataSetTableAdapters.Tbl_ogrencidetayTableAdapter tbl_ogrencidetayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sINAV1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sINAV2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sINAV3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
    }
}