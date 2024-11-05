namespace AdministratorWydarzen.Views
{
    partial class Form1
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
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LowPrioBox = new System.Windows.Forms.RadioButton();
            this.MidPrioBox = new System.Windows.Forms.RadioButton();
            this.HighPrioBox = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tytuł = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Wystapienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priorytet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SortBtn = new System.Windows.Forms.Button();
            this.FiltrBtn = new System.Windows.Forms.Button();
            this.SortByDateBox = new System.Windows.Forms.RadioButton();
            this.SortByPrioBox = new System.Windows.Forms.RadioButton();
            this.SortByTypeBox = new System.Windows.Forms.RadioButton();
            this.FiltrByPriorityBox = new System.Windows.Forms.RadioButton();
            this.FiltrByTypeBox = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TitleBox.Location = new System.Drawing.Point(141, 30);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(248, 24);
            this.TitleBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DescriptionBox.Location = new System.Drawing.Point(141, 82);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(248, 89);
            this.DescriptionBox.TabIndex = 3;
            this.DescriptionBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data wystąpienia";
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DateBox.Location = new System.Drawing.Point(141, 192);
            this.DateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(248, 24);
            this.DateBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(14, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Typ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(14, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Priorytet";
            // 
            // LowPrioBox
            // 
            this.LowPrioBox.AutoSize = true;
            this.LowPrioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LowPrioBox.Location = new System.Drawing.Point(141, 332);
            this.LowPrioBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LowPrioBox.Name = "LowPrioBox";
            this.LowPrioBox.Size = new System.Drawing.Size(59, 22);
            this.LowPrioBox.TabIndex = 9;
            this.LowPrioBox.TabStop = true;
            this.LowPrioBox.Text = "niski";
            this.LowPrioBox.UseVisualStyleBackColor = true;
            // 
            // MidPrioBox
            // 
            this.MidPrioBox.AutoSize = true;
            this.MidPrioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MidPrioBox.Location = new System.Drawing.Point(141, 356);
            this.MidPrioBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MidPrioBox.Name = "MidPrioBox";
            this.MidPrioBox.Size = new System.Drawing.Size(69, 22);
            this.MidPrioBox.TabIndex = 10;
            this.MidPrioBox.TabStop = true;
            this.MidPrioBox.Text = "sredni";
            this.MidPrioBox.UseVisualStyleBackColor = true;
            // 
            // HighPrioBox
            // 
            this.HighPrioBox.AutoSize = true;
            this.HighPrioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.HighPrioBox.Location = new System.Drawing.Point(141, 380);
            this.HighPrioBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HighPrioBox.Name = "HighPrioBox";
            this.HighPrioBox.Size = new System.Drawing.Size(75, 22);
            this.HighPrioBox.TabIndex = 11;
            this.HighPrioBox.TabStop = true;
            this.HighPrioBox.Text = "wysoki";
            this.HighPrioBox.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tytuł,
            this.Data_Wystapienia,
            this.Typ,
            this.Priorytet,
            this.Opis});
            this.dataGridView1.Location = new System.Drawing.Point(445, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(893, 326);
            this.dataGridView1.TabIndex = 12;
            // 
            // Tytuł
            // 
            this.Tytuł.HeaderText = "Tytuł";
            this.Tytuł.MinimumWidth = 8;
            this.Tytuł.Name = "Tytuł";
            this.Tytuł.ReadOnly = true;
            this.Tytuł.Width = 110;
            // 
            // Data_Wystapienia
            // 
            this.Data_Wystapienia.HeaderText = "Data wystąpienia";
            this.Data_Wystapienia.MinimumWidth = 8;
            this.Data_Wystapienia.Name = "Data_Wystapienia";
            this.Data_Wystapienia.ReadOnly = true;
            this.Data_Wystapienia.Width = 125;
            // 
            // Typ
            // 
            this.Typ.HeaderText = "Typ";
            this.Typ.MinimumWidth = 8;
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            this.Typ.Width = 75;
            // 
            // Priorytet
            // 
            this.Priorytet.HeaderText = "Priorytet";
            this.Priorytet.MinimumWidth = 8;
            this.Priorytet.Name = "Priorytet";
            this.Priorytet.ReadOnly = true;
            this.Priorytet.Width = 75;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 8;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 245;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(17, 420);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(185, 45);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Dodaj";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(208, 420);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(181, 45);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Location = new System.Drawing.Point(445, 444);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(185, 48);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LoadBtn.Location = new System.Drawing.Point(445, 378);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(185, 48);
            this.LoadBtn.TabIndex = 16;
            this.LoadBtn.Text = "Wczytaj";
            this.LoadBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SortBtn
            // 
            this.SortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortBtn.Location = new System.Drawing.Point(716, 378);
            this.SortBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(111, 38);
            this.SortBtn.TabIndex = 17;
            this.SortBtn.Text = "Sortuj";
            this.SortBtn.UseVisualStyleBackColor = true;
            // 
            // FiltrBtn
            // 
            this.FiltrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FiltrBtn.Location = new System.Drawing.Point(915, 378);
            this.FiltrBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltrBtn.Name = "FiltrBtn";
            this.FiltrBtn.Size = new System.Drawing.Size(102, 38);
            this.FiltrBtn.TabIndex = 18;
            this.FiltrBtn.Text = "Filtruj";
            this.FiltrBtn.UseVisualStyleBackColor = true;
            // 
            // SortByDateBox
            // 
            this.SortByDateBox.AutoSize = true;
            this.SortByDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SortByDateBox.Location = new System.Drawing.Point(716, 468);
            this.SortByDateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortByDateBox.Name = "SortByDateBox";
            this.SortByDateBox.Size = new System.Drawing.Size(87, 22);
            this.SortByDateBox.TabIndex = 21;
            this.SortByDateBox.TabStop = true;
            this.SortByDateBox.Text = "Po dacie";
            this.SortByDateBox.UseVisualStyleBackColor = true;
            // 
            // SortByPrioBox
            // 
            this.SortByPrioBox.AutoSize = true;
            this.SortByPrioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SortByPrioBox.Location = new System.Drawing.Point(716, 444);
            this.SortByPrioBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortByPrioBox.Name = "SortByPrioBox";
            this.SortByPrioBox.Size = new System.Drawing.Size(120, 22);
            this.SortByPrioBox.TabIndex = 20;
            this.SortByPrioBox.TabStop = true;
            this.SortByPrioBox.Text = "Po priorytecie";
            this.SortByPrioBox.UseVisualStyleBackColor = true;
            // 
            // SortByTypeBox
            // 
            this.SortByTypeBox.AutoSize = true;
            this.SortByTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SortByTypeBox.Location = new System.Drawing.Point(716, 420);
            this.SortByTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortByTypeBox.Name = "SortByTypeBox";
            this.SortByTypeBox.Size = new System.Drawing.Size(82, 22);
            this.SortByTypeBox.TabIndex = 19;
            this.SortByTypeBox.TabStop = true;
            this.SortByTypeBox.Text = "Po typie";
            this.SortByTypeBox.UseVisualStyleBackColor = true;
            // 
            // FiltrByPriorityBox
            // 
            this.FiltrByPriorityBox.AutoSize = true;
            this.FiltrByPriorityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FiltrByPriorityBox.Location = new System.Drawing.Point(915, 457);
            this.FiltrByPriorityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltrByPriorityBox.Name = "FiltrByPriorityBox";
            this.FiltrByPriorityBox.Size = new System.Drawing.Size(120, 22);
            this.FiltrByPriorityBox.TabIndex = 23;
            this.FiltrByPriorityBox.TabStop = true;
            this.FiltrByPriorityBox.Text = "Po priorytecie";
            this.FiltrByPriorityBox.UseVisualStyleBackColor = true;
            // 
            // FiltrByTypeBox
            // 
            this.FiltrByTypeBox.AutoSize = true;
            this.FiltrByTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FiltrByTypeBox.Location = new System.Drawing.Point(915, 420);
            this.FiltrByTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltrByTypeBox.Name = "FiltrByTypeBox";
            this.FiltrByTypeBox.Size = new System.Drawing.Size(82, 22);
            this.FiltrByTypeBox.TabIndex = 22;
            this.FiltrByTypeBox.TabStop = true;
            this.FiltrByTypeBox.Text = "Po typie";
            this.FiltrByTypeBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rodzina",
            "Sport",
            "Rozrywka",
            "Praca"});
            this.comboBox1.Location = new System.Drawing.Point(141, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 26);
            this.comboBox1.TabIndex = 25;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GroupBox1.Controls.Add(this.comboBox1);
            this.GroupBox1.Controls.Add(this.DeleteBtn);
            this.GroupBox1.Controls.Add(this.AddBtn);
            this.GroupBox1.Controls.Add(this.HighPrioBox);
            this.GroupBox1.Controls.Add(this.MidPrioBox);
            this.GroupBox1.Controls.Add(this.LowPrioBox);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.DateBox);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.DescriptionBox);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.TitleBox);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(20, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(413, 482);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Nowe wydarzenie";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "niski",
            "sredni",
            "wysoki"});
            this.comboBox2.Location = new System.Drawing.Point(1036, 453);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 28;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Rodzina",
            "Sport",
            "Rozrywka",
            "Praca"});
            this.comboBox3.Location = new System.Drawing.Point(1036, 421);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1545, 574);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.FiltrByPriorityBox);
            this.Controls.Add(this.FiltrByTypeBox);
            this.Controls.Add(this.SortByDateBox);
            this.Controls.Add(this.SortByPrioBox);
            this.Controls.Add(this.SortByTypeBox);
            this.Controls.Add(this.FiltrBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton LowPrioBox;
        private System.Windows.Forms.RadioButton MidPrioBox;
        private System.Windows.Forms.RadioButton HighPrioBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton FiltrByPriorityBox;
        private System.Windows.Forms.RadioButton FiltrByTypeBox;
        private System.Windows.Forms.RadioButton SortByDateBox;
        private System.Windows.Forms.RadioButton SortByPrioBox;
        private System.Windows.Forms.RadioButton SortByTypeBox;
        private System.Windows.Forms.Button FiltrBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tytuł;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Wystapienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priorytet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}