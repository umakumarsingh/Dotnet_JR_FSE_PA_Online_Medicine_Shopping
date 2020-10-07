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
    public class FuctionalTests
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
        public FuctionalTests()
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
        static FuctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Testfor_Validate_ValidUserPlacing Order and Medicine id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidPlaceOrder()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.PlaceOrder(_medicine.MedicineId, _user)).ReturnsAsync(_user);
            var result = await _medicineServices.PlaceOrder(_medicine.MedicineId, _user);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_ValidPlaceOrder=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get All medicine by id and without id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetAllMedicine()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetAllMedicine(_medicine.MedicineId));
            var result = await _medicineServices.GetAllMedicine(_medicine.MedicineId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetAllMedicine=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get medicine by id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetMedicineById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetMedicineById(_medicine.MedicineId)).ReturnsAsync(_medicine);
            var result = await _medicineServices.GetMedicineById(_medicine.MedicineId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetMedicineById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to verify Get medicine by name
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetMedicineName()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.MedicineByName(_medicine.Name));
            var result = await _medicineServices.MedicineByName(_medicine.Name);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetMedicineName=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to verify get order by User Id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetOrderById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.OrderByuserId(_user.UserId));
            var result = await _medicineServices.OrderByuserId(_user.UserId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetOrderById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to validate appint booking is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidAppointment()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.DoctorAppointment(_appointment)).ReturnsAsync(_appointment);
            var result = await _medicineServices.DoctorAppointment(_appointment);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_ValidAppointment=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get appointment by Id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetAppointmentById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetAppointmentById(_appointment.AppointmentId)).ReturnsAsync(_appointment);
            var result = await _medicineServices.GetAppointmentById(_appointment.AppointmentId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetAppointmentById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get all doctor
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetAllDoctor()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.GetAllDoctor());
            var result = await _medicineServices.GetAllDoctor();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetAllDoctor=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get category list for menu
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetCategoryList()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.CatList());
            var result = _medicineServices.CatList();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetCategoryList=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Tset fro get Doctor list
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetDoctorList()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.Doctor());
            var result = _medicineServices.Doctor();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetDoctorList=" + res + "\n");
            return res;
        }
    }
}
