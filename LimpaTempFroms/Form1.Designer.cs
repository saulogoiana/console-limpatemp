namespace LimpaTempFroms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelQtdTempFiles = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxLocals = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivos Temporários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Lime;
            this.labelStatus.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelStatus.Location = new System.Drawing.Point(218, 84);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 18);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelQtdTempFiles
            // 
            this.labelQtdTempFiles.AutoSize = true;
            this.labelQtdTempFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdTempFiles.ForeColor = System.Drawing.Color.Black;
            this.labelQtdTempFiles.Location = new System.Drawing.Point(22, 9);
            this.labelQtdTempFiles.Name = "labelQtdTempFiles";
            this.labelQtdTempFiles.Size = new System.Drawing.Size(0, 20);
            this.labelQtdTempFiles.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(69, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "LIMPAR TODOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxLocals
            // 
            this.comboBoxLocals.FormattingEnabled = true;
            this.comboBoxLocals.Location = new System.Drawing.Point(12, 42);
            this.comboBoxLocals.Name = "comboBoxLocals";
            this.comboBoxLocals.Size = new System.Drawing.Size(189, 21);
            this.comboBoxLocals.TabIndex = 4;
            this.comboBoxLocals.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocals_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 114);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxLocals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelQtdTempFiles);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temp Cleaner";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelQtdTempFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxLocals;
        private System.Windows.Forms.Button button2;
    }
}

