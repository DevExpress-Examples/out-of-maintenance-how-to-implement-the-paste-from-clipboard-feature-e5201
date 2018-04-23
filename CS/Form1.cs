using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E5201_CS {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        private string ClipboardData {
            get {
                IDataObject iData = Clipboard.GetDataObject();
                if(iData == null) return "";

                if(iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        public Form1() {
            InitializeComponent();
            gridControl1.DataSource = GetDataSource();

            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;

            gridControl1.ProcessGridKey += gridControl1_ProcessGridKey;
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e) {
            if(e.Control && e.KeyCode == Keys.V) {
                string[] data = ClipboardData.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if(data.Length < 1) return;
                int startRow = gridView1.FocusedRowHandle;
                foreach(string row in data) {
                    AddRow(row, startRow++);
                    if(!gridView1.IsValidRowHandle(startRow)) break;
                }
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void AddRow(string data, int rowHandle) {
            if(data == string.Empty) return;
            string[] rowData = data.Split('\t');
            int column = gridView1.FocusedColumn.VisibleIndex;
            for(int i = 0; i < rowData.Length; i++) {
                if(i >= gridView1.VisibleColumns.Count) break;
                gridView1.SetRowCellValue(rowHandle, gridView1.VisibleColumns[column + i], rowData[i]);
            }
        }

        private object GetDataSource() {
            BindingList<Record> records = new BindingList<Record>();
            for(int i = 0; i < 8; i++)
                records.Add(new Record() { ID = i.ToString(), Name = "Name" + i });
            return records;
        }
    }
}
