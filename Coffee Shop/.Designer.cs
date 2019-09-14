namespace Coffee_Shop
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
            this.customer_informationLabel = new System.Windows.Forms.Label();
            this.customer_nameLabel = new System.Windows.Forms.Label();
            this.contact_noLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.contact_noTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.customer_informationPanel = new System.Windows.Forms.Panel();
            this.purchase_informationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.customer_informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_informationLabel
            // 
            this.customer_informationLabel.AutoSize = true;
            this.customer_informationLabel.Location = new System.Drawing.Point(14, 32);
            this.customer_informationLabel.Name = "customer_informationLabel";
            this.customer_informationLabel.Size = new System.Drawing.Size(142, 17);
            this.customer_informationLabel.TabIndex = 0;
            this.customer_informationLabel.Text = "Customer Information";
            // 
            // customer_nameLabel
            // 
            this.customer_nameLabel.AutoSize = true;
            this.customer_nameLabel.Location = new System.Drawing.Point(33, 87);
            this.customer_nameLabel.Name = "customer_nameLabel";
            this.customer_nameLabel.Size = new System.Drawing.Size(109, 17);
            this.customer_nameLabel.TabIndex = 1;
            this.customer_nameLabel.Text = "Customer Name";
            // 
            // contact_noLabel
            // 
            this.contact_noLabel.AutoSize = true;
            this.contact_noLabel.Location = new System.Drawing.Point(33, 122);
            this.contact_noLabel.Name = "contact_noLabel";
            this.contact_noLabel.Size = new System.Drawing.Size(78, 17);
            this.contact_noLabel.TabIndex = 2;
            this.contact_noLabel.Text = "Contact No";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(33, 156);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(33, 236);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(45, 17);
            this.orderLabel.TabIndex = 4;
            this.orderLabel.Text = "Order";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(33, 278);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.Location = new System.Drawing.Point(210, 82);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.customer_nameTextBox.TabIndex = 6;
            // 
            // contact_noTextBox
            // 
            this.contact_noTextBox.Location = new System.Drawing.Point(210, 117);
            this.contact_noTextBox.Name = "contact_noTextBox";
            this.contact_noTextBox.Size = new System.Drawing.Size(100, 22);
            this.contact_noTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(210, 151);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(210, 273);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 9;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(210, 229);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 24);
            this.orderComboBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(210, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // customer_informationPanel
            // 
            this.customer_informationPanel.Controls.Add(this.customer_informationLabel);
            this.customer_informationPanel.Controls.Add(this.saveButton);
            this.customer_informationPanel.Controls.Add(this.customer_nameLabel);
            this.customer_informationPanel.Controls.Add(this.quantityTextBox);
            this.customer_informationPanel.Controls.Add(this.orderComboBox);
            this.customer_informationPanel.Controls.Add(this.quantityLabel);
            this.customer_informationPanel.Controls.Add(this.contact_noLabel);
            this.customer_informationPanel.Controls.Add(this.addressLabel);
            this.customer_informationPanel.Controls.Add(this.addressTextBox);
            this.customer_informationPanel.Controls.Add(this.orderLabel);
            this.customer_informationPanel.Controls.Add(this.customer_nameTextBox);
            this.customer_informationPanel.Controls.Add(this.contact_noTextBox);
            this.customer_informationPanel.Location = new System.Drawing.Point(43, 29);
            this.customer_informationPanel.Name = "customer_informationPanel";
            this.customer_informationPanel.Size = new System.Drawing.Size(422, 369);
            this.customer_informationPanel.TabIndex = 12;
            // 
            // purchase_informationRichTextBox
            // 
            this.purchase_informationRichTextBox.Location = new System.Drawing.Point(541, 29);
            this.purchase_informationRichTextBox.Name = "purchase_informationRichTextBox";
            this.purchase_informationRichTextBox.Size = new System.Drawing.Size(232, 369);
            this.purchase_informationRichTextBox.TabIndex = 13;
            this.purchase_informationRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purchase_informationRichTextBox);
            this.Controls.Add(this.customer_informationPanel);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customer_informationPanel.ResumeLayout(false);
            this.customer_informationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label customer_informationLabel;
        private System.Windows.Forms.Label customer_nameLabel;
        private System.Windows.Forms.Label contact_noLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.TextBox contact_noTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel customer_informationPanel;
        private System.Windows.Forms.RichTextBox purchase_informationRichTextBox;
    }
}

