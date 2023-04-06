using System.ComponentModel;
using OfficeOpenXml;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.Items.Add("95");
            this.comboBox1.Items.Add("91");

            this.comboBox2.Items.Add("95");
            this.comboBox2.Items.Add("91");

            this.comboBox3.Items.Add("rad");
            this.comboBox3.Items.Add("bule");

            this.comboBox4.Items.Add("white");
            this.comboBox4.Items.Add("black");

            read_excel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var car = this.comboBox1.SelectedItem.ToString();
            var quantity = this.textBox1.Text;
            Car newCar = new Car("Honda Civic", "1259000", quantity, car);
            var message = $"คุณสั่งชื้อ {newCar.getName()} ราคา {(Int32.Parse(newCar.getPrice()) * Int32.Parse(newCar.getQuantity()))} {newCar.getQuantity()} ชิ้น";
            MessageBox.Show(message);
            Save_to_excel(message);
            this.dataGridView1.Rows.Add(message);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bike = this.comboBox2.SelectedItem.ToString();
            var quantity = this.textBox2.Text;
            Bike newBike = new Bike("Yamaha NMAX", "917953", quantity, bike);
            var message = $"คุณสั่งชื้อ {newBike.getName()} ราคา {(Int32.Parse(newBike.getPrice()) * Int32.Parse(newBike.getQuantity()))} {newBike.getQuantity()} ชิ้น";
            MessageBox.Show(message);
            Save_to_excel(message);
            this.dataGridView1.Rows.Add(message);
        }

        private void Save_to_excel(string message)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (var package = new ExcelPackage(new FileInfo(@"E:\VS Proj\WinFormsApp7\WinFormsApp7\bin\Debug\SoBer.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                if (worksheet == null)
                {
                    throw new Exception("Worksheet does not exist");
                }
                int lastUsedRow = worksheet.Dimension.End.Row;

                ExcelRange cell = worksheet.Cells[lastUsedRow + 1, 1];
                cell.Value = message;

                package.Save();
            }
        }
        private void read_excel()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(@"E:\VS Proj\WinFormsApp7\WinFormsApp7\bin\Debug\SoBer.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int lastUsedRow = worksheet.Dimension.End.Row;
                for (int row = 1; row <= lastUsedRow; row++)
                {
                    string value = worksheet.Cells[row, 1].Value?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.dataGridView1.Rows.Add(value);
                    }
                }
            }
        }
    }
}