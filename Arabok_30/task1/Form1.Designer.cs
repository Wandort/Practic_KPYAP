namespace task1
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.туристыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.кодТуристаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.databaseTuristDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.databaseTuristDataSet = new task1.DatabaseTuristDataSet();
			this.туристыTableAdapter = new task1.DatabaseTuristDataSetTableAdapters.ТуристыTableAdapter();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.турыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.турыTableAdapter = new task1.DatabaseTuristDataSetTableAdapters.ТурыTableAdapter();
			this.кодТураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.информацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTourIdToDelete = new System.Windows.Forms.TextBox();
			this.btnDeleteTour = new System.Windows.Forms.Button();
			this.txtAddSurname = new System.Windows.Forms.TextBox();
			this.btnAddTourist = new System.Windows.Forms.Button();
			this.txtAddFirstName = new System.Windows.Forms.TextBox();
			this.txtAddPatronymic = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUpdateTouristId = new System.Windows.Forms.TextBox();
			this.txtUpdateSurname = new System.Windows.Forms.TextBox();
			this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
			this.txtUpdatePatronymic = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnUpdateTourist = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.туристыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseTuristDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseTuristDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТуристаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.туристыBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(749, 147);
			this.dataGridView1.TabIndex = 0;
			// 
			// туристыBindingSource
			// 
			this.туристыBindingSource.DataMember = "Туристы";
			this.туристыBindingSource.DataSource = this.databaseTuristDataSetBindingSource;
			// 
			// кодТуристаDataGridViewTextBoxColumn
			// 
			this.кодТуристаDataGridViewTextBoxColumn.DataPropertyName = "Код туриста";
			this.кодТуристаDataGridViewTextBoxColumn.HeaderText = "Код туриста";
			this.кодТуристаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодТуристаDataGridViewTextBoxColumn.Name = "кодТуристаDataGridViewTextBoxColumn";
			this.кодТуристаDataGridViewTextBoxColumn.Width = 125;
			// 
			// фамилияDataGridViewTextBoxColumn
			// 
			this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
			this.фамилияDataGridViewTextBoxColumn.Width = 125;
			// 
			// имяDataGridViewTextBoxColumn
			// 
			this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
			this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
			this.имяDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчествоDataGridViewTextBoxColumn
			// 
			this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
			this.отчествоDataGridViewTextBoxColumn.Width = 125;
			// 
			// databaseTuristDataSetBindingSource
			// 
			this.databaseTuristDataSetBindingSource.DataSource = this.databaseTuristDataSet;
			this.databaseTuristDataSetBindingSource.Position = 0;
			// 
			// databaseTuristDataSet
			// 
			this.databaseTuristDataSet.DataSetName = "DatabaseTuristDataSet";
			this.databaseTuristDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// туристыTableAdapter
			// 
			this.туристыTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТураDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.информацияDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.турыBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(12, 165);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(749, 150);
			this.dataGridView2.TabIndex = 1;
			// 
			// турыBindingSource
			// 
			this.турыBindingSource.DataMember = "Туры";
			this.турыBindingSource.DataSource = this.databaseTuristDataSetBindingSource;
			// 
			// турыTableAdapter
			// 
			this.турыTableAdapter.ClearBeforeFill = true;
			// 
			// кодТураDataGridViewTextBoxColumn
			// 
			this.кодТураDataGridViewTextBoxColumn.DataPropertyName = "Код тура";
			this.кодТураDataGridViewTextBoxColumn.HeaderText = "Код тура";
			this.кодТураDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодТураDataGridViewTextBoxColumn.Name = "кодТураDataGridViewTextBoxColumn";
			this.кодТураDataGridViewTextBoxColumn.Width = 125;
			// 
			// названиеDataGridViewTextBoxColumn
			// 
			this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
			this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
			this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
			this.названиеDataGridViewTextBoxColumn.Width = 125;
			// 
			// ценаDataGridViewTextBoxColumn
			// 
			this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
			this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
			this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
			this.ценаDataGridViewTextBoxColumn.Width = 125;
			// 
			// информацияDataGridViewTextBoxColumn
			// 
			this.информацияDataGridViewTextBoxColumn.DataPropertyName = "Информация";
			this.информацияDataGridViewTextBoxColumn.HeaderText = "Информация";
			this.информацияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.информацияDataGridViewTextBoxColumn.Name = "информацияDataGridViewTextBoxColumn";
			this.информацияDataGridViewTextBoxColumn.Width = 125;
			// 
			// txtTourIdToDelete
			// 
			this.txtTourIdToDelete.Location = new System.Drawing.Point(767, 18);
			this.txtTourIdToDelete.Name = "txtTourIdToDelete";
			this.txtTourIdToDelete.Size = new System.Drawing.Size(154, 22);
			this.txtTourIdToDelete.TabIndex = 2;
			// 
			// btnDeleteTour
			// 
			this.btnDeleteTour.Location = new System.Drawing.Point(767, 42);
			this.btnDeleteTour.Name = "btnDeleteTour";
			this.btnDeleteTour.Size = new System.Drawing.Size(154, 31);
			this.btnDeleteTour.TabIndex = 3;
			this.btnDeleteTour.Text = "Удалить тур по ID";
			this.btnDeleteTour.UseVisualStyleBackColor = true;
			this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
			// 
			// txtAddSurname
			// 
			this.txtAddSurname.Location = new System.Drawing.Point(767, 91);
			this.txtAddSurname.Name = "txtAddSurname";
			this.txtAddSurname.Size = new System.Drawing.Size(154, 22);
			this.txtAddSurname.TabIndex = 4;
			// 
			// btnAddTourist
			// 
			this.btnAddTourist.Location = new System.Drawing.Point(767, 219);
			this.btnAddTourist.Name = "btnAddTourist";
			this.btnAddTourist.Size = new System.Drawing.Size(154, 28);
			this.btnAddTourist.TabIndex = 5;
			this.btnAddTourist.Text = "Добавить туриста";
			this.btnAddTourist.UseVisualStyleBackColor = true;
			this.btnAddTourist.Click += new System.EventHandler(this.btnAddTourist_Click);
			// 
			// txtAddFirstName
			// 
			this.txtAddFirstName.Location = new System.Drawing.Point(767, 137);
			this.txtAddFirstName.Name = "txtAddFirstName";
			this.txtAddFirstName.Size = new System.Drawing.Size(154, 22);
			this.txtAddFirstName.TabIndex = 6;
			// 
			// txtAddPatronymic
			// 
			this.txtAddPatronymic.Location = new System.Drawing.Point(767, 185);
			this.txtAddPatronymic.Name = "txtAddPatronymic";
			this.txtAddPatronymic.Size = new System.Drawing.Size(154, 22);
			this.txtAddPatronymic.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(768, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(771, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(771, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Отчество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(767, -1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "ID тура";
			// 
			// txtUpdateTouristId
			// 
			this.txtUpdateTouristId.Location = new System.Drawing.Point(13, 366);
			this.txtUpdateTouristId.Name = "txtUpdateTouristId";
			this.txtUpdateTouristId.Size = new System.Drawing.Size(100, 22);
			this.txtUpdateTouristId.TabIndex = 12;
			// 
			// txtUpdateSurname
			// 
			this.txtUpdateSurname.Location = new System.Drawing.Point(163, 366);
			this.txtUpdateSurname.Name = "txtUpdateSurname";
			this.txtUpdateSurname.Size = new System.Drawing.Size(100, 22);
			this.txtUpdateSurname.TabIndex = 13;
			// 
			// txtUpdateFirstName
			// 
			this.txtUpdateFirstName.Location = new System.Drawing.Point(307, 366);
			this.txtUpdateFirstName.Name = "txtUpdateFirstName";
			this.txtUpdateFirstName.Size = new System.Drawing.Size(100, 22);
			this.txtUpdateFirstName.TabIndex = 14;
			// 
			// txtUpdatePatronymic
			// 
			this.txtUpdatePatronymic.Location = new System.Drawing.Point(448, 366);
			this.txtUpdatePatronymic.Name = "txtUpdatePatronymic";
			this.txtUpdatePatronymic.Size = new System.Drawing.Size(100, 22);
			this.txtUpdatePatronymic.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 321);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 32);
			this.label5.TabIndex = 16;
			this.label5.Text = "ID туриста, которого\r\nнужно изменить";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(160, 321);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 16);
			this.label6.TabIndex = 17;
			this.label6.Text = "Новая фамилия";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(304, 321);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 16);
			this.label7.TabIndex = 18;
			this.label7.Text = "Новое имя";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(445, 321);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(113, 16);
			this.label8.TabIndex = 19;
			this.label8.Text = "Новое отчество";
			// 
			// btnUpdateTourist
			// 
			this.btnUpdateTourist.Location = new System.Drawing.Point(576, 330);
			this.btnUpdateTourist.Name = "btnUpdateTourist";
			this.btnUpdateTourist.Size = new System.Drawing.Size(94, 58);
			this.btnUpdateTourist.TabIndex = 20;
			this.btnUpdateTourist.Text = "Изменить \r\nтуриста";
			this.btnUpdateTourist.UseVisualStyleBackColor = true;
			this.btnUpdateTourist.Click += new System.EventHandler(this.btnUpdateTourist_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 450);
			this.Controls.Add(this.btnUpdateTourist);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtUpdatePatronymic);
			this.Controls.Add(this.txtUpdateFirstName);
			this.Controls.Add(this.txtUpdateSurname);
			this.Controls.Add(this.txtUpdateTouristId);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAddPatronymic);
			this.Controls.Add(this.txtAddFirstName);
			this.Controls.Add(this.btnAddTourist);
			this.Controls.Add(this.txtAddSurname);
			this.Controls.Add(this.btnDeleteTour);
			this.Controls.Add(this.txtTourIdToDelete);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.туристыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseTuristDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseTuristDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource databaseTuristDataSetBindingSource;
		private DatabaseTuristDataSet databaseTuristDataSet;
		private System.Windows.Forms.BindingSource туристыBindingSource;
		private DatabaseTuristDataSetTableAdapters.ТуристыTableAdapter туристыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодТуристаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource турыBindingSource;
		private DatabaseTuristDataSetTableAdapters.ТурыTableAdapter турыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодТураDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn информацияDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox txtTourIdToDelete;
		private System.Windows.Forms.Button btnDeleteTour;
		private System.Windows.Forms.TextBox txtAddSurname;
		private System.Windows.Forms.Button btnAddTourist;
		private System.Windows.Forms.TextBox txtAddFirstName;
		private System.Windows.Forms.TextBox txtAddPatronymic;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUpdateTouristId;
		private System.Windows.Forms.TextBox txtUpdateSurname;
		private System.Windows.Forms.TextBox txtUpdateFirstName;
		private System.Windows.Forms.TextBox txtUpdatePatronymic;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnUpdateTourist;
	}
}

