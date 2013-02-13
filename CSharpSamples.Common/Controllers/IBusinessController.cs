﻿//  File:        IBusinessController.cs
//  Copyright:   Copyright 2012 MYOB Technology Pty Ltd. All rights reserved.
//  Website:     http://www.myob.com
//  Author:      MYOB
//  E-mail:      info@myob.com
//
//Documentation, code and sample applications provided by MYOB Australia are for 
//information purposes only. MYOB Technology Pty Ltd and its suppliers make no 
//warranties, either express or implied, in this document. 
//
//Information in this document or code, including website references, is subject
//to change without notice. Unless otherwise noted, the example companies, 
//organisations, products, domain names, email addresses, people, places, and 
//events are fictitious. 
//
//The entire risk of the use of this documentation or code remains with the user. 
//Complying with all applicable copyright laws is the responsibility of the user. 
//
//Copyright 2012 MYOB Technology Pty Ltd. All rights reserved.
using System.Web.Mvc;
using CSharpSamples.Common.Models;

namespace CSharpSamples.Common
{
    public interface IBusinessController
    {
        OAuthInfo OAuthInformation { get; }
        string CloudApi { get; set; }
        string NetworkApi { get; set; }
        bool IsLogon { get; }
        CompanyModel CompanyFile { get; }
        string CurrentUser { get; }
        string LoginInfo { get; }
        string LoginInfoTitle { get; }
        JsonResult CompanyLogon(CompanyModel companyFile, string userId, string password);
        JsonResult CompanyLogOut();
    }
}