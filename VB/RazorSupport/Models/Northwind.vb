Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Collections

Namespace RazorSupport.Models
	Public Module NorthwindDataProvider
'INSTANT VB NOTE: The field db was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private db_Conflict As NorthwindDataContext
		Public ReadOnly Property DB() As NorthwindDataContext
			Get
				If db_Conflict Is Nothing Then
					db_Conflict = New NorthwindDataContext()
				End If
				Return db_Conflict
			End Get
		End Property
		Public Function GetInvoices() As IEnumerable
			Return From invoice In DB.Invoices
				Select invoice
		End Function
	End Module
End Namespace