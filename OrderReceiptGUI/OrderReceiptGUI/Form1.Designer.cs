namespace OrderReceiptGUI
{
    partial class frmOrderReceiptGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputNewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveCopiedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCopiedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblOutputAll = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblBudgetPrompt = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtlaboratory = new System.Windows.Forms.TextBox();
            this.lblLaboratory = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.copyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.addANewRecordToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File ";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.inputToolStripMenuItem.Text = "Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.displayToolStripMenuItem.Text = "Output First Record";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // addANewRecordToolStripMenuItem
            // 
            this.addANewRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputNewRecordToolStripMenuItem,
            this.saveNewRecordToolStripMenuItem});
            this.addANewRecordToolStripMenuItem.Name = "addANewRecordToolStripMenuItem";
            this.addANewRecordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addANewRecordToolStripMenuItem.Text = "Add a New Record";
            this.addANewRecordToolStripMenuItem.Click += new System.EventHandler(this.addANewRecordToolStripMenuItem_Click);
            // 
            // outputNewRecordToolStripMenuItem
            // 
            this.outputNewRecordToolStripMenuItem.Name = "outputNewRecordToolStripMenuItem";
            this.outputNewRecordToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.outputNewRecordToolStripMenuItem.Text = "outputNewRecord";
            this.outputNewRecordToolStripMenuItem.Click += new System.EventHandler(this.outputNewRecordToolStripMenuItem_Click);
            // 
            // saveNewRecordToolStripMenuItem
            // 
            this.saveNewRecordToolStripMenuItem.Name = "saveNewRecordToolStripMenuItem";
            this.saveNewRecordToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveNewRecordToolStripMenuItem.Text = "Save New Record";
            this.saveNewRecordToolStripMenuItem.Click += new System.EventHandler(this.saveNewRecordToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveCopiedFileToolStripMenuItem});
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.moveToolStripMenuItem.Text = "Move ";
            // 
            // moveCopiedFileToolStripMenuItem
            // 
            this.moveCopiedFileToolStripMenuItem.Name = "moveCopiedFileToolStripMenuItem";
            this.moveCopiedFileToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.moveCopiedFileToolStripMenuItem.Text = "Move Copied File";
            this.moveCopiedFileToolStripMenuItem.Click += new System.EventHandler(this.moveCopiedFileToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCopiedFileToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteCopiedFileToolStripMenuItem
            // 
            this.deleteCopiedFileToolStripMenuItem.Name = "deleteCopiedFileToolStripMenuItem";
            this.deleteCopiedFileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteCopiedFileToolStripMenuItem.Text = "Delete Copied File";
            this.deleteCopiedFileToolStripMenuItem.Click += new System.EventHandler(this.deleteCopiedFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyOriginalToolStripMenuItem});
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.copyToolStripMenuItem1.Text = "Copy ";
            // 
            // copyOriginalToolStripMenuItem
            // 
            this.copyOriginalToolStripMenuItem.Name = "copyOriginalToolStripMenuItem";
            this.copyOriginalToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.copyOriginalToolStripMenuItem.Text = "Copy Original";
            this.copyOriginalToolStripMenuItem.Click += new System.EventHandler(this.copyOriginalToolStripMenuItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(39, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ItemName";
            this.lblName.Visible = false;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(15, 125);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(120, 20);
            this.lblStreetAddress.TabIndex = 2;
            this.lblStreetAddress.Text = "Street Address:";
            this.lblStreetAddress.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(73, 171);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            this.lblCity.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(60, 218);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 20);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            this.lblState.Visible = false;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipcode.Location = new System.Drawing.Point(47, 257);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(69, 20);
            this.lblZipcode.TabIndex = 5;
            this.lblZipcode.Text = "ZipCode";
            this.lblZipcode.Visible = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(54, 305);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 83);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 18);
            this.txtName.TabIndex = 7;
            this.txtName.Visible = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(419, 30);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(76, 25);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "Output";
            this.lblDisplay.Visible = false;
            // 
            // lblOutputAll
            // 
            this.lblOutputAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputAll.Location = new System.Drawing.Point(424, 55);
            this.lblOutputAll.Name = "lblOutputAll";
            this.lblOutputAll.Size = new System.Drawing.Size(444, 475);
            this.lblOutputAll.TabIndex = 9;
            this.lblOutputAll.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 127);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(266, 20);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Visible = false;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 173);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(281, 20);
            this.txtCity.TabIndex = 11;
            this.txtCity.Visible = false;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(126, 218);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(281, 20);
            this.txtState.TabIndex = 12;
            this.txtState.Visible = false;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(131, 257);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(276, 20);
            this.txtZipCode.TabIndex = 13;
            this.txtZipCode.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(131, 305);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(276, 20);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.Visible = false;
            // 
            // lblBudgetPrompt
            // 
            this.lblBudgetPrompt.AutoSize = true;
            this.lblBudgetPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetPrompt.Location = new System.Drawing.Point(60, 360);
            this.lblBudgetPrompt.Name = "lblBudgetPrompt";
            this.lblBudgetPrompt.Size = new System.Drawing.Size(61, 20);
            this.lblBudgetPrompt.TabIndex = 16;
            this.lblBudgetPrompt.Text = "Budget";
            this.lblBudgetPrompt.Visible = false;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(131, 360);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(276, 20);
            this.txtBudget.TabIndex = 17;
            this.txtBudget.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(66, 415);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(42, 20);
            this.lblCost.TabIndex = 18;
            this.lblCost.Text = "Cost";
            this.lblCost.Visible = false;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(131, 417);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(276, 20);
            this.txtCost.TabIndex = 19;
            this.txtCost.Visible = false;
            // 
            // txtlaboratory
            // 
            this.txtlaboratory.Location = new System.Drawing.Point(131, 34);
            this.txtlaboratory.Name = "txtlaboratory";
            this.txtlaboratory.Size = new System.Drawing.Size(276, 20);
            this.txtlaboratory.TabIndex = 21;
            this.txtlaboratory.Visible = false;
            // 
            // lblLaboratory
            // 
            this.lblLaboratory.AutoSize = true;
            this.lblLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratory.Location = new System.Drawing.Point(43, 35);
            this.lblLaboratory.Name = "lblLaboratory";
            this.lblLaboratory.Size = new System.Drawing.Size(79, 20);
            this.lblLaboratory.TabIndex = 22;
            this.lblLaboratory.Text = "laboratory";
            this.lblLaboratory.Visible = false;
            // 
            // frmOrderReceiptGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 540);
            this.ControlBox = false;
            this.Controls.Add(this.lblLaboratory);
            this.Controls.Add(this.txtlaboratory);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.lblBudgetPrompt);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblOutputAll);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblZipcode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "frmOrderReceiptGUI";
            this.Text = "OrderReceiptGUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblOutputAll;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblBudgetPrompt;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtlaboratory;
        private System.Windows.Forms.Label lblLaboratory;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputNewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveCopiedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCopiedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyOriginalToolStripMenuItem;
    }
}

