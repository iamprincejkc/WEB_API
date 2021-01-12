using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_API_V2.Models;

namespace WEB_API_V2.Controllers
{
    public class MainAPIController : ApiController
    {
        Test_v2Entities db = new Test_v2Entities();
        public IHttpActionResult GetData()
        {
            var product = db.Tbl_Product.ToList();
            var store = db.Tbl_Store.ToList();
            var staff = db.sp_GetStaff().ToList();

            List<StoreModel> storelist = new List<StoreModel>();
            List<ProductModel> prodlist = new List<ProductModel>();
            List<StaffModel> stafflist = new List<StaffModel>();

            foreach (var i in product)
            {
                ProductModel prod = new ProductModel()
                {
                    productid = i.productid,
                    productname = i.productname,
                    productquantity = Convert.ToInt32(i.productquantity),
                    productprice = Convert.ToDecimal(i.productprice),
                    storeid = i.storeid.GetValueOrDefault(),
                    staffid = i.staffid.GetValueOrDefault()
                };
                prodlist.Add(prod);
            }

            foreach (var i in staff)
            {
                StaffModel st = new StaffModel()
                {
                    staffid = i.staffid,
                    storeid = i.storeid.GetValueOrDefault(),
                    staffname = i.staffname,
                    staffaddress = i.staffaddress
                };
                stafflist.Add(st);
            }

            foreach (var i in store)
            {
                StoreModel st = new StoreModel()
                {
                    storeid = i.storeid,
                    storename = i.storename,
                    storelocation = i.storelocation,
                    Product = prodlist,
                    Staff=stafflist
                };
                storelist.Add(st);
            }

            return Ok(storelist);

        }
    }
}
