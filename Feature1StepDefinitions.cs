using Allure_SpecFlow_Datadriven_POM.Support.Make_Appointment;
using System;
using TechTalk.SpecFlow;

namespace Allure_SpecFlow_Datadriven_POM.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        MakeAppointment makeAppointment =new MakeAppointment();
        [Given(@"the url open")]
        public void GivenTheUrlOpen()
        {
            makeAppointment.BrowserIntialize();
            makeAppointment.openURL();
        }

        [When(@"Make Apointment button is clicked")]
        public void WhenMakeApointmentButtonIsClicked()
        {
           makeAppointment.Appointment();
        }

        [Then(@"validate the login message")]
        public void ThenValidateTheLoginMessage()
        {
            makeAppointment.Apointment_validate();
        }

        [Given(@"the username")]
        public void GivenTheUsername()
        {
           makeAppointment.login_username();
        }

        [Given(@"the password")]
        public void GivenThePassword()
        {
            makeAppointment.login_password();
        }

        [When(@"Click on login button")]
        public void WhenClickOnLoginButton()
        {
            makeAppointment.loginclick();
        }

        [Then(@"validate the login assertion")]
        public void ThenValidateTheLoginAssertion()
        {
            
            makeAppointment.login_validate();
        }

        [Given(@"the Faculty")]
        public void GivenTheFaculty()
        {
            makeAppointment.facultyinput();
        }

        [When(@"readmission clicked")]
        public void WhenReadmissionClicked()
        {
            makeAppointment.hospitalreadmission();
        }

        [When(@"Radio button for healtyCare")]
        public void WhenRadioButtonForHealtyCare()
        {
            makeAppointment.HealthCareRadio();
        }

        [When(@"visit date")]
        public void WhenVisitDate()
        {
            makeAppointment.Dateinput();
        }

        [When(@"comment added")]
        public void WhenCommentAdded()
        {
            makeAppointment.Comment();
        }

        [When(@"bookapointment button clicked")]
        public void WhenBookapointmentButtonClicked()
        {
            makeAppointment.Book();
        }

        [Then(@"verifiaction final")]
        public void ThenVerifiactionFinal()
        {
            makeAppointment.FinalValidate();
            makeAppointment.DisposeDriver();

        }
    }
}
