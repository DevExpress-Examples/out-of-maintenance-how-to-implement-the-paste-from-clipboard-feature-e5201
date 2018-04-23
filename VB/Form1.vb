Imports Microsoft.VisualBasic
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
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm
		Private Property ClipboardData() As String
			Get
				Dim iData As IDataObject = Clipboard.GetDataObject()
				If iData Is Nothing Then
					Return ""
				End If

				If iData.GetDataPresent(DataFormats.Text) Then
					Return CStr(iData.GetData(DataFormats.Text))
				End If
				Return ""
			End Get
			Set(ByVal value As String)
				Clipboard.SetDataObject(value)
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = GetDataSource()

			gridView1.OptionsSelection.MultiSelect = True
			gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect
			gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = False

			AddHandler gridControl1.ProcessGridKey, AddressOf gridControl1_ProcessGridKey
		End Sub

		Private Sub gridControl1_ProcessGridKey(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.Control AndAlso e.KeyCode = Keys.V Then
				Dim data() As String = ClipboardData.Split(New Char() { ControlChars.Cr, ControlChars.Lf }, StringSplitOptions.RemoveEmptyEntries)
				If data.Length < 1 Then
					Return
				End If
				Dim startRow As Integer = gridView1.FocusedRowHandle
				For Each row As String In data
					AddRow(row, startRow)
					startRow += 1
					If (Not gridView1.IsValidRowHandle(startRow)) Then
						Exit For
					End If
				Next row
				e.SuppressKeyPress = True
				e.Handled = True
			End If
		End Sub

		Private Sub AddRow(ByVal data As String, ByVal rowHandle As Integer)
			If data = String.Empty Then
				Return
			End If
			Dim rowData() As String = data.Split(ControlChars.Tab)
			Dim column As Integer = gridView1.FocusedColumn.VisibleIndex
			For i As Integer = 0 To rowData.Length - 1
				If i >= gridView1.VisibleColumns.Count Then
					Exit For
				End If
				gridView1.SetRowCellValue(rowHandle, gridView1.VisibleColumns(column + i), rowData(i))
			Next i
		End Sub

		Private Function GetDataSource() As Object
			Dim records As New BindingList(Of Record)()
			For i As Integer = 0 To 7
				records.Add(New Record() With {.ID = i.ToString(), .Name = "Name" & i})
			Next i
			Return records
		End Function
	End Class
End Namespace
