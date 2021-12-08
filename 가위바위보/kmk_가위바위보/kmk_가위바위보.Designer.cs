namespace kmk_가위바위보
{
    partial class kmk_가위바위보
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kmk_가위바위보));
            this.lbCom = new System.Windows.Forms.Label();
            this.lbMe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.Scissor = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.Papper = new System.Windows.Forms.Button();
            this.Timer_View_Result = new System.Windows.Forms.Timer(this.components);
            this.btn_View_Result = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Com_P = new System.Windows.Forms.Label();
            this.lb_Com_R = new System.Windows.Forms.Label();
            this.lb_Com_S = new System.Windows.Forms.Label();
            this.lb_Me_P = new System.Windows.Forms.Label();
            this.lb_Me_R = new System.Windows.Forms.Label();
            this.lb_Me_S = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Total_Count = new System.Windows.Forms.Label();
            this.lb_Draw_Score = new System.Windows.Forms.Label();
            this.lb_Com_Score = new System.Windows.Forms.Label();
            this.lb_Me_Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Location = new System.Drawing.Point(34, 67);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(22, 15);
            this.lbCom.TabIndex = 0;
            this.lbCom.Text = "컴";
            // 
            // lbMe
            // 
            this.lbMe.AutoSize = true;
            this.lbMe.Location = new System.Drawing.Point(34, 145);
            this.lbMe.Name = "lbMe";
            this.lbMe.Size = new System.Drawing.Size(22, 15);
            this.lbMe.TabIndex = 1;
            this.lbMe.Text = "나";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 88);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(113, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 90);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbResult.ForeColor = System.Drawing.Color.Blue;
            this.lbResult.Location = new System.Drawing.Point(228, 114);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(64, 25);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "결과";
            // 
            // Scissor
            // 
            this.Scissor.Font = new System.Drawing.Font("굴림", 20F);
            this.Scissor.ForeColor = System.Drawing.Color.Red;
            this.Scissor.Image = ((System.Drawing.Image)(resources.GetObject("Scissor.Image")));
            this.Scissor.Location = new System.Drawing.Point(12, 237);
            this.Scissor.Name = "Scissor";
            this.Scissor.Size = new System.Drawing.Size(89, 79);
            this.Scissor.TabIndex = 5;
            this.Scissor.Text = "1";
            this.Scissor.UseVisualStyleBackColor = true;
            this.Scissor.Click += new System.EventHandler(this.Scissor_Click);
            // 
            // Rock
            // 
            this.Rock.Font = new System.Drawing.Font("굴림", 20F);
            this.Rock.ForeColor = System.Drawing.Color.Red;
            this.Rock.Image = ((System.Drawing.Image)(resources.GetObject("Rock.Image")));
            this.Rock.Location = new System.Drawing.Point(127, 237);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(95, 79);
            this.Rock.TabIndex = 6;
            this.Rock.Text = "2";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Papper
            // 
            this.Papper.Font = new System.Drawing.Font("굴림", 20F);
            this.Papper.ForeColor = System.Drawing.Color.Red;
            this.Papper.Image = ((System.Drawing.Image)(resources.GetObject("Papper.Image")));
            this.Papper.Location = new System.Drawing.Point(244, 237);
            this.Papper.Name = "Papper";
            this.Papper.Size = new System.Drawing.Size(96, 79);
            this.Papper.TabIndex = 7;
            this.Papper.Text = "3";
            this.Papper.UseVisualStyleBackColor = true;
            this.Papper.Click += new System.EventHandler(this.Papper_Click);
            // 
            // Timer_View_Result
            // 
            this.Timer_View_Result.Tick += new System.EventHandler(this.Timer_View_Result_Tick);
            // 
            // btn_View_Result
            // 
            this.btn_View_Result.Location = new System.Drawing.Point(244, 182);
            this.btn_View_Result.Name = "btn_View_Result";
            this.btn_View_Result.Size = new System.Drawing.Size(75, 23);
            this.btn_View_Result.TabIndex = 8;
            this.btn_View_Result.Text = "결과보기";
            this.btn_View_Result.UseVisualStyleBackColor = true;
            this.btn_View_Result.Click += new System.EventHandler(this.Btn_View_Result_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Com_P);
            this.groupBox1.Controls.Add(this.lb_Com_R);
            this.groupBox1.Controls.Add(this.lb_Com_S);
            this.groupBox1.Controls.Add(this.lb_Me_P);
            this.groupBox1.Controls.Add(this.lb_Me_R);
            this.groupBox1.Controls.Add(this.lb_Me_S);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_Total_Count);
            this.groupBox1.Controls.Add(this.lb_Draw_Score);
            this.groupBox1.Controls.Add(this.lb_Com_Score);
            this.groupBox1.Controls.Add(this.lb_Me_Score);
            this.groupBox1.Location = new System.Drawing.Point(361, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 291);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "게임 결과";
            // 
            // lb_Com_P
            // 
            this.lb_Com_P.AutoSize = true;
            this.lb_Com_P.Location = new System.Drawing.Point(145, 273);
            this.lb_Com_P.Name = "lb_Com_P";
            this.lb_Com_P.Size = new System.Drawing.Size(57, 15);
            this.lb_Com_P.TabIndex = 11;
            this.lb_Com_P.Text = "보 횟수";
            // 
            // lb_Com_R
            // 
            this.lb_Com_R.AutoSize = true;
            this.lb_Com_R.Location = new System.Drawing.Point(145, 239);
            this.lb_Com_R.Name = "lb_Com_R";
            this.lb_Com_R.Size = new System.Drawing.Size(67, 15);
            this.lb_Com_R.TabIndex = 10;
            this.lb_Com_R.Text = "바위횟수";
            // 
            // lb_Com_S
            // 
            this.lb_Com_S.AutoSize = true;
            this.lb_Com_S.Location = new System.Drawing.Point(145, 211);
            this.lb_Com_S.Name = "lb_Com_S";
            this.lb_Com_S.Size = new System.Drawing.Size(67, 15);
            this.lb_Com_S.TabIndex = 9;
            this.lb_Com_S.Text = "가위횟수";
            // 
            // lb_Me_P
            // 
            this.lb_Me_P.AutoSize = true;
            this.lb_Me_P.Location = new System.Drawing.Point(16, 273);
            this.lb_Me_P.Name = "lb_Me_P";
            this.lb_Me_P.Size = new System.Drawing.Size(57, 15);
            this.lb_Me_P.TabIndex = 8;
            this.lb_Me_P.Text = "보 횟수";
            // 
            // lb_Me_R
            // 
            this.lb_Me_R.AutoSize = true;
            this.lb_Me_R.Location = new System.Drawing.Point(16, 239);
            this.lb_Me_R.Name = "lb_Me_R";
            this.lb_Me_R.Size = new System.Drawing.Size(67, 15);
            this.lb_Me_R.TabIndex = 7;
            this.lb_Me_R.Text = "바위횟수";
            // 
            // lb_Me_S
            // 
            this.lb_Me_S.AutoSize = true;
            this.lb_Me_S.Location = new System.Drawing.Point(16, 212);
            this.lb_Me_S.Name = "lb_Me_S";
            this.lb_Me_S.Size = new System.Drawing.Size(67, 15);
            this.lb_Me_S.TabIndex = 6;
            this.lb_Me_S.Text = "가위횟수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "컴";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "나";
            // 
            // lb_Total_Count
            // 
            this.lb_Total_Count.AutoSize = true;
            this.lb_Total_Count.Location = new System.Drawing.Point(33, 96);
            this.lb_Total_Count.Name = "lb_Total_Count";
            this.lb_Total_Count.Size = new System.Drawing.Size(92, 15);
            this.lb_Total_Count.TabIndex = 3;
            this.lb_Total_Count.Text = "총 게임 횟수";
            // 
            // lb_Draw_Score
            // 
            this.lb_Draw_Score.AutoSize = true;
            this.lb_Draw_Score.Location = new System.Drawing.Point(33, 73);
            this.lb_Draw_Score.Name = "lb_Draw_Score";
            this.lb_Draw_Score.Size = new System.Drawing.Size(72, 15);
            this.lb_Draw_Score.TabIndex = 2;
            this.lb_Draw_Score.Text = "비긴 횟수";
            // 
            // lb_Com_Score
            // 
            this.lb_Com_Score.AutoSize = true;
            this.lb_Com_Score.Location = new System.Drawing.Point(33, 42);
            this.lb_Com_Score.Name = "lb_Com_Score";
            this.lb_Com_Score.Size = new System.Drawing.Size(107, 15);
            this.lb_Com_Score.TabIndex = 1;
            this.lb_Com_Score.Text = "컴이 이긴 횟수";
            // 
            // lb_Me_Score
            // 
            this.lb_Me_Score.AutoSize = true;
            this.lb_Me_Score.Location = new System.Drawing.Point(33, 21);
            this.lb_Me_Score.Name = "lb_Me_Score";
            this.lb_Me_Score.Size = new System.Drawing.Size(107, 15);
            this.lb_Me_Score.TabIndex = 0;
            this.lb_Me_Score.Text = "내가 이긴 횟수";
            // 
            // kmk_가위바위보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_View_Result);
            this.Controls.Add(this.Papper);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.Scissor);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMe);
            this.Controls.Add(this.lbCom);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(370, 400);
            this.Name = "kmk_가위바위보";
            this.Text = "가위바위보";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.Label lbMe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button Scissor;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Papper;
        private System.Windows.Forms.Timer Timer_View_Result;
        private System.Windows.Forms.Button btn_View_Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Com_P;
        private System.Windows.Forms.Label lb_Com_R;
        private System.Windows.Forms.Label lb_Com_S;
        private System.Windows.Forms.Label lb_Me_P;
        private System.Windows.Forms.Label lb_Me_R;
        private System.Windows.Forms.Label lb_Me_S;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Total_Count;
        private System.Windows.Forms.Label lb_Draw_Score;
        private System.Windows.Forms.Label lb_Com_Score;
        private System.Windows.Forms.Label lb_Me_Score;
    }
}

