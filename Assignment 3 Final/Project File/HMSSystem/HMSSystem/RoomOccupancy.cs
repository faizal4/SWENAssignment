using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Reflection;
using ClosedXML.Excel;

namespace HMSSystem
{
    public partial class RoomOccupancy : Form
    {
        public RoomOccupancy()
        {
            InitializeComponent();
        }

        private void buttonWeek_Click(object sender, EventArgs e)
        {
            RODate newDate = new RODate();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            newDate.StartDate = "'" + dateTimePicker1.Value.ToShortDateString() + "'";
            dataGridView1.DataSource = RODatabase.GetAllWeek(newDate);
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {

            RODate newDate = new RODate();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            newDate.StartDate = "'" + dateTimePicker1.Value.ToShortDateString() + "'";
            dataGridView1.DataSource = RODatabase.GetAllMonth(newDate);

        }

        private void buttonYear_Click(object sender, EventArgs e)
        {

            RODate newDate = new RODate();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            newDate.StartDate = "'" + dateTimePicker1.Value.ToShortDateString() + "'";
            dataGridView1.DataSource = RODatabase.GetAllYear(newDate);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RODate newDate = new RODate();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            newDate.StartDate = "'" + dateTimePicker1.Value.ToShortDateString() + "'";
        }
        Bitmap bitmap;
        private void button2_Click(object sender, EventArgs e)
        {

            int height = dataGridView1.Height;
            dataGridView1.Height = (dataGridView1.RowCount + 1) * dataGridView1.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            //Resize DataGridView back to original height.
            dataGridView1.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnExportExcel_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //Adding the Columns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            //Exporting to Excel
            string folderPath = "C:\\Users\\Mohamed\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Statistics");
                wb.SaveAs(folderPath + "RoomOccupancyExport.xlsx");
            }
            label2.Visible = true;
        }

    }
}
