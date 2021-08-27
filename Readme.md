<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128553847/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3997)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DevExpressMvcSchedulerEditable/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DevExpressMvcSchedulerEditable/Controllers/HomeController.vb))
* [SchedulerSettingsHelper.cs](./CS/DevExpressMvcSchedulerEditable/Helpers/SchedulerSettingsHelper.cs) (VB: [SchedulerSettingsHelper.vb](./VB/DevExpressMvcSchedulerEditable/Helpers/SchedulerSettingsHelper.vb))
* [Scheduling.cs](./CS/DevExpressMvcSchedulerEditable/Models/Scheduling.cs) (VB: [Scheduling.vb](./VB/DevExpressMvcSchedulerEditable/Models/Scheduling.vb))
* [Index.cshtml](./CS/DevExpressMvcSchedulerEditable/Views/Home/Index.cshtml)
* [SchedulerPartial.cshtml](./CS/DevExpressMvcSchedulerEditable/Views/Home/SchedulerPartial.cshtml)
<!-- default file list end -->
# Scheduler - Lesson 3 - How to Use Scheduler in complex views


<p>When a Scheduler view is customized in a way more complex than just specifying the start date or decorating web element styles, you should pass the Scheduler settings to the corresponding overloads of the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcSchedulerExtension_GetAppointmentToInsert[T]topic"><u>SchedulerExtension.GetAppointmentToInsert<T></u></a>, the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcSchedulerExtension_GetAppointmentsToUpdate[T]topic"><u>SchedulerExtension.GetAppointmentsToUpdate<T></u></a> and the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcSchedulerExtension_GetAppointmentsToRemove[T]topic"><u>SchedulerExtension.GetAppointmentsToRemove<T></u></a> methods. Otherwise appointment display and operations may perform incorrectly.</p><p>This approach requires that the <a href="https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.SchedulerSettings"><u>SchedulerSettings</u></a> object is instantiated on server side and passed to the controller and to the view. So a special helper class <i>SchedulerSettingsHelper</i> is implemented that provides required settings for views and controllers within the application. </p><p></p><p></p>

<br/>


