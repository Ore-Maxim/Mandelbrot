namespace WindowsFormsApp2
{
    partial class Mandelbrot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mandelbrot));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анимацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderPixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ускоритьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замедлитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.построениеТочекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem,
            this.renderPixelToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.сохранитьИзображениеКакToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построениеТочекToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.анимацияToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            // 
            // анимацияToolStripMenuItem
            // 
            this.анимацияToolStripMenuItem.Name = "анимацияToolStripMenuItem";
            this.анимацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.анимацияToolStripMenuItem.Text = "Анимация";
            this.анимацияToolStripMenuItem.Click += new System.EventHandler(this.анимацияToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // renderPixelToolStripMenuItem
            // 
            this.renderPixelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьToolStripMenuItem1,
            this.ускоритьToolStripMenuItem,
            this.замедлитьToolStripMenuItem,
            this.выключитьToolStripMenuItem1});
            this.renderPixelToolStripMenuItem.Name = "renderPixelToolStripMenuItem";
            this.renderPixelToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.renderPixelToolStripMenuItem.Text = "Zoom";
            this.renderPixelToolStripMenuItem.Click += new System.EventHandler(this.renderPixelToolStripMenuItem_Click);
            // 
            // включитьToolStripMenuItem1
            // 
            this.включитьToolStripMenuItem1.Name = "включитьToolStripMenuItem1";
            this.включитьToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.включитьToolStripMenuItem1.Text = "Включить";
            this.включитьToolStripMenuItem1.Click += new System.EventHandler(this.включитьToolStripMenuItem1_Click);
            // 
            // ускоритьToolStripMenuItem
            // 
            this.ускоритьToolStripMenuItem.Name = "ускоритьToolStripMenuItem";
            this.ускоритьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ускоритьToolStripMenuItem.Text = "Ускорить";
            this.ускоритьToolStripMenuItem.Click += new System.EventHandler(this.ускоритьToolStripMenuItem_Click);
            // 
            // замедлитьToolStripMenuItem
            // 
            this.замедлитьToolStripMenuItem.Name = "замедлитьToolStripMenuItem";
            this.замедлитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.замедлитьToolStripMenuItem.Text = "Замедлить";
            this.замедлитьToolStripMenuItem.Click += new System.EventHandler(this.замедлитьToolStripMenuItem_Click);
            // 
            // выключитьToolStripMenuItem1
            // 
            this.выключитьToolStripMenuItem1.Name = "выключитьToolStripMenuItem1";
            this.выключитьToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.выключитьToolStripMenuItem1.Text = "Выключить";
            this.выключитьToolStripMenuItem1.Click += new System.EventHandler(this.выключитьToolStripMenuItem1_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.zoomToolStripMenuItem.Text = "Render";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // сохранитьИзображениеКакToolStripMenuItem
            // 
            this.сохранитьИзображениеКакToolStripMenuItem.Name = "сохранитьИзображениеКакToolStripMenuItem";
            this.сохранитьИзображениеКакToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.сохранитьИзображениеКакToolStripMenuItem.Text = "Сохранить изображение как";
            this.сохранитьИзображениеКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзображениеКакToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(405, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Re = None, Im = None;";
            // 
            // построениеТочекToolStripMenuItem
            // 
            this.построениеТочекToolStripMenuItem.Name = "построениеТочекToolStripMenuItem";
            this.построениеТочекToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.построениеТочекToolStripMenuItem.Text = "Построение точек";
            this.построениеТочекToolStripMenuItem.Click += new System.EventHandler(this.построениеТочекToolStripMenuItem_Click);
            // 
            // Mandelbrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mandelbrot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Множество Мандельброта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderPixelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ускоритьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замедлитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem анимацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построениеТочекToolStripMenuItem;
    }
}

