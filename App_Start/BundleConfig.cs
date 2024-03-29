﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace News.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js"));
            bundles.Add(new ScriptBundle("~/bundles/news").Include(
            "~/Scripts/app/news/news.viewmodel.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/business").Include(
            "~/Scripts/app/business/business.viewmodel.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/cyber").Include(
            "~/Scripts/app/cyber/cyber.viewmodel.js"
                ));



            //bundles.Add(new ScriptBundle("~/bundles/app").Include(
            //    "~/Scripts/sammy-{version}.js",
            //    "~/Scripts/app/common.js",
            //    "~/Scripts/app/app.datamodel.js",
            //    "~/Scripts/app/app.viewmodel.js",
            //    "~/Scripts/app/home.viewmodel.js",
            //    "~/Scripts/app/_run.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));
            bundles.Add(new StyleBundle("~/Content/font").Include(
                "~/Content/font-awesome.min.css"
                ));
            bundles.Add(new StyleBundle("~/Content/custom").Include(
                "~/Content/style.css"
                ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                              "~/Content/bootstrap.min.css",

                              "~/Content/Site.css"));
            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                "~/Scripts/main.js"
                )); 
        }
    }
}
