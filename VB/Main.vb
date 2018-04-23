Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace E5201_CS
    Partial Public Class Main
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = GetDataSource()

            gridView1.OptionsSelection.MultiSelect = True
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect
            gridView1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False

            gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Update
        End Sub

        Private Function GetDataSource() As Object
            Dim records As New BindingList(Of Record)()
            For i As Integer = 0 To 7
                records.Add(New Record() With { _
                    .ID = i.ToString(), _
                    .Name = "Name" & i _
                })
            Next i
            Return records
        End Function
    End Class
End Namespace
