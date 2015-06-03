namespace HMSSystem
{
    partial class HMS
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
            this.roomStatus = new System.Windows.Forms.Button();
            this.roomBooking = new System.Windows.Forms.Button();
            this.roomOccupant = new System.Windows.Forms.Button();
            this.roomOccupancy = new System.Windows.Forms.Button();
            this.housekeeping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingDetails = new System.Windows.Forms.Button();
            this.guestParticulars = new System.Windows.Forms.Button();
            this.bookingDetails2 = new System.Windows.Forms.Button();
            this.guestParticulars2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roomStatus
            // 
            this.roomStatus.Location = new System.Drawing.Point(273, 293);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.Size = new System.Drawing.Size(100, 56);
            this.roomStatus.TabIndex = 0;
            this.roomStatus.Text = "Room Status Reporting";
            this.roomStatus.UseVisualStyleBackColor = true;
            this.roomStatus.Click += new System.EventHandler(this.roomStatus_Click);
            // 
            // roomBooking
            // 
            this.roomBooking.Location = new System.Drawing.Point(26, 293);
            this.roomBooking.Name = "roomBooking";
            this.roomBooking.Size = new System.Drawing.Size(100, 56);
            this.roomBooking.TabIndex = 1;
            this.roomBooking.Text = "Room Booking Information Reporting";
            this.roomBooking.UseVisualStyleBackColor = true;
            this.roomBooking.Click += new System.EventHandler(this.roomBooking_Click);
            // 
            // roomOccupant
            // 
            this.roomOccupant.Location = new System.Drawing.Point(144, 293);
            this.roomOccupant.Name = "roomOccupant";
            this.roomOccupant.Size = new System.Drawing.Size(100, 56);
            this.roomOccupant.TabIndex = 2;
            this.roomOccupant.Text = "Room Occupant Reporting";
            this.roomOccupant.UseVisualStyleBackColor = true;
            this.roomOccupant.Click += new System.EventHandler(this.roomOccupant_Click);
            // 
            // roomOccupancy
            // 
            this.roomOccupancy.Location = new System.Drawing.Point(406, 293);
            this.roomOccupancy.Name = "roomOccupancy";
            this.roomOccupancy.Size = new System.Drawing.Size(100, 56);
            this.roomOccupancy.TabIndex = 3;
            this.roomOccupancy.Text = "Room Occupancy Reporting";
            this.roomOccupancy.UseVisualStyleBackColor = true;
            this.roomOccupancy.Click += new System.EventHandler(this.roomOccupancy_Click);
            // 
            // housekeeping
            // 
            this.housekeeping.Location = new System.Drawing.Point(547, 293);
            this.housekeeping.Name = "housekeeping";
            this.housekeeping.Size = new System.Drawing.Size(100, 56);
            this.housekeeping.TabIndex = 4;
            this.housekeeping.Text = "Housekeeping Reporting";
            this.housekeeping.UseVisualStyleBackColor = true;
            this.housekeeping.Click += new System.EventHandler(this.housekeeping_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Booking Modules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(21, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reporting Modules";
            // 
            // bookingDetails
            // 
            this.bookingDetails.Location = new System.Drawing.Point(144, 102);
            this.bookingDetails.Name = "bookingDetails";
            this.bookingDetails.Size = new System.Drawing.Size(100, 56);
            this.bookingDetails.TabIndex = 7;
            this.bookingDetails.Text = "View and Delete Bookings";
            this.bookingDetails.UseVisualStyleBackColor = true;
            this.bookingDetails.Click += new System.EventHandler(this.bookingDetails_Click);
            // 
            // guestParticulars
            // 
            this.guestParticulars.Location = new System.Drawing.Point(547, 102);
            this.guestParticulars.Name = "guestParticulars";
            this.guestParticulars.Size = new System.Drawing.Size(100, 56);
            this.guestParticulars.TabIndex = 8;
            this.guestParticulars.Text = "View and Delete Guest Details";
            this.guestParticulars.UseVisualStyleBackColor = true;
            this.guestParticulars.Click += new System.EventHandler(this.guestParticulars_Click);
            // 
            // bookingDetails2
            // 
            this.bookingDetails2.Location = new System.Drawing.Point(26, 102);
            this.bookingDetails2.Name = "bookingDetails2";
            this.bookingDetails2.Size = new System.Drawing.Size(100, 56);
            this.bookingDetails2.TabIndex = 9;
            this.bookingDetails2.Text = "Create and Update Bookings";
            this.bookingDetails2.UseVisualStyleBackColor = true;
            this.bookingDetails2.Click += new System.EventHandler(this.bookingDetails2_Click);
            // 
            // guestParticulars2
            // 
            this.guestParticulars2.Location = new System.Drawing.Point(406, 102);
            this.guestParticulars2.Name = "guestParticulars2";
            this.guestParticulars2.Size = new System.Drawing.Size(100, 56);
            this.guestParticulars2.TabIndex = 10;
            this.guestParticulars2.Text = "Create and Update Guest Details";
            this.guestParticulars2.UseVisualStyleBackColor = true;
            this.guestParticulars2.Click += new System.EventHandler(this.guestParticulars2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(401, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Guest Modules";
            // 
            // HMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guestParticulars2);
            this.Controls.Add(this.bookingDetails2);
            this.Controls.Add(this.guestParticulars);
            this.Controls.Add(this.bookingDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.housekeeping);
            this.Controls.Add(this.roomOccupancy);
            this.Controls.Add(this.roomOccupant);
            this.Controls.Add(this.roomBooking);
            this.Controls.Add(this.roomStatus);
            this.Name = "HMS";
            this.Text = "HMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roomStatus;
        private System.Windows.Forms.Button roomBooking;
        private System.Windows.Forms.Button roomOccupant;
        private System.Windows.Forms.Button roomOccupancy;
        private System.Windows.Forms.Button housekeeping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bookingDetails;
        private System.Windows.Forms.Button guestParticulars;
        private System.Windows.Forms.Button bookingDetails2;
        private System.Windows.Forms.Button guestParticulars2;
        private System.Windows.Forms.Label label3;
    }
}