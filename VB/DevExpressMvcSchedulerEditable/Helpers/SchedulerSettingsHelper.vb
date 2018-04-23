Imports Microsoft.VisualBasic
Imports DevExpress.Web.Mvc
Imports DevExpress.Web.ASPxScheduler
Imports System
Imports DevExpress.XtraScheduler

#Region "#schedulersettingshelper"
Public Class SchedulerSettingsHelper

	Private Shared commonSchedulerSettings_Renamed As SchedulerSettings
	Public Shared ReadOnly Property CommonSchedulerSettings() As SchedulerSettings
		Get
			If commonSchedulerSettings_Renamed Is Nothing Then
				commonSchedulerSettings_Renamed = CreateSchedulerSettings()
			End If
			Return commonSchedulerSettings_Renamed
		End Get
	End Property
	Private Shared Function CreateSchedulerSettings() As SchedulerSettings
		Dim settings As New SchedulerSettings()
		settings.Name = "scheduler"
		settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "SchedulerPartial"}
		settings.EditAppointmentRouteValues = New With {Key .Controller = "Home", Key .Action = "EditAppointment"}

		settings.Storage.Appointments.Assign(SchedulerDataHelper.DefaultAppointmentStorage)
		settings.Storage.Resources.Assign(SchedulerDataHelper.DefaultResourceStorage)

		settings.Width = 300
		settings.Views.WeekView.Styles.DateCellBody.Height = 50
		settings.Views.MonthView.CellAutoHeightOptions.Mode = AutoHeightMode.FitToContent
		settings.Views.MonthView.AppointmentDisplayOptions.AppointmentAutoHeight = True
		settings.Views.MonthView.AppointmentDisplayOptions.TimeDisplayType = AppointmentTimeDisplayType.Clock
		settings.Views.DayView.Styles.ScrollAreaHeight = 250
		settings.Views.DayView.ShowWorkTimeOnly = True
		settings.Views.DayView.DayCount = 2
		settings.Start = New DateTime(2012, 5, 9)
		settings.ActiveViewType = SchedulerViewType.Day

		Return settings
	End Function
End Class
#End Region ' #schedulersettingshelper