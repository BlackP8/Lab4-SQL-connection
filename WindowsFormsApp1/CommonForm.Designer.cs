
namespace WindowsFormsApp1
{
    partial class CommonForm
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
            this.btnOpenBenches = new System.Windows.Forms.Button();
            this.btnOpenGilds = new System.Windows.Forms.Button();
            this.btnOpenDetails = new System.Windows.Forms.Button();
            this.btnOpenMods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "В данной программе пользователь может сгенерировать\r\nданные для таблицы из файла " +
    "и добавить значение на сервер\r\nслучайным образом.\r\nВыберите форму, которую хотит" +
    "е открыть:";
            // 
            // btnOpenBenches
            // 
            this.btnOpenBenches.Location = new System.Drawing.Point(41, 122);
            this.btnOpenBenches.Name = "btnOpenBenches";
            this.btnOpenBenches.Size = new System.Drawing.Size(88, 34);
            this.btnOpenBenches.TabIndex = 1;
            this.btnOpenBenches.Text = "Станки";
            this.btnOpenBenches.UseVisualStyleBackColor = true;
            this.btnOpenBenches.Click += new System.EventHandler(this.btnOpenBenches_Click);
            // 
            // btnOpenGilds
            // 
            this.btnOpenGilds.Location = new System.Drawing.Point(41, 179);
            this.btnOpenGilds.Name = "btnOpenGilds";
            this.btnOpenGilds.Size = new System.Drawing.Size(88, 34);
            this.btnOpenGilds.TabIndex = 2;
            this.btnOpenGilds.Text = "Цеха";
            this.btnOpenGilds.UseVisualStyleBackColor = true;
            this.btnOpenGilds.Click += new System.EventHandler(this.btnOpenGilds_Click);
            // 
            // btnOpenDetails
            // 
            this.btnOpenDetails.Location = new System.Drawing.Point(290, 179);
            this.btnOpenDetails.Name = "btnOpenDetails";
            this.btnOpenDetails.Size = new System.Drawing.Size(88, 34);
            this.btnOpenDetails.TabIndex = 3;
            this.btnOpenDetails.Text = "Детали";
            this.btnOpenDetails.UseVisualStyleBackColor = true;
            this.btnOpenDetails.Click += new System.EventHandler(this.btnOpenDetails_Click);
            // 
            // btnOpenMods
            // 
            this.btnOpenMods.Location = new System.Drawing.Point(290, 122);
            this.btnOpenMods.Name = "btnOpenMods";
            this.btnOpenMods.Size = new System.Drawing.Size(143, 35);
            this.btnOpenMods.TabIndex = 4;
            this.btnOpenMods.Text = "Модификации";
            this.btnOpenMods.UseVisualStyleBackColor = true;
            this.btnOpenMods.Click += new System.EventHandler(this.btnOpenMods_Click);
            // 
            // CommonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 238);
            this.Controls.Add(this.btnOpenMods);
            this.Controls.Add(this.btnOpenDetails);
            this.Controls.Add(this.btnOpenGilds);
            this.Controls.Add(this.btnOpenBenches);
            this.Controls.Add(this.label1);
            this.Name = "CommonForm";
            this.Text = "CommonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenBenches;
        private System.Windows.Forms.Button btnOpenGilds;
        private System.Windows.Forms.Button btnOpenDetails;
        private System.Windows.Forms.Button btnOpenMods;
    }
}