
namespace BigProject.GUI
{
    partial class DiemForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienDataSet_Diem = new BigProject.QLSinhVienDataSet_Diem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.diemTableAdapter = new BigProject.QLSinhVienDataSet_DiemTableAdapters.DiemTableAdapter();
            this.txtmasinhvien = new System.Windows.Forms.TextBox();
            this.txtmahocphan = new System.Windows.Forms.TextBox();
            this.txtdiemchuyencan = new System.Windows.Forms.TextBox();
            this.txtdiemgiuaky = new System.Windows.Forms.TextBox();
            this.txtdiemcuoiky = new System.Windows.Forms.TextBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dataGridView_diem = new System.Windows.Forms.DataGridView();
            this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemchuyencanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemgiuakyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemcuoikyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiem10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiem4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiemchuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet_Diem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnxoa);
            this.panel3.Controls.Add(this.btnsua);
            this.panel3.Controls.Add(this.btnthem);
            this.panel3.Controls.Add(this.txtdiemcuoiky);
            this.panel3.Controls.Add(this.txtdiemgiuaky);
            this.panel3.Controls.Add(this.txtdiemchuyencan);
            this.panel3.Controls.Add(this.txtmahocphan);
            this.panel3.Controls.Add(this.txtmasinhvien);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 176);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(291, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Điểm cuối kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(291, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Điểm giữa kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(272, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Điểm chuyên cần:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã học phần:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_diem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 244);
            this.panel2.TabIndex = 4;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            this.diemBindingSource.DataSource = this.qLSinhVienDataSet_Diem;
            // 
            // qLSinhVienDataSet_Diem
            // 
            this.qLSinhVienDataSet_Diem.DataSetName = "QLSinhVienDataSet_Diem";
            this.qLSinhVienDataSet_Diem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 35);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tìm kiếm:";
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // txtmasinhvien
            // 
            this.txtmasinhvien.Location = new System.Drawing.Point(127, 21);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.Size = new System.Drawing.Size(100, 21);
            this.txtmasinhvien.TabIndex = 36;
            // 
            // txtmahocphan
            // 
            this.txtmahocphan.Location = new System.Drawing.Point(127, 68);
            this.txtmahocphan.Name = "txtmahocphan";
            this.txtmahocphan.Size = new System.Drawing.Size(100, 21);
            this.txtmahocphan.TabIndex = 37;
            // 
            // txtdiemchuyencan
            // 
            this.txtdiemchuyencan.Location = new System.Drawing.Point(395, 21);
            this.txtdiemchuyencan.Name = "txtdiemchuyencan";
            this.txtdiemchuyencan.Size = new System.Drawing.Size(100, 21);
            this.txtdiemchuyencan.TabIndex = 38;
            // 
            // txtdiemgiuaky
            // 
            this.txtdiemgiuaky.Location = new System.Drawing.Point(395, 60);
            this.txtdiemgiuaky.Name = "txtdiemgiuaky";
            this.txtdiemgiuaky.Size = new System.Drawing.Size(100, 21);
            this.txtdiemgiuaky.TabIndex = 39;
            // 
            // txtdiemcuoiky
            // 
            this.txtdiemcuoiky.Location = new System.Drawing.Point(395, 102);
            this.txtdiemcuoiky.Name = "txtdiemcuoiky";
            this.txtdiemcuoiky.Size = new System.Drawing.Size(100, 21);
            this.txtdiemcuoiky.TabIndex = 40;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(75, 8);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 20);
            this.txttimkiem.TabIndex = 41;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(604, 21);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(604, 62);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 42;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(604, 101);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView_diem
            // 
            this.dataGridView_diem.AllowUserToAddRows = false;
            this.dataGridView_diem.AllowUserToDeleteRows = false;
            this.dataGridView_diem.AutoGenerateColumns = false;
            this.dataGridView_diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvienDataGridViewTextBoxColumn,
            this.mahocphanDataGridViewTextBoxColumn,
            this.diemchuyencanDataGridViewTextBoxColumn,
            this.diemgiuakyDataGridViewTextBoxColumn,
            this.diemcuoikyDataGridViewTextBoxColumn,
            this.thangdiem10DataGridViewTextBoxColumn,
            this.thangdiem4DataGridViewTextBoxColumn,
            this.thangdiemchuDataGridViewTextBoxColumn});
            this.dataGridView_diem.DataSource = this.diemBindingSource;
            this.dataGridView_diem.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_diem.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_diem.Name = "dataGridView_diem";
            this.dataGridView_diem.Size = new System.Drawing.Size(772, 244);
            this.dataGridView_diem.TabIndex = 0;
            // 
            // masinhvienDataGridViewTextBoxColumn
            // 
            this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "Masinhvien";
            this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Masinhvien";
            this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
            // 
            // mahocphanDataGridViewTextBoxColumn
            // 
            this.mahocphanDataGridViewTextBoxColumn.DataPropertyName = "Mahocphan";
            this.mahocphanDataGridViewTextBoxColumn.HeaderText = "Mahocphan";
            this.mahocphanDataGridViewTextBoxColumn.Name = "mahocphanDataGridViewTextBoxColumn";
            // 
            // diemchuyencanDataGridViewTextBoxColumn
            // 
            this.diemchuyencanDataGridViewTextBoxColumn.DataPropertyName = "Diemchuyencan";
            this.diemchuyencanDataGridViewTextBoxColumn.HeaderText = "Diemchuyencan";
            this.diemchuyencanDataGridViewTextBoxColumn.Name = "diemchuyencanDataGridViewTextBoxColumn";
            // 
            // diemgiuakyDataGridViewTextBoxColumn
            // 
            this.diemgiuakyDataGridViewTextBoxColumn.DataPropertyName = "Diemgiuaky";
            this.diemgiuakyDataGridViewTextBoxColumn.HeaderText = "Diemgiuaky";
            this.diemgiuakyDataGridViewTextBoxColumn.Name = "diemgiuakyDataGridViewTextBoxColumn";
            // 
            // diemcuoikyDataGridViewTextBoxColumn
            // 
            this.diemcuoikyDataGridViewTextBoxColumn.DataPropertyName = "Diemcuoiky";
            this.diemcuoikyDataGridViewTextBoxColumn.HeaderText = "Diemcuoiky";
            this.diemcuoikyDataGridViewTextBoxColumn.Name = "diemcuoikyDataGridViewTextBoxColumn";
            // 
            // thangdiem10DataGridViewTextBoxColumn
            // 
            this.thangdiem10DataGridViewTextBoxColumn.DataPropertyName = "Thangdiem10";
            this.thangdiem10DataGridViewTextBoxColumn.HeaderText = "Thangdiem10";
            this.thangdiem10DataGridViewTextBoxColumn.Name = "thangdiem10DataGridViewTextBoxColumn";
            // 
            // thangdiem4DataGridViewTextBoxColumn
            // 
            this.thangdiem4DataGridViewTextBoxColumn.DataPropertyName = "Thangdiem4";
            this.thangdiem4DataGridViewTextBoxColumn.HeaderText = "Thangdiem4";
            this.thangdiem4DataGridViewTextBoxColumn.Name = "thangdiem4DataGridViewTextBoxColumn";
            // 
            // thangdiemchuDataGridViewTextBoxColumn
            // 
            this.thangdiemchuDataGridViewTextBoxColumn.DataPropertyName = "Thangdiemchu";
            this.thangdiemchuDataGridViewTextBoxColumn.HeaderText = "Thangdiemchu";
            this.thangdiemchuDataGridViewTextBoxColumn.Name = "thangdiemchuDataGridViewTextBoxColumn";
            // 
            // DiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 452);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DiemForm";
            this.Text = "DiemForm";
            this.Load += new System.EventHandler(this.DiemForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet_Diem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private QLSinhVienDataSet_Diem qLSinhVienDataSet_Diem;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private QLSinhVienDataSet_DiemTableAdapters.DiemTableAdapter diemTableAdapter;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtdiemcuoiky;
        private System.Windows.Forms.TextBox txtdiemgiuaky;
        private System.Windows.Forms.TextBox txtdiemchuyencan;
        private System.Windows.Forms.TextBox txtmahocphan;
        private System.Windows.Forms.TextBox txtmasinhvien;
        private System.Windows.Forms.DataGridView dataGridView_diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemchuyencanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemgiuakyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemcuoikyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiem10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiem4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiemchuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}