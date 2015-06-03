namespace HMSSystem
{
    partial class GuestRnD
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDeleteID = new System.Windows.Forms.Button();
            this.btnGuestFind = new System.Windows.Forms.Button();
            this.tbxGuestID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(338, 367);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(86, 23);
            this.btnMenu.TabIndex = 20;
            this.btnMenu.Text = "Back to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(222, 367);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDetails.TabIndex = 19;
            this.btnUpdateDetails.Text = "Update";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(549, 247);
            this.dataGridView2.TabIndex = 18;
            // 
            // btnDeleteID
            // 
            this.btnDeleteID.Location = new System.Drawing.Point(222, 62);
            this.btnDeleteID.Name = "btnDeleteID";
            this.btnDeleteID.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteID.TabIndex = 17;
            this.btnDeleteID.Text = "Delete";
            this.btnDeleteID.UseVisualStyleBackColor = true;
            this.btnDeleteID.Click += new System.EventHandler(this.btnDeleteID_Click);
            // 
            // btnGuestFind
            // 
            this.btnGuestFind.Location = new System.Drawing.Point(222, 23);
            this.btnGuestFind.Name = "btnGuestFind";
            this.btnGuestFind.Size = new System.Drawing.Size(92, 23);
            this.btnGuestFind.TabIndex = 16;
            this.btnGuestFind.Text = "Find by guest ID";
            this.btnGuestFind.UseVisualStyleBackColor = true;
            this.btnGuestFind.Click += new System.EventHandler(this.btnGuestFind_Click);
            // 
            // tbxGuestID
            // 
            this.tbxGuestID.Location = new System.Drawing.Point(78, 24);
            this.tbxGuestID.Name = "tbxGuestID";
            this.tbxGuestID.Size = new System.Drawing.Size(127, 20);
            this.tbxGuestID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Guest ID:";
            // 
            // GuestRnD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 411);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnUpdateDetails);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnDeleteID);
            this.Controls.Add(this.btnGuestFind);
            this.Controls.Add(this.tbxGuestID);
            this.Controls.Add(this.label2);
            this.Name = "GuestRnD";
            this.Text = "GuestRnD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDeleteID;
        private System.Windows.Forms.Button btnGuestFind;
        private System.Windows.Forms.TextBox tbxGuestID;
        private System.Windows.Forms.Label label2;
    }
}