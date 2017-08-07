namespace ShutdownTimer
{
    partial class Form_Interface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Hour = new System.Windows.Forms.ComboBox();
            this.comboBox_Minute = new System.Windows.Forms.ComboBox();
            this.button_Shutdown = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
            this.button_ShutdownAtTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(147, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minute";
            // 
            // comboBox_Hour
            // 
            this.comboBox_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox_Hour.FormattingEnabled = true;
            this.comboBox_Hour.Location = new System.Drawing.Point(40, 73);
            this.comboBox_Hour.Name = "comboBox_Hour";
            this.comboBox_Hour.Size = new System.Drawing.Size(68, 33);
            this.comboBox_Hour.TabIndex = 2;
            // 
            // comboBox_Minute
            // 
            this.comboBox_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox_Minute.FormattingEnabled = true;
            this.comboBox_Minute.Location = new System.Drawing.Point(150, 73);
            this.comboBox_Minute.Name = "comboBox_Minute";
            this.comboBox_Minute.Size = new System.Drawing.Size(68, 33);
            this.comboBox_Minute.TabIndex = 3;
            // 
            // button_Shutdown
            // 
            this.button_Shutdown.Location = new System.Drawing.Point(251, 13);
            this.button_Shutdown.Name = "button_Shutdown";
            this.button_Shutdown.Size = new System.Drawing.Size(75, 44);
            this.button_Shutdown.TabIndex = 4;
            this.button_Shutdown.Text = "Shutdown";
            this.button_Shutdown.UseVisualStyleBackColor = true;
            this.button_Shutdown.Click += new System.EventHandler(this.button_Shutdown_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(251, 73);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 44);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker_Time.Location = new System.Drawing.Point(40, 164);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.Size = new System.Drawing.Size(178, 26);
            this.dateTimePicker_Time.TabIndex = 6;
            // 
            // button_ShutdownAtTime
            // 
            this.button_ShutdownAtTime.Location = new System.Drawing.Point(251, 155);
            this.button_ShutdownAtTime.Name = "button_ShutdownAtTime";
            this.button_ShutdownAtTime.Size = new System.Drawing.Size(75, 44);
            this.button_ShutdownAtTime.TabIndex = 7;
            this.button_ShutdownAtTime.Text = "Shutdown";
            this.button_ShutdownAtTime.UseVisualStyleBackColor = true;
            this.button_ShutdownAtTime.Click += new System.EventHandler(this.button_ShutdownAtTime_Click);
            // 
            // Form_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 212);
            this.Controls.Add(this.button_ShutdownAtTime);
            this.Controls.Add(this.dateTimePicker_Time);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Shutdown);
            this.Controls.Add(this.comboBox_Minute);
            this.Controls.Add(this.comboBox_Hour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Interface";
            this.Text = "Shutdown Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Hour;
        private System.Windows.Forms.ComboBox comboBox_Minute;
        private System.Windows.Forms.Button button_Shutdown;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
        private System.Windows.Forms.Button button_ShutdownAtTime;
    }
}

