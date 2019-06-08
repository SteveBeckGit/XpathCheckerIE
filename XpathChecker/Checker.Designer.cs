namespace XpathChecker
{
    partial class Checker
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
            this.label1 = new System.Windows.Forms.Label();
            this.xpathBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalFound = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.defaultBtn = new System.Windows.Forms.RadioButton();
            this.ignoreFrames = new System.Windows.Forms.RadioButton();
            this.withinFramesBtn = new System.Windows.Forms.RadioButton();
            this.SearchRules = new System.Windows.Forms.GroupBox();
            this.WindowList = new System.Windows.Forms.ListView();
            this.switchWindow = new System.Windows.Forms.Button();
            this.GetWindows = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.curWIndowLabel = new System.Windows.Forms.Label();
            this.SearchRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xpath";
            // 
            // xpathBox
            // 
            this.xpathBox.Location = new System.Drawing.Point(206, 35);
            this.xpathBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xpathBox.Name = "xpathBox";
            this.xpathBox.Size = new System.Drawing.Size(362, 26);
            this.xpathBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(588, 31);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(143, 30);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elements Found:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalFound
            // 
            this.totalFound.AutoSize = true;
            this.totalFound.Location = new System.Drawing.Point(278, 163);
            this.totalFound.Name = "totalFound";
            this.totalFound.Size = new System.Drawing.Size(18, 20);
            this.totalFound.TabIndex = 4;
            this.totalFound.Text = "0";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(595, 68);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(135, 36);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // defaultBtn
            // 
            this.defaultBtn.AutoSize = true;
            this.defaultBtn.Checked = true;
            this.defaultBtn.Location = new System.Drawing.Point(14, 25);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(83, 24);
            this.defaultBtn.TabIndex = 6;
            this.defaultBtn.TabStop = true;
            this.defaultBtn.Text = "default";
            this.defaultBtn.UseVisualStyleBackColor = true;
            this.defaultBtn.CheckedChanged += new System.EventHandler(this.DefaultBtn_CheckedChanged);
            // 
            // ignoreFrames
            // 
            this.ignoreFrames.AutoSize = true;
            this.ignoreFrames.Location = new System.Drawing.Point(14, 52);
            this.ignoreFrames.Name = "ignoreFrames";
            this.ignoreFrames.Size = new System.Drawing.Size(148, 24);
            this.ignoreFrames.TabIndex = 7;
            this.ignoreFrames.Text = "Scan all Frames";
            this.ignoreFrames.UseVisualStyleBackColor = true;
            this.ignoreFrames.CheckedChanged += new System.EventHandler(this.IgnoreFrames_CheckedChanged);
            // 
            // withinFramesBtn
            // 
            this.withinFramesBtn.AutoSize = true;
            this.withinFramesBtn.Location = new System.Drawing.Point(149, 25);
            this.withinFramesBtn.Name = "withinFramesBtn";
            this.withinFramesBtn.Size = new System.Drawing.Size(185, 24);
            this.withinFramesBtn.TabIndex = 8;
            this.withinFramesBtn.Text = "Check Within Frames";
            this.withinFramesBtn.UseVisualStyleBackColor = true;
            this.withinFramesBtn.CheckedChanged += new System.EventHandler(this.WithinFramesBtn_CheckedChanged);
            // 
            // SearchRules
            // 
            this.SearchRules.Controls.Add(this.withinFramesBtn);
            this.SearchRules.Controls.Add(this.ignoreFrames);
            this.SearchRules.Controls.Add(this.defaultBtn);
            this.SearchRules.Location = new System.Drawing.Point(148, 68);
            this.SearchRules.Name = "SearchRules";
            this.SearchRules.Size = new System.Drawing.Size(375, 82);
            this.SearchRules.TabIndex = 9;
            this.SearchRules.TabStop = false;
            this.SearchRules.Text = "Find Behaviour";
            // 
            // WindowList
            // 
            this.WindowList.FullRowSelect = true;
            this.WindowList.GridLines = true;
            this.WindowList.Location = new System.Drawing.Point(101, 246);
            this.WindowList.Name = "WindowList";
            this.WindowList.Size = new System.Drawing.Size(632, 127);
            this.WindowList.TabIndex = 10;
            this.WindowList.UseCompatibleStateImageBehavior = false;
            this.WindowList.SelectedIndexChanged += new System.EventHandler(this.WindowList_SelectedIndexChanged);
            // 
            // switchWindow
            // 
            this.switchWindow.Location = new System.Drawing.Point(741, 289);
            this.switchWindow.Name = "switchWindow";
            this.switchWindow.Size = new System.Drawing.Size(115, 35);
            this.switchWindow.TabIndex = 11;
            this.switchWindow.Text = "switch";
            this.switchWindow.UseVisualStyleBackColor = true;
            this.switchWindow.Click += new System.EventHandler(this.SwitchWindow_Click);
            // 
            // GetWindows
            // 
            this.GetWindows.Location = new System.Drawing.Point(739, 246);
            this.GetWindows.Name = "GetWindows";
            this.GetWindows.Size = new System.Drawing.Size(116, 37);
            this.GetWindows.TabIndex = 12;
            this.GetWindows.Text = "Get Windows";
            this.GetWindows.UseVisualStyleBackColor = true;
            this.GetWindows.Click += new System.EventHandler(this.GetWindows_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Window : ";
            // 
            // curWIndowLabel
            // 
            this.curWIndowLabel.AutoSize = true;
            this.curWIndowLabel.Location = new System.Drawing.Point(245, 214);
            this.curWIndowLabel.Name = "curWIndowLabel";
            this.curWIndowLabel.Size = new System.Drawing.Size(0, 20);
            this.curWIndowLabel.TabIndex = 14;
            // 
            // Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.curWIndowLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GetWindows);
            this.Controls.Add(this.switchWindow);
            this.Controls.Add(this.WindowList);
            this.Controls.Add(this.SearchRules);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.totalFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.xpathBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Checker";
            this.Text = "Checker";
            this.Load += new System.EventHandler(this.Checker_Load);
            this.SearchRules.ResumeLayout(false);
            this.SearchRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xpathBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalFound;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.RadioButton defaultBtn;
        private System.Windows.Forms.RadioButton ignoreFrames;
        private System.Windows.Forms.RadioButton withinFramesBtn;
        private System.Windows.Forms.GroupBox SearchRules;
        private System.Windows.Forms.ListView WindowList;
        private System.Windows.Forms.Button switchWindow;
        private System.Windows.Forms.Button GetWindows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label curWIndowLabel;
    }
}