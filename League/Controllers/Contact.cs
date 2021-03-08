﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using Axuno.Web;
using League.BackgroundTasks;
using League.Models.AccountViewModels;
using League.Models.ContactViewModels;
using League.Routing;
using League.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using TournamentManager.MultiTenancy;

namespace League.Controllers
{
    public class Contact : AbstractController
    {
        private readonly AppDb _appDb;
        private readonly ITenantContext _tenantContext;
        private readonly TenantStore _tenantStore;
        private readonly IStringLocalizer<Account> _localizer;
        private readonly Axuno.BackgroundTask.IBackgroundQueue _queue;
        private readonly SendEmailTask _sendEmailTask;
        private readonly ILogger<Home> _logger;

        public Contact(ITenantContext tenantContext, TenantStore tenantStore, Axuno.BackgroundTask.IBackgroundQueue queue, SendEmailTask sendEmailTask, ILogger<Home> logger, IStringLocalizer<Account> localizer)
        {
            _tenantContext = tenantContext;
            _tenantStore = tenantStore;
            _appDb = _tenantContext.DbContext.AppDb;
            _queue = queue;
            _sendEmailTask = sendEmailTask;
            _logger = logger;            
            _localizer = localizer;
            _tenantContext = tenantContext;
        }
        
        [HttpGet("{organization:MatchingTenant}/contact", Name = RouteNames.TenantContact)]
        [HttpGet("/contact", Name = RouteNames.GeneralContact)]
        public IActionResult Index()
        {
            var model = new ContactViewModel();
            if (User.Identity.IsAuthenticated)
            {
                model.Email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                model.Gender = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Gender)?.Value;
                model.FirstName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value;
                model.LastName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value;
            }
            
            // Note: The form will use route name to generate the action url
            // Also, if we are in an organization context, the organization contact url will be used, otherwise the general one
            return View(ViewNames.Contact.Index, model);
        }

        [HttpPost("{organization:MatchingTenant}/contact", Name = RouteNames.TenantContact)]
        [HttpPost("/contact", Name = RouteNames.GeneralContact)]
        public IActionResult Index(ContactViewModel model)
        {
            if (model.Captcha != HttpContext.Session.GetString(CaptchaSvgGenerator.CaptchaSessionKeyName))
            {
                ModelState.AddModelError(nameof(CreateAccountViewModel.Captcha), _localizer["Math task result was incorrect"]);
            }
            if (!ModelState.IsValid)
            {
                return View(ViewNames.Contact.Index, model);
            }

            SendEmail(model);
            _logger.LogTrace("Mail sent: {@model}", model);

            return _tenantContext.IsDefault ? RedirectToRoute(RouteNames.GeneralContactConfirmation) : RedirectToRoute(RouteNames.TenantContactConfirmation, new { Organization = _tenantContext.SiteContext.UrlSegmentValue });
        }

        [HttpGet("{organization:MatchingTenant}/contact-confirmation", Name = RouteNames.TenantContactConfirmation)]
        [HttpGet("/contact-confirmation", Name = RouteNames.GeneralContactConfirmation)]
        public IActionResult ContactConfirmation()
        {
            return View(ViewNames.Contact.ContactConfirmation);
        }

        private void SendEmail(ContactViewModel model)
        {
            _sendEmailTask.SetMessageCreator(new Emailing.Creators.ContactFormCreator
            {
                Parameters =
                {
                    ContactForm = model,
                    CultureInfo = CultureInfo.DefaultThreadCurrentUICulture ?? CultureInfo.CurrentCulture
                }
            });

            _queue.QueueTask(_sendEmailTask);
        }
    }
}