# Scheduler - Lesson 3 - How to Use Scheduler in complex views


<p>When a Scheduler view is customized in a way more complex than just specifying the start date or decorating web element styles, you should pass the Scheduler settings to the corresponding overloads of the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcSchedulerExtension_GetAppointmentToInsert[T]topic"><u>SchedulerExtension.GetAppointmentToInsert<T></u></a>, the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcSchedulerExtension_GetAppointmentsToUpdate[T]topic"><u>SchedulerExtension.GetAppointmentsToUpdate<T></u></a> and the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcSchedulerExtension_GetAppointmentsToRemove[T]topic"><u>SchedulerExtension.GetAppointmentsToRemove<T></u></a> methods. Otherwise appointment display and operations may perform incorrectly.</p><p>This approach requires that the <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebMvcSchedulerSettingstopic"><u>SchedulerSettings</u></a> object is instantiated on server side and passed to the controller and to the view. So a special helper class <i>SchedulerSettingsHelper</i> is implemented that provides required settings for views and controllers within the application. </p><p></p><p></p>

<br/>


