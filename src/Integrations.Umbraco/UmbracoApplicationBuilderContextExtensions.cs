﻿using System;
using Microsoft.AspNetCore.Builder;
using Relewise.Integrations.Umbraco.Infrastructure.Mvc.Middlewares;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

namespace Relewise.Integrations.Umbraco;

public static class UmbracoApplicationBuilderContextExtensions
{
    public static void TrackContentViews(this IUmbracoApplicationBuilderContext builder)
    {
        if (builder == null) throw new ArgumentNullException(nameof(builder));

        builder.AppBuilder.UseMiddleware<RelewiseContentMiddleware>();
    }
}