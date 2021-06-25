
namespace HelloCSharpWin
{
    partial class Calculator
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
            this.HelloLabel1 = new System.Windows.Forms.Label();
            this.Sum1 = new System.Windows.Forms.TextBox();
            this.Sum2 = new System.Windows.Forms.TextBox();
            this.SumNumbers = new System.Windows.Forms.Button();
            this.SumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloLabel1
            // 
            this.HelloLabel1.AutoSize = true;
            this.HelloLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel1.Location = new System.Drawing.Point(33, 33);
            this.HelloLabel1.Name = "HelloLabel1";
            this.HelloLabel1.Size = new System.Drawing.Size(105, 12);
            this.HelloLabel1.TabIndex = 0;
            this.HelloLabel1.Text = "여기를 클릭하세요";
            this.HelloLabel1.Click += new System.EventHandler(this.Hellolabel1_Click);
            // 
            // Sum1
            // 
            this.Sum1.Location = new System.Drawing.Point(35, 76);
            this.Sum1.Name = "Sum1";
            this.Sum1.Size = new System.Drawing.Size(100, 21);
            this.Sum1.TabIndex = 1;
            // 
            // Sum2
            // 
            this.Sum2.Location = new System.Drawing.Point(152, 76);
            this.Sum2.Name = "Sum2";
            this.Sum2.Size = new System.Drawing.Size(100, 21);
            this.Sum2.TabIndex = 2;
            // 
            // SumNumbers
            // 
            this.SumNumbers.Location = new System.Drawing.Point(270, 76);
            this.SumNumbers.Name = "SumNumbers";
            this.SumNumbers.Size = new System.Drawing.Size(75, 23);
            this.SumNumbers.TabIndex = 3;
            this.SumNumbers.Text = "=";
            this.SumNumbers.UseVisualStyleBackColor = true;
            this.SumNumbers.Click += new System.EventHandler(this.SumNumbers_Click);
            // 
            // SumResult
            // 
            this.SumResult.Location = new System.Drawing.Point(364, 76);
            this.SumResult.Name = "SumResult";
            this.SumResult.Size = new System.Drawing.Size(100, 21);
            this.SumResult.TabIndex = 4;
            // 
            // Calculator
            // 
            this.ClientSize = new System.Drawing.Size(534, 338);
            this.Controls.Add(this.SumResult);
            this.Controls.Add(this.SumNumbers);
            this.Controls.Add(this.Sum2);
            this.Controls.Add(this.Sum1);
            this.Controls.Add(this.HelloLabel1);
            this.Name = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label HelloLabel1;
        private System.Windows.Forms.TextBox Sum1;
        private System.Windows.Forms.TextBox Sum2;
        private System.Windows.Forms.Button SumNumbers;
        private System.Windows.Forms.TextBox SumResult;
    }
}

