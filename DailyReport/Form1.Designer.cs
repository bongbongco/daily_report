namespace DailyReport
{
    partial class Form1
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
            this.createButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.startDate_TextBox = new System.Windows.Forms.TextBox();
            this.endDate_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateChange_Button = new System.Windows.Forms.Button();
            this.endDateChange_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 358);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(254, 80);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "생성";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // startDate_TextBox
            // 
            this.startDate_TextBox.Location = new System.Drawing.Point(366, 15);
            this.startDate_TextBox.Name = "startDate_TextBox";
            this.startDate_TextBox.Size = new System.Drawing.Size(159, 25);
            this.startDate_TextBox.TabIndex = 2;
            // 
            // endDate_TextBox
            // 
            this.endDate_TextBox.Location = new System.Drawing.Point(366, 47);
            this.endDate_TextBox.Name = "endDate_TextBox";
            this.endDate_TextBox.Size = new System.Drawing.Size(159, 25);
            this.endDate_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // startDateChange_Button
            // 
            this.startDateChange_Button.Location = new System.Drawing.Point(532, 15);
            this.startDateChange_Button.Name = "startDateChange_Button";
            this.startDateChange_Button.Size = new System.Drawing.Size(75, 25);
            this.startDateChange_Button.TabIndex = 6;
            this.startDateChange_Button.Text = "변경";
            this.startDateChange_Button.UseVisualStyleBackColor = true;
            this.startDateChange_Button.Click += new System.EventHandler(this.startDateChange_Button_Click);
            // 
            // endDateChange_Button
            // 
            this.endDateChange_Button.Location = new System.Drawing.Point(532, 47);
            this.endDateChange_Button.Name = "endDateChange_Button";
            this.endDateChange_Button.Size = new System.Drawing.Size(75, 25);
            this.endDateChange_Button.TabIndex = 7;
            this.endDateChange_Button.Text = "변경";
            this.endDateChange_Button.UseVisualStyleBackColor = true;
            this.endDateChange_Button.Click += new System.EventHandler(this.endDateChange_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.endDateChange_Button);
            this.Controls.Add(this.startDateChange_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDate_TextBox);
            this.Controls.Add(this.startDate_TextBox);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.createButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox startDate_TextBox;
        private System.Windows.Forms.TextBox endDate_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startDateChange_Button;
        private System.Windows.Forms.Button endDateChange_Button;
    }
}

