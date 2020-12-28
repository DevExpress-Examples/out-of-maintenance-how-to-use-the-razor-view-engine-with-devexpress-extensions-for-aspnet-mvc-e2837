Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports RazorSupport.Models

Namespace RazorSupport.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return GridView()
		End Function
		Public Function GridView() As ActionResult
			Return View("GridView", NorthwindDataProvider.GetInvoices())
		End Function
		Public Function GridViewPartial() As ActionResult
			Return PartialView("GridViewPartial", NorthwindDataProvider.GetInvoices())
		End Function
	End Class
End Namespace
