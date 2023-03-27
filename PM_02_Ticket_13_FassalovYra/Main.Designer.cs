
namespace PM_02_Ticket_13_FassalovYra
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.сontainerImg = new System.Windows.Forms.Panel();
            this.containerInfo = new System.Windows.Forms.Panel();
            this.сontainerContent = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.сontainerBottom = new System.Windows.Forms.Panel();
            this.buttonIssue = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.сontainerTop = new System.Windows.Forms.Panel();
            this.labelViews = new System.Windows.Forms.Label();
            this.comboBoxViews = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.buttonOpenImg = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.сontainerImg.SuspendLayout();
            this.containerInfo.SuspendLayout();
            this.сontainerContent.SuspendLayout();
            this.сontainerBottom.SuspendLayout();
            this.сontainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 489);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.сontainerImg);
            this.tabPageMain.Controls.Add(this.containerInfo);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(792, 460);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Театр";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // сontainerImg
            // 
            this.сontainerImg.Controls.Add(this.buttonOpenImg);
            this.сontainerImg.Controls.Add(this.pictureBoxImg);
            this.сontainerImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.сontainerImg.Location = new System.Drawing.Point(267, 3);
            this.сontainerImg.Name = "сontainerImg";
            this.сontainerImg.Padding = new System.Windows.Forms.Padding(50);
            this.сontainerImg.Size = new System.Drawing.Size(522, 454);
            this.сontainerImg.TabIndex = 2;
            // 
            // containerInfo
            // 
            this.containerInfo.Controls.Add(this.сontainerContent);
            this.containerInfo.Controls.Add(this.сontainerBottom);
            this.containerInfo.Controls.Add(this.сontainerTop);
            this.containerInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.containerInfo.Location = new System.Drawing.Point(3, 3);
            this.containerInfo.Name = "containerInfo";
            this.containerInfo.Size = new System.Drawing.Size(264, 454);
            this.containerInfo.TabIndex = 1;
            // 
            // сontainerContent
            // 
            this.сontainerContent.AutoScroll = true;
            this.сontainerContent.Controls.Add(this.radioButton3);
            this.сontainerContent.Controls.Add(this.radioButton2);
            this.сontainerContent.Controls.Add(this.radioButton1);
            this.сontainerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.сontainerContent.Location = new System.Drawing.Point(0, 72);
            this.сontainerContent.Name = "сontainerContent";
            this.сontainerContent.Padding = new System.Windows.Forms.Padding(10, 10, 0, 510);
            this.сontainerContent.Size = new System.Drawing.Size(264, 159);
            this.сontainerContent.TabIndex = 2;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.Location = new System.Drawing.Point(10, 92);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.radioButton3.Size = new System.Drawing.Size(233, 41);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.Location = new System.Drawing.Point(10, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.radioButton2.Size = new System.Drawing.Size(233, 41);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.Location = new System.Drawing.Point(10, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.radioButton1.Size = new System.Drawing.Size(233, 41);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // сontainerBottom
            // 
            this.сontainerBottom.Controls.Add(this.numericUpDownQuantity);
            this.сontainerBottom.Controls.Add(this.buttonIssue);
            this.сontainerBottom.Controls.Add(this.labelInformation);
            this.сontainerBottom.Controls.Add(this.buttonCalculation);
            this.сontainerBottom.Controls.Add(this.labelQuantity);
            this.сontainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.сontainerBottom.Location = new System.Drawing.Point(0, 231);
            this.сontainerBottom.Name = "сontainerBottom";
            this.сontainerBottom.Size = new System.Drawing.Size(264, 223);
            this.сontainerBottom.TabIndex = 1;
            // 
            // buttonIssue
            // 
            this.buttonIssue.Location = new System.Drawing.Point(8, 193);
            this.buttonIssue.Name = "buttonIssue";
            this.buttonIssue.Size = new System.Drawing.Size(248, 25);
            this.buttonIssue.TabIndex = 6;
            this.buttonIssue.Text = "Оформить квитанцию";
            this.buttonIssue.UseVisualStyleBackColor = true;
            this.buttonIssue.Click += new System.EventHandler(this.buttonIssue_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInformation.AutoEllipsis = true;
            this.labelInformation.Location = new System.Drawing.Point(10, 91);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(248, 99);
            this.labelInformation.TabIndex = 5;
            this.labelInformation.Text = "Вывод информации о\nсеанса";
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Location = new System.Drawing.Point(10, 63);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(248, 25);
            this.buttonCalculation.TabIndex = 4;
            this.buttonCalculation.Text = "Расчет";
            this.buttonCalculation.UseVisualStyleBackColor = true;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(7, 14);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(86, 17);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Количество";
            // 
            // сontainerTop
            // 
            this.сontainerTop.Controls.Add(this.labelViews);
            this.сontainerTop.Controls.Add(this.comboBoxViews);
            this.сontainerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.сontainerTop.Location = new System.Drawing.Point(0, 0);
            this.сontainerTop.Name = "сontainerTop";
            this.сontainerTop.Size = new System.Drawing.Size(264, 72);
            this.сontainerTop.TabIndex = 0;
            // 
            // labelViews
            // 
            this.labelViews.AutoSize = true;
            this.labelViews.Location = new System.Drawing.Point(5, 10);
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(111, 17);
            this.labelViews.TabIndex = 1;
            this.labelViews.Text = "Представление";
            // 
            // comboBoxViews
            // 
            this.comboBoxViews.FormattingEnabled = true;
            this.comboBoxViews.Location = new System.Drawing.Point(5, 30);
            this.comboBoxViews.Name = "comboBoxViews";
            this.comboBoxViews.Size = new System.Drawing.Size(212, 24);
            this.comboBoxViews.TabIndex = 0;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(10, 35);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(207, 22);
            this.numericUpDownQuantity.TabIndex = 7;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxImg.Location = new System.Drawing.Point(50, 50);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(422, 300);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImg.TabIndex = 0;
            this.pictureBoxImg.TabStop = false;
            // 
            // buttonOpenImg
            // 
            this.buttonOpenImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpenImg.Location = new System.Drawing.Point(195, 356);
            this.buttonOpenImg.Name = "buttonOpenImg";
            this.buttonOpenImg.Size = new System.Drawing.Size(147, 32);
            this.buttonOpenImg.TabIndex = 1;
            this.buttonOpenImg.Text = "Добавить афишу";
            this.buttonOpenImg.UseVisualStyleBackColor = true;
            this.buttonOpenImg.Click += new System.EventHandler(this.buttonOpenImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Театр";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.сontainerImg.ResumeLayout(false);
            this.containerInfo.ResumeLayout(false);
            this.сontainerContent.ResumeLayout(false);
            this.сontainerContent.PerformLayout();
            this.сontainerBottom.ResumeLayout(false);
            this.сontainerBottom.PerformLayout();
            this.сontainerTop.ResumeLayout(false);
            this.сontainerTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.Panel containerInfo;
        private System.Windows.Forms.ComboBox comboBoxViews;
        private System.Windows.Forms.Panel сontainerImg;
        private System.Windows.Forms.Panel сontainerContent;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel сontainerBottom;
        private System.Windows.Forms.Button buttonCalculation;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Panel сontainerTop;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.Button buttonIssue;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.Button buttonOpenImg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

