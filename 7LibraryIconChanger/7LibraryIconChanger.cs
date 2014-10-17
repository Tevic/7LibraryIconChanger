using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using CSharpHelperLibrary;
using System.Drawing;

namespace _7LibraryIconChanger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            GetAllLibrary(CbxLibrary);

            label2.Text +="\n"+ Environment.OSVersion.ToString();
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            //获取图标路径
            if (getIconPathDlg.ShowDialog() == DialogResult.OK)
            {
                TbxIconPath.Text = getIconPathDlg.FileName;
                this.BtnChoose.BackgroundImage = new Icon(this.getIconPathDlg.FileName,new Size(48,48)).ToBitmap();
                this.BtnChoose.Text = "";
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            //替换库图标
            if (TbxIconPath.Text != "" && CbxLibrary.SelectedItem != null)
            {
                try
                {
                    string sysPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string libraryPath = sysPath + "\\Microsoft\\Windows\\Libraries\\";
                    string selectLibraryPath = libraryPath + CbxLibrary.SelectedItem.ToString() + ".library-ms";
                    XMLReader xr = new XMLReader(selectLibraryPath, "libraryDescription");
                    xr.SetChildNodeText("iconReference", TbxIconPath.Text);
                    if (MessageBox.Show("替换成功，是否现在将打开库？", "成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Process.Start("explorer.exe");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (CbxLibrary.SelectedItem == null)
            {
                MessageBox.Show("请选择一个库！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TbxIconPath.Text == "")
            {
                MessageBox.Show("请选择一个图标！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            //还原库图标
            if (CbxLibrary.SelectedItem != null)
            {
                string sysPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string libraryPath = sysPath + "\\Microsoft\\Windows\\Libraries\\";
                string selectLibraryPath = libraryPath + CbxLibrary.SelectedItem.ToString() + ".library-ms";

                //还原文档库
                if (CbxLibrary.SelectedItem.ToString() == "Documents")
                {
                    try
                    {

                        XMLReader xr = new XMLReader(selectLibraryPath, "libraryDescription");
                        xr.SetChildNodeText("iconReference", "imageres.dll,-1002");
                        if (MessageBox.Show("还原成功，是否现在将打开库？", "成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Process.Start("explorer.exe");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //还原音乐库
                else if (CbxLibrary.SelectedItem.ToString() == "Music")
                {
                    try
                    {

                        XMLReader xr = new XMLReader(selectLibraryPath, "libraryDescription");
                        xr.SetChildNodeText("iconReference", "imageres.dll,-1004");
                        if (MessageBox.Show("还原成功，是否现在将打开库？", "成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Process.Start("explorer.exe");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //还原视频库
                else if (CbxLibrary.SelectedItem.ToString() == "Videos")
                {
                    try
                    {

                        XMLReader xr = new XMLReader(selectLibraryPath, "libraryDescription");
                        xr.SetChildNodeText("iconReference", "imageres.dll,-1005");
                        if (MessageBox.Show("还原成功，是否现在将打开库？", "成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Process.Start("explorer.exe");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //还原图片库
                else if (CbxLibrary.SelectedItem.ToString() == "Pictures")
                {
                    try
                    {

                        XMLReader xr = new XMLReader(selectLibraryPath, "libraryDescription");
                        xr.SetChildNodeText("iconReference", "imageres.dll,-1003");
                        if (MessageBox.Show("还原成功，是否现在将打开库？", "成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Process.Start("explorer.exe");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        
                        XMLReader xr = new XMLReader(selectLibraryPath, "libraryDescription");
                        xr.SetChildNodeText("iconReference", "");
                        if (MessageBox.Show("还原成功，是否现在将打开库？", "成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Process.Start("explorer.exe");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("请选择一个库！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此软件用于更换Winodws 7库的图标，\n替换和还原系统自带库的图标后需要刷新图标缓存。\n\n版权归 Tevic.TT 所有\nCopyright © 2010\nE-Mail : Tevic.TT@Gmail.Com", "关于 7 Library Icon Changer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRebuildIconCache_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("请退出所有无关程序后再刷新图标及缩略图缓存！\n刷新过程中将重启资源管理器！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    BtnRebuildIconCache.Enabled = false;
                    RebuileIconCache.Rebuild();
                    //提示操作成功
                    MessageBox.Show("刷新图标及缩略图缓存完成！", "完成",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnRebuildIconCache.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序出现异常：\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnRebuildIconCache.Enabled = true;
                }
            }
            
        }

        static void GetAllLibrary(ComboBox cb)
        {
            //获取当前用户的Library
            string sysPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string libraryPath = sysPath + "\\Microsoft\\Windows\\Libraries";
            DirectoryInfo dir = new DirectoryInfo(libraryPath);
            FileInfo[] allLibrary = dir.GetFiles("*.library-ms");
            foreach (var item in allLibrary)
            {
                // cb.Items.Add(item.Name.Substring(0, item.Name.IndexOf(".")));
                cb.Items.Add(GetFileName(item.FullName,false));
            }
        }

        /// <summary>
        /// 根据传来的文件全路径，获取文件名称部分
        /// </summary>
        /// <param name="FileFullPath">文件全路径</param>
        /// <param name="IncludeExtension">是否包括文件扩展名</param>
        /// <returns>string 文件名称</returns>
        public static string GetFileName(string FileFullPath, bool IncludeExtension)
        {
            if (File.Exists(FileFullPath) == true)
            {
                FileInfo F = new FileInfo(FileFullPath);
                if (IncludeExtension == true)
                {
                    return F.Name;
                }
                else
                {
                    return F.Name.Replace(F.Extension, "");
                }
            }
            else//文件不存在
            {
                return null;
            }
        }

    }
}
