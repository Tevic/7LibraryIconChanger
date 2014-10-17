using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Threading;

namespace _7LibraryIconChanger
{
    class RebuileIconCache
    {
        //获取管理员权限
        private static void TakeOwner(string filepath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "takeown",
                Arguments = string.Format("/f \"{0}\" /a", filepath),
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(startInfo).WaitForExit();
            startInfo.FileName = "icacls";
            startInfo.Arguments = string.Format("\"{0}\" /grant administrators:F", filepath);
            Process.Start(startInfo).WaitForExit();
        }

 
        //重建图标和缩略图缓存
        public static void Rebuild()
        {
                //结束EXPLORER
                KillProcess("explorer");

                //修改注册表键值禁止EXPLORER自启动
                RegistryKey RegExplorerAutoRestart = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
                RegExplorerAutoRestart.SetValue("AutoRestartShell", 0, Microsoft.Win32.RegistryValueKind.DWord);

                //清除托盘图标缓存
                RegistryKey RegTrayNotify = Registry.ClassesRoot.OpenSubKey("Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\TrayNotify", true);
                RegTrayNotify.DeleteValue("IconStreams", false);
                RegTrayNotify.DeleteValue("PastIconsStream", false);

                //设置文件路径
                string LocalAppDataPath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string TempDir = LocalAppDataPath + "\\Temp\\";

                List<string> tempFileList = new List<string>();
                List<string> delFileList = new List<string>();
                delFileList.Add(LocalAppDataPath + "\\IconCache.db");
                delFileList.Add(LocalAppDataPath + "\\Microsoft\\Windows\\Explorer\\" + "thumbcache_32.db");
                delFileList.Add(LocalAppDataPath + "\\Microsoft\\Windows\\Explorer\\" + "thumbcache_96.db");
                delFileList.Add(LocalAppDataPath + "\\Microsoft\\Windows\\Explorer\\" + "thumbcache_256.db");
                delFileList.Add(LocalAppDataPath + "\\Microsoft\\Windows\\Explorer\\" + "thumbcache_1024.db");
                delFileList.Add(LocalAppDataPath + "\\Microsoft\\Windows\\Explorer\\" + "thumbcache_idx.db");
                delFileList.Add(LocalAppDataPath + "\\Microsoft\\Windows\\Explorer\\" + "thumbcache_sr.db");

                try
                {
                    //设置文件属性,移动删除文件
                    foreach (var srcFileName in delFileList)
                    {
                        string tempFileName = TempDir + System.Guid.NewGuid().ToString();
                        tempFileList.Add(tempFileName);
                        if (File.Exists(srcFileName))
                        {
                            File.SetAttributes(srcFileName, FileAttributes.Normal);
                            File.Move(srcFileName, tempFileName);
                        }
                    }



                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    //重启EXPLORER
                    StartProcess("explorer.exe");
                    //还原注册表键值并回收资源
                    RegExplorerAutoRestart.SetValue("AutoRestartShell", 1, Microsoft.Win32.RegistryValueKind.DWord);
                    RegExplorerAutoRestart.Close();
                    RegTrayNotify.Close();
                    Thread.Sleep(1500);
                    //删除临时文件
                    foreach (var fileName in tempFileList)
                    {
                        File.Delete(fileName);
                    }
                }
  
            
        }

        //结束进程
        private static void KillProcess(String procName)
        {
            foreach (System.Diagnostics.Process Proc in System.Diagnostics.Process.GetProcesses())
            {
                if (Proc.ProcessName.ToString() == procName)
                {
                    Proc.Kill();
                    Proc.Close();
                }
            }
        }

        //启动进程(不重复启动)
        private static void StartProcess(string procName)
        {
            bool existProcess = false;
            foreach (System.Diagnostics.Process Proc in System.Diagnostics.Process.GetProcesses())
            {
                if (Proc.ProcessName.ToString() == procName)
                {
                    existProcess = true;
                }
            }
            if (!existProcess)
            {
                Process.Start(procName);
            }
        }
    }
}
