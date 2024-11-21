using System.Windows.Forms;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<OfficeEquip> officeEquipments = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void addOfficeEquipButton_Click(object sender, EventArgs e)
        {
            try
            {
                string model = modelTextBox.Text == "Model" ? string.Empty : modelTextBox.Text;
                int price = int.Parse(priceTextBox.Text);
                int scanSpeed = int.Parse(paramTextBox.Text);

                officeEquipments.Add(new OfficeEquip(model, price, scanSpeed));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addPrinterButton_Click(object sender, EventArgs e)
        {
            try
            {
                string model = modelTextBox.Text == "Model" ? string.Empty : modelTextBox.Text;
                int price = int.Parse(priceTextBox.Text);
                int scanSpeed = int.Parse(paramTextBox.Text);
                int storage = int.Parse(extraParamTextBox.Text);

                officeEquipments.Add(new Printer(model, price, scanSpeed, storage));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addFaxButton_Click(object sender, EventArgs e)
        {
            try
            {
                string model = modelTextBox.Text == "Model" ? string.Empty : modelTextBox.Text;
                int price = int.Parse(priceTextBox.Text);
                int scanSpeed = int.Parse(paramTextBox.Text);
                int phoneLines = int.Parse(extraParamTextBox.Text);

                officeEquipments.Add(new Fax(model, price, scanSpeed, phoneLines));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = string.Empty;
            foreach (var item in officeEquipments)
            {
                outputTextBox.Text += item.ToString() + "\r\n";
            }
        }

        private void modelTextBox_Enter(object sender, EventArgs e)
        {
            if (modelTextBox.Text == "Model")
            {
                modelTextBox.Clear();
                modelTextBox.ForeColor = Color.Black;
            }
        }

        private void modelTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modelTextBox.Text))
            {
                modelTextBox.Text = "Model";
                modelTextBox.ForeColor = Color.Blue;
            }
        }

        private void priceTextBox_Enter(object sender, EventArgs e)
        {
            if (priceTextBox.Text == "Price (>0)")
            {
                priceTextBox.Clear();
                priceTextBox.ForeColor = Color.Black;
            }
        }

        private void priceTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(priceTextBox.Text))
            {
                priceTextBox.Text = "Price (>0)";
                priceTextBox.ForeColor = Color.Blue;
            }
        }

        private void paramTextBox_Enter(object sender, EventArgs e)
        {
            if (paramTextBox.Text == "Scan Speed (1-100)")
            {
                paramTextBox.Clear();
                paramTextBox.ForeColor = Color.Black;
            }
        }

        private void paramTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(paramTextBox.Text))
            {
                paramTextBox.Text = "Scan Speed (1-100)";
                paramTextBox.ForeColor = Color.Blue;
            }
        }

        private void extraParamTextBox_Enter(object sender, EventArgs e)
        {
            if (extraParamTextBox.Text == "Storage/Phone Lines")
            {
                extraParamTextBox.Clear();
                extraParamTextBox.ForeColor = Color.Black;
            }
        }

        private void extraParamTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(extraParamTextBox.Text))
            {
                extraParamTextBox.Text = "Storage/Phone Lines";
                extraParamTextBox.ForeColor = Color.Blue;
            }
        }
    }
}

