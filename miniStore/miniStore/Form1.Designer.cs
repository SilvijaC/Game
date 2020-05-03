namespace miniStore
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
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.CheckedListBox();
            this.BasketBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SumBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeliveryTypeBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceCalculation = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ItemSelectionPanel = new System.Windows.Forms.Panel();
            this.ContinueToDelivery = new System.Windows.Forms.Button();
            this.DeliveryPanel = new System.Windows.Forms.Panel();
            this.BasketSizeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ItemSelectionPanel.SuspendLayout();
            this.DeliveryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(19, 149);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(269, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Selected Items In To Basket";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(114, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Basket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price without shipping";
            // 
            // ItemListBox
            // 
            this.ItemListBox.CheckOnClick = true;
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.Location = new System.Drawing.Point(19, 39);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(269, 109);
            this.ItemListBox.TabIndex = 7;
            // 
            // BasketBox
            // 
            this.BasketBox.FormattingEnabled = true;
            this.BasketBox.Location = new System.Drawing.Point(19, 198);
            this.BasketBox.Name = "BasketBox";
            this.BasketBox.Size = new System.Drawing.Size(269, 108);
            this.BasketBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(94, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Items";
            // 
            // SumBox
            // 
            this.SumBox.Location = new System.Drawing.Point(98, 341);
            this.SumBox.Name = "SumBox";
            this.SumBox.Size = new System.Drawing.Size(100, 20);
            this.SumBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(79, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Delivery ";
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Location = new System.Drawing.Point(26, 73);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(121, 21);
            this.CountryBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Delivery Type";
            // 
            // DeliveryTypeBox
            // 
            this.DeliveryTypeBox.FormattingEnabled = true;
            this.DeliveryTypeBox.Location = new System.Drawing.Point(26, 113);
            this.DeliveryTypeBox.Name = "DeliveryTypeBox";
            this.DeliveryTypeBox.Size = new System.Drawing.Size(121, 21);
            this.DeliveryTypeBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Price With Shipping";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(178, 341);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 17;
            // 
            // PriceCalculation
            // 
            this.PriceCalculation.Location = new System.Drawing.Point(78, 149);
            this.PriceCalculation.Name = "PriceCalculation";
            this.PriceCalculation.Size = new System.Drawing.Size(140, 23);
            this.PriceCalculation.TabIndex = 18;
            this.PriceCalculation.Text = "CalculatePrice";
            this.PriceCalculation.UseVisualStyleBackColor = true;
            this.PriceCalculation.Click += new System.EventHandler(this.PriceCalculation_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(83, 367);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(135, 23);
            this.SubmitButton.TabIndex = 19;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ItemSelectionPanel
            // 
            this.ItemSelectionPanel.Controls.Add(this.ContinueToDelivery);
            this.ItemSelectionPanel.Controls.Add(this.label3);
            this.ItemSelectionPanel.Controls.Add(this.ItemListBox);
            this.ItemSelectionPanel.Controls.Add(this.AddButton);
            this.ItemSelectionPanel.Controls.Add(this.label1);
            this.ItemSelectionPanel.Controls.Add(this.BasketBox);
            this.ItemSelectionPanel.Controls.Add(this.label2);
            this.ItemSelectionPanel.Controls.Add(this.SumBox);
            this.ItemSelectionPanel.Location = new System.Drawing.Point(72, 6);
            this.ItemSelectionPanel.Name = "ItemSelectionPanel";
            this.ItemSelectionPanel.Size = new System.Drawing.Size(323, 425);
            this.ItemSelectionPanel.TabIndex = 20;
            // 
            // ContinueToDelivery
            // 
            this.ContinueToDelivery.Location = new System.Drawing.Point(59, 367);
            this.ContinueToDelivery.Name = "ContinueToDelivery";
            this.ContinueToDelivery.Size = new System.Drawing.Size(183, 23);
            this.ContinueToDelivery.TabIndex = 11;
            this.ContinueToDelivery.Text = "Continue To Delivery";
            this.ContinueToDelivery.UseVisualStyleBackColor = true;
            this.ContinueToDelivery.Click += new System.EventHandler(this.ContinueToDelivery_Click);
            // 
            // DeliveryPanel
            // 
            this.DeliveryPanel.Controls.Add(this.BasketSizeBox);
            this.DeliveryPanel.Controls.Add(this.label8);
            this.DeliveryPanel.Controls.Add(this.label4);
            this.DeliveryPanel.Controls.Add(this.label5);
            this.DeliveryPanel.Controls.Add(this.SubmitButton);
            this.DeliveryPanel.Controls.Add(this.CountryBox);
            this.DeliveryPanel.Controls.Add(this.PriceBox);
            this.DeliveryPanel.Controls.Add(this.PriceCalculation);
            this.DeliveryPanel.Controls.Add(this.label7);
            this.DeliveryPanel.Controls.Add(this.label6);
            this.DeliveryPanel.Controls.Add(this.DeliveryTypeBox);
            this.DeliveryPanel.Location = new System.Drawing.Point(401, 6);
            this.DeliveryPanel.Name = "DeliveryPanel";
            this.DeliveryPanel.Size = new System.Drawing.Size(296, 426);
            this.DeliveryPanel.TabIndex = 21;
            // 
            // BasketSizeBox
            // 
            this.BasketSizeBox.Location = new System.Drawing.Point(47, 341);
            this.BasketSizeBox.Name = "BasketSizeBox";
            this.BasketSizeBox.Size = new System.Drawing.Size(100, 20);
            this.BasketSizeBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Basket Size";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(miniStore.Goods);
            // 
            // goodsBindingSource1
            // 
            this.goodsBindingSource1.DataSource = typeof(miniStore.Goods);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.DeliveryPanel);
            this.Controls.Add(this.ItemSelectionPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ItemSelectionPanel.ResumeLayout(false);
            this.ItemSelectionPanel.PerformLayout();
            this.DeliveryPanel.ResumeLayout(false);
            this.DeliveryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource goodsBindingSource1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ItemListBox;
        private System.Windows.Forms.ListBox BasketBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DeliveryTypeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button PriceCalculation;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Panel ItemSelectionPanel;
        private System.Windows.Forms.Button ContinueToDelivery;
        private System.Windows.Forms.Panel DeliveryPanel;
        private System.Windows.Forms.TextBox BasketSizeBox;
        private System.Windows.Forms.Label label8;
    }
}

