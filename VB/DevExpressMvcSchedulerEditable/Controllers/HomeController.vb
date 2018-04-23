Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports DevExpressMvcSchedulerEditable.Models

Namespace DevExpressMvcSchedulerEditable.Views
	Public Class HomeController
		Inherits Controller
		'
		' GET: /Home/

		Public Function Index() As ActionResult
			Return View(SchedulerDataHelper.DataObject)
		End Function

		Public Function SchedulerPartial() As ActionResult
			Return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject)
		End Function

		Public Function EditAppointment() As ActionResult
			UpdateAppointment()
			Return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject)
		End Function
		#Region "#updateappointment"
		Private Shared Sub UpdateAppointment()
			Dim insertedAppt As DBAppointment = SchedulerExtension.GetAppointmentToInsert(Of DBAppointment)(SchedulerSettingsHelper.CommonSchedulerSettings, SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources())
			SchedulerDataHelper.InsertAppointment(insertedAppt)

			Dim updatedAppt() As DBAppointment = SchedulerExtension.GetAppointmentsToUpdate(Of DBAppointment)(SchedulerSettingsHelper.CommonSchedulerSettings, SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources())
			For Each appt In updatedAppt
				SchedulerDataHelper.UpdateAppointment(appt)
			Next appt

			Dim removedAppt() As DBAppointment = SchedulerExtension.GetAppointmentsToRemove(Of DBAppointment)(SchedulerSettingsHelper.CommonSchedulerSettings, SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources())
			For Each appt In removedAppt
				SchedulerDataHelper.RemoveAppointment(appt)
			Next appt
		End Sub
		#End Region ' #updateappointment
	End Class
End Namespace
