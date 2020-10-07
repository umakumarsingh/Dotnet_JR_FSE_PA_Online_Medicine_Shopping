using OnlineMedicineShopping.BusinessLayer.Interfaces;
using OnlineMedicineShopping.BusinessLayer.Services.Repository;
using OnlineMedicineShopping.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMedicineShopping.BusinessLayer.Services
{
    public class MedicineServices : IMedicineServices
    {
        /// <summary>
        /// Creating referance variable of IMedicineRepository and injecting in MedicineServices constructor
        /// </summary>
        private readonly IMedicineRepository _mediRepository;
        public MedicineServices(IMedicineRepository medicineRepository)
        {
            _mediRepository = medicineRepository;
        }
        /// <summary>
        /// Get List of Medicine Category from InMemeoryDb
        /// </summary>
        /// <returns></returns>
        public IList<Category> CatList()
        {
            var catlist = _mediRepository.CatList();
            return catlist;
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Get list of doctor and show on dropdownlist while appointment booking with doctor
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Doctor> Doctor()
        {
            var doctor = _mediRepository.Doctor();
            return doctor;
        }
        /// <summary>
        /// Book a doctor appointment and save data in appointment Table
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> DoctorAppointment(Appointment appointment)
        {
            var appoint = await _mediRepository.DoctorAppointment(appointment);
            return appoint;
        }
        /// <summary>
        /// Get all doctor list from InMemoryDb and show doctor list
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Doctor>> GetAllDoctor()
        {
            var doctor = await _mediRepository.GetAllDoctor();
            return doctor;
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Get all medicine and show on web home page for shoppers, and show medicine with medicine category id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Medicine>> GetAllMedicine(int? id)
        {
            var medi = await _mediRepository.GetAllMedicine(id);
            return medi;
        }
        /// <summary>
        /// Get appointment details for user
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<Appointment> GetAppointmentById(int appointmentId)
        {
            var appointment = await _mediRepository.GetAppointmentById(appointmentId);
            return appointment;
        }
        /// <summary>
        /// Get medicine by Medicine Id from InMemoryDb
        /// </summary>
        /// <param name="medicineId"></param>
        /// <returns></returns>
        public async Task<Medicine> GetMedicineById(int medicineId)
        {
            var medi = await _mediRepository.GetMedicineById(medicineId);
            return medi;
        }
        /// <summary>
        /// Get medicine by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Medicine>> MedicineByName(string name)
        {
            var mediname = await _mediRepository.MedicineByName(name);
            return mediname;
        }
        /// <summary>
        /// Get order infromation of medicine order
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public Task<IEnumerable<MedicineOrder>> OrderByuserId(int UserId)
        {
            var order = _mediRepository.OrderByuserId(UserId);
            return order;
        }
        /// <summary>
        /// Place medicine order and save user address as well
        /// </summary>
        /// <param name="medicineId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> PlaceOrder(int medicineId, ApplicationUser user)
        {
            var placeorder = await _mediRepository.PlaceOrder(medicineId, user);
            return placeorder;
        }
    }
}
