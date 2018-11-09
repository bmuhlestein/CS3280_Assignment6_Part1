namespace CS3280_Assignment6_Part1
{
    partial class AddPassengerForm
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
            this.lblPassengerFirstName = new System.Windows.Forms.Label();
            this.lblPassengerLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEnterPassengerInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassengerFirstName
            // 
            this.lblPassengerFirstName.AutoSize = true;
            this.lblPassengerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFirstName.Location = new System.Drawing.Point(106, 106);
            this.lblPassengerFirstName.Name = "lblPassengerFirstName";
            this.lblPassengerFirstName.Size = new System.Drawing.Size(125, 26);
            this.lblPassengerFirstName.TabIndex = 0;
            this.lblPassengerFirstName.Text = "First Name:";
            // 
            // lblPassengerLastName
            // 
            this.lblPassengerLastName.AutoSize = true;
            this.lblPassengerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerLastName.Location = new System.Drawing.Point(107, 166);
            this.lblPassengerLastName.Name = "lblPassengerLastName";
            this.lblPassengerLastName.Size = new System.Drawing.Size(124, 26);
            this.lblPassengerLastName.TabIndex = 1;
            this.lblPassengerLastName.Text = "Last Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 32);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(237, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 32);
            this.textBox2.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(279, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(94, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblEnterPassengerInformation
            // 
            this.lblEnterPassengerInformation.AutoSize = true;
            this.lblEnterPassengerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPassengerInformation.Location = new System.Drawing.Point(89, 32);
            this.lblEnterPassengerInformation.Name = "lblEnterPassengerInformation";
            this.lblEnterPassengerInformation.Size = new System.Drawing.Size(406, 29);
            this.lblEnterPassengerInformation.TabIndex = 6;
            this.lblEnterPassengerInformation.Text = "Please enter passengers information";
            // 
            // AddPassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 364);
            this.Controls.Add(this.lblEnterPassengerInformation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPassengerLastName);
            this.Controls.Add(this.lblPassengerFirstName);
            this.Name = "AddPassengerForm";
            this.Text = "AddPassengerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassengerFirstName;
        private System.Windows.Forms.Label lblPassengerLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEnterPassengerInformation;
    }
}