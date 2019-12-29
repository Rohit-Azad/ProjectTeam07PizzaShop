namespace ProjectTeam07PizzaShop
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.buttonUpdatePrice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewToppings = new System.Windows.Forms.DataGridView();
            this.dataGridViewSize = new System.Windows.Forms.DataGridView();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.labelNumberOfOrders = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelEarnings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewOrdersSummary = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveOrders = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSize)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersSummary)).BeginInit();
            this.tabPageBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Controls.Add(this.tabPageOrders);
            this.tabControl1.Controls.Add(this.tabPageBackup);
            this.tabControl1.Location = new System.Drawing.Point(31, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.buttonUpdatePrice);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.label4);
            this.tabPageUpdate.Controls.Add(this.dataGridViewToppings);
            this.tabPageUpdate.Controls.Add(this.dataGridViewSize);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageUpdate.Size = new System.Drawing.Size(668, 354);
            this.tabPageUpdate.TabIndex = 0;
            this.tabPageUpdate.Text = "Update Data";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonUpdatePrice
            // 
            this.buttonUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePrice.Location = new System.Drawing.Point(428, 220);
            this.buttonUpdatePrice.Name = "buttonUpdatePrice";
            this.buttonUpdatePrice.Size = new System.Drawing.Size(142, 66);
            this.buttonUpdatePrice.TabIndex = 6;
            this.buttonUpdatePrice.Text = "Update";
            this.buttonUpdatePrice.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Update price of Toppings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Update price by Size:";
            // 
            // dataGridViewToppings
            // 
            this.dataGridViewToppings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToppings.Location = new System.Drawing.Point(22, 53);
            this.dataGridViewToppings.Name = "dataGridViewToppings";
            this.dataGridViewToppings.Size = new System.Drawing.Size(278, 258);
            this.dataGridViewToppings.TabIndex = 3;
            // 
            // dataGridViewSize
            // 
            this.dataGridViewSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSize.Location = new System.Drawing.Point(365, 53);
            this.dataGridViewSize.Name = "dataGridViewSize";
            this.dataGridViewSize.Size = new System.Drawing.Size(269, 108);
            this.dataGridViewSize.TabIndex = 2;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.buttonSaveChanges);
            this.tabPageOrders.Controls.Add(this.buttonRemoveOrders);
            this.tabPageOrders.Controls.Add(this.labelNumberOfOrders);
            this.tabPageOrders.Controls.Add(this.label8);
            this.tabPageOrders.Controls.Add(this.labelEarnings);
            this.tabPageOrders.Controls.Add(this.label6);
            this.tabPageOrders.Controls.Add(this.dataGridViewOrdersSummary);
            this.tabPageOrders.Controls.Add(this.label3);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageOrders.Size = new System.Drawing.Size(668, 354);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Orders Summary";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfOrders
            // 
            this.labelNumberOfOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumberOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfOrders.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNumberOfOrders.Location = new System.Drawing.Point(235, 250);
            this.labelNumberOfOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfOrders.Name = "labelNumberOfOrders";
            this.labelNumberOfOrders.Size = new System.Drawing.Size(101, 21);
            this.labelNumberOfOrders.TabIndex = 11;
            this.labelNumberOfOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Number of Orders:";
            // 
            // labelEarnings
            // 
            this.labelEarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEarnings.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelEarnings.Location = new System.Drawing.Point(235, 216);
            this.labelEarnings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEarnings.Name = "labelEarnings";
            this.labelEarnings.Size = new System.Drawing.Size(101, 21);
            this.labelEarnings.TabIndex = 9;
            this.labelEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Earnings on all Orders:";
            // 
            // dataGridViewOrdersSummary
            // 
            this.dataGridViewOrdersSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersSummary.Location = new System.Drawing.Point(28, 41);
            this.dataGridViewOrdersSummary.Name = "dataGridViewOrdersSummary";
            this.dataGridViewOrdersSummary.Size = new System.Drawing.Size(614, 143);
            this.dataGridViewOrdersSummary.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orders Summary";
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.buttonBackup);
            this.tabPageBackup.Controls.Add(this.label2);
            this.tabPageBackup.Controls.Add(this.label1);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Size = new System.Drawing.Size(668, 354);
            this.tabPageBackup.TabIndex = 2;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackup.Location = new System.Drawing.Point(215, 154);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(213, 94);
            this.buttonBackup.TabIndex = 2;
            this.buttonBackup.Text = "Backup to XML";
            this.buttonBackup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use this Tab to back-up data to an XML file";
            // 
            // buttonRemoveOrders
            // 
            this.buttonRemoveOrders.Location = new System.Drawing.Point(457, 243);
            this.buttonRemoveOrders.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRemoveOrders.Name = "buttonRemoveOrders";
            this.buttonRemoveOrders.Size = new System.Drawing.Size(185, 28);
            this.buttonRemoveOrders.TabIndex = 12;
            this.buttonRemoveOrders.Text = "Remove Selected Order";
            this.buttonRemoveOrders.UseVisualStyleBackColor = true;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(457, 208);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(185, 28);
            this.buttonSaveChanges.TabIndex = 13;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 440);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSize)).EndInit();
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersSummary)).EndInit();
            this.tabPageBackup.ResumeLayout(false);
            this.tabPageBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewToppings;
        private System.Windows.Forms.DataGridView dataGridViewSize;
        private System.Windows.Forms.DataGridView dataGridViewOrdersSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonUpdatePrice;
        private System.Windows.Forms.Label labelEarnings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumberOfOrders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRemoveOrders;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}