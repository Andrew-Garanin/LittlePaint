
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
            this.Lines = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemDDA = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBrezLine = new System.Windows.Forms.ToolStripMenuItem();
            this.IrracionalEndsLine = new System.Windows.Forms.ToolStripMenuItem();
            this.circleButton = new System.Windows.Forms.ToolStripButton();
            this.bezierButton = new System.Windows.Forms.ToolStripButton();
            this.Cutters = new System.Windows.Forms.ToolStripDropDownButton();
            this.Cutter1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Cutter2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Cutter3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorButton = new System.Windows.Forms.ToolStripButton();
            this.Ax = new System.Windows.Forms.TextBox();
            this.Ay = new System.Windows.Forms.TextBox();
            this.Bx = new System.Windows.Forms.TextBox();
            this.By = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drawlineBtn = new System.Windows.Forms.Button();
            this.groupBoxIrrEndsLine = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBoxIrrEndsLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lines,
            this.circleButton,
            this.bezierButton,
            this.Cutters,
            this.toolStripSeparator1,
            this.colorButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(985, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Lines
            // 
            this.Lines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Lines.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDDA,
            this.MenuItemBrezLine,
            this.IrracionalEndsLine});
            this.Lines.Image = global::LittlePaint.Properties.Resources.Line;
            this.Lines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(34, 24);
            this.Lines.Text = "toolStripDropDownButton1";
            // 
            // MenuItemDDA
            // 
            this.MenuItemDDA.Name = "MenuItemDDA";
            this.MenuItemDDA.Size = new System.Drawing.Size(398, 26);
            this.MenuItemDDA.Text = "DDA алгоритм";
            this.MenuItemDDA.Click += new System.EventHandler(this.MenuItemDDA_Click);
            // 
            // MenuItemBrezLine
            // 
            this.MenuItemBrezLine.Name = "MenuItemBrezLine";
            this.MenuItemBrezLine.Size = new System.Drawing.Size(398, 26);
            this.MenuItemBrezLine.Text = "Алгоритм Брезенхема";
            this.MenuItemBrezLine.Click += new System.EventHandler(this.MenuItemBrezLine_Click);
            // 
            // IrracionalEndsLine
            // 
            this.IrracionalEndsLine.Name = "IrracionalEndsLine";
            this.IrracionalEndsLine.Size = new System.Drawing.Size(398, 26);
            this.IrracionalEndsLine.Text = "Отрезок с нецелыми координатами концов";
            this.IrracionalEndsLine.Click += new System.EventHandler(this.IrracionalEndsLine_Click);
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
            this.bezierButton.ToolTipText = "Кривая безье";
            this.bezierButton.Click += new System.EventHandler(this.BezierButton_Click);
            // 
            // Cutters
            // 
            this.Cutters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cutters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cutter1,
            this.Cutter2,
            this.Cutter3});
            this.Cutters.Image = global::LittlePaint.Properties.Resources.Cutter;
            this.Cutters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cutters.Name = "Cutters";
            this.Cutters.Size = new System.Drawing.Size(34, 24);
            this.Cutters.Text = "toolStripDropDownButton2";
            // 
            // Cutter1
            // 
            this.Cutter1.Name = "Cutter1";
            this.Cutter1.Size = new System.Drawing.Size(294, 26);
            this.Cutter1.Text = "Алгоритм Коэна-Сазерленда";
            this.Cutter1.Click += new System.EventHandler(this.Cutter1_Click);
            // 
            // Cutter2
            // 
            this.Cutter2.Name = "Cutter2";
            this.Cutter2.Size = new System.Drawing.Size(294, 26);
            this.Cutter2.Text = "Алгоритм Кируса-Бека";
            this.Cutter2.Click += new System.EventHandler(this.Cutter2_Click);
            // 
            // Cutter3
            // 
            this.Cutter3.Name = "Cutter3";
            this.Cutter3.Size = new System.Drawing.Size(294, 26);
            this.Cutter3.Text = "Алгоритм средней точки";
            this.Cutter3.Click += new System.EventHandler(this.Cutter3_Click);
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
            // Ax
            // 
            this.Ax.Location = new System.Drawing.Point(93, 38);
            this.Ax.Name = "Ax";
            this.Ax.Size = new System.Drawing.Size(100, 22);
            this.Ax.TabIndex = 2;
            // 
            // Ay
            // 
            this.Ay.Location = new System.Drawing.Point(93, 76);
            this.Ay.Name = "Ay";
            this.Ay.Size = new System.Drawing.Size(100, 22);
            this.Ay.TabIndex = 2;
            // 
            // Bx
            // 
            this.Bx.Location = new System.Drawing.Point(305, 38);
            this.Bx.Name = "Bx";
            this.Bx.Size = new System.Drawing.Size(100, 22);
            this.Bx.TabIndex = 2;
            // 
            // By
            // 
            this.By.Location = new System.Drawing.Point(305, 76);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(100, 22);
            this.By.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "By";
            // 
            // drawlineBtn
            // 
            this.drawlineBtn.Location = new System.Drawing.Point(174, 129);
            this.drawlineBtn.Name = "drawlineBtn";
            this.drawlineBtn.Size = new System.Drawing.Size(108, 33);
            this.drawlineBtn.TabIndex = 4;
            this.drawlineBtn.Text = "Нарисовать";
            this.drawlineBtn.UseVisualStyleBackColor = true;
            this.drawlineBtn.Click += new System.EventHandler(this.DrawlineBtn_Click);
            // 
            // groupBoxIrrEndsLine
            // 
            this.groupBoxIrrEndsLine.Controls.Add(this.By);
            this.groupBoxIrrEndsLine.Controls.Add(this.drawlineBtn);
            this.groupBoxIrrEndsLine.Controls.Add(this.Ax);
            this.groupBoxIrrEndsLine.Controls.Add(this.label4);
            this.groupBoxIrrEndsLine.Controls.Add(this.Ay);
            this.groupBoxIrrEndsLine.Controls.Add(this.label3);
            this.groupBoxIrrEndsLine.Controls.Add(this.Bx);
            this.groupBoxIrrEndsLine.Controls.Add(this.label2);
            this.groupBoxIrrEndsLine.Controls.Add(this.label1);
            this.groupBoxIrrEndsLine.Location = new System.Drawing.Point(529, 40);
            this.groupBoxIrrEndsLine.Name = "groupBoxIrrEndsLine";
            this.groupBoxIrrEndsLine.Size = new System.Drawing.Size(433, 198);
            this.groupBoxIrrEndsLine.TabIndex = 5;
            this.groupBoxIrrEndsLine.TabStop = false;
            this.groupBoxIrrEndsLine.Text = "Отрезок с нецелыми координатами концов";
            this.groupBoxIrrEndsLine.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 496);
            this.Controls.Add(this.groupBoxIrrEndsLine);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Рисовалка";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxIrrEndsLine.ResumeLayout(false);
            this.groupBoxIrrEndsLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton circleButton;
        private System.Windows.Forms.ToolStripButton bezierButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton colorButton;
        private System.Windows.Forms.ToolStripDropDownButton Lines;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDDA;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBrezLine;
        private System.Windows.Forms.ToolStripDropDownButton Cutters;
        private System.Windows.Forms.ToolStripMenuItem Cutter1;
        private System.Windows.Forms.ToolStripMenuItem Cutter2;
        private System.Windows.Forms.ToolStripMenuItem Cutter3;
        private System.Windows.Forms.TextBox Ax;
        private System.Windows.Forms.TextBox Ay;
        private System.Windows.Forms.TextBox Bx;
        private System.Windows.Forms.TextBox By;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button drawlineBtn;
        private System.Windows.Forms.ToolStripMenuItem IrracionalEndsLine;
        private System.Windows.Forms.GroupBox groupBoxIrrEndsLine;
    }
}

