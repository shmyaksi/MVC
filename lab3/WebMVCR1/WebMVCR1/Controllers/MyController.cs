﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;



namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" :
           "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }


        private static PersonRepository db = new PersonRepository();
        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }




















        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            string sq1 = String.Format("Площадь фигуры {0} равна: {1:0.##}", tr1.Name, tr1.Area);
            return sq1;
        }

        public string ExeCircle()
        {
            Circle cir1 = new Circle(3);
            string sq = String.Format("Площадь фигуры {0} равна:{1:0.##}", cir1.Name, cir1.Area);
            return sq;
        }



        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            string res1 = String.Format("Тип банковского счета {0}", goldAccount);
            string res2 = String.Format("Тип банковского счета {0}", platinumAccount);
            string res = res1 + "<p>" + res2;
            return res;

        }

        public string ExeStruct()
        {
            BankAccount goldBankAccount;
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;
            string res = String.Format("Информация о банковском счете: {0}", goldBankAccount);
            return res;

        }

        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StadyCsharp.Factorial(x, out f);
            if (ok)
                return String.Format("Факториал числа {0} равен {1} ", x, f);
            else
                return "Невозможно вычислить факториал";
        }

        public string ExePolim()
        {
            StringBuilder str = new StringBuilder();
            Shape[] sh = {
                new Triangle(1,2,3),
               new Circle(5),
               new Triangle(5,6,8)
               };
            foreach (Shape item in sh)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }
            return str.ToString();

        }

        public string ExeCollection()
        {
            List<Circle> cirs = new List<Circle>
            {
              new Circle(12),
              new Circle(5),
              new Circle(15),
              new Circle(6)
            };
            cirs.Add(new Circle(7));

            cirs.Sort();
            StringBuilder str = new StringBuilder();
            foreach (Shape item in cirs)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }
            return str.ToString();






        }
    }
}