﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravitybox.GCache
{
    /// <summary />
    public static class Logger
    {
        #region Class Members

        private static NLog.Logger _logger = null;

        #endregion

        #region Constructor

        static Logger()
        {
            _logger = NLog.LogManager.GetLogger(string.Empty);
        }

        #endregion

        #region Logging

        /// <summary />
        public static void LogError(string message)
        {
            try
            {
                if (_logger != null)
                {
                    _logger.Error(message);
                }
            }
            catch (Exception)
            {
                //Do Nothing
            }
        }

        /// <summary />
        public static void LogError(Exception exception, string message)
        {
            try
            {
                if (_logger != null)
                    _logger.Error(message + "\n" + exception.ToString());
            }
            catch (Exception)
            {
                //Do Nothing
            }
        }

        /// <summary />
        public static void LogError(Exception exception)
        {
            try
            {
                if (_logger != null)
                    _logger.Error(exception.ToString());
            }
            catch (Exception)
            {
                //Do Nothing
            }
        }

        /// <summary />
        public static void LogDebug(string message)
        {
            try
            {
                if (_logger != null)
                    _logger.Debug(message);
            }
            catch (Exception)
            {
                //Do Nothing
            }
        }

        /// <summary />
        public static void LogInfo(string message)
        {
            try
            {
                if (_logger != null)
                    _logger.Info(message);
            }
            catch (Exception)
            {
                //Do Nothing
            }
        }

        /// <summary />
        public static void LogWarning(string message)
        {
            try
            {
                if (_logger != null)
                    _logger.Warn(message);
            }
            catch (Exception)
            {
                //Do Nothing
            }
        }

        #endregion
    }
}