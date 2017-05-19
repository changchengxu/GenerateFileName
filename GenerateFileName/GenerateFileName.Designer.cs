namespace GenerateFileName
{
    partial class GenerateFileName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_FileList = new System.Windows.Forms.ListBox();
            this.txt_fileType = new System.Windows.Forms.TextBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_openPath = new System.Windows.Forms.TextBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.btn_autoNum = new System.Windows.Forms.Button();
            this.btn_savePath = new System.Windows.Forms.Button();
            this.txt_savePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_searchContentDel = new System.Windows.Forms.TextBox();
            this.check_searchContentDel = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_InsertToPos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searchContentInsert = new System.Windows.Forms.TextBox();
            this.check_searchContentInsertPos = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_deleteNum = new System.Windows.Forms.CheckBox();
            this.check_deleteTrim = new System.Windows.Forms.CheckBox();
            this.check_generateDateTime = new System.Windows.Forms.CheckBox();
            this.check_generateNum = new System.Windows.Forms.CheckBox();
            this.radiobtn_searchAll = new System.Windows.Forms.RadioButton();
            this.radiobtn_onlyContainsSpace = new System.Windows.Forms.RadioButton();
            this.radiobtn_onlyContainsNum = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_ProgressPresent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TimeRemain = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_FileList
            // 
            this.listBox_FileList.FormattingEnabled = true;
            this.listBox_FileList.HorizontalScrollbar = true;
            this.listBox_FileList.ItemHeight = 12;
            this.listBox_FileList.Location = new System.Drawing.Point(5, 0);
            this.listBox_FileList.Name = "listBox_FileList";
            this.listBox_FileList.ScrollAlwaysVisible = true;
            this.listBox_FileList.Size = new System.Drawing.Size(278, 484);
            this.listBox_FileList.TabIndex = 1;
            // 
            // txt_fileType
            // 
            this.txt_fileType.Location = new System.Drawing.Point(390, 77);
            this.txt_fileType.Name = "txt_fileType";
            this.txt_fileType.Size = new System.Drawing.Size(279, 21);
            this.txt_fileType.TabIndex = 2;
            this.txt_fileType.Text = "*.*";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(337, 81);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(41, 12);
            this.lbl_Type.TabIndex = 3;
            this.lbl_Type.Text = "类型：";
            // 
            // txt_openPath
            // 
            this.txt_openPath.Location = new System.Drawing.Point(390, 13);
            this.txt_openPath.Name = "txt_openPath";
            this.txt_openPath.Size = new System.Drawing.Size(279, 21);
            this.txt_openPath.TabIndex = 4;
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(306, 13);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(78, 21);
            this.btn_path.TabIndex = 5;
            this.btn_path.Text = "打开路径：";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // btn_autoNum
            // 
            this.btn_autoNum.Location = new System.Drawing.Point(426, 396);
            this.btn_autoNum.Name = "btn_autoNum";
            this.btn_autoNum.Size = new System.Drawing.Size(163, 52);
            this.btn_autoNum.TabIndex = 6;
            this.btn_autoNum.Text = "所有文件生成编号";
            this.btn_autoNum.UseVisualStyleBackColor = true;
            this.btn_autoNum.Click += new System.EventHandler(this.btn_autoNum_Click);
            // 
            // btn_savePath
            // 
            this.btn_savePath.Location = new System.Drawing.Point(306, 43);
            this.btn_savePath.Name = "btn_savePath";
            this.btn_savePath.Size = new System.Drawing.Size(78, 21);
            this.btn_savePath.TabIndex = 8;
            this.btn_savePath.Text = "保存路径：";
            this.btn_savePath.UseVisualStyleBackColor = true;
            this.btn_savePath.Click += new System.EventHandler(this.btn_savePath_Click);
            // 
            // txt_savePath
            // 
            this.txt_savePath.Location = new System.Drawing.Point(390, 43);
            this.txt_savePath.Name = "txt_savePath";
            this.txt_savePath.Size = new System.Drawing.Size(279, 21);
            this.txt_savePath.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radiobtn_searchAll);
            this.groupBox1.Controls.Add(this.radiobtn_onlyContainsSpace);
            this.groupBox1.Controls.Add(this.radiobtn_onlyContainsNum);
            this.groupBox1.Location = new System.Drawing.Point(306, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 280);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生成名称格式";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_searchContentDel);
            this.groupBox4.Controls.Add(this.check_searchContentDel);
            this.groupBox4.Location = new System.Drawing.Point(109, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 63);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "搜索内容：";
            // 
            // txt_searchContentDel
            // 
            this.txt_searchContentDel.Location = new System.Drawing.Point(75, 40);
            this.txt_searchContentDel.Name = "txt_searchContentDel";
            this.txt_searchContentDel.Size = new System.Drawing.Size(279, 21);
            this.txt_searchContentDel.TabIndex = 12;
            // 
            // check_searchContentDel
            // 
            this.check_searchContentDel.AutoSize = true;
            this.check_searchContentDel.Location = new System.Drawing.Point(6, 20);
            this.check_searchContentDel.Name = "check_searchContentDel";
            this.check_searchContentDel.Size = new System.Drawing.Size(120, 16);
            this.check_searchContentDel.TabIndex = 4;
            this.check_searchContentDel.Text = "删除指定文件内容";
            this.check_searchContentDel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_InsertToPos);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_searchContentInsert);
            this.groupBox3.Controls.Add(this.check_searchContentInsertPos);
            this.groupBox3.Location = new System.Drawing.Point(109, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 101);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "插入到指定字符后面：";
            // 
            // txt_InsertToPos
            // 
            this.txt_InsertToPos.Location = new System.Drawing.Point(141, 72);
            this.txt_InsertToPos.Name = "txt_InsertToPos";
            this.txt_InsertToPos.Size = new System.Drawing.Size(214, 21);
            this.txt_InsertToPos.TabIndex = 12;
            this.txt_InsertToPos.Text = "格式：-|—（‘|’代表或者）";
            this.txt_InsertToPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_InsertToPos_MouseDown);
            this.txt_InsertToPos.MouseLeave += new System.EventHandler(this.txt_InsertToPos_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "检索指定字符前面的内容：";
            // 
            // txt_searchContentInsert
            // 
            this.txt_searchContentInsert.Location = new System.Drawing.Point(165, 42);
            this.txt_searchContentInsert.Name = "txt_searchContentInsert";
            this.txt_searchContentInsert.Size = new System.Drawing.Size(190, 21);
            this.txt_searchContentInsert.TabIndex = 10;
            // 
            // check_searchContentInsertPos
            // 
            this.check_searchContentInsertPos.AutoSize = true;
            this.check_searchContentInsertPos.Location = new System.Drawing.Point(6, 20);
            this.check_searchContentInsertPos.Name = "check_searchContentInsertPos";
            this.check_searchContentInsertPos.Size = new System.Drawing.Size(120, 16);
            this.check_searchContentInsertPos.TabIndex = 3;
            this.check_searchContentInsertPos.Text = "替换指定文件内容";
            this.check_searchContentInsertPos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_deleteNum);
            this.groupBox2.Controls.Add(this.check_deleteTrim);
            this.groupBox2.Controls.Add(this.check_generateDateTime);
            this.groupBox2.Controls.Add(this.check_generateNum);
            this.groupBox2.Location = new System.Drawing.Point(109, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 83);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // check_deleteNum
            // 
            this.check_deleteNum.AutoSize = true;
            this.check_deleteNum.Location = new System.Drawing.Point(6, 61);
            this.check_deleteNum.Name = "check_deleteNum";
            this.check_deleteNum.Size = new System.Drawing.Size(96, 16);
            this.check_deleteNum.TabIndex = 3;
            this.check_deleteNum.Text = "删除所有数字";
            this.check_deleteNum.UseVisualStyleBackColor = true;
            // 
            // check_deleteTrim
            // 
            this.check_deleteTrim.AutoSize = true;
            this.check_deleteTrim.Location = new System.Drawing.Point(6, 29);
            this.check_deleteTrim.Name = "check_deleteTrim";
            this.check_deleteTrim.Size = new System.Drawing.Size(96, 16);
            this.check_deleteTrim.TabIndex = 2;
            this.check_deleteTrim.Text = "剔除所有空格";
            this.check_deleteTrim.UseVisualStyleBackColor = true;
            // 
            // check_generateDateTime
            // 
            this.check_generateDateTime.AutoSize = true;
            this.check_generateDateTime.Location = new System.Drawing.Point(108, 22);
            this.check_generateDateTime.Name = "check_generateDateTime";
            this.check_generateDateTime.Size = new System.Drawing.Size(174, 28);
            this.check_generateDateTime.TabIndex = 0;
            this.check_generateDateTime.Text = "生成时间戳\r\n格式：YYYY/MM/DD HH:MM:SS";
            this.check_generateDateTime.UseVisualStyleBackColor = true;
            // 
            // check_generateNum
            // 
            this.check_generateNum.AutoSize = true;
            this.check_generateNum.Location = new System.Drawing.Point(288, 23);
            this.check_generateNum.Name = "check_generateNum";
            this.check_generateNum.Size = new System.Drawing.Size(90, 28);
            this.check_generateNum.TabIndex = 1;
            this.check_generateNum.Text = "生成编号\r\n格式：1,2,3";
            this.check_generateNum.UseVisualStyleBackColor = true;
            // 
            // radiobtn_searchAll
            // 
            this.radiobtn_searchAll.AutoSize = true;
            this.radiobtn_searchAll.Checked = true;
            this.radiobtn_searchAll.Location = new System.Drawing.Point(8, 33);
            this.radiobtn_searchAll.Name = "radiobtn_searchAll";
            this.radiobtn_searchAll.Size = new System.Drawing.Size(95, 28);
            this.radiobtn_searchAll.TabIndex = 12;
            this.radiobtn_searchAll.TabStop = true;
            this.radiobtn_searchAll.Text = "检索\r\n所有文件名称";
            this.radiobtn_searchAll.UseVisualStyleBackColor = true;
            // 
            // radiobtn_onlyContainsSpace
            // 
            this.radiobtn_onlyContainsSpace.AutoSize = true;
            this.radiobtn_onlyContainsSpace.Location = new System.Drawing.Point(8, 196);
            this.radiobtn_onlyContainsSpace.Name = "radiobtn_onlyContainsSpace";
            this.radiobtn_onlyContainsSpace.Size = new System.Drawing.Size(95, 28);
            this.radiobtn_onlyContainsSpace.TabIndex = 11;
            this.radiobtn_onlyContainsSpace.Text = "只检索\r\n含空格文件名";
            this.radiobtn_onlyContainsSpace.UseVisualStyleBackColor = true;
            // 
            // radiobtn_onlyContainsNum
            // 
            this.radiobtn_onlyContainsNum.AutoSize = true;
            this.radiobtn_onlyContainsNum.Location = new System.Drawing.Point(8, 118);
            this.radiobtn_onlyContainsNum.Name = "radiobtn_onlyContainsNum";
            this.radiobtn_onlyContainsNum.Size = new System.Drawing.Size(95, 28);
            this.radiobtn_onlyContainsNum.TabIndex = 10;
            this.radiobtn_onlyContainsNum.Text = "只检索\r\n含数字文件名";
            this.radiobtn_onlyContainsNum.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(306, 457);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // lbl_ProgressPresent
            // 
            this.lbl_ProgressPresent.AutoSize = true;
            this.lbl_ProgressPresent.Location = new System.Drawing.Point(780, 462);
            this.lbl_ProgressPresent.Name = "lbl_ProgressPresent";
            this.lbl_ProgressPresent.Size = new System.Drawing.Size(17, 12);
            this.lbl_ProgressPresent.TabIndex = 14;
            this.lbl_ProgressPresent.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "剩余时间：";
            // 
            // lbl_TimeRemain
            // 
            this.lbl_TimeRemain.AutoSize = true;
            this.lbl_TimeRemain.Location = new System.Drawing.Point(703, 440);
            this.lbl_TimeRemain.Name = "lbl_TimeRemain";
            this.lbl_TimeRemain.Size = new System.Drawing.Size(65, 12);
            this.lbl_TimeRemain.TabIndex = 16;
            this.lbl_TimeRemain.Text = "00：00：00";
            // 
            // GenerateFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 492);
            this.Controls.Add(this.lbl_TimeRemain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ProgressPresent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_savePath);
            this.Controls.Add(this.txt_savePath);
            this.Controls.Add(this.btn_autoNum);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.txt_openPath);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.txt_fileType);
            this.Controls.Add(this.listBox_FileList);
            this.Name = "GenerateFileName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateFileName";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_FileList;
        private System.Windows.Forms.TextBox txt_fileType;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_openPath;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Button btn_autoNum;
        private System.Windows.Forms.Button btn_savePath;
        private System.Windows.Forms.TextBox txt_savePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_generateNum;
        private System.Windows.Forms.CheckBox check_generateDateTime;
        private System.Windows.Forms.CheckBox check_deleteTrim;
        private System.Windows.Forms.RadioButton radiobtn_onlyContainsSpace;
        private System.Windows.Forms.RadioButton radiobtn_onlyContainsNum;
        private System.Windows.Forms.RadioButton radiobtn_searchAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check_deleteNum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_searchContentDel;
        private System.Windows.Forms.CheckBox check_searchContentDel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_InsertToPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_searchContentInsert;
        private System.Windows.Forms.CheckBox check_searchContentInsertPos;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_ProgressPresent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TimeRemain;
    }
}