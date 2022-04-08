﻿
namespace BigProject.GUI
{
    partial class FormLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.txtnienkhoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttenlop = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmalop = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_lop = new Guna.UI2.WinForms.Guna2DataGridView();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienDataSet = new BigProject.QLSinhVienDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnxoa);
            this.panel3.Controls.Add(this.btnsua);
            this.panel3.Controls.Add(this.btnthem);
            this.panel3.Controls.Add(this.txtnienkhoa);
            this.panel3.Controls.Add(this.txttenlop);
            this.panel3.Controls.Add(this.txtmalop);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 183);
            this.panel3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(261, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mã lớp:";
            // 
            // btnxoa
            // 
            this.btnxoa.BorderRadius = 5;
            this.btnxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(602, 127);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 34);
            this.btnxoa.TabIndex = 30;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BorderRadius = 5;
            this.btnsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsua.FillColor = System.Drawing.Color.Olive;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(602, 76);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 33);
            this.btnsua.TabIndex = 29;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BorderRadius = 5;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(602, 23);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 35);
            this.btnthem.TabIndex = 28;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtnienkhoa
            // 
            this.txtnienkhoa.BorderRadius = 5;
            this.txtnienkhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnienkhoa.DefaultText = "";
            this.txtnienkhoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnienkhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnienkhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnienkhoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnienkhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnienkhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnienkhoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnienkhoa.Location = new System.Drawing.Point(317, 115);
            this.txtnienkhoa.Name = "txtnienkhoa";
            this.txtnienkhoa.PasswordChar = '\0';
            this.txtnienkhoa.PlaceholderText = "Nhập niên khóa";
            this.txtnienkhoa.SelectedText = "";
            this.txtnienkhoa.Size = new System.Drawing.Size(198, 40);
            this.txtnienkhoa.TabIndex = 23;
            // 
            // txttenlop
            // 
            this.txttenlop.BorderRadius = 5;
            this.txttenlop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenlop.DefaultText = "";
            this.txttenlop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenlop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenlop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenlop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenlop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenlop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttenlop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenlop.Location = new System.Drawing.Point(317, 69);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.PasswordChar = '\0';
            this.txttenlop.PlaceholderText = "Nhập tên lớp";
            this.txttenlop.SelectedText = "";
            this.txttenlop.Size = new System.Drawing.Size(200, 40);
            this.txttenlop.TabIndex = 21;
            // 
            // txtmalop
            // 
            this.txtmalop.BorderRadius = 5;
            this.txtmalop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmalop.DefaultText = "";
            this.txtmalop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmalop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmalop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmalop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmalop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmalop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmalop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmalop.Location = new System.Drawing.Point(317, 23);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.PasswordChar = '\0';
            this.txtmalop.PlaceholderText = "Nhập mã lớp";
            this.txtmalop.SelectedText = "";
            this.txtmalop.Size = new System.Drawing.Size(200, 40);
            this.txtmalop.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(243, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Niên khóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(257, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên lớp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_lop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 526);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView_lop
            // 
            this.dataGridView_lop.AllowUserToAddRows = false;
            this.dataGridView_lop.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_lop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_lop.AutoGenerateColumns = false;
            this.dataGridView_lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_lop.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_lop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_lop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_lop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_lop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_lop.ColumnHeadersHeight = 22;
            this.dataGridView_lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malopDataGridViewTextBoxColumn,
            this.tenlopDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dataGridView_lop.DataSource = this.lopBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_lop.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_lop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_lop.EnableHeadersVisualStyles = false;
            this.dataGridView_lop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_lop.Location = new System.Drawing.Point(0, -64);
            this.dataGridView_lop.Name = "dataGridView_lop";
            this.dataGridView_lop.RowHeadersVisible = false;
            this.dataGridView_lop.RowTemplate.Height = 40;
            this.dataGridView_lop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_lop.Size = new System.Drawing.Size(962, 590);
            this.dataGridView_lop.TabIndex = 0;
            this.dataGridView_lop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_lop.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_lop.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_lop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_lop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_lop.ThemeStyle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_lop.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_lop.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_lop.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_lop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_lop.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_lop.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_lop.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridView_lop.ThemeStyle.ReadOnly = false;
            this.dataGridView_lop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_lop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_lop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_lop.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_lop.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridView_lop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_lop.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lop_CellClick);
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "Malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            // 
            // tenlopDataGridViewTextBoxColumn
            // 
            this.tenlopDataGridViewTextBoxColumn.DataPropertyName = "Tenlop";
            this.tenlopDataGridViewTextBoxColumn.HeaderText = "Tên lớp";
            this.tenlopDataGridViewTextBoxColumn.Name = "tenlopDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Niên khóa";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLSinhVienDataSet;
            // 
            // qLSinhVienDataSet
            // 
            this.qLSinhVienDataSet.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 10);
            this.panel1.TabIndex = 1;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormLop";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnxoa;
        private Guna.UI2.WinForms.Guna2Button btnsua;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2TextBox txtnienkhoa;
        private Guna.UI2.WinForms.Guna2TextBox txttenlop;
        private Guna.UI2.WinForms.Guna2TextBox txtmalop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private System.Windows.Forms.Panel panel1;
    }
}