using Moq;
using OnlineMedicineShopping.BusinessLayer.Interfaces;
using OnlineMedicineShopping.BusinessLayer.Services;
using OnlineMedicineShopping.BusinessLayer.Services.Repository;
using OnlineMedicineShopping.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OnlineMedicineShopping.Test.TestCases
{
    public class ExceptionalTest
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IMedicineServices _medicineServices;
        public readonly Mock<IMedicineRepository> service = new Mock<IMedicineRepository>();
        private readonly Medicine _medicine;
        private readonly Category _category;
        private readonly ApplicationUser _user;
        private readonly MedicineOrder _order;
        private readonly Appointment _appointment;
        private readonly Doctor _doctor;
        public ExceptionalTest()
        {
            //Creating New mock Object with value.
            _medicineServices = new MedicineServices(service.Object);
            _medicine = new Medicine
            {
                MedicineId = 1,
                Name = "CETAPHIL GENTLE SKIN CLEANSER, 125ML",
                Details = "Gentle face wash, Cetaphil Gentle Skin Cleanser",
                Price = 129,
                Size = "125 ML",
                Stock = 10,
                CatId = 1,
                Features = "Feature 1	Gentle face wash, Feature 2   Trusted brand ,Feature 3   Easy to Use, Feature 4   Alcohol free formulation,FREE SHIPPING"
            };
            _category = new Category
            {
                Id = 1,
                Title = "Men's Care",
                Url = "~/Medicine/Index/6",
                OpenInNewWindow = false
            };
            _doctor = new Doctor
            {
                DoctorId = 1,
                Name = "Rajnish Ranjan",
                Specialization = "Eye Spe...",
                Qualification = "MBBS DMCH",
                PracticingFrom = DateTime.Now
            };
            _user = new ApplicationUser()
            {
                UserId = 1,
                Name = "Name1",
                Email = "namelast@gmail.com",
                MobileNumber = 9631438113,
                PinCode = 823311,
                HouseNo_Building_Name = "9/11",
                Road_area = "Manpur Gaya",
                City = "Gaya",
                State = "Bihar"
            };
            _order = new MedicineOrder()
            {
                OrderId = 1,
                MedicineId = 1,
                UserId = 1
            };
            _appointment = new Appointment()
            {
                AppointmentId = 1,
                PatientName = "Uma",
                DoctorName = "Rajnish Ranjan",
                Takendate = DateTime.Now,
                Symtoms = "Cold Fever",
                PatientAge = 23,
                Remark = ""
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test for placing invalid order fro medicine
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_InvlidPlaceOrder()
        {
            //Arrange
            bool res = false;
            var _userApp = new ApplicationUser()
            {
                UserId = 2,
                Name = "Name1",
                Email = "namelast@gmail.com",
                MobileNumber = 9631438113,
                PinCode = 823311,
                HouseNo_Building_Name = "9/11",
                Road_area = "Manpur Gaya",
                City = "Gaya",
                State = "Bihar"
            };
            _userApp = null;
            //Act
            service.Setup(repo => repo.PlaceOrder(_medicine.MedicineId, _user)).ReturnsAsync(_userApp = null);
            var result = await _medicineServices.PlaceOrder(_medicine.MedicineId, _user);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_InvlidPlaceOrder=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for verify invalid doctor appointment Booking
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_InvlidAppointmentbooking()
        {
            //Arrange
            bool res = false;
            var appointment = new Appointment()
            {
                AppointmentId = 1,
                PatientName = "Uma",
                DoctorName = "Rajnish Ranjan",
                Takendate = DateTime.Now,
                Symtoms = "Cold Fever",
                PatientAge = 23,
                Remark = ""
            };
            appointment = null;
            //Act
            service.Setup(repo => repo.DoctorAppointment(appointment)).ReturnsAsync(appointment = null);
            var result = await _medicineServices.DoctorAppointment(appointment);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_InvlidAppointmentbooking=" + res + "\n");
            return res;
        }
    }
}
