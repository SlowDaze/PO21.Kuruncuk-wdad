﻿namespace WindowsFormsApp10
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.телефонный_справочникDataSet = new WindowsFormsApp10.Телефонный_справочникDataSet();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаTableAdapter = new WindowsFormsApp10.Телефонный_справочникDataSetTableAdapters.ГруппаTableAdapter();
            this.idгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиегруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.телефонный_справочникDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idгруппыDataGridViewTextBoxColumn,
            this.названиегруппыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(243, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // телефонный_справочникDataSet
            // 
            this.телефонный_справочникDataSet.DataSetName = "Телефонный_справочникDataSet";
            this.телефонный_справочникDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.телефонный_справочникDataSet;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // idгруппыDataGridViewTextBoxColumn
            // 
            this.idгруппыDataGridViewTextBoxColumn.DataPropertyName = "id_группы";
            this.idгруппыDataGridViewTextBoxColumn.HeaderText = "id_группы";
            this.idгруппыDataGridViewTextBoxColumn.Name = "idгруппыDataGridViewTextBoxColumn";
            // 
            // названиегруппыDataGridViewTextBoxColumn
            // 
            this.названиегруппыDataGridViewTextBoxColumn.DataPropertyName = "Название_группы";
            this.названиегруппыDataGridViewTextBoxColumn.HeaderText = "Название_группы";
            this.названиегруппыDataGridViewTextBoxColumn.Name = "названиегруппыDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Группа";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.телефонный_справочникDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Телефонный_справочникDataSet телефонный_справочникDataSet;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private Телефонный_справочникDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиегруппыDataGridViewTextBoxColumn;
    }
}