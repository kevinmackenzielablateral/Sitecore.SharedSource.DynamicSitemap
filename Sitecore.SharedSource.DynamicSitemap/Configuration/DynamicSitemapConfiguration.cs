﻿using Sitecore.Xml;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sitecore.SharedSource.DynamicSitemap.Configuration
{
    /// <summary>
    /// Dynamic Sitemap Module Configuration
    /// </summary>
    internal class DynamicSitemapConfiguration
    {
        public static string XmlnsTpl
        {
            get
            {
                return GetValueByName("xmlnsTpl");
            }
        }

        public static string WorkingDatabase
        {
            get
            {
                return GetValueByName("database");
            }
        }

        public static string SitemapConfigurationItemPath
        {
            get
            {
                return GetValueByName("sitemapConfigurationItemPath");
            }
        }

        public static string SitemapConfigurationSitesFolderName
        {
            get
            {
                return GetValueByName("sitemapConfigurationSitesFolderName");
            }
        }

        public static string SitemapConfigurationRoutesFolderName
        {
            get
            {
                return GetValueByName("sitemapConfigurationRoutesFolderName");
            }
        }

        public static string SitemapConfigurationChangeFrequenciesFolderName
        {
            get
            {
                return GetValueByName("sitemapConfigurationChangeFrequenciesFolderName");
            }
        }

        public static string SitemapConfigurationPrioritiesFolderName
        {
            get
            {
                return GetValueByName("sitemapConfigurationPrioritiesFolderName");
            }
        }

        public static string SitemapConfigurationOutputFolder
        {
            get
            {
                return GetValueByName("sitemapConfigurationOutputFolder");
            }
        }

        public static bool SubmitToSearchEngine
        {
            get
            {
                string valueByName = GetValueByName("submitToSearchEngine");
                return !string.IsNullOrEmpty(valueByName) && (valueByName.ToLower() == "true" || valueByName == "1");
            }
        }

        public static bool RefreshRobotsFile
        {
            get
            {
                string valueByName = GetValueByName("refreshRobotsFile");
                return !string.IsNullOrEmpty(valueByName) && (valueByName.ToLower() == "true" || valueByName == "1");
            }
        }

        public static bool UseSitemapsIndexFile
        {
            get
            {
                string valueByName = GetValueByName("useSitemapsIndexFile");
                return !string.IsNullOrEmpty(valueByName) && (valueByName.ToLower() == "true" || valueByName == "1");
            }
        }

        private static string GetValueByName(string name)
        {
            string result = string.Empty;
            foreach (XmlNode xmlNode in Sitecore.Configuration.Factory.GetConfigNodes("dynamicSitemap/sitemapVariable"))
            {
                if (XmlUtil.GetAttribute("name", xmlNode) == name)
                {
                    result = XmlUtil.GetAttribute("value", xmlNode);
                    break;
                }
            }

            return result;
        }
    }
}