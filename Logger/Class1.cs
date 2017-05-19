using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Logger
{
    public class Logger
    {
        static object _lock = new object();
        static StringBuilder _logBuffer = new StringBuilder();
        static Thread _logThread;
        static string _appPath;


        /// <summary>
        /// class construction
        /// </summary>
        static Logger()
        {
            //create a thread to save logs to harddisk
            _logThread = new Thread(new ThreadStart(LogThread));
            _logThread.Name = Process.GetCurrentProcess().ProcessName + "日志记录线程";
            _logThread.Priority = ThreadPriority.BelowNormal;
            _logThread.IsBackground = true;
            _logThread.Start();
        }        

        /// <summary>
        /// Log thread
        /// </summary>
        private static void LogThread()
        {
            while (true)
            {
                try
                {
                    DateTime today = DateTime.Now;

                    //open log file
                    string logFileDir = GetDirectory();
                  
                    if (!Directory.Exists(logFileDir))
                        Directory.CreateDirectory(logFileDir);
                    string logFilePath = string.Format("{0}{1}.log", logFileDir, today.ToString("yyyyMMdd"));
                    using (StreamWriter fs = new StreamWriter(logFilePath, true))
                    {
                        while (true)
                        {
                            string logs = string.Empty;
                            lock (_lock)
                            {
                                //get message from string buffer
                                if (_logBuffer.Length > 0)
                                {
                                    logs = _logBuffer.ToString();
                                    _logBuffer.Remove(0, _logBuffer.Length);
                                }
                            }
                            //write message to log file
                            if (!string.IsNullOrEmpty(logs))
                            {
                                fs.Write(logs);
                                fs.Flush();
                            }
                            //judge whether to jump to next log file
                            if (DateTime.Now.Day != today.Day)
                                break;

                            Thread.Sleep(1000);
                        }
                        fs.Close();
                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    Thread.Sleep(1000);
                }
            }
        }


        /// <summary>
        /// using windows event log function to log run-time messages & dump datas
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public static void Write(string message)
        {
            lock (_lock)
            {
                if (_logBuffer.Length < 10000000)
                {
                    string typeStr = "Test";
                   
                    _logBuffer.Append(string.Format("{0} [{1}] {2}\r\n",
                        DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"), typeStr, message.Replace("\n", "\n\t\t\t")));
                }
            }
        }

        public static string GetDirectory()
        {
            var ret = Path.Combine(GetAppDir(), "Logs");
            if (!ret.EndsWith(Path.DirectorySeparatorChar.ToString()))
                ret = ret + Path.DirectorySeparatorChar;

            if (!Directory.Exists(ret))
                Directory.CreateDirectory(ret);

            return ret;
        }

        /// <summary>
        /// Application directory
        /// </summary>
        /// <returns></returns>
        public static string GetAppDir()
        {
            return string.IsNullOrWhiteSpace(_appPath) ? _appPath = GetAppStartupDirectory() : _appPath;
        }

        /// <summary>
        /// Application start up directory
        /// </summary>
        /// <returns></returns>
        static string GetAppStartupDirectory()
        {
            var startupPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            string dir = Path.GetDirectoryName(startupPath);
            return dir;
        }


    }
}
