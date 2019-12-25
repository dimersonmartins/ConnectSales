using ConnectSales.Controllers;
using ConnectSales.Default;
using ConnectSales.Properties;
using ExcelDataReader;
using HttpNtConnect.Repository;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ConnectSales.Views.Modules
{
    public partial class ImportControl : UserControl
    {
        public ImportControl()
        {
            InitializeComponent();
        }
        private int columnIndex = 0;
        private string pathFile = Path.GetTempPath();
        private string fileNameExcel = "\\" +
           DateTime.Now.ToString()
          .Replace("-", "")
          .Replace(":", "")
          .Replace("/", "")
          .Replace(" ", "") + ".csv";

        DataGridViewTextBoxColumn statusNetsales = new DataGridViewTextBoxColumn();
        private void btnImportar_Click(object sender, EventArgs e)
        {
            statusNetsales.HeaderText = "";
            statusNetsales.Name = "STATUS_NETSALES";
            statusNetsales.Width = 150;
            statusNetsales.Visible = false;

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Excel (*.xls)|*.xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
              
                            try
                            {
                                dataView.Columns.RemoveAt(0);
                                dataView.Rows.Clear();
                            }
                            catch { }

                            dataView.Columns.Add(statusNetsales);
                            var data = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                // Gets or sets a value indicating whether to set the DataColumn.DataType 
                                // property in a second pass.
                                UseColumnDataType = true,

                                // Gets or sets a callback to determine whether to include the current sheet
                                // in the DataSet. Called once per sheet before ConfigureDataTable.
                                FilterSheet = (tableReader, sheetIndex) => true,

                                // Gets or sets a callback to obtain configuration options for a DataTable. 
                                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                                {
                                    // Gets or sets a value indicating the prefix of generated column names.
                                    EmptyColumnNamePrefix = "",

                                    // Gets or sets a value indicating whether to use a row from the 
                                    // data as column names.
                                    UseHeaderRow = false,

                                    // Gets or sets a callback to determine which row is the header row. 
                                    // Only called when UseHeaderRow = true.
                                    ReadHeaderRow = (rowReader) => {
                                        // F.ex skip the first row and use the 2nd row as column headers:
                                        rowReader.Read();
                                    },

                                    // Gets or sets a callback to determine whether to include the 
                                    // current row in the DataTable.
                                    FilterRow = (rowReader) => {
                                        return true;
                                    },

                                    // Gets or sets a callback to determine whether to include the specific
                                    // column in the DataTable. Called once per column after reading the 
                                    // headers.
                                    FilterColumn = (rowReader, columnIndex) => {
                                        return true;
                                    }
                                }
                            }).Tables[0];
                            dataView.DataSource = data;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            columnIndex = dataView.CurrentCell.ColumnIndex;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Manager netSalesManager = new Manager();
                netSalesManager.totalParams = countParams();

                int indexColumn = dataView.Columns.Count;
                if (await netSalesManager.connect(Settings.Default["user"].ToString(), Settings.Default["password"].ToString()))
                {
                    StausController stausController = new StausController();
                    stausController.ClearAll();
                    statusNetsales.Visible = true;
                    int index = columnIndex;

                    for (int i = 0; i < dataView.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            dataView[0, i].Value = "STATUS_NETSALES";
                            continue;
                        }
                        string contrato = dataView.Rows[i].Cells[index].Value.ToString();
                        string status = await netSalesManager.consultaContrato(contrato);
                        stausController.CONTRATO = contrato;
                        stausController.STATUS = status;
                        stausController.save();
                        dataView[0, i].Value = status;
                    }
                    btnExport.Visible = true;
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro no login, Por favor tente novamente!", Config.AplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void export()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < dataView.Rows.Count; i++)
            {
                for (int k = 0; k < dataView.Columns.Count; k++)
                {
                    sb.Append(dataView.Rows[i].Cells[k].Value.ToString().Replace("\r", " ").Replace("\n", " ") + ";");
                }
                sb.AppendLine();
            }
            File.WriteAllText(pathFile + fileNameExcel, sb.ToString());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                export();
                Process process = new Process();
                process.StartInfo.FileName = pathFile + fileNameExcel;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int countParams()
        {
            int total = 0;
            if (!string.IsNullOrWhiteSpace(Settings.Default["paramDb1"].ToString())
                && !string.IsNullOrWhiteSpace(Settings.Default["dbaseState1"].ToString()) 
                && !string.IsNullOrWhiteSpace(Settings.Default["dbaseCity1"].ToString()))
            {
                total = 1;
            }

            if (!string.IsNullOrWhiteSpace(Settings.Default["paramDb2"].ToString())
                && !string.IsNullOrWhiteSpace(Settings.Default["dbaseState2"].ToString()) 
                && !string.IsNullOrWhiteSpace(Settings.Default["dbaseCity2"].ToString()))
            {
                total = 2;
            }

            if (!string.IsNullOrWhiteSpace(Settings.Default["paramDb3"].ToString())
                && !string.IsNullOrWhiteSpace(Settings.Default["dbaseState3"].ToString()) 
                && !string.IsNullOrWhiteSpace(Settings.Default["dbaseCity3"].ToString()))
            {
                total = 3;
            }

            return total;
        }
    }
}
