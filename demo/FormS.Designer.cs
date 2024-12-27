namespace demo
{
    partial class FormS
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
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPartsNeeded = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOrderParts = new System.Windows.Forms.Button();
            this.buttonGenerateQRCode = new System.Windows.Forms.Button();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.textBoxRequestId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(191)))), ((int)(((byte)(185)))));
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Location = new System.Drawing.Point(46, 39);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.RowHeadersWidth = 51;
            this.dataGridViewRequests.RowTemplate.Height = 24;
            this.dataGridViewRequests.Size = new System.Drawing.Size(724, 217);
            this.dataGridViewRequests.TabIndex = 0;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(203, 305);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(103)))), ((int)(((byte)(80)))));
            this.buttonUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateStatus.Location = new System.Drawing.Point(188, 341);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(146, 49);
            this.buttonUpdateStatus.TabIndex = 2;
            this.buttonUpdateStatus.Text = "Обновить статус";
            this.buttonUpdateStatus.UseVisualStyleBackColor = false;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.buttonUpdateStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Статус";
            // 
            // textBoxPartsNeeded
            // 
            this.textBoxPartsNeeded.Location = new System.Drawing.Point(218, 476);
            this.textBoxPartsNeeded.Name = "textBoxPartsNeeded";
            this.textBoxPartsNeeded.Size = new System.Drawing.Size(191, 22);
            this.textBoxPartsNeeded.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Запчасти";
            // 
            // buttonOrderParts
            // 
            this.buttonOrderParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(103)))), ((int)(((byte)(80)))));
            this.buttonOrderParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderParts.Location = new System.Drawing.Point(241, 504);
            this.buttonOrderParts.Name = "buttonOrderParts";
            this.buttonOrderParts.Size = new System.Drawing.Size(146, 72);
            this.buttonOrderParts.TabIndex = 6;
            this.buttonOrderParts.Text = "Заказать запчасти";
            this.buttonOrderParts.UseVisualStyleBackColor = false;
            this.buttonOrderParts.Click += new System.EventHandler(this.buttonOrderParts_Click);
            // 
            // buttonGenerateQRCode
            // 
            this.buttonGenerateQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(103)))), ((int)(((byte)(80)))));
            this.buttonGenerateQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateQRCode.Location = new System.Drawing.Point(623, 407);
            this.buttonGenerateQRCode.Name = "buttonGenerateQRCode";
            this.buttonGenerateQRCode.Size = new System.Drawing.Size(163, 91);
            this.buttonGenerateQRCode.TabIndex = 7;
            this.buttonGenerateQRCode.Text = "Сгенерировать QR-код";
            this.buttonGenerateQRCode.UseVisualStyleBackColor = false;
            this.buttonGenerateQRCode.Click += new System.EventHandler(this.buttonGenerateQRCode_Click);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(818, 341);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(293, 231);
            this.pictureBoxQRCode.TabIndex = 8;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // textBoxRequestId
            // 
            this.textBoxRequestId.Location = new System.Drawing.Point(51, 305);
            this.textBoxRequestId.Name = "textBoxRequestId";
            this.textBoxRequestId.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestId.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(103)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(809, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 111);
            this.button1.TabIndex = 10;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер заявки";
            // 
            // FormS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1150, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRequestId);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.buttonGenerateQRCode);
            this.Controls.Add(this.buttonOrderParts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPartsNeeded);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdateStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dataGridViewRequests);
            this.Name = "FormS";
            this.Text = "FormS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonUpdateStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPartsNeeded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOrderParts;
        private System.Windows.Forms.Button buttonGenerateQRCode;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.TextBox textBoxRequestId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}