namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_connectionState = new System.Windows.Forms.Label();
            this.btn_connectDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.txb_ipAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_fam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sendRequest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_connectionState);
            this.groupBox1.Controls.Add(this.btn_connectDisconnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_port);
            this.groupBox1.Controls.Add(this.txb_ipAddress);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подклчение";
            // 
            // lbl_connectionState
            // 
            this.lbl_connectionState.AutoSize = true;
            this.lbl_connectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_connectionState.Location = new System.Drawing.Point(20, 98);
            this.lbl_connectionState.Name = "lbl_connectionState";
            this.lbl_connectionState.Size = new System.Drawing.Size(158, 24);
            this.lbl_connectionState.TabIndex = 5;
            this.lbl_connectionState.Text = "Нет соединения";
            // 
            // btn_connectDisconnect
            // 
            this.btn_connectDisconnect.Location = new System.Drawing.Point(20, 72);
            this.btn_connectDisconnect.Name = "btn_connectDisconnect";
            this.btn_connectDisconnect.Size = new System.Drawing.Size(175, 23);
            this.btn_connectDisconnect.TabIndex = 4;
            this.btn_connectDisconnect.Text = "Подключиться";
            this.btn_connectDisconnect.UseVisualStyleBackColor = true;
            this.btn_connectDisconnect.Click += new System.EventHandler(this.btn_connectDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Порт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP-адрес";
            // 
            // txb_port
            // 
            this.txb_port.Location = new System.Drawing.Point(77, 46);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(118, 20);
            this.txb_port.TabIndex = 1;
            this.txb_port.Text = "35072";
            // 
            // txb_ipAddress
            // 
            this.txb_ipAddress.Location = new System.Drawing.Point(77, 20);
            this.txb_ipAddress.Name = "txb_ipAddress";
            this.txb_ipAddress.Size = new System.Drawing.Size(118, 20);
            this.txb_ipAddress.TabIndex = 0;
            this.txb_ipAddress.Text = "192.168.2.115";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_surname);
            this.groupBox2.Controls.Add(this.lbl_name);
            this.groupBox2.Controls.Add(this.lbl_fam);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_sendRequest);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(102, 132);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(10, 13);
            this.lbl_surname.TabIndex = 6;
            this.lbl_surname.Text = "-";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(102, 109);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(10, 13);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "-";
            // 
            // lbl_fam
            // 
            this.lbl_fam.AutoSize = true;
            this.lbl_fam.Location = new System.Drawing.Point(102, 82);
            this.lbl_fam.Name = "lbl_fam";
            this.lbl_fam.Size = new System.Drawing.Size(10, 13);
            this.lbl_fam.TabIndex = 4;
            this.lbl_fam.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фамилия";
            // 
            // btn_sendRequest
            // 
            this.btn_sendRequest.Location = new System.Drawing.Point(6, 19);
            this.btn_sendRequest.Name = "btn_sendRequest";
            this.btn_sendRequest.Size = new System.Drawing.Size(193, 47);
            this.btn_sendRequest.TabIndex = 0;
            this.btn_sendRequest.Text = "Отправить запрос на сервер";
            this.btn_sendRequest.UseVisualStyleBackColor = true;
            this.btn_sendRequest.Click += new System.EventHandler(this.btn_sendRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ФИО сервера";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_connectionState;
        private System.Windows.Forms.Button btn_connectDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.TextBox txb_ipAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sendRequest;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_fam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

