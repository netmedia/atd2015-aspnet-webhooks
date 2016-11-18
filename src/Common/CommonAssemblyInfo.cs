// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if !BUILD_GENERATED_VERSION
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
#endif
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
#if !NOT_CLS_COMPLIANT
[assembly: CLSCompliant(true)]
#endif
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: AssemblyMetadata("Serviceable", "True")]

//// ===========================================================================
////  DO NOT EDIT OR REMOVE ANYTHING BELOW THIS COMMENT.
////  Version numbers are automatically generated based on regular expressions.
//// ===========================================================================

#if ASPNETWEBHOOKS
#if !BUILD_GENERATED_VERSION
[assembly: AssemblyVersion("1.1.0.0")]
[assembly: AssemblyFileVersion("1.1.0.0")]
#endif
[assembly: AssemblyProduct("Microsoft ASP.NET WebHooks")]
#else
#error Runtime projects must define ASPNETWEBHOOKS
#endif

[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Common.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Custom.Api.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Custom.AzureStorage.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Custom.Mvc.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Custom.SqlStorage.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Custom.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Azure.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Bitbucket.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Custom.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Dropbox.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Generic.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.GitHub.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Instagram.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.MailChimp.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.PayPal.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Pusher.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Salesforce.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Slack.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Stripe.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.Trello.Test")]
[assembly:InternalsVisibleTo("Microsoft.AspNet.WebHooks.Receivers.WordPress.Test")]
[assembly:InternalsVisibleTo("Microsoft.TestUtilities")]