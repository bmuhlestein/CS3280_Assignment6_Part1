﻿namespace CS3280_Assignment6_Part1
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
            this.cbFlightName = new System.Windows.Forms.ComboBox();
            this.lblFlightSelection = new System.Windows.Forms.Label();
            this.lblPassengerSelection = new System.Windows.Forms.Label();
            this.cbPassengerName = new System.Windows.Forms.ComboBox();
            this.lblPassengerSeatSelection = new System.Windows.Forms.Label();
            this.cbPassengerSeat = new System.Windows.Forms.ComboBox();
            this.btnChangeSeat = new System.Windows.Forms.Button();
            this.btnDeletePassenger = new System.Windows.Forms.Button();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.gbColorKey = new System.Windows.Forms.GroupBox();
            this.lblFlightName = new System.Windows.Forms.Label();
            this.pnlFlight1 = new System.Windows.Forms.Panel();
            this.lblFlight1Seat14 = new System.Windows.Forms.Label();
            this.lblFlight1Seat13 = new System.Windows.Forms.Label();
            this.lblFlight1Seat12 = new System.Windows.Forms.Label();
            this.lblFlight1Seat11 = new System.Windows.Forms.Label();
            this.lblFlight1Seat10 = new System.Windows.Forms.Label();
            this.lblFlight1Seat9 = new System.Windows.Forms.Label();
            this.lblFlight1Seat8 = new System.Windows.Forms.Label();
            this.lblFlight1Seat7 = new System.Windows.Forms.Label();
            this.lblFlight1Seat6 = new System.Windows.Forms.Label();
            this.lblFlight1Seat5 = new System.Windows.Forms.Label();
            this.lblFlight1Seat4 = new System.Windows.Forms.Label();
            this.lblFlight1Seat3 = new System.Windows.Forms.Label();
            this.lblFlight1Seat2 = new System.Windows.Forms.Label();
            this.lblFlight1Seat1 = new System.Windows.Forms.Label();
            this.pnlFlight2 = new System.Windows.Forms.Panel();
            this.lblFlight2Seat12 = new System.Windows.Forms.Label();
            this.lblFlight2Seat11 = new System.Windows.Forms.Label();
            this.lblFlight2Seat10 = new System.Windows.Forms.Label();
            this.lblFlight2Seat9 = new System.Windows.Forms.Label();
            this.lblFlight2Seat8 = new System.Windows.Forms.Label();
            this.lblFlight2Seat7 = new System.Windows.Forms.Label();
            this.lblFlight2Seat6 = new System.Windows.Forms.Label();
            this.lblFlight2Seat5 = new System.Windows.Forms.Label();
            this.lblFlight2Seat4 = new System.Windows.Forms.Label();
            this.lblFlight2Seat3 = new System.Windows.Forms.Label();
            this.lblFlight2Seat2 = new System.Windows.Forms.Label();
            this.lblFlight2Seat1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbColorKey.SuspendLayout();
            this.pnlFlight1.SuspendLayout();
            this.pnlFlight2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFlightName
            // 
            this.cbFlightName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFlightName.FormattingEnabled = true;
            this.cbFlightName.Location = new System.Drawing.Point(763, 61);
            this.cbFlightName.Name = "cbFlightName";
            this.cbFlightName.Size = new System.Drawing.Size(275, 37);
            this.cbFlightName.TabIndex = 0;
            this.cbFlightName.SelectedIndexChanged += new System.EventHandler(this.cbFlightName_SelectedIndexChanged);
            // 
            // lblFlightSelection
            // 
            this.lblFlightSelection.AutoSize = true;
            this.lblFlightSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightSelection.Location = new System.Drawing.Point(553, 61);
            this.lblFlightSelection.Name = "lblFlightSelection";
            this.lblFlightSelection.Size = new System.Drawing.Size(190, 31);
            this.lblFlightSelection.TabIndex = 1;
            this.lblFlightSelection.Text = "Choose Flight:";
            // 
            // lblPassengerSelection
            // 
            this.lblPassengerSelection.AutoSize = true;
            this.lblPassengerSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerSelection.Location = new System.Drawing.Point(490, 124);
            this.lblPassengerSelection.Name = "lblPassengerSelection";
            this.lblPassengerSelection.Size = new System.Drawing.Size(253, 31);
            this.lblPassengerSelection.TabIndex = 2;
            this.lblPassengerSelection.Text = "Choose Passenger:";
            // 
            // cbPassengerName
            // 
            this.cbPassengerName.Enabled = false;
            this.cbPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPassengerName.FormattingEnabled = true;
            this.cbPassengerName.Location = new System.Drawing.Point(763, 124);
            this.cbPassengerName.Name = "cbPassengerName";
            this.cbPassengerName.Size = new System.Drawing.Size(275, 37);
            this.cbPassengerName.TabIndex = 3;
            this.cbPassengerName.SelectedIndexChanged += new System.EventHandler(this.cbPassengerName_SelectedIndexChanged);
            // 
            // lblPassengerSeatSelection
            // 
            this.lblPassengerSeatSelection.AutoSize = true;
            this.lblPassengerSeatSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerSeatSelection.Location = new System.Drawing.Point(509, 184);
            this.lblPassengerSeatSelection.Name = "lblPassengerSeatSelection";
            this.lblPassengerSeatSelection.Size = new System.Drawing.Size(234, 31);
            this.lblPassengerSeatSelection.TabIndex = 4;
            this.lblPassengerSeatSelection.Text = "Passenger\'s Seat:";
            // 
            // cbPassengerSeat
            // 
            this.cbPassengerSeat.Enabled = false;
            this.cbPassengerSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPassengerSeat.FormattingEnabled = true;
            this.cbPassengerSeat.Location = new System.Drawing.Point(763, 184);
            this.cbPassengerSeat.Name = "cbPassengerSeat";
            this.cbPassengerSeat.Size = new System.Drawing.Size(275, 37);
            this.cbPassengerSeat.TabIndex = 5;
            // 
            // btnChangeSeat
            // 
            this.btnChangeSeat.Enabled = false;
            this.btnChangeSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSeat.Location = new System.Drawing.Point(801, 256);
            this.btnChangeSeat.Name = "btnChangeSeat";
            this.btnChangeSeat.Size = new System.Drawing.Size(189, 56);
            this.btnChangeSeat.TabIndex = 6;
            this.btnChangeSeat.Text = "Change Seat";
            this.btnChangeSeat.UseVisualStyleBackColor = true;
            // 
            // btnDeletePassenger
            // 
            this.btnDeletePassenger.Enabled = false;
            this.btnDeletePassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePassenger.Location = new System.Drawing.Point(786, 346);
            this.btnDeletePassenger.Name = "btnDeletePassenger";
            this.btnDeletePassenger.Size = new System.Drawing.Size(205, 56);
            this.btnDeletePassenger.TabIndex = 7;
            this.btnDeletePassenger.Text = "Delete Passenger";
            this.btnDeletePassenger.UseVisualStyleBackColor = true;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Enabled = false;
            this.btnAddPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPassenger.Location = new System.Drawing.Point(582, 346);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(189, 56);
            this.btnAddPassenger.TabIndex = 8;
            this.btnAddPassenger.Text = "Add Passenger";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // gbColorKey
            // 
            this.gbColorKey.Controls.Add(this.label6);
            this.gbColorKey.Controls.Add(this.label5);
            this.gbColorKey.Controls.Add(this.label4);
            this.gbColorKey.Controls.Add(this.label3);
            this.gbColorKey.Controls.Add(this.label2);
            this.gbColorKey.Controls.Add(this.label1);
            this.gbColorKey.Location = new System.Drawing.Point(545, 429);
            this.gbColorKey.Name = "gbColorKey";
            this.gbColorKey.Size = new System.Drawing.Size(444, 161);
            this.gbColorKey.TabIndex = 9;
            this.gbColorKey.TabStop = false;
            this.gbColorKey.Text = "Color Key";
            // 
            // lblFlightName
            // 
            this.lblFlightName.AutoSize = true;
            this.lblFlightName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightName.Location = new System.Drawing.Point(179, 69);
            this.lblFlightName.Name = "lblFlightName";
            this.lblFlightName.Size = new System.Drawing.Size(79, 29);
            this.lblFlightName.TabIndex = 10;
            this.lblFlightName.Text = "label1";
            // 
            // pnlFlight1
            // 
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat14);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat13);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat12);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat11);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat10);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat9);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat8);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat7);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat6);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat5);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat4);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat3);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat2);
            this.pnlFlight1.Controls.Add(this.lblFlight1Seat1);
            this.pnlFlight1.Location = new System.Drawing.Point(39, 140);
            this.pnlFlight1.Name = "pnlFlight1";
            this.pnlFlight1.Size = new System.Drawing.Size(402, 230);
            this.pnlFlight1.TabIndex = 11;
            this.pnlFlight1.Visible = false;
            // 
            // lblFlight1Seat14
            // 
            this.lblFlight1Seat14.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat14.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat14.Location = new System.Drawing.Point(331, 156);
            this.lblFlight1Seat14.Name = "lblFlight1Seat14";
            this.lblFlight1Seat14.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat14.TabIndex = 13;
            this.lblFlight1Seat14.Text = "14";
            this.lblFlight1Seat14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat13
            // 
            this.lblFlight1Seat13.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat13.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat13.Location = new System.Drawing.Point(274, 156);
            this.lblFlight1Seat13.Name = "lblFlight1Seat13";
            this.lblFlight1Seat13.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat13.TabIndex = 12;
            this.lblFlight1Seat13.Text = "13";
            this.lblFlight1Seat13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat12
            // 
            this.lblFlight1Seat12.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat12.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat12.Location = new System.Drawing.Point(217, 156);
            this.lblFlight1Seat12.Name = "lblFlight1Seat12";
            this.lblFlight1Seat12.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat12.TabIndex = 11;
            this.lblFlight1Seat12.Text = "12";
            this.lblFlight1Seat12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat11
            // 
            this.lblFlight1Seat11.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat11.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat11.Location = new System.Drawing.Point(105, 156);
            this.lblFlight1Seat11.Name = "lblFlight1Seat11";
            this.lblFlight1Seat11.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat11.TabIndex = 10;
            this.lblFlight1Seat11.Text = "11";
            this.lblFlight1Seat11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat10
            // 
            this.lblFlight1Seat10.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat10.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat10.Location = new System.Drawing.Point(45, 156);
            this.lblFlight1Seat10.Name = "lblFlight1Seat10";
            this.lblFlight1Seat10.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat10.TabIndex = 9;
            this.lblFlight1Seat10.Text = "10";
            this.lblFlight1Seat10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat9
            // 
            this.lblFlight1Seat9.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat9.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat9.Location = new System.Drawing.Point(331, 100);
            this.lblFlight1Seat9.Name = "lblFlight1Seat9";
            this.lblFlight1Seat9.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat9.TabIndex = 8;
            this.lblFlight1Seat9.Text = "9";
            this.lblFlight1Seat9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat8
            // 
            this.lblFlight1Seat8.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat8.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat8.Location = new System.Drawing.Point(274, 100);
            this.lblFlight1Seat8.Name = "lblFlight1Seat8";
            this.lblFlight1Seat8.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat8.TabIndex = 7;
            this.lblFlight1Seat8.Text = "8";
            this.lblFlight1Seat8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat7
            // 
            this.lblFlight1Seat7.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat7.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat7.Location = new System.Drawing.Point(217, 100);
            this.lblFlight1Seat7.Name = "lblFlight1Seat7";
            this.lblFlight1Seat7.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat7.TabIndex = 6;
            this.lblFlight1Seat7.Text = "7";
            this.lblFlight1Seat7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat6
            // 
            this.lblFlight1Seat6.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat6.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat6.Location = new System.Drawing.Point(105, 100);
            this.lblFlight1Seat6.Name = "lblFlight1Seat6";
            this.lblFlight1Seat6.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat6.TabIndex = 5;
            this.lblFlight1Seat6.Text = "6";
            this.lblFlight1Seat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat5
            // 
            this.lblFlight1Seat5.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat5.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat5.Location = new System.Drawing.Point(45, 100);
            this.lblFlight1Seat5.Name = "lblFlight1Seat5";
            this.lblFlight1Seat5.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat5.TabIndex = 4;
            this.lblFlight1Seat5.Text = "5";
            this.lblFlight1Seat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat4
            // 
            this.lblFlight1Seat4.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat4.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat4.Location = new System.Drawing.Point(274, 35);
            this.lblFlight1Seat4.Name = "lblFlight1Seat4";
            this.lblFlight1Seat4.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat4.TabIndex = 3;
            this.lblFlight1Seat4.Text = "4";
            this.lblFlight1Seat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat3
            // 
            this.lblFlight1Seat3.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat3.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat3.Location = new System.Drawing.Point(217, 35);
            this.lblFlight1Seat3.Name = "lblFlight1Seat3";
            this.lblFlight1Seat3.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat3.TabIndex = 2;
            this.lblFlight1Seat3.Text = "3";
            this.lblFlight1Seat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat2
            // 
            this.lblFlight1Seat2.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat2.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat2.Location = new System.Drawing.Point(105, 35);
            this.lblFlight1Seat2.Name = "lblFlight1Seat2";
            this.lblFlight1Seat2.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat2.TabIndex = 1;
            this.lblFlight1Seat2.Text = "2";
            this.lblFlight1Seat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight1Seat1
            // 
            this.lblFlight1Seat1.BackColor = System.Drawing.Color.Blue;
            this.lblFlight1Seat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight1Seat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight1Seat1.ForeColor = System.Drawing.Color.White;
            this.lblFlight1Seat1.Location = new System.Drawing.Point(45, 35);
            this.lblFlight1Seat1.Name = "lblFlight1Seat1";
            this.lblFlight1Seat1.Size = new System.Drawing.Size(45, 45);
            this.lblFlight1Seat1.TabIndex = 0;
            this.lblFlight1Seat1.Text = "1";
            this.lblFlight1Seat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFlight2
            // 
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat12);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat11);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat10);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat9);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat8);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat7);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat6);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat5);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat4);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat3);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat2);
            this.pnlFlight2.Controls.Add(this.lblFlight2Seat1);
            this.pnlFlight2.Location = new System.Drawing.Point(54, 377);
            this.pnlFlight2.Name = "pnlFlight2";
            this.pnlFlight2.Size = new System.Drawing.Size(376, 213);
            this.pnlFlight2.TabIndex = 12;
            this.pnlFlight2.Visible = false;
            // 
            // lblFlight2Seat12
            // 
            this.lblFlight2Seat12.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat12.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat12.Location = new System.Drawing.Point(280, 144);
            this.lblFlight2Seat12.Name = "lblFlight2Seat12";
            this.lblFlight2Seat12.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat12.TabIndex = 26;
            this.lblFlight2Seat12.Text = "12";
            this.lblFlight2Seat12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat11
            // 
            this.lblFlight2Seat11.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat11.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat11.Location = new System.Drawing.Point(223, 144);
            this.lblFlight2Seat11.Name = "lblFlight2Seat11";
            this.lblFlight2Seat11.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat11.TabIndex = 25;
            this.lblFlight2Seat11.Text = "11";
            this.lblFlight2Seat11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat10
            // 
            this.lblFlight2Seat10.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat10.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat10.Location = new System.Drawing.Point(111, 144);
            this.lblFlight2Seat10.Name = "lblFlight2Seat10";
            this.lblFlight2Seat10.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat10.TabIndex = 24;
            this.lblFlight2Seat10.Text = "10";
            this.lblFlight2Seat10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat9
            // 
            this.lblFlight2Seat9.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat9.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat9.Location = new System.Drawing.Point(51, 144);
            this.lblFlight2Seat9.Name = "lblFlight2Seat9";
            this.lblFlight2Seat9.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat9.TabIndex = 23;
            this.lblFlight2Seat9.Text = "9";
            this.lblFlight2Seat9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat8
            // 
            this.lblFlight2Seat8.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat8.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat8.Location = new System.Drawing.Point(280, 88);
            this.lblFlight2Seat8.Name = "lblFlight2Seat8";
            this.lblFlight2Seat8.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat8.TabIndex = 21;
            this.lblFlight2Seat8.Text = "8";
            this.lblFlight2Seat8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat7
            // 
            this.lblFlight2Seat7.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat7.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat7.Location = new System.Drawing.Point(223, 88);
            this.lblFlight2Seat7.Name = "lblFlight2Seat7";
            this.lblFlight2Seat7.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat7.TabIndex = 20;
            this.lblFlight2Seat7.Text = "7";
            this.lblFlight2Seat7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat6
            // 
            this.lblFlight2Seat6.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat6.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat6.Location = new System.Drawing.Point(111, 88);
            this.lblFlight2Seat6.Name = "lblFlight2Seat6";
            this.lblFlight2Seat6.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat6.TabIndex = 19;
            this.lblFlight2Seat6.Text = "6";
            this.lblFlight2Seat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat5
            // 
            this.lblFlight2Seat5.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat5.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat5.Location = new System.Drawing.Point(51, 88);
            this.lblFlight2Seat5.Name = "lblFlight2Seat5";
            this.lblFlight2Seat5.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat5.TabIndex = 18;
            this.lblFlight2Seat5.Text = "5";
            this.lblFlight2Seat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat4
            // 
            this.lblFlight2Seat4.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat4.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat4.Location = new System.Drawing.Point(280, 23);
            this.lblFlight2Seat4.Name = "lblFlight2Seat4";
            this.lblFlight2Seat4.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat4.TabIndex = 17;
            this.lblFlight2Seat4.Text = "4";
            this.lblFlight2Seat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat3
            // 
            this.lblFlight2Seat3.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat3.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat3.Location = new System.Drawing.Point(223, 23);
            this.lblFlight2Seat3.Name = "lblFlight2Seat3";
            this.lblFlight2Seat3.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat3.TabIndex = 16;
            this.lblFlight2Seat3.Text = "3";
            this.lblFlight2Seat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat2
            // 
            this.lblFlight2Seat2.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat2.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat2.Location = new System.Drawing.Point(111, 23);
            this.lblFlight2Seat2.Name = "lblFlight2Seat2";
            this.lblFlight2Seat2.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat2.TabIndex = 15;
            this.lblFlight2Seat2.Text = "2";
            this.lblFlight2Seat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlight2Seat1
            // 
            this.lblFlight2Seat1.BackColor = System.Drawing.Color.Blue;
            this.lblFlight2Seat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlight2Seat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight2Seat1.ForeColor = System.Drawing.Color.White;
            this.lblFlight2Seat1.Location = new System.Drawing.Point(51, 23);
            this.lblFlight2Seat1.Name = "lblFlight2Seat1";
            this.lblFlight2Seat1.Size = new System.Drawing.Size(45, 45);
            this.lblFlight2Seat1.TabIndex = 14;
            this.lblFlight2Seat1.Text = "1";
            this.lblFlight2Seat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(59, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 45);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(59, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 45);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(257, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 45);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seat is Taken";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seat is Empty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Selected Passenger Seat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 607);
            this.Controls.Add(this.pnlFlight2);
            this.Controls.Add(this.pnlFlight1);
            this.Controls.Add(this.lblFlightName);
            this.Controls.Add(this.gbColorKey);
            this.Controls.Add(this.btnAddPassenger);
            this.Controls.Add(this.btnDeletePassenger);
            this.Controls.Add(this.btnChangeSeat);
            this.Controls.Add(this.cbPassengerSeat);
            this.Controls.Add(this.lblPassengerSeatSelection);
            this.Controls.Add(this.cbPassengerName);
            this.Controls.Add(this.lblPassengerSelection);
            this.Controls.Add(this.lblFlightSelection);
            this.Controls.Add(this.cbFlightName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbColorKey.ResumeLayout(false);
            this.gbColorKey.PerformLayout();
            this.pnlFlight1.ResumeLayout(false);
            this.pnlFlight2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFlightName;
        private System.Windows.Forms.Label lblFlightSelection;
        private System.Windows.Forms.Label lblPassengerSelection;
        private System.Windows.Forms.ComboBox cbPassengerName;
        private System.Windows.Forms.Label lblPassengerSeatSelection;
        private System.Windows.Forms.ComboBox cbPassengerSeat;
        private System.Windows.Forms.Button btnChangeSeat;
        private System.Windows.Forms.Button btnDeletePassenger;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.GroupBox gbColorKey;
        private System.Windows.Forms.Label lblFlightName;
        private System.Windows.Forms.Panel pnlFlight1;
        private System.Windows.Forms.Panel pnlFlight2;
        private System.Windows.Forms.Label lblFlight1Seat14;
        private System.Windows.Forms.Label lblFlight1Seat13;
        private System.Windows.Forms.Label lblFlight1Seat12;
        private System.Windows.Forms.Label lblFlight1Seat11;
        private System.Windows.Forms.Label lblFlight1Seat10;
        private System.Windows.Forms.Label lblFlight1Seat9;
        private System.Windows.Forms.Label lblFlight1Seat8;
        private System.Windows.Forms.Label lblFlight1Seat7;
        private System.Windows.Forms.Label lblFlight1Seat6;
        private System.Windows.Forms.Label lblFlight1Seat5;
        private System.Windows.Forms.Label lblFlight1Seat4;
        private System.Windows.Forms.Label lblFlight1Seat3;
        private System.Windows.Forms.Label lblFlight1Seat2;
        private System.Windows.Forms.Label lblFlight1Seat1;
        private System.Windows.Forms.Label lblFlight2Seat12;
        private System.Windows.Forms.Label lblFlight2Seat11;
        private System.Windows.Forms.Label lblFlight2Seat10;
        private System.Windows.Forms.Label lblFlight2Seat9;
        private System.Windows.Forms.Label lblFlight2Seat8;
        private System.Windows.Forms.Label lblFlight2Seat7;
        private System.Windows.Forms.Label lblFlight2Seat6;
        private System.Windows.Forms.Label lblFlight2Seat5;
        private System.Windows.Forms.Label lblFlight2Seat4;
        private System.Windows.Forms.Label lblFlight2Seat3;
        private System.Windows.Forms.Label lblFlight2Seat2;
        private System.Windows.Forms.Label lblFlight2Seat1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

