﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace TestingProject
{
    class DetailsPOM
    {

        public DetailsPOM()
        {
            PageFactory.InitElements(PropertiesFile.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "name_3_firstname")]
        public IWebElement txtFirstname { get; set; }

        [FindsBy(How = How.Id, Using = "name_3_lastname")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.Name, Using = "radio_4[]")]
        public IList<IWebElement> rdBtnMarriedStatus { get; set; }

        [FindsBy(How = How.Name, Using = "checkbox_5[]")]
        public IList<IWebElement> CheckBoxHobby { get; set; }

        [FindsBy(How = How.Id, Using = "dropdown_7")]
        public IWebElement ddlCountry { get; set; }

        [FindsBy(How = How.Id, Using = "mm_date_8")]
        public IWebElement ddlMonth { get; set; }

        [FindsBy(How = How.Id, Using = "dd_date_8")]
        public IWebElement ddlDay { get; set; }

        [FindsBy(How = How.Id, Using = "yy_date_8")]
        public IWebElement ddlYear { get; set; }

        [FindsBy(How = How.Id, Using = "phone_9")]
        public IWebElement txtPhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id, Using = "email_1")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "description")]
        public IWebElement txtDescription { get; set; }

        [FindsBy(How = How.Id, Using = "password_2")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password_password_2")]
        public IWebElement txtConfirmPassword { get; set; }

        [FindsBy(How = How.Name, Using = "pie_submit")]
        public IWebElement btnSubmit { get; set; }


        public void Resgister(string Firstname, string Lastname, string MarriedStatus, List<string> Hobby, string Country, string DOBMonth, string DOBDay, string DOBYear, string PhoneNumber, string username, string Email, string AboutMe, string Password, string ConfirmPassword)
        {
            txtFirstname.SetTextbox(Firstname);
            txtLastName.SetTextbox(Lastname);

            for (int i = 0; i < rdBtnMarriedStatus.Count; i++)
            {
                if (rdBtnMarriedStatus.ElementAt(i).GetAttribute("value").Equals(MarriedStatus))
                {
                    rdBtnMarriedStatus.ElementAt(i).SetRadiobtn();
                }
            }
            //if (rdBtnMarriedStatus.ElementAt(1).GetAttribute("value").Equals(MarriedStatus))
            //{
            //    rdBtnMarriedStatus.ElementAt(1).SetRadiobtn();
            //}
            //if (rdBtnMarriedStatus.ElementAt(2).GetAttribute("value").Equals(MarriedStatus))
            //{
            //    rdBtnMarriedStatus.ElementAt(2).SetRadiobtn();
            //}

            for (int i = 0; i < CheckBoxHobby.Count; i++)
            {
                for (int j = 0; j < Hobby.Count; j++)
                {
                    if (CheckBoxHobby.ElementAt(i).GetAttribute("value").Equals(Hobby.ElementAt(j)))
                        CheckBoxHobby.ElementAt(i).SetCheckbox();
                }
            }
            //MultipleCheckBox.SetCheckbox(Hobby);
            ddlCountry.SetDropDownList(Country);
            ddlMonth.SetDropDownList(DOBMonth);
            ddlDay.SetDropDownList(DOBDay);
            ddlYear.SetDropDownList(DOBYear);
            txtPhoneNumber.SetTextbox(PhoneNumber);
            txtUsername.SetTextbox(username);
            txtEmail.SetTextbox(Email);
            txtDescription.SetTextbox(AboutMe);
            txtPassword.SetTextbox(Password);
            txtConfirmPassword.SetTextbox(ConfirmPassword);
            btnSubmit.Click();

        }
    }
}
