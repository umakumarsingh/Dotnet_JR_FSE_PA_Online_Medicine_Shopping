using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineMedicineShopping.BusinessLayer.Interfaces;
using OnlineMedicineShopping.BusinessLayer.ViewModels;
using OnlineMedicineShopping.Entities;

namespace OnlineMedicineShopping.Controllers
{
    public class MedicineController : Controller
    {
        /// <summary>
        /// Creating Referance variable of IMedicineServices and injecting in MedicineController constructor
        /// </summary>
        private readonly IMedicineServices _medicineServices;
        public MedicineController(IMedicineServices medicineServices)
        {
            _medicineServices = medicineServices;
        }
        /// <summary>
        /// Get all Medicine, serach medicine by name and show medicine by category Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(int? id, string search, int page = 1)
        {
            if (search != null)
            {
                var intView = new MedicineViewModel
                {
                    MedicinePerPage = 5,
                    Medicines = await _medicineServices.MedicineByName(search),
                    CurrentPage = page
                };
                return View(intView);
            }
            else
            {
                var intView = new MedicineViewModel
                {
                    MedicinePerPage = 5,
                    Medicines = await _medicineServices.GetAllMedicine(id),
                    CurrentPage = page
                };
                return View(intView);
            }
        }
        /// <summary>
        /// Get Medicine Details after click ondetails link
        /// </summary>
        /// <param name="MedicineId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int MedicineId)
        {
            var medicine = await _medicineServices.GetMedicineById(MedicineId);
            return View(medicine);
        }
        /// <summary>
        /// Place order for new medicine get method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Placeorder()
        {
            return View();
        }
        /// <summary>
        /// Place order by medicine id
        /// </summary>
        /// <param name="MedicineId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Placeorder(int MedicineId, ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser users = new ApplicationUser
                {
                    Name = user.Name,
                    Email = user.Email,
                    MobileNumber = user.MobileNumber,
                    PinCode = user.PinCode,
                    HouseNo_Building_Name = user.HouseNo_Building_Name,
                    Road_area = user.Road_area,
                    City = user.City,
                    State = user.State
                };
                var result = await _medicineServices.PlaceOrder(MedicineId, users);
                return RedirectToAction("OrderInfo", "Medicine", new { userId = result.UserId });
            }
            return View();
        }
        /// <summary>
        /// Used for show order info
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> OrderInfo(int userId)
        {
            var order = await _medicineServices.OrderByuserId(userId);
            return View(order);
        }
        /// <summary>
        /// Book a doctor appointment
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DoctorAppointment()
        {
            var viewModel = new AppointmentViewModel
            {
                Doctors = _medicineServices.Doctor()
            };
            return View(viewModel);
        }
        /// <summary>
        /// Book a doctor appointment
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> DoctorAppointment(AppointmentViewModel appointment)
        {
            if (ModelState.IsValid)
            {
                Appointment patient = new Appointment
                {
                    PatientName = appointment.PatientName,
                    DoctorName = appointment.DoctorName,
                    Takendate = appointment.Takendate,
                    Symtoms = appointment.Symtoms,
                    PatientAge = appointment.PatientAge,
                    Remark = appointment.Remark
                };
                await _medicineServices.DoctorAppointment(patient);
                ViewBag.DoctorId = new SelectList(_medicineServices.Doctor(), "DoctorId", "Name", appointment.DoctorId);
                return RedirectToAction("AppointmentInfo", "Medicine", new { AppointmentId = patient.AppointmentId });
            }
            return View();
        }
        /// <summary>
        /// Show appointment setails after appointment booking is complete
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AppointmentInfo(int appointmentId)
        {
            var appointment = await _medicineServices.GetAppointmentById(appointmentId);
            return View(appointment);
        }
    }
}
