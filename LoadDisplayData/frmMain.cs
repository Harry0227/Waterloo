using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using LoadDisplayData.DataSource;
using LoadDisplayData.DataSource.Implementations;
using LoadDisplayData.Resources;


namespace LoadDisplayData
{
    public partial class frmMain : Form
    {
        #region Public Methods
        public void SetCultureInfo(string culture)
        {
            CultureInfo myCultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;

            InitializeComponent();

            //show diferent language
            lblDataCSV.Text = CommonResource.DataCSVFile ;
            this.Text = CommonResource.LoadAndDisplayCSVData ;
            gbDisplayData.Text = CommonResource.DisplayDataCSVFile;
            cmdCSVFile.Text = CommonResource.BrowseLoadToDataGrid;
            btnRowColumnSwitch.Text = CommonResource.FullColumnSelect;
            btnReplace.Text = CommonResource.ReplaceForSelectedColumn;
            gbComboBox.Text = CommonResource.ComboBox;
            lblComboBoxCsvFile.Text = CommonResource.ComboBoxCSVFile;
            btnComboCsvFile.Text = CommonResource.BrowseLoadToComboBox;
            btnShowSelectedId.Text = CommonResource.ShowSelectedId;
            btnClose.Text = CommonResource.Close;


        }
        #endregion

        bool fullColumnSelection = false;

        public frmMain()
        {
            //InitializeComponent();
            
        }

        private void cmdCSVFile_Click(object sender, EventArgs e)
        {
            txtDataCSVFile.Text=SelectCSVFile();

            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
                     
            string path = txtDataCSVFile.Text;

            if (File.Exists(path))
            {
                var dtFromCsv = new DataGridFromCsv(path);
                dgvLoadCSVFile.DataSource = dtFromCsv.GetDataSource();
            }

        }

        private string SelectCSVFile()
        {
            string CSVFilePath;

            OFD.Filter = "CSV(*.csv)|*.csv";
            OFD.FileName = string.Empty;
            OFD.ShowDialog();
            CSVFilePath = OFD.FileName;

            return CSVFilePath;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void PopulateCombobox()
        {
            cboIDName.DataSource = null;
            cboIDName.Items.Clear();

            var filePath = txtComboCsvFile.Text;

            if (File.Exists(filePath))
            {
                var dtFromCsv = new DataComboFromCsv(filePath);
                cboIDName.DataSource = dtFromCsv.GetDataSource();
                cboIDName.DisplayMember = "Name";
                cboIDName.ValueMember = "Id";
            }
             
        }  
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            var currDir = Directory.GetCurrentDirectory();

            var dataFilePath = Path.Combine(currDir, "data.csv");

            if (File.Exists(dataFilePath))
            {
                txtDataCSVFile.Text = dataFilePath;
                DisplayData();
            }
            else
            {
                txtDataCSVFile.Text = "Browse a data CSV file to load to data view grid.";
            }


            var comboBoxFilePath = Path.Combine(currDir, "combo_example.csv");
            
            if (File.Exists(comboBoxFilePath))
            {
                txtComboCsvFile.Text = comboBoxFilePath;
                PopulateCombobox();
            }
            else
            {
                txtComboCsvFile.Text = "Browse a combo box CSV file to load to ComboBox.";
            }

        }

        private void btnShowSelectedId_Click(object sender, EventArgs e)
        {
            object selectedId;

            selectedId =cboIDName.SelectedValue;
            btnShowSelectedId.Text = $"Selected Id: {selectedId}";
        }

        private void cboIDName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShowSelectedId.Text = CommonResource.ShowSelectedId; // "Show Selected Id";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (fullColumnSelection == true)
            {
                ReplaceSelectedColumnsChar();
            }
            else
            {
                MessageBox.Show("Please set Full Column Selection first, then select some columns.");
            }
        }

        private void ReplaceSelectedColumnsChar() 
        {

            Int32 selectedCellCount =  dgvLoadCSVFile.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {


                for (int i = 0; i < selectedCellCount; i++)
                {

                    string selectedCellValue = Convert.ToString(dgvLoadCSVFile.SelectedCells[i].Value);

                    dgvLoadCSVFile.SelectedCells[i].Value = selectedCellValue.Replace("a", "@");

                }
            }
        }

        private void btnRowColumnSwitch_Click(object sender, EventArgs e)
        {
            
            if (dgvLoadCSVFile.Rows.Count>0)
            {
                if (fullColumnSelection == false)
                {


                    if (dgvLoadCSVFile.Columns.Count > 0)
                    {
                        fullColumnSelection = true;

                        foreach (DataGridViewColumn col in dgvLoadCSVFile.Columns)
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                            col.Selected = false;
                        }

                        dgvLoadCSVFile.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
                        dgvLoadCSVFile.Columns[0].Selected = true;

                        btnRowColumnSwitch.Text = "Full Row Select";
                    }

                }
                else
                {

                    fullColumnSelection = false;

                    dgvLoadCSVFile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvLoadCSVFile.Rows[0].Selected = true;

                    btnRowColumnSwitch.Text = "Full Column Select";
                }
            }
            
           
        }

        private void btnComboCsvFile_Click(object sender, EventArgs e)
        {
            txtComboCsvFile.Text = SelectCSVFile();

            PopulateCombobox();
        }

        

        
    }
 }
