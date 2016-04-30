using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CharReplacer
{
    public partial class Form1 : Form
    {
        private String fileType;
        private String find;
        private String replace;
        private bool useRegex;
        private int total;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = dlg.SelectedPath;
            }
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 进行开始替换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBegin_Click(object sender, EventArgs e)
        {
            String originPath = tbPath.Text;
            fileType = cbFileType.Text;
            find = tbSource.Text;
            replace = tbDestination.Text;
            useRegex = isRegex.Checked;
            total = 0;
            
            if (fileType.Equals("") || fileType.EndsWith("."))
            {
                MessageBox.Show("请选择正确的文件类型！");
                return;
            }

            if (originPath.Equals(""))
            {
                MessageBox.Show("请先选择要处理的文件目录！");
                return;
            }
            if (!Directory.Exists(originPath))
            {
                MessageBox.Show("选择的目录不存在！");
                return;
            }

            if (find.Trim().Equals(""))
            {
                MessageBox.Show("请输入要替换的字符串，不能是空格!");
                return;
            }

            bool isSubPath = cbSubPath.Checked;
            if (isSubPath)
            {
                //如果包含子目录
                doFiles(originPath);
                doDirectories(originPath);
            }
            else
            {
                //不包含子目录，只处理文件
                doFiles(originPath);
            }
            MessageBox.Show("替换完成，共替换 "+total+" 个文件！");
        }

        /// <summary>
        /// 对目录下的文件进行处理操作
        /// </summary>
        /// <param name="path">要处理的目录</param>
        private void doFiles(String path)
        {
            if (fileType.Equals("*.*"))
            {
                //所有类型文件
                if (useRegex)
                {
                    foreach (String file in Directory.GetFiles(path))
                    {
                        doReplaceWithRegex(file);
                    }
                }
                else
                {
                    foreach (String file in Directory.GetFiles(path))
                    {
                        doReplace(file);
                    }
                }
            }
            else
            {
                //按类型处理文件
                fileType = fileType.Substring(fileType.LastIndexOf("."));
                foreach (String file in Directory.GetFiles(path))
                {
                    //处理替换文件
                    if (file.EndsWith(fileType))
                    {
                        if (useRegex)
                        {
                            doReplaceWithRegex(file);
                        }
                        else
                        {
                            doReplace(file);
                        }
                        
                    }
                }
            }
            
        }

        /// <summary>
        /// 对目录下的文件进行递归处理，包含子目录及文件
        /// </summary>
        /// <param name="path">要处理的目录</param>
        private void doDirectories(String path)
        {
            foreach (String floder in Directory.GetDirectories(path))
            {
                doDirectories(floder);
                doFiles(floder);
            }
        }

        /// <summary>
        /// 使用普通字符串替换
        /// </summary>
        /// <param name="path">替换的文件路径</param>
        private void doReplace(string path)
        {
            string strContent = File.ReadAllText(path);
            if (strContent.Contains(find))
            {
                strContent = strContent.Replace(find,replace);
                File.WriteAllText(path, strContent);
                total++;
            }
        }

        /// <summary>
        /// 使用正则表达式进行替换
        /// </summary>
        /// <param name="path">替换的文件路径</param>
        private void doReplaceWithRegex(string path)
        {
            string strContent = File.ReadAllText(path);
            MatchCollection collection = Regex.Matches(strContent, find, RegexOptions.Multiline);
            if (collection.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < collection.Count; i++)
            {
                strContent = strContent.Replace(collection[i].Value, replace);
            }
            File.WriteAllText(path, strContent);
            total++;
        }
    }
}
