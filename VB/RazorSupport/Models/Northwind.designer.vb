﻿Imports System
Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Linq
Imports System.Reflection
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Linq.Mapping
Imports System.Data.Linq

#Disable Warning BC1591
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace RazorSupport.Models


	<System.Data.Linq.Mapping.DatabaseAttribute(Name:="Northwind")>
	Partial Public Class NorthwindDataContext
		Inherits System.Data.Linq.DataContext

		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnCreated()
	End Sub
	#End Region

		Public Sub New()
			MyBase.New(System.Configuration.ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public ReadOnly Property Invoices() As System.Data.Linq.Table(Of Invoice)
			Get
				Return Me.GetTable(Of Invoice)()
			End Get
		End Property
	End Class

	<System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Invoices")>
	Partial Public Class Invoice

		Private _ShipName As String

		Private _ShipAddress As String

		Private _ShipCity As String

		Private _ShipRegion As String

		Private _ShipPostalCode As String

		Private _ShipCountry As String

		Private _CustomerID As String

		Private _CustomerName As String

		Private _Address As String

		Private _City As String

		Private _Region As String

		Private _PostalCode As String

		Private _Country As String

		Private _Salesperson As String

		Private _OrderID As Integer

		Private _OrderDate? As DateTime

		Private _RequiredDate? As DateTime

		Private _ShippedDate? As DateTime

		Private _ShipperName As String

		Private _ProductID As Integer

		Private _ProductName As String

		Private _UnitPrice As Decimal

		Private _Quantity As Short

		Private _Discount As Single

		Private _ExtendedPrice? As Decimal

		Private _Freight? As Decimal

		Public Sub New()
		End Sub

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipName", DbType:="NVarChar(40)")>
		Public Property ShipName() As String
			Get
				Return Me._ShipName
			End Get
			Set(ByVal value As String)
				If (Me._ShipName <> value) Then
					Me._ShipName = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipAddress", DbType:="NVarChar(60)")>
		Public Property ShipAddress() As String
			Get
				Return Me._ShipAddress
			End Get
			Set(ByVal value As String)
				If (Me._ShipAddress <> value) Then
					Me._ShipAddress = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipCity", DbType:="NVarChar(15)")>
		Public Property ShipCity() As String
			Get
				Return Me._ShipCity
			End Get
			Set(ByVal value As String)
				If (Me._ShipCity <> value) Then
					Me._ShipCity = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipRegion", DbType:="NVarChar(15)")>
		Public Property ShipRegion() As String
			Get
				Return Me._ShipRegion
			End Get
			Set(ByVal value As String)
				If (Me._ShipRegion <> value) Then
					Me._ShipRegion = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipPostalCode", DbType:="NVarChar(10)")>
		Public Property ShipPostalCode() As String
			Get
				Return Me._ShipPostalCode
			End Get
			Set(ByVal value As String)
				If (Me._ShipPostalCode <> value) Then
					Me._ShipPostalCode = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipCountry", DbType:="NVarChar(15)")>
		Public Property ShipCountry() As String
			Get
				Return Me._ShipCountry
			End Get
			Set(ByVal value As String)
				If (Me._ShipCountry <> value) Then
					Me._ShipCountry = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerID", DbType:="NChar(5)")>
		Public Property CustomerID() As String
			Get
				Return Me._CustomerID
			End Get
			Set(ByVal value As String)
				If (Me._CustomerID <> value) Then
					Me._CustomerID = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=False)>
		Public Property CustomerName() As String
			Get
				Return Me._CustomerName
			End Get
			Set(ByVal value As String)
				If (Me._CustomerName <> value) Then
					Me._CustomerName = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(60)")>
		Public Property Address() As String
			Get
				Return Me._Address
			End Get
			Set(ByVal value As String)
				If (Me._Address <> value) Then
					Me._Address = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="NVarChar(15)")>
		Public Property City() As String
			Get
				Return Me._City
			End Get
			Set(ByVal value As String)
				If (Me._City <> value) Then
					Me._City = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Region", DbType:="NVarChar(15)")>
		Public Property Region() As String
			Get
				Return Me._Region
			End Get
			Set(ByVal value As String)
				If (Me._Region <> value) Then
					Me._Region = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PostalCode", DbType:="NVarChar(10)")>
		Public Property PostalCode() As String
			Get
				Return Me._PostalCode
			End Get
			Set(ByVal value As String)
				If (Me._PostalCode <> value) Then
					Me._PostalCode = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="NVarChar(15)")>
		Public Property Country() As String
			Get
				Return Me._Country
			End Get
			Set(ByVal value As String)
				If (Me._Country <> value) Then
					Me._Country = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Salesperson", DbType:="NVarChar(31) NOT NULL", CanBeNull:=False)>
		Public Property Salesperson() As String
			Get
				Return Me._Salesperson
			End Get
			Set(ByVal value As String)
				If (Me._Salesperson <> value) Then
					Me._Salesperson = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderID", DbType:="Int NOT NULL")>
		Public Property OrderID() As Integer
			Get
				Return Me._OrderID
			End Get
			Set(ByVal value As Integer)
				If (Me._OrderID <> value) Then
					Me._OrderID = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderDate", DbType:="DateTime")>
		Public Property OrderDate() As DateTime?
			Get
				Return Me._OrderDate
			End Get
			Set(ByVal value? As DateTime)
				If (Not Me._OrderDate.Equals(value)) Then
					Me._OrderDate = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RequiredDate", DbType:="DateTime")>
		Public Property RequiredDate() As DateTime?
			Get
				Return Me._RequiredDate
			End Get
			Set(ByVal value? As DateTime)
				If (Not Me._RequiredDate.Equals(value)) Then
					Me._RequiredDate = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShippedDate", DbType:="DateTime")>
		Public Property ShippedDate() As DateTime?
			Get
				Return Me._ShippedDate
			End Get
			Set(ByVal value? As DateTime)
				If (Not Me._ShippedDate.Equals(value)) Then
					Me._ShippedDate = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipperName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=False)>
		Public Property ShipperName() As String
			Get
				Return Me._ShipperName
			End Get
			Set(ByVal value As String)
				If (Me._ShipperName <> value) Then
					Me._ShipperName = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductID", DbType:="Int NOT NULL")>
		Public Property ProductID() As Integer
			Get
				Return Me._ProductID
			End Get
			Set(ByVal value As Integer)
				If (Me._ProductID <> value) Then
					Me._ProductID = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=False)>
		Public Property ProductName() As String
			Get
				Return Me._ProductName
			End Get
			Set(ByVal value As String)
				If (Me._ProductName <> value) Then
					Me._ProductName = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UnitPrice", DbType:="SmallMoney NOT NULL")>
		Public Property UnitPrice() As Decimal
			Get
				Return Me._UnitPrice
			End Get
			Set(ByVal value As Decimal)
				If (Me._UnitPrice <> value) Then
					Me._UnitPrice = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Quantity", DbType:="SmallInt NOT NULL")>
		Public Property Quantity() As Short
			Get
				Return Me._Quantity
			End Get
			Set(ByVal value As Short)
				If (Me._Quantity <> value) Then
					Me._Quantity = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Discount", DbType:="Real NOT NULL")>
		Public Property Discount() As Single
			Get
				Return Me._Discount
			End Get
			Set(ByVal value As Single)
				If (Me._Discount <> value) Then
					Me._Discount = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ExtendedPrice", DbType:="SmallMoney")>
		Public Property ExtendedPrice() As Decimal?
			Get
				Return Me._ExtendedPrice
			End Get
			Set(ByVal value? As Decimal)
				If (Not Me._ExtendedPrice.Equals(value)) Then
					Me._ExtendedPrice = value
				End If
			End Set
		End Property

		<System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Freight", DbType:="SmallMoney")>
		Public Property Freight() As Decimal?
			Get
				Return Me._Freight
			End Get
			Set(ByVal value? As Decimal)
				If (Not Me._Freight.Equals(value)) Then
					Me._Freight = value
				End If
			End Set
		End Property
	End Class
End Namespace
#Enable Warning BC1591
