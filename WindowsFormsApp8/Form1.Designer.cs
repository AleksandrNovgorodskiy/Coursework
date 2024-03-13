namespace WindowsFormsApp8
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
            this.iDМатчуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяТаПрізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.голиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.асистиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жовтіКарткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.червоніКарткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаТрансферуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гравціBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseworkDataSet = new WindowsFormsApp8.CourseworkDataSet();
            this.гравціTableAdapter = new WindowsFormsApp8.CourseworkDataSetTableAdapters.ГравціTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гравціBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМатчуDataGridViewTextBoxColumn,
            this.імяТаПрізвищеDataGridViewTextBoxColumn,
            this.голиDataGridViewTextBoxColumn,
            this.асистиDataGridViewTextBoxColumn,
            this.жовтіКарткиDataGridViewTextBoxColumn,
            this.червоніКарткиDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn,
            this.цінаТрансферуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.гравціBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1429, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDМатчуDataGridViewTextBoxColumn
            // 
            this.iDМатчуDataGridViewTextBoxColumn.DataPropertyName = "ID матчу";
            this.iDМатчуDataGridViewTextBoxColumn.HeaderText = "ID матчу";
            this.iDМатчуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDМатчуDataGridViewTextBoxColumn.Name = "iDМатчуDataGridViewTextBoxColumn";
            this.iDМатчуDataGridViewTextBoxColumn.Width = 125;
            // 
            // імяТаПрізвищеDataGridViewTextBoxColumn
            // 
            this.імяТаПрізвищеDataGridViewTextBoxColumn.DataPropertyName = "Ім\'я та прізвище";
            this.імяТаПрізвищеDataGridViewTextBoxColumn.HeaderText = "Ім\'я та прізвище";
            this.імяТаПрізвищеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.імяТаПрізвищеDataGridViewTextBoxColumn.Name = "імяТаПрізвищеDataGridViewTextBoxColumn";
            this.імяТаПрізвищеDataGridViewTextBoxColumn.Width = 125;
            // 
            // голиDataGridViewTextBoxColumn
            // 
            this.голиDataGridViewTextBoxColumn.DataPropertyName = "Голи";
            this.голиDataGridViewTextBoxColumn.HeaderText = "Голи";
            this.голиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.голиDataGridViewTextBoxColumn.Name = "голиDataGridViewTextBoxColumn";
            this.голиDataGridViewTextBoxColumn.Width = 125;
            // 
            // асистиDataGridViewTextBoxColumn
            // 
            this.асистиDataGridViewTextBoxColumn.DataPropertyName = "Асисти";
            this.асистиDataGridViewTextBoxColumn.HeaderText = "Асисти";
            this.асистиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.асистиDataGridViewTextBoxColumn.Name = "асистиDataGridViewTextBoxColumn";
            this.асистиDataGridViewTextBoxColumn.Width = 125;
            // 
            // жовтіКарткиDataGridViewTextBoxColumn
            // 
            this.жовтіКарткиDataGridViewTextBoxColumn.DataPropertyName = "Жовті картки";
            this.жовтіКарткиDataGridViewTextBoxColumn.HeaderText = "Жовті картки";
            this.жовтіКарткиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.жовтіКарткиDataGridViewTextBoxColumn.Name = "жовтіКарткиDataGridViewTextBoxColumn";
            this.жовтіКарткиDataGridViewTextBoxColumn.Width = 125;
            // 
            // червоніКарткиDataGridViewTextBoxColumn
            // 
            this.червоніКарткиDataGridViewTextBoxColumn.DataPropertyName = "Червоні картки";
            this.червоніКарткиDataGridViewTextBoxColumn.HeaderText = "Червоні картки";
            this.червоніКарткиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.червоніКарткиDataGridViewTextBoxColumn.Name = "червоніКарткиDataGridViewTextBoxColumn";
            this.червоніКарткиDataGridViewTextBoxColumn.Width = 125;
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата($)";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата($)";
            this.зарплатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            this.зарплатаDataGridViewTextBoxColumn.Width = 125;
            // 
            // цінаТрансферуDataGridViewTextBoxColumn
            // 
            this.цінаТрансферуDataGridViewTextBoxColumn.DataPropertyName = "Ціна трансферу(€)";
            this.цінаТрансферуDataGridViewTextBoxColumn.HeaderText = "Ціна трансферу(€)";
            this.цінаТрансферуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.цінаТрансферуDataGridViewTextBoxColumn.Name = "цінаТрансферуDataGridViewTextBoxColumn";
            this.цінаТрансферуDataGridViewTextBoxColumn.Width = 125;
            // 
            // гравціBindingSource
            // 
            this.гравціBindingSource.DataMember = "Гравці";
            this.гравціBindingSource.DataSource = this.courseworkDataSet;
            // 
            // courseworkDataSet
            // 
            this.courseworkDataSet.DataSetName = "CourseworkDataSet";
            this.courseworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // гравціTableAdapter
            // 
            this.гравціTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(52, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сортування за гравцями";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сортування за зарплатами";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сортування за голами";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(791, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Оновлення даних";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.LOGO_FCMK1925;
            this.pictureBox1.Location = new System.Drawing.Point(470, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1494, 729);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Металіст - 1925";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гравціBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseworkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CourseworkDataSet courseworkDataSet;
        private System.Windows.Forms.BindingSource гравціBindingSource;
        private CourseworkDataSetTableAdapters.ГравціTableAdapter гравціTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМатчуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяТаПрізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn голиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn асистиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жовтіКарткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn червоніКарткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаТрансферуDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

