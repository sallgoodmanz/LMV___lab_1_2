

namespace Laboratory_work_1_2
{
    public partial class Form1 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.buttonDefaultMessage = new System.Windows.Forms.Button();
            this.buttonClearMessage = new System.Windows.Forms.Button();
            this.comboBoxChooseProgram = new System.Windows.Forms.ComboBox();
            this.labelRunAProgram = new System.Windows.Forms.Label();
            this.buttonRunAProgram = new System.Windows.Forms.Button();
            this.groupBoxEnable = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableProgram = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableMessage = new System.Windows.Forms.CheckBox();
            this.groupBoxShow = new System.Windows.Forms.GroupBox();
            this.checkBoxShowProgram = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMessage = new System.Windows.Forms.CheckBox();
            this.buttonGet_Text = new System.Windows.Forms.Button();
            this.groupBoxEnable.SuspendLayout();
            this.groupBoxShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Exit);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new System.Drawing.Point(71, 61);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(149, 25);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Enter a message";
            this.labelMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(226, 61);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(310, 33);
            this.textBoxMessage.TabIndex = 2;
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowMessage.Location = new System.Drawing.Point(570, 50);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(154, 46);
            this.buttonShowMessage.TabIndex = 3;
            this.buttonShowMessage.Text = "Show message";
            this.buttonShowMessage.UseVisualStyleBackColor = true;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // 
            // buttonDefaultMessage
            // 
            this.buttonDefaultMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDefaultMessage.Location = new System.Drawing.Point(119, 131);
            this.buttonDefaultMessage.Name = "buttonDefaultMessage";
            this.buttonDefaultMessage.Size = new System.Drawing.Size(197, 45);
            this.buttonDefaultMessage.TabIndex = 4;
            this.buttonDefaultMessage.Text = "Default Message";
            this.buttonDefaultMessage.UseVisualStyleBackColor = true;
            this.buttonDefaultMessage.Click += new System.EventHandler(this.buttonDefaultMessage_Click);
            // 
            // buttonClearMessage
            // 
            this.buttonClearMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearMessage.Location = new System.Drawing.Point(486, 131);
            this.buttonClearMessage.Name = "buttonClearMessage";
            this.buttonClearMessage.Size = new System.Drawing.Size(197, 45);
            this.buttonClearMessage.TabIndex = 5;
            this.buttonClearMessage.Text = "Clear Message";
            this.buttonClearMessage.UseVisualStyleBackColor = true;
            this.buttonClearMessage.Click += new System.EventHandler(this.buttonClearMessage_Click);
            // 
            // comboBoxChooseProgram
            // 
            this.comboBoxChooseProgram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChooseProgram.FormattingEnabled = true;
            this.comboBoxChooseProgram.Items.AddRange(new object[] {
            "Блокнот",
            "Калькулятор",
            "Paint",
            "Панель управления",
            "Командная строка"});
            this.comboBoxChooseProgram.Location = new System.Drawing.Point(226, 237);
            this.comboBoxChooseProgram.Name = "comboBoxChooseProgram";
            this.comboBoxChooseProgram.Size = new System.Drawing.Size(310, 33);
            this.comboBoxChooseProgram.TabIndex = 6;
            this.comboBoxChooseProgram.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseProgram_SelectedIndexChanged);
            // 
            // labelRunAProgram
            // 
            this.labelRunAProgram.AutoSize = true;
            this.labelRunAProgram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRunAProgram.Location = new System.Drawing.Point(71, 240);
            this.labelRunAProgram.Name = "labelRunAProgram";
            this.labelRunAProgram.Size = new System.Drawing.Size(138, 25);
            this.labelRunAProgram.TabIndex = 7;
            this.labelRunAProgram.Text = "Run a program";
            this.labelRunAProgram.Click += new System.EventHandler(this.labelRunAProgram_Click);
            // 
            // buttonRunAProgram
            // 
            this.buttonRunAProgram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRunAProgram.Location = new System.Drawing.Point(582, 233);
            this.buttonRunAProgram.Name = "buttonRunAProgram";
            this.buttonRunAProgram.Size = new System.Drawing.Size(161, 37);
            this.buttonRunAProgram.TabIndex = 8;
            this.buttonRunAProgram.Text = "Run a program";
            this.buttonRunAProgram.UseVisualStyleBackColor = true;
            this.buttonRunAProgram.Click += new System.EventHandler(this.buttonRunAProgram_Click);
            // 
            // groupBoxEnable
            // 
            this.groupBoxEnable.Controls.Add(this.checkBoxEnableProgram);
            this.groupBoxEnable.Controls.Add(this.checkBoxEnableMessage);
            this.groupBoxEnable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEnable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxEnable.Location = new System.Drawing.Point(122, 302);
            this.groupBoxEnable.Name = "groupBoxEnable";
            this.groupBoxEnable.Size = new System.Drawing.Size(204, 88);
            this.groupBoxEnable.TabIndex = 9;
            this.groupBoxEnable.TabStop = false;
            this.groupBoxEnable.Text = "Enable Actions";
            this.groupBoxEnable.Enter += new System.EventHandler(this.groupBoxEnable_Enter);
            // 
            // checkBoxEnableProgram
            // 
            this.checkBoxEnableProgram.AutoSize = true;
            this.checkBoxEnableProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEnableProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxEnableProgram.Location = new System.Drawing.Point(6, 57);
            this.checkBoxEnableProgram.Name = "checkBoxEnableProgram";
            this.checkBoxEnableProgram.Size = new System.Drawing.Size(188, 25);
            this.checkBoxEnableProgram.TabIndex = 1;
            this.checkBoxEnableProgram.Text = "Enable Program Action";
            this.checkBoxEnableProgram.UseVisualStyleBackColor = true;
            this.checkBoxEnableProgram.CheckedChanged += new System.EventHandler(this.checkBoxEnableProgram_CheckedChanged);
            // 
            // checkBoxEnableMessage
            // 
            this.checkBoxEnableMessage.AutoSize = true;
            this.checkBoxEnableMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEnableMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxEnableMessage.Location = new System.Drawing.Point(6, 28);
            this.checkBoxEnableMessage.Name = "checkBoxEnableMessage";
            this.checkBoxEnableMessage.Size = new System.Drawing.Size(188, 25);
            this.checkBoxEnableMessage.TabIndex = 0;
            this.checkBoxEnableMessage.Text = "Enable Message Action";
            this.checkBoxEnableMessage.UseVisualStyleBackColor = true;
            this.checkBoxEnableMessage.CheckedChanged += new System.EventHandler(this.checkBoxEnableMessage_CheckedChanged);
            // 
            // groupBoxShow
            // 
            this.groupBoxShow.Controls.Add(this.checkBoxShowProgram);
            this.groupBoxShow.Controls.Add(this.checkBoxShowMessage);
            this.groupBoxShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxShow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxShow.Location = new System.Drawing.Point(526, 302);
            this.groupBoxShow.Name = "groupBoxShow";
            this.groupBoxShow.Size = new System.Drawing.Size(185, 88);
            this.groupBoxShow.TabIndex = 10;
            this.groupBoxShow.TabStop = false;
            this.groupBoxShow.Text = "Show Actions";
            this.groupBoxShow.Enter += new System.EventHandler(this.groupBoxShow_Enter);
            // 
            // checkBoxShowProgram
            // 
            this.checkBoxShowProgram.AutoSize = true;
            this.checkBoxShowProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxShowProgram.Location = new System.Drawing.Point(7, 62);
            this.checkBoxShowProgram.Name = "checkBoxShowProgram";
            this.checkBoxShowProgram.Size = new System.Drawing.Size(181, 25);
            this.checkBoxShowProgram.TabIndex = 1;
            this.checkBoxShowProgram.Text = "Show Program Action";
            this.checkBoxShowProgram.UseVisualStyleBackColor = true;
            this.checkBoxShowProgram.CheckedChanged += new System.EventHandler(this.checkBoxShowProgram_CheckedChanged);
            // 
            // checkBoxShowMessage
            // 
            this.checkBoxShowMessage.AutoSize = true;
            this.checkBoxShowMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxShowMessage.Location = new System.Drawing.Point(7, 33);
            this.checkBoxShowMessage.Name = "checkBoxShowMessage";
            this.checkBoxShowMessage.Size = new System.Drawing.Size(181, 25);
            this.checkBoxShowMessage.TabIndex = 0;
            this.checkBoxShowMessage.Text = "Show Message Action";
            this.checkBoxShowMessage.UseVisualStyleBackColor = true;
            this.checkBoxShowMessage.CheckedChanged += new System.EventHandler(this.checkBoxShowMessage_CheckedChanged);
            // 
            // buttonGet_Text
            // 
            this.buttonGet_Text.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGet_Text.Location = new System.Drawing.Point(330, 184);
            this.buttonGet_Text.Name = "buttonGet_Text";
            this.buttonGet_Text.Size = new System.Drawing.Size(136, 34);
            this.buttonGet_Text.TabIndex = 11;
            this.buttonGet_Text.Text = "Get text";
            this.buttonGet_Text.UseVisualStyleBackColor = true;
            this.buttonGet_Text.Click += new System.EventHandler(this.buttonGet_Text_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGet_Text);
            this.Controls.Add(this.groupBoxEnable);
            this.Controls.Add(this.groupBoxShow);
            this.Controls.Add(this.buttonRunAProgram);
            this.Controls.Add(this.labelRunAProgram);
            this.Controls.Add(this.comboBoxChooseProgram);
            this.Controls.Add(this.buttonClearMessage);
            this.Controls.Add(this.buttonDefaultMessage);
            this.Controls.Add(this.buttonShowMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEnable.ResumeLayout(false);
            this.groupBoxEnable.PerformLayout();
            this.groupBoxShow.ResumeLayout(false);
            this.groupBoxShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonShowMessage;
        private System.Windows.Forms.Button buttonDefaultMessage;
        private System.Windows.Forms.Button buttonClearMessage;
        private System.Windows.Forms.ComboBox comboBoxChooseProgram;
        private System.Windows.Forms.Label labelRunAProgram;
        private System.Windows.Forms.Button buttonRunAProgram;
        private System.Windows.Forms.GroupBox groupBoxEnable;
        private System.Windows.Forms.GroupBox groupBoxShow;
        private System.Windows.Forms.CheckBox checkBoxEnableProgram;
        private System.Windows.Forms.CheckBox checkBoxEnableMessage;
        private System.Windows.Forms.CheckBox checkBoxShowProgram;
        private System.Windows.Forms.CheckBox checkBoxShowMessage;
        private System.Windows.Forms.Button buttonGet_Text;
    }
}

