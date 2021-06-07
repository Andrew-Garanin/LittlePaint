
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lineButton = new System.Windows.Forms.ToolStripButton();
            this.circleButton = new System.Windows.Forms.ToolStripButton();
            this.bezierButton = new System.Windows.Forms.ToolStripButton();
            this.cutterButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineButton,
            this.circleButton,
            this.bezierButton,
            this.cutterButton,
            this.toolStripSeparator1,
            this.colorButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(803, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lineButton
            // 
            this.lineButton.CheckOnClick = true;
            this.lineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineButton.Image = global::LittlePaint.Properties.Resources.Line;
            this.lineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(29, 24);
            this.lineButton.Text = "toolStripButton1";
            this.lineButton.ToolTipText = "Линия";
            this.lineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.CheckOnClick = true;
            this.circleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circleButton.Image = global::LittlePaint.Properties.Resources.Circle;
            this.circleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(29, 24);
            this.circleButton.Text = "toolStripButton2";
            this.circleButton.ToolTipText = "Круг";
            this.circleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // bezierButton
            // 
            this.bezierButton.CheckOnClick = true;
            this.bezierButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bezierButton.Image = global::LittlePaint.Properties.Resources.Bezier;
            this.bezierButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bezierButton.Name = "bezierButton";
            this.bezierButton.Size = new System.Drawing.Size(29, 24);
            this.bezierButton.Text = "toolStripButton3";
            this.bezierButton.ToolTipText = "Кривая бизье";
            this.bezierButton.Click += new System.EventHandler(this.BezierButton_Click);
            // 
            // cutterButton
            // 
            this.cutterButton.CheckOnClick = true;
            this.cutterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutterButton.Image = global::LittlePaint.Properties.Resources.Cutter;
            this.cutterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutterButton.Name = "cutterButton";
            this.cutterButton.Size = new System.Drawing.Size(29, 24);
            this.cutterButton.Text = "toolStripButton1";
            this.cutterButton.ToolTipText = "Обрезание области";
            this.cutterButton.Click += new System.EventHandler(this.CutterButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // colorButton
            // 
            this.colorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorButton.Image = global::LittlePaint.Properties.Resources.Color;
            this.colorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(29, 24);
            this.colorButton.Text = "toolStripButton1";
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 496);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Рисовалка";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton lineButton;
        private System.Windows.Forms.ToolStripButton circleButton;
        private System.Windows.Forms.ToolStripButton bezierButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton colorButton;
        private System.Windows.Forms.ToolStripButton cutterButton;
    }
}

