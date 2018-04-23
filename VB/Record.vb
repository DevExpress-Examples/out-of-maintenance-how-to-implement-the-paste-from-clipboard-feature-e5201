Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace E5201_CS
	Public Class Record
		Private id_Renamed As String
		Private name_Renamed As String

		Public Property ID() As String
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As String)
				id_Renamed = value
			End Set
		End Property

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
	End Class
End Namespace
