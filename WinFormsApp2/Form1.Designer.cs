namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox paramTextBox;
        private System.Windows.Forms.TextBox extraParamTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button addOfficeEquipButton;
        private System.Windows.Forms.Button addPrinterButton;
        private System.Windows.Forms.Button addFaxButton;
        private System.Windows.Forms.Button printButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.paramTextBox = new System.Windows.Forms.TextBox();
            this.extraParamTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.addOfficeEquipButton = new System.Windows.Forms.Button();
            this.addPrinterButton = new System.Windows.Forms.Button();
            this.addFaxButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Text = "Office Equipment Manager";

            this.modelTextBox.Location = new System.Drawing.Point(20, 20);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 22);
            this.modelTextBox.Text = "Model";
            this.modelTextBox.ForeColor = System.Drawing.Color.Blue;
            this.modelTextBox.Enter += new System.EventHandler(this.modelTextBox_Enter);
            this.modelTextBox.Leave += new System.EventHandler(this.modelTextBox_Leave);

            this.priceTextBox.Location = new System.Drawing.Point(20, 60);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.priceTextBox.Text = "Price (>0)";
            this.priceTextBox.ForeColor = System.Drawing.Color.Blue;
            this.priceTextBox.Enter += new System.EventHandler(this.priceTextBox_Enter);
            this.priceTextBox.Leave += new System.EventHandler(this.priceTextBox_Leave);

            this.paramTextBox.Location = new System.Drawing.Point(20, 100);
            this.paramTextBox.Name = "paramTextBox";
            this.paramTextBox.Size = new System.Drawing.Size(200, 22);
            this.paramTextBox.Text = "Scan Speed (1-100)";
            this.paramTextBox.ForeColor = System.Drawing.Color.Blue;
            this.paramTextBox.Enter += new System.EventHandler(this.paramTextBox_Enter);
            this.paramTextBox.Leave += new System.EventHandler(this.paramTextBox_Leave);

            this.extraParamTextBox.Location = new System.Drawing.Point(20, 140);
            this.extraParamTextBox.Name = "extraParamTextBox";
            this.extraParamTextBox.Size = new System.Drawing.Size(200, 22);
            this.extraParamTextBox.Text = "Storage/Phone Lines";
            this.extraParamTextBox.ForeColor = System.Drawing.Color.Blue;
            this.extraParamTextBox.Enter += new System.EventHandler(this.extraParamTextBox_Enter);
            this.extraParamTextBox.Leave += new System.EventHandler(this.extraParamTextBox_Leave);

            this.outputTextBox.Location = new System.Drawing.Point(240, 20);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(240, 300);
            this.outputTextBox.ReadOnly = true;

            this.addOfficeEquipButton.Location = new System.Drawing.Point(20, 180);
            this.addOfficeEquipButton.Name = "addOfficeEquipButton";
            this.addOfficeEquipButton.Size = new System.Drawing.Size(200, 30);
            this.addOfficeEquipButton.Text = "Add Office Equipment";
            this.addOfficeEquipButton.Click += new System.EventHandler(this.addOfficeEquipButton_Click);

            this.addPrinterButton.Location = new System.Drawing.Point(20, 220);
            this.addPrinterButton.Name = "addPrinterButton";
            this.addPrinterButton.Size = new System.Drawing.Size(200, 30);
            this.addPrinterButton.Text = "Add Printer";
            this.addPrinterButton.Click += new System.EventHandler(this.addPrinterButton_Click);

            this.addFaxButton.Location = new System.Drawing.Point(20, 260);
            this.addFaxButton.Name = "addFaxButton";
            this.addFaxButton.Size = new System.Drawing.Size(200, 30);
            this.addFaxButton.Text = "Add Fax";
            this.addFaxButton.Click += new System.EventHandler(this.addFaxButton_Click);

            this.printButton.Location = new System.Drawing.Point(20, 300);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(200, 30);
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);

            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.paramTextBox);
            this.Controls.Add(this.extraParamTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.addOfficeEquipButton);
            this.Controls.Add(this.addPrinterButton);
            this.Controls.Add(this.addFaxButton);
            this.Controls.Add(this.printButton);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

