
namespace LittlePaint
{
    partial class Form1
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
            this.colorSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorSelection
            // 
            this.colorSelection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorSelection.Location = new System.Drawing.Point(705, 12);
            this.colorSelection.Name = "colorSelection";
            this.colorSelection.Size = new System.Drawing.Size(83, 49);
            this.colorSelection.TabIndex = 0;
            this.colorSelection.Text = "Выбор цвета";
            this.colorSelection.UseVisualStyleBackColor = true;
            this.colorSelection.Click += new System.EventHandler(this.colorSelection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 496);
            this.Controls.Add(this.colorSelection);
            this.Name = "Form1";
            this.Text = "Попиксельное рисование";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colorSelection;
    }
}

