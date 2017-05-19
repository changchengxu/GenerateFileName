using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace GenerateFileName
{
    public partial class GenerateFileName : Form
    {
        /// <summary>
        ///  Init = 0,   UnUsed,  Trim,  Generate,
        /// </summary>
        public enum CheckConditionFileType
        {
            Init = 0,
            UnUsed,
            Trim,
            Generate,
        }

        /// <summary>
        ///  AddDateTime = 0,  AddIndex,DeleteTrim
        /// </summary>
        public enum FileNameFormat
        {
            SearchContainsNum = 0,
            SearchContainsSpace = 1,
            AddDateTime,
            AddIndex,
            DeleteTrim,
            DeleteNum,
            SearchContentToPos,
            SearchContentDel,
        }

        Dictionary<string, Tuple<string, FileInfo>> dictionary = new Dictionary<string, Tuple<string, FileInfo>>();
        TimeSpan timeSpan;

        #region 参考
        //C#追加文件
        //    StreamWriter sw = File.AppendText(Server.MapPath(".")+"\\myText.txt");
        //    sw.WriteLine("追逐理想");
        //    sw.WriteLine("kzlll");
        //    sw.WriteLine(".NET笔记");
        //    sw.Flush();
        //    sw.Close();
        //C#拷贝文件
        //    string OrignFile,NewFile;
        //    OrignFile = Server.MapPath(".")+"\\myText.txt";
        //    NewFile = Server.MapPath(".")+"\\myTextCopy.txt";
        //    File.Copy(OrignFile,NewFile,true);
        //C#删除文件
        //    string delFile = Server.MapPath(".")+"\\myTextCopy.txt";
        //    File.Delete(delFile);
        //C#移动文件
        //    string OrignFile,NewFile;
        //    OrignFile = Server.MapPath(".")+"\\myText.txt";
        //    NewFile = Server.MapPath(".")+"\\myTextCopy.txt";
        //    File.Move(OrignFile,NewFile);
        //C#创建目录
        //// 创建目录c:\sixAge
        //    DirectoryInfo d=Directory.CreateDirectory("c:\\sixAge");
        //// d1指向c:\sixAge\sixAge1
        //    DirectoryInfo d1=d.CreateSubdirectory("sixAge1");
        //// d2指向c:\sixAge\sixAge1\sixAge1_1
        //    DirectoryInfo d2=d1.CreateSubdirectory("sixAge1_1");
        //// 将当前目录设为c:\sixAge
        //    Directory.SetCurrentDirectory("c:\\sixAge");
        //// 创建目录c:\sixAge\sixAge2
        //    Directory.CreateDirectory("sixAge2");
        //// 创建目录c:\sixAge\sixAge2\sixAge2_1
        //    Directory.CreateDirectory("sixAge2\\sixAge2_1");
        #endregion

        public GenerateFileName()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            timeSpan = TimeSpan.FromTicks(0);
        }

        /// <summary>
        /// 打开路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_path_Click(object sender, EventArgs e)
        {
            string reason = string.Empty;

            folderBrowserDialog1.SelectedPath = "D:";
            DialogResult ret = folderBrowserDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                txt_openPath.Text = folderBrowserDialog1.SelectedPath;

                CreateSaveFolder();
            }
            else return;

            if (!checkConditon(ref reason, CheckConditionFileType.Init))
            {
                MessageBox.Show(reason);
                return;
            }

            updatedData();
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_savePath_Click(object sender, EventArgs e)
        {
            string reason = string.Empty;

            folderBrowserDialog1.SelectedPath = "D:";
            DialogResult ret = folderBrowserDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                txt_savePath.Text = folderBrowserDialog1.SelectedPath;
            }
            else return;
        }

        /// <summary>
        /// 生成带有格式的文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_autoNum_Click(object sender, EventArgs e)
        {
            string reason = string.Empty;

            if (!checkConditon(ref reason, CheckConditionFileType.Generate))
            {
                MessageBox.Show(reason);
                return;
            }

            List<FileNameFormat> formatList = new List<FileNameFormat>();

            //radio判断必须在前面
            if (radiobtn_onlyContainsNum.Checked)
            {
                formatList.Add(FileNameFormat.SearchContainsNum);
            }
            if (radiobtn_onlyContainsSpace.Checked)
            {
                formatList.Add(FileNameFormat.SearchContainsSpace);
            }
            //checkbox判断必须在radiobox之后
            if (check_generateNum.Checked)
            {
                formatList.Add(FileNameFormat.AddIndex);
            }
            if (check_generateDateTime.Checked)
            {
                formatList.Add(FileNameFormat.AddDateTime);
            }
            if (check_deleteTrim.Checked)
            {
                formatList.Add(FileNameFormat.DeleteTrim);
            }
            if (check_deleteNum.Checked)
            {
                formatList.Add(FileNameFormat.DeleteNum);
            }
            if (check_searchContentInsertPos.Checked)
            {
                formatList.Add(FileNameFormat.SearchContentToPos);
            }
            if (check_searchContentDel.Checked)
            {
                formatList.Add(FileNameFormat.SearchContentDel);
            }

            updatedData();

            formatName(formatList);

            updatedData();
        }

        #region private func

        private bool checkConditon(ref string reason, CheckConditionFileType type = CheckConditionFileType.UnUsed)
        {
            bool ret = true;

            CreateSaveFolder();

            if (string.IsNullOrEmpty(txt_openPath.Text.Trim()))
            {
                reason = string.Format("打开路径不能为空！");
                ret = false;
                goto Ret;
            }
            else if (!Directory.Exists(txt_openPath.Text.Trim()))
            {
                reason = string.Format("打开路径不存在！");
                ret = false;
                goto Ret;
            }
            if (string.IsNullOrEmpty(txt_savePath.Text.Trim()))
            {
                reason = string.Format("保存路径不能为空！");
                ret = false;
                goto Ret;
            }
            else if (!Directory.Exists(txt_savePath.Text.Trim()))
            {
                reason = string.Format("保存路径不存在！");
                ret = false;
                goto Ret;
            }
            else if (string.IsNullOrEmpty(txt_fileType.Text.Trim()))
            {
                reason = string.Format("文件类型不能为空！");
                ret = false;
                goto Ret;
            }
            else if (check_searchContentInsertPos.Checked)
            {
                if (string.IsNullOrEmpty(txt_searchContentInsert.Text))
                {
                    reason = string.Format("搜索内容不能为空！");
                    ret = false;
                    goto Ret;
                }
                else if (string.IsNullOrEmpty(txt_searchContentInsert.Text))
                {
                    reason = string.Format("内容插入位置不能为空！");
                    ret = false;
                    goto Ret;
                }
            }
            else if (check_searchContentDel.Checked)
            {
                if (string.IsNullOrEmpty(txt_searchContentDel.Text))
                {
                    reason = string.Format("需要删除的内容不能为空！");
                    ret = false;
                    goto Ret;
                }
            }

            if (type != CheckConditionFileType.UnUsed)
            {
                if (dictionary.Count < 0 || listBox_FileList.Items.Count < 0)
                {
                    reason = string.Format("文件列表中没有文件！");
                    ret = false;
                    goto Ret;
                }

                if (type == CheckConditionFileType.Generate)
                {
                    if ((!check_generateDateTime.Checked && !check_generateNum.Checked && !check_deleteTrim.Checked && !check_deleteNum.Checked &&!check_searchContentInsertPos.Checked && !check_searchContentDel.Checked) &&
                        (!radiobtn_onlyContainsNum.Checked && !radiobtn_onlyContainsSpace.Checked))
                    {
                        reason = string.Format("请选择生成名称的格式！");
                        ret = false;
                        goto Ret;
                    }
                }
            }

        Ret:
            listBox_FileList.Items.Clear();

            return ret;

        }

        private void updatedData()
        {
            dictionary.Clear();
            listBox_FileList.Items.Clear();

            //*.mp3;*.wav;*.flac;*;*.mp4;*.mkv;*.rmvb
            FileInfo[] fileInfos;
            DirectoryInfo curFolderInfo = new DirectoryInfo(txt_openPath.Text.Trim());

            string[] splitType = txt_fileType.Text.Trim().Split(';');
            if (splitType.Length < 2 && txt_fileType.Text.Trim() == "*.*")
            {
                fileInfos = curFolderInfo.GetFiles();
                foreach (FileInfo info in fileInfos)
                {
                    dictionary.Add(info.Name, new Tuple<string, FileInfo>("", info));
                }
            }
            else if (splitType.Length > 0)
            {
                foreach (string type in splitType)
                {
                    fileInfos = curFolderInfo.GetFiles(type);
                    foreach (FileInfo info in fileInfos)
                    {
                        dictionary.Add(info.Name, new Tuple<string, FileInfo>("", info));
                    }
                }
            }

            foreach (var dic in dictionary)
            {
                listBox_FileList.Items.Add(dic.Key);
            }
        }

        private void formatName(List<FileNameFormat> format)
        {
            string openPath = txt_openPath.Text.Trim() + @"\";
            string savePath = txt_savePath.Text.Trim() + @"\";
            Dictionary<int, string> processedCount = new Dictionary<int, string>();
            int index = 0;

            updatedData();

            try
            {
                DateTime timeStart = DateTime.Now;

                foreach (var dic in dictionary)
                {
                    string sourceName = openPath + dic.Value.Item2.Name;
                    string destName = dic.Value.Item2.Name;

                    ///只检索指定条件的文件名
                    if (format.Contains(FileNameFormat.SearchContainsNum)
                        && !ScanStr(ref destName, ScanStrPattern.ContainInt))
                    {
                        continue;
                    }

                    if (format.Contains(FileNameFormat.SearchContainsSpace)
                      && !ScanStr(ref destName, ScanStrPattern.ContainSpace))
                    {
                        continue;
                    }
                    ///对文件名进行修改
                    //第一种判断
                    if (format.Contains(FileNameFormat.DeleteTrim))
                    {
                        destName = destName.Replace(" ", "");
                    }
                    //第二种判断
                    if (format.Contains(FileNameFormat.AddDateTime))
                    {
                        destName = DateTime.Now.ToString("yyyy-MM-dd HH：mm：ss") + " " + destName;
                    }
                    //第三种判断
                    if (format.Contains(FileNameFormat.AddIndex))
                    {
                        destName = (index + 1) + destName;
                    }
                    if (format.Contains(FileNameFormat.DeleteNum))
                    {
                        ScanStr(ref destName, ScanStrPattern.ContainInt, true);
                    }

                    ///将指定内容插入指定位置
                    if (format.Contains(FileNameFormat.SearchContentToPos))
                    {
                        string newName = ReplaceStr(destName, txt_searchContentInsert.Text, txt_InsertToPos.Text);
                        if (!string.IsNullOrEmpty(newName))
                        {
                            destName = newName;
                        }
                        else
                        {
                            Logger.Logger.Write(string.Format("转换失败! name:{0}", destName));
                        }
                    }
                    //将指定内容删除
                    if(format.Contains(FileNameFormat.SearchContentDel))
                    {
                        string newName = ReplaceStr(destName, txt_searchContentDel.Text, "", true);
                        if (!string.IsNullOrEmpty(newName))
                        {
                            destName = newName;
                        }
                        else
                        {
                            Logger.Logger.Write(string.Format("转换失败! name:{0}", destName));
                        }
                    }
                   
                    //判断是否有重名文件（不执行覆盖操作）
                    string judgeSameName = savePath + destName;
                    if (File.Exists(judgeSameName))
                    {
                        destName += Guid.NewGuid();
                    }
                    //海之南汽车影音－|－海之南汽车影音|海之南汽车影音
                    processedCount.Add(index++, dic.Value.Item2.Name);
                    Logger.Logger.Write(string.Format("已处理：{0}个，【原文件名】：{1}; 【更新文件名】:{2}", index, dic.Value.Item2.Name, destName));

                    destName = savePath + destName;

                    //if (File.Exists(destName))
                    //{
                    //    File.Delete(destName);
                    //}

                    File.Copy(sourceName, destName);
                  
                    DateTime timeEnd = DateTime.Now;
                    timeSpan = TimeSpan.FromTicks((timeEnd.Ticks - timeStart.Ticks) * (dictionary.Count - index - 1));
                 
                    int processIndex = (int)((1 * index) / ((double)dictionary.Count / progressBar1.Maximum));
                    SetPos(processIndex);
                }
                if (processedCount.Count < 100)
                {
                    MessageBox.Show(string.Format("已处理文件：\r\n{0}", string.Join("\r\n", processedCount.Values.ToList())));
                }
                else
                {
                    MessageBox.Show(string.Format("已处理文件：\r\n{0}个", processedCount.Count));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Scan str
        public enum ScanStrPattern
        {
            ContainInt,
            ContainSpace,
        }

        /// <summary>
        /// 1.删除文件名数字 2.判断是否有数字或空格
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="pattern"></param>
        /// <param name="edit"></param>
        /// <returns></returns>
        public static bool ScanStr(ref string Str, ScanStrPattern pattern,bool edit=false)
        {
            bool flag = false;
            if (Str != "")
            {
                if (pattern == ScanStrPattern.ContainInt)
                {
                    for (int i = 0; i < Str.Length; i++)
                    {
                        if (Char.IsNumber(Str, i))
                        {
                            if (edit)
                            {
                                Str=Str.Remove(i, 1);
                                i--;
                            }
                            else
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                }
                else if (pattern == ScanStrPattern.ContainSpace)
                {
                    if (Str.Contains(" "))
                    {
                        flag = true;
                    }
                }
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// 1. 删除指定内容 2.将指定内容插入到指定位置
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchContent"></param>
        /// <param name="insertPosChar"></param>
        /// <param name="delete"></param>
        /// <returns></returns>
        public static string ReplaceStr(string str,string searchContent,string insertPosChar, bool delete = false)
        {
            if(string.IsNullOrEmpty(str))
                return "";

            if (delete)
            {
                string[] splitList = searchContent.Split('|');
                foreach (string _split in splitList)
                {
                    str = str.Replace(_split, "");
                }
            }
            else
            {
                //先删除查找的内容
                string _searchCont = str.Substring(0, str.IndexOf(searchContent) + 1);
                if (string.IsNullOrEmpty(_searchCont)) return str;
                str = str.Replace(_searchCont, "");
                _searchCont = _searchCont.Remove(_searchCont.Length - 1);

                //将查找的内容插入指定位置
                string[] splitList = insertPosChar.Split('|');
                int succeedCount = 0;
                foreach (string _split in splitList)
                {
                    if (_split == "") continue;
                    int index = str.IndexOf(_split);
                    if (index < 0) continue;
                    str = str.Insert(index, "-" + _searchCont);
                    succeedCount++;
                }
                if (succeedCount <= 0)
                {
                    int index = str.LastIndexOf('.');
                    index = index > 0 ? index : str.Length;
                    str = str.Insert(index, "-" + _searchCont);
                }

            }

            return str;
        }
        #endregion

        #region 替换及删除
        private void txt_InsertToPos_MouseDown(object sender, MouseEventArgs e)
        {
            if (txt_InsertToPos.Text.Contains( "格式"))
                txt_InsertToPos.Text = "";
        }

        private void txt_InsertToPos_MouseLeave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_InsertToPos.Text))
            {
                txt_InsertToPos.Text = "格式：-|+（‘|’代表或者";
            }
        }
        #endregion

        #region  进度条
        private void SetPos(int step)
        {
            if (step <= progressBar1.Maximum)
            {
                progressBar1.Value = step;
                lbl_ProgressPresent.Text = string.Format("{0}%", step);

                //lbl_ProgressPresent.Text = string.Format("{0}%", step*1000 / progressBar1.Maximum);
            }

            if (timeSpan.Ticks != 0)
                new Action(delegate
                {
                    lbl_TimeRemain.Invoke(new Action(delegate
                    {
                        lbl_TimeRemain.Text = string.Format("{0:d2}:{1:d2}:{2:d2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                    }
                    ));
                }).BeginInvoke(null, null);

            Application.DoEvents();
        }
        #endregion

        private void CreateSaveFolder()
        {
            if (string.IsNullOrEmpty(txt_savePath.Text) || !Directory.Exists(txt_savePath.Text))
            {
                string savePath = txt_openPath.Text + @"\output";
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }

                txt_savePath.Text = savePath;
            }
        }

    }
}
