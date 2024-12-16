namespace Muzeim
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpenAddExhibitForm = new System.Windows.Forms.Button();
            this.btnOpenAddExhibitionForm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exhibitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muzeimDataSet = new Muzeim.MuzeimDataSet();
            this.exhibitionsTableAdapter = new Muzeim.MuzeimDataSetTableAdapters.ExhibitionsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.exhibitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibitionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exhibitsTableAdapter = new Muzeim.MuzeimDataSetTableAdapters.ExhibitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzeimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenAddExhibitForm
            // 
            this.btnOpenAddExhibitForm.Location = new System.Drawing.Point(1054, 59);
            this.btnOpenAddExhibitForm.Name = "btnOpenAddExhibitForm";
            this.btnOpenAddExhibitForm.Size = new System.Drawing.Size(83, 42);
            this.btnOpenAddExhibitForm.TabIndex = 0;
            this.btnOpenAddExhibitForm.Text = "Добавить экспонавт";
            this.btnOpenAddExhibitForm.UseVisualStyleBackColor = true;
            this.btnOpenAddExhibitForm.Click += new System.EventHandler(this.btnOpenAddExhibitForm_Click);
            // 
            // btnOpenAddExhibitionForm
            // 
            this.btnOpenAddExhibitionForm.Location = new System.Drawing.Point(1054, 11);
            this.btnOpenAddExhibitionForm.Name = "btnOpenAddExhibitionForm";
            this.btnOpenAddExhibitionForm.Size = new System.Drawing.Size(84, 42);
            this.btnOpenAddExhibitionForm.TabIndex = 1;
            this.btnOpenAddExhibitionForm.Text = "Создать выставку";
            this.btnOpenAddExhibitionForm.UseVisualStyleBackColor = true;
            this.btnOpenAddExhibitionForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exhibitionIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exhibitionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // exhibitionIDDataGridViewTextBoxColumn
            // 
            this.exhibitionIDDataGridViewTextBoxColumn.DataPropertyName = "ExhibitionID";
            this.exhibitionIDDataGridViewTextBoxColumn.HeaderText = "ExhibitionID";
            this.exhibitionIDDataGridViewTextBoxColumn.Name = "exhibitionIDDataGridViewTextBoxColumn";
            this.exhibitionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.exhibitionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // exhibitionsBindingSource
            // 
            this.exhibitionsBindingSource.DataMember = "Exhibitions";
            this.exhibitionsBindingSource.DataSource = this.muzeimDataSet;
            // 
            // muzeimDataSet
            // 
            this.muzeimDataSet.DataSetName = "MuzeimDataSet";
            this.muzeimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exhibitionsTableAdapter
            // 
            this.exhibitionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exhibitIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.exhibitionIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.exhibitsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(504, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 426);
            this.dataGridView2.TabIndex = 3;
            // 
            // exhibitIDDataGridViewTextBoxColumn
            // 
            this.exhibitIDDataGridViewTextBoxColumn.DataPropertyName = "ExhibitID";
            this.exhibitIDDataGridViewTextBoxColumn.HeaderText = "ExhibitID";
            this.exhibitIDDataGridViewTextBoxColumn.Name = "exhibitIDDataGridViewTextBoxColumn";
            this.exhibitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.exhibitIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // exhibitionIDDataGridViewTextBoxColumn1
            // 
            this.exhibitionIDDataGridViewTextBoxColumn1.DataPropertyName = "ExhibitionID";
            this.exhibitionIDDataGridViewTextBoxColumn1.HeaderText = "ExhibitionID";
            this.exhibitionIDDataGridViewTextBoxColumn1.Name = "exhibitionIDDataGridViewTextBoxColumn1";
            // 
            // exhibitsBindingSource
            // 
            this.exhibitsBindingSource.DataMember = "Exhibits";
            this.exhibitsBindingSource.DataSource = this.muzeimDataSet;
            // 
            // exhibitsTableAdapter
            // 
            this.exhibitsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 460);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOpenAddExhibitionForm);
            this.Controls.Add(this.btnOpenAddExhibitForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzeimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAddExhibitForm;
        private System.Windows.Forms.Button btnOpenAddExhibitionForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MuzeimDataSet muzeimDataSet;
        private System.Windows.Forms.BindingSource exhibitionsBindingSource;
        private MuzeimDataSetTableAdapters.ExhibitionsTableAdapter exhibitionsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource exhibitsBindingSource;
        private MuzeimDataSetTableAdapters.ExhibitsTableAdapter exhibitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn exhibitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exhibitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exhibitionIDDataGridViewTextBoxColumn1;
    }
}

