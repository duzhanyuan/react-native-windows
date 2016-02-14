﻿using Newtonsoft.Json.Linq;
using System;
using System.Runtime.ExceptionServices;

namespace ReactNative.DevSupport
{
    class DisabledDevSupportManager : IDevSupportManager
    {
        public bool IsEnabled
        {
            get;
            set;
        }

        public string SourceUrl
        {
            get
            {
                return null;
            }
        }

        public string SourceMapUrl
        {
            get
            {
                return null;
            }
        }

        public string CachedJavaScriptBundleFile
        {
            get
            {
                return null;
            }
        }

        public void HandleException(Exception exception)
        {
            ExceptionDispatchInfo.Capture(exception).Throw();
        }

        public void HandleReloadJavaScript()
        {
        }

        public void ShowDevOptionsDialog()
        {
        }

        public void ShowNewJavaScriptError(string title, JArray details, int exceptionId)
        {
        }

        public void ShowNewNativeError(string message, Exception ex)
        {
        }

        public void UpdateJavaScriptError(string title, JArray details, int exceptionId)
        {
        }
    }
}