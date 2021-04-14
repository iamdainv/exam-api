using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using btapApi14_4.Models;
namespace WebAPI_new.Controller
{
    public class CustomersController : ApiController
    {
        //httpGet: dùng để lấy thông tin khách hàng
        //1. Dịch vụ lấy thông tin của toàn bộ khách hàng
        [HttpGet]
        public List<tblKhach> GetCustomerLists()
        {
            DBCustomerDataContext dbCustomer = new DBCustomerDataContext();
            return dbCustomer.tblKhaches.ToList();
        }
        //2. Dịch vụ lấy thông tin một khách hàng với mã nào đó
        [HttpGet]
        public tblKhach GetCustomer(int id)
        {
            DBCustomerDataContext dbCustomer = new DBCustomerDataContext();
            return dbCustomer.tblKhaches.FirstOrDefault(x => x.Makhach == id);
        }
        //3. httpPost, dịch vụ thêm mới một khách hàng
        [HttpPost]
        public bool InsertNewCustomer(int id, string name, string adress, string phoneNumber)
        {
            try
            {
                DBCustomerDataContext dbCustomer = new DBCustomerDataContext();
                tblKhach customer = new tblKhach();
                customer.Makhach = id;
                customer.TenKhach = name;
                customer.DiaChi = adress;
                customer.DienThoai = phoneNumber;
                dbCustomer.tblKhaches.Add(customer);
                dbCustomer.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //4. httpPut để chỉnh sửa thông tin một khách hàng
        [HttpPut]
        public bool UpdateCustomer(int id, string name, string adress, string phoneNumber)
        {
            try
            {
                DBCustomerDataContext dbCustomer = new DBCustomerDataContext();
                //Lấy mã khách đã có
                tblKhach customer = dbCustomer.tblKhaches.FirstOrDefault(x => x.Makhach == id);
                if (customer == null) return false;
                customer.Makhach = id;
                customer.TenKhach = name;
                customer.DiaChi = adress;
                customer.DienThoai = phoneNumber;
                dbCustomer.SaveChanges();//Xác nhận chỉnh sửa
                return true;
            }
            catch
            {
                return false;
            }
        }
        //5.httpDelete để xóa một Khách hàng
        [HttpDelete]
        public bool DeleteCustomer(int id)
        {
            try
            {
                DBCustomerDataContext dbCustomer = new DBCustomerDataContext();
                //Lấy mã khách đã có
                tblKhach customer = dbCustomer.tblKhaches.FirstOrDefault(x => x.Makhach == id);
                if (customer == null) return false;
                dbCustomer.tblKhaches.Remove(customer);
                dbCustomer.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
