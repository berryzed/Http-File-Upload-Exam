namespace HttpFileUploadExam
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.prog_Upload = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Selectfile = new System.Windows.Forms.Button();
            this.txt_Filepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.lbl_Filesize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prog_Upload
            // 
            this.prog_Upload.Location = new System.Drawing.Point(12, 12);
            this.prog_Upload.Name = "prog_Upload";
            this.prog_Upload.Size = new System.Drawing.Size(268, 23);
            this.prog_Upload.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_Selectfile
            // 
            this.btn_Selectfile.Location = new System.Drawing.Point(12, 142);
            this.btn_Selectfile.Name = "btn_Selectfile";
            this.btn_Selectfile.Size = new System.Drawing.Size(75, 23);
            this.btn_Selectfile.TabIndex = 1;
            this.btn_Selectfile.Text = "Select File";
            this.btn_Selectfile.UseVisualStyleBackColor = true;
            this.btn_Selectfile.Click += new System.EventHandler(this.btn_Selectfile_Click);
            // 
            // txt_Filepath
            // 
            this.txt_Filepath.Enabled = false;
            this.txt_Filepath.Location = new System.Drawing.Point(12, 115);
            this.txt_Filepath.Name = "txt_Filepath";
            this.txt_Filepath.Size = new System.Drawing.Size(268, 21);
            this.txt_Filepath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
            // 
            // btn_Upload
            // 
            this.btn_Upload.Enabled = false;
            this.btn_Upload.Location = new System.Drawing.Point(205, 142);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload.TabIndex = 4;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.Location = new System.Drawing.Point(12, 38);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(21, 12);
            this.lbl_Percent.TabIndex = 5;
            this.lbl_Percent.Text = "0%";
            // 
            // lbl_Filesize
            // 
            this.lbl_Filesize.AutoSize = true;
            this.lbl_Filesize.Location = new System.Drawing.Point(12, 69);
            this.lbl_Filesize.Name = "lbl_Filesize";
            this.lbl_Filesize.Size = new System.Drawing.Size(114, 12);
            this.lbl_Filesize.TabIndex = 6;
            this.lbl_Filesize.Text = "File Size: no select";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 174);
            this.Controls.Add(this.lbl_Filesize);
            this.Controls.Add(this.lbl_Percent);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Filepath);
            this.Controls.Add(this.btn_Selectfile);
            this.Controls.Add(this.prog_Upload);
            this.Name = "MainForm";
            this.Text = "Http FileUpload Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prog_Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Selectfile;
        private System.Windows.Forms.TextBox txt_Filepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Label lbl_Percent;
        private System.Windows.Forms.Label lbl_Filesize;
    }
}

