﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Core;
//using Core.Identity;


namespace Web.Areas.Api.Controllers
{
    public class UserController : BaseController
    {
        //
        // GET: /Api/User/

        //[HttpPost]
        //public ActionResult Signin(string email, string password, bool? persist)
        //{
        //    string response = "";
        //    if (Membership.ValidateUser(email, password))
        //    {
        //        FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(email, true, (int)FormsAuthentication.Timeout.TotalMinutes);
        //        string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
        //        HttpCookie cookie = Core.Web.CookieFactory.Create(FormsAuthentication.FormsCookieName, encryptedTicket);
        //        if (persist.HasValue && persist.Value)
        //        {
        //            cookie.Expires = authTicket.Expiration;
        //        }
        //        Response.Cookies.Set(cookie);
        //        response = "ok";
        //    }
        //    else
        //    {
        //        MembershipUser thisUser = Membership.GetUser(email);
        //        if (thisUser == null)
        //        {
        //            response = "failed";
        //        }
        //        else if (!thisUser.IsApproved)
        //        {
        //            response = "unvalidated";
        //        }
        //        else if (thisUser.IsLockedOut)
        //        {
        //            response = "locked";
        //        }
        //        else
        //        {
        //            response = "failed";
        //        }
        //    }

        //    return Json(response, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Signout()
        //{
        //    if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
        //    {
        //        HttpCookie cookie = Core.Web.CookieFactory.Create(FormsAuthentication.FormsCookieName);
        //        cookie.Expires = DateTime.Now.AddDays(-1);
        //        Response.Cookies.Add(cookie);
        //    }
        //    return Json(true, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult ResetPassword(string email)
        //{
        //    var i = Identity.GetUser(email);
        //    if (i != null)
        //    {
        //        Singleton<Mailer>.Instance.SendResetPasswordEmail(i);
        //    }

        //    return Json(true);
        //}

        //[HttpPost]
        //public ActionResult SendVerification(string email)
        //{
        //    var i = Identity.GetUser(email);
        //    if (i != null)
        //    {
        //        Singleton<Mailer>.Instance.SendRegistrationEmail(i);
        //    }

        //    return Json(true);
        //}


        //[HttpPost]
        //public ActionResult Password(string password)
        //{

        //    Identity.CurrentUser.ResetPassword(password);
        //    return Json(true);
        //}

        //[HttpPost]
        //public ActionResult Profile(Identity identity)
        //{
        //    identity.UserId = Identity.CurrentUser.UserId;
        //    identity.Email = Identity.CurrentUser.Email;
        //    identity.IsApproved = Identity.CurrentUser.IsApproved;
        //    identity.IsLockedOut = Identity.CurrentUser.IsLockedOut;
        //    identity.Save();

        //    return Json(true);
        //}


    

    }
}
