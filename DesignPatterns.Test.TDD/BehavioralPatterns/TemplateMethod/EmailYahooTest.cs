﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.TemplateMethod.Emails;

namespace DesignPatterns.Test.TDD.BehavioralPatterns.TemplateMethod
{
    [TestClass]
    public class EmailYahooTest
    {
        private EmailYahoo _yahoo;

        public EmailYahooTest()
        {
            _yahoo = new EmailYahoo();
        }

        [TestMethod, TestCategory("Template Method")]
        public void Validate_Send_Yahoo_Email()
        {
            _yahoo.SendEmail("templatemethod@gmail.com", "Hello dear!");
        }

        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), "Message can not be null. yahoo team.")]
        public void Validate_Send_Yahho_Email_Without_Message()
        {
            _yahoo.SendEmail("templatemethod@gmail.com", null);
        }

        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), "Recipient can not be null. yahoo team.")]
        public void Validate_Send_Yahho_Email_Without_Recipient()
        {
            _yahoo.SendEmail(null, "Hello dear!");
        }
        
        [TestMethod, TestCategory("Template Method")]
        [ExpectedException(typeof(EmailException), noExceptionMessage: "Invalid e-mail address.")]
        public void Validate_Send_Yahho_Email_Invalid_Address()
        {
            _yahoo.SendEmail("invalidaddress", "Hello dear!");
        }
    }
}
