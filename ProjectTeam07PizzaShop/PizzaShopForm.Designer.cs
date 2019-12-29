namespace ProjectTeam07PizzaShop
{
    partial class PizzaShopForm
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
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(66, 342);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(421, 307);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(571, 342);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(421, 307);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Either Admin or User Window:";
            // 
            // PizzaShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 832);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "PizzaShopForm";
            this.Text = "Pizza Shop Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Label label1;
    }
}

