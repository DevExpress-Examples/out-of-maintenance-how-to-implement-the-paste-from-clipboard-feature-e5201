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
    public partial class Main : DevExpress.XtraEditors.XtraForm {

        public Main() {
            InitializeComponent();
            gridControl1.DataSource = GetDataSource();

            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            gridView1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;

            gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Update;
        }

        private object GetDataSource() {
            BindingList<Record> records = new BindingList<Record>();
            for(int i = 0; i < 8; i++)
                records.Add(new Record() { ID = i.ToString(), Name = "Name" + i });
            return records;
        }
    }
}
