namespace TruckManagement
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCostPerRemainingBox = new System.Windows.Forms.TextBox();
            this.tbCostPerFullPallets = new System.Windows.Forms.TextBox();
            this.tbMaxNoOfBoxesPerPallets = new System.Windows.Forms.TextBox();
            this.tbMaxNoOfPallets = new System.Windows.Forms.TextBox();
            this.tbTruckName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblResult = new System.Windows.Forms.Label();
            this.cbTruckList = new System.Windows.Forms.ComboBox();
            this.tbToBeShipped = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemovePlaceOrder = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCostPerRemainingBox);
            this.groupBox2.Controls.Add(this.tbCostPerFullPallets);
            this.groupBox2.Controls.Add(this.tbMaxNoOfBoxesPerPallets);
            this.groupBox2.Controls.Add(this.tbMaxNoOfPallets);
            this.groupBox2.Controls.Add(this.tbTruckName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Truck";
            // 
            // tbCostPerRemainingBox
            // 
            this.tbCostPerRemainingBox.Location = new System.Drawing.Point(501, 99);
            this.tbCostPerRemainingBox.Name = "tbCostPerRemainingBox";
            this.tbCostPerRemainingBox.Size = new System.Drawing.Size(48, 20);
            this.tbCostPerRemainingBox.TabIndex = 11;
            // 
            // tbCostPerFullPallets
            // 
            this.tbCostPerFullPallets.Location = new System.Drawing.Point(501, 63);
            this.tbCostPerFullPallets.Name = "tbCostPerFullPallets";
            this.tbCostPerFullPallets.Size = new System.Drawing.Size(48, 20);
            this.tbCostPerFullPallets.TabIndex = 10;
            // 
            // tbMaxNoOfBoxesPerPallets
            // 
            this.tbMaxNoOfBoxesPerPallets.Location = new System.Drawing.Point(197, 103);
            this.tbMaxNoOfBoxesPerPallets.Name = "tbMaxNoOfBoxesPerPallets";
            this.tbMaxNoOfBoxesPerPallets.Size = new System.Drawing.Size(45, 20);
            this.tbMaxNoOfBoxesPerPallets.TabIndex = 9;
            // 
            // tbMaxNoOfPallets
            // 
            this.tbMaxNoOfPallets.Location = new System.Drawing.Point(197, 67);
            this.tbMaxNoOfPallets.Name = "tbMaxNoOfPallets";
            this.tbMaxNoOfPallets.Size = new System.Drawing.Size(45, 20);
            this.tbMaxNoOfPallets.TabIndex = 8;
            // 
            // tbTruckName
            // 
            this.tbTruckName.Location = new System.Drawing.Point(82, 28);
            this.tbTruckName.Name = "tbTruckName";
            this.tbTruckName.Size = new System.Drawing.Size(200, 20);
            this.tbTruckName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cost Per Remaining Box: €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cost Per Full Pallets: € ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max. Number of Boxes Per Pallets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max. Number Of Pallets:\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Truck Name:";
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.Location = new System.Drawing.Point(6, 198);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(669, 56);
            this.lbShow.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(203, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 303);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.lbShow);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Trucks";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(331, 169);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Controls.Add(this.btnRemovePlaceOrder);
            this.tabPage2.Controls.Add(this.lblResult);
            this.tabPage2.Controls.Add(this.cbTruckList);
            this.tabPage2.Controls.Add(this.tbToBeShipped);
            this.tabPage2.Controls.Add(this.btnCalculate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Place Order";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(327, 204);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(30, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Here";
            // 
            // cbTruckList
            // 
            this.cbTruckList.FormattingEnabled = true;
            this.cbTruckList.Location = new System.Drawing.Point(206, 79);
            this.cbTruckList.Name = "cbTruckList";
            this.cbTruckList.Size = new System.Drawing.Size(121, 21);
            this.cbTruckList.TabIndex = 7;
            // 
            // tbToBeShipped
            // 
            this.tbToBeShipped.Location = new System.Drawing.Point(206, 33);
            this.tbToBeShipped.Name = "tbToBeShipped";
            this.tbToBeShipped.Size = new System.Drawing.Size(52, 20);
            this.tbToBeShipped.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.Location = new System.Drawing.Point(395, 77);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(77, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Truck Type to be used:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "No. of boxes to be Shipped:";
            // 
            // btnRemovePlaceOrder
            // 
            this.btnRemovePlaceOrder.Location = new System.Drawing.Point(395, 106);
            this.btnRemovePlaceOrder.Name = "btnRemovePlaceOrder";
            this.btnRemovePlaceOrder.Size = new System.Drawing.Size(77, 23);
            this.btnRemovePlaceOrder.TabIndex = 9;
            this.btnRemovePlaceOrder.Text = "Remove";
            this.btnRemovePlaceOrder.UseVisualStyleBackColor = true;
            this.btnRemovePlaceOrder.Click += new System.EventHandler(this.btnRemovePlaceOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCostPerRemainingBox;
        private System.Windows.Forms.TextBox tbCostPerFullPallets;
        private System.Windows.Forms.TextBox tbMaxNoOfBoxesPerPallets;
        private System.Windows.Forms.TextBox tbMaxNoOfPallets;
        private System.Windows.Forms.TextBox tbTruckName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cbTruckList;
        private System.Windows.Forms.TextBox tbToBeShipped;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemovePlaceOrder;
    }
}

