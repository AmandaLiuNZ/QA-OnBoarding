using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Faker;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfilePage :BasePage
    {

        By _SignIn = By.LinkText("Sign In");
        By _email = By.Name("email");
        By _password = By.Name("password");
        By _Login = By.CssSelector(".fluid");
        By _username = By.CssSelector(".title");
        By _nsbox = By.CssSelector("body > div.ns-box");

        By _availabilityTypeButton = By.CssSelector(".item:nth-child(2) > .right .right");
        By _availabilityTypeDropdown = By.Name("availabiltyType");
        By _availabilityTypeText = By.CssSelector(".item:nth-child(2) > .right > span");

        By _nameicon = By.CssSelector(".title > i");
        By _firstname = By.Name("firstName");
        By _lastname = By.Name("lastName");
        By _save = By.CssSelector("div > .teal");

        IWebDriver driver;
        int availabilityType;
        string selectedAvailabilityType;
        string newFirstname;
        string newLastname;
        

        public ProfilePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void Login()
        {
            Click(_SignIn);
            Type(_email, "amandaliunz@gmail.com");
            Type(_password, "amanda2021");
            Click(_Login);
        }

        public string GetUsername() 
        {
            if (IsTextDisplayed(_username, 10))
            {
                return Find(_username).Text;

            } else 
            {
                return "fail to get username";
            }
        }

        public void UpdateAvailabilityType() 
        {
            Click(_availabilityTypeButton);

            if (IsDisplayed(_availabilityTypeDropdown))
            {
                var dropdown = Find(_availabilityTypeDropdown);
                var selectElement = new SelectElement(dropdown);

                availabilityType = new Random().Next(1, 3);
                selectElement.SelectByIndex(availabilityType);
                if (availabilityType == 1)
                {
                    selectedAvailabilityType = "Part Time";
                }
                else {
                    selectedAvailabilityType = "Full Time";
                }
                //  Type(_availabilityType, "Part Time");
            }

        }

        public void UpdateAvailabilityType(string availabilityType)
        {
            Click(_availabilityTypeButton);

            if (IsDisplayed(_availabilityTypeDropdown))
            {
                Type(_availabilityTypeDropdown, availabilityType);
            }

        }
        public void AssertAvailabilityType()
        {

            if (IsDisplayed(_nsbox, 10))
            {
                Assert.AreEqual(Find(_nsbox).Text, "Availability updated");
                //TestContext.WriteLine(Find(_nsbox).Text);
                TestContext.WriteLine(Find(_availabilityTypeText).Text);
                Assert.AreEqual(Find(_availabilityTypeText).Text, selectedAvailabilityType);
            }
        }
        public void AssertAvailabilityType(string availabilityType,string expectedMsg)
        {

            if (IsDisplayed(_nsbox, 10))
            {
                Assert.AreEqual(Find(_nsbox).Text, expectedMsg);
                TestContext.WriteLine(Find(_availabilityTypeText).Text);
                Assert.AreEqual(Find(_availabilityTypeText).Text, availabilityType);
            }
        }

        public void UpdateName()
        {                          //update random firstname and lastname
            Click(_nameicon);

            newFirstname = Name.First();
            newLastname = Name.Last();

            if (IsDisplayed(_firstname, 10))
            {
                Find(_firstname).Clear();
                Type(_firstname, newFirstname);
                Find(_lastname).Clear();
                Type(_lastname, newLastname);
                Click(_save);

            }
        }
        public void UpdateName(string firstName, string lastName)
        {                                         //update from Scenario
            Click(_nameicon);

            newFirstname = firstName;
            newLastname = lastName;

            if (IsDisplayed(_firstname, 10))
            {
                Find(_firstname).Clear();
                Type(_firstname, newFirstname);
                Find(_lastname).Clear();
                Type(_lastname, newLastname);
                Click(_save);
            }
        }

        public void AssertName()
        {
            if (IsTextDisplayed(_username, 10))
            {
                Assert.AreEqual(Find(_username).Text, newFirstname+" "+newLastname);
                TestContext.WriteLine(newFirstname);
                TestContext.WriteLine(newLastname);
            }
        }
        public void AssertName(string fullName)
        {                               // Assert from Scenario
            if (IsTextDisplayed(_username, 10))
            {
                Assert.AreEqual(Find(_username).Text, fullName);
                TestContext.WriteLine(newFirstname);
                TestContext.WriteLine(newLastname);
            }
        }

        public void DeleteName()
        {
            string firstName;
            int lenth, i;

            Click(_nameicon);

            if (IsDisplayed(_firstname, 10))
            {
                firstName = Find(_firstname).GetAttribute("value");
                lenth = firstName.Length;
                TestContext.WriteLine(lenth);
                TestContext.WriteLine(firstName);
                for (i = 1; i <= lenth; i++)
                {
                    Type(_firstname, Keys.Backspace);
                }
                Click(_save);
            }
        }

        public void AssertErrorMsg()
        {
            if (IsDisplayed(_nsbox, 10))
            {
                Assert.AreEqual(Find(_nsbox).Text, "First name and last name are required");
            }
        }
    }


}
