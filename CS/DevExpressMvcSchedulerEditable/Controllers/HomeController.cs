using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpressMvcSchedulerEditable.Models;

namespace DevExpressMvcSchedulerEditable.Views {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Index() {
            return View(SchedulerDataHelper.DataObject);
        }

        public ActionResult SchedulerPartial() {
            return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject);
        }

        public ActionResult EditAppointment() {
            UpdateAppointment();
            return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject);
        }
        #region #updateappointment
        static void UpdateAppointment() {
            DBAppointment insertedAppt = SchedulerExtension.GetAppointmentToInsert<DBAppointment>(SchedulerSettingsHelper.CommonSchedulerSettings,
                SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources());
            SchedulerDataHelper.InsertAppointment(insertedAppt);

            DBAppointment[] updatedAppt = SchedulerExtension.GetAppointmentsToUpdate<DBAppointment>(SchedulerSettingsHelper.CommonSchedulerSettings,
                SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources());
            foreach (var appt in updatedAppt) {
                SchedulerDataHelper.UpdateAppointment(appt);
            }

            DBAppointment[] removedAppt = SchedulerExtension.GetAppointmentsToRemove<DBAppointment>(SchedulerSettingsHelper.CommonSchedulerSettings,
                SchedulerDataHelper.GetAppointments(), SchedulerDataHelper.GetResources());
            foreach (var appt in removedAppt) {
                SchedulerDataHelper.RemoveAppointment(appt);
            }
        }
        #endregion #updateappointment
    }
}
