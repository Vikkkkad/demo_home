namespace demo
{
    partial class FormM
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
            this.btnExtendDeadline = new System.Windows.Forms.Button();
            this.btnAssignSpecialist = new System.Windows.Forms.Button();
            this.dateTimePickerNewDeadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSpecialists = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRequestId = new System.Windows.Forms.TextBox();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtendDeadline
            // 
            this.btnExtendDeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(103)))), ((int)(((byte)(80)))));
            this.btnExtendDeadline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtendDeadline.Location = new System.Drawing.Point(453, 457);
            this.btnExtendDeadline.Name = "btnExtendDeadline";
            this.btnExtendDeadline.Size = new System.Drawing.Size(142, 63);
            this.btnExtendDeadline.TabIndex = 15;
            this.btnExtendDeadline.Text = "Продлить срок";
            this.btnExtendDeadline.UseVisualStyleBackColor = false;
            this.btnExtendDeadline.Click += new System.EventHandler(this.btnExtendDeadline_Click);
            // 
            // btnAssignSpecialist
            // 
            this.btnAssignSpecialist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(103)))), ((int)(((byte)(80)))));
            this.btnAssignSpecialist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignSpecialist.Location = new System.Drawing.Point(188, 457);
            this.btnAssignSpecialist.Name = "btnAssignSpecialist";
            this.btnAssignSpecialist.Size = new System.Drawing.Size(148, 63);
            this.btnAssignSpecialist.TabIndex = 14;
            this.btnAssignSpecialist.Text = "Назначить специалиста";
            this.btnAssignSpecialist.UseVisualStyleBackColor = false;
            this.btnAssignSpecialist.Click += new System.EventHandler(this.btnAssignSpecialist_Click);
            // 
            // dateTimePickerNewDeadline
            // 
            this.dateTimePickerNewDeadline.Location = new System.Drawing.Point(433, 407);
            this.dateTimePickerNewDeadline.Name = "dateTimePickerNewDeadline";
            this.dateTimePickerNewDeadline.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNewDeadline.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выбор специалиста";
            // 
            // comboBoxSpecialists
            // 
            this.comboBoxSpecialists.FormattingEnabled = true;
            this.comboBoxSpecialists.Location = new System.Drawing.Point(202, 409);
            this.comboBoxSpecialists.Name = "comboBoxSpecialists";
            this.comboBoxSpecialists.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSpecialists.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер заявки";
            // 
            // textBoxRequestId
            // 
            this.textBoxRequestId.Location = new System.Drawing.Point(44, 409);
            this.textBoxRequestId.Name = "textBoxRequestId";
            this.textBoxRequestId.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestId.TabIndex = 9;
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Location = new System.Drawing.Point(12, 11);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.RowHeadersWidth = 51;
            this.dataGridViewRequests.RowTemplate.Height = 24;
            this.dataGridViewRequests.Size = new System.Drawing.Size(1118, 356);
            this.dataGridViewRequests.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(103)))), ((int)(((byte)(80)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(960, 403);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 170);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1150, 602);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExtendDeadline);
            this.Controls.Add(this.btnAssignSpecialist);
            this.Controls.Add(this.dateTimePickerNewDeadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSpecialists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRequestId);
            this.Controls.Add(this.dataGridViewRequests);
            this.Name = "FormM";
            this.Text = "FormM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtendDeadline;
        private System.Windows.Forms.Button btnAssignSpecialist;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDeadline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSpecialists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRequestId;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Button btnRefresh;
    }
}