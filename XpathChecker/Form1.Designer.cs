namespace XpathChecker
{
    partial class Form1
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
            this.startBtn = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlSelect = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(599, 34);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(135, 35);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(110, 49);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(42, 20);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL";
            this.urlLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // urlSelect
            // 
            this.urlSelect.FormattingEnabled = true;
            this.urlSelect.Location = new System.Drawing.Point(158, 45);
            this.urlSelect.Name = "urlSelect";
            this.urlSelect.Size = new System.Drawing.Size(435, 28);
            this.urlSelect.TabIndex = 3;
            this.urlSelect.SelectedIndexChanged += new System.EventHandler(this.UrlSelect_SelectedIndexChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(599, 74);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(135, 34);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear List";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 120);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.urlSelect);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.startBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.ComboBox urlSelect;
        private System.Windows.Forms.Button clearBtn;
    }
}

