namespace Paint_App
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawPanel = new System.Windows.Forms.Panel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.brownButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.fileProcessPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeProcessPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.shapePanel = new System.Windows.Forms.Panel();
            this.rectanglePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.circlePanel = new System.Windows.Forms.Panel();
            this.hexagonPanel = new System.Windows.Forms.Panel();
            this.trianglePanel = new System.Windows.Forms.Panel();
            this.saveFilePanel = new System.Windows.Forms.Panel();
            this.openFilePanel = new System.Windows.Forms.Panel();
            this.newBoardPanel = new System.Windows.Forms.Panel();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.choosePanel = new System.Windows.Forms.Panel();
            this.colorPanel.SuspendLayout();
            this.fileProcessPanel.SuspendLayout();
            this.shapeProcessPanel.SuspendLayout();
            this.shapePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.Info;
            this.drawPanel.Location = new System.Drawing.Point(12, 12);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(734, 575);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseClick);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // colorPanel
            // 
            this.colorPanel.Controls.Add(this.label1);
            this.colorPanel.Controls.Add(this.yellowButton);
            this.colorPanel.Controls.Add(this.blackButton);
            this.colorPanel.Controls.Add(this.orangeButton);
            this.colorPanel.Controls.Add(this.purpleButton);
            this.colorPanel.Controls.Add(this.brownButton);
            this.colorPanel.Controls.Add(this.whiteButton);
            this.colorPanel.Controls.Add(this.greenButton);
            this.colorPanel.Controls.Add(this.blueButton);
            this.colorPanel.Controls.Add(this.redButton);
            this.colorPanel.Location = new System.Drawing.Point(749, 191);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(170, 165);
            this.colorPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RENK SEÇİMİ";
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(117, 72);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(50, 40);
            this.yellowButton.TabIndex = 8;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.Location = new System.Drawing.Point(61, 72);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(50, 40);
            this.blackButton.TabIndex = 7;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.Orange;
            this.orangeButton.Location = new System.Drawing.Point(4, 72);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(50, 40);
            this.orangeButton.TabIndex = 6;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.Purple;
            this.purpleButton.Location = new System.Drawing.Point(4, 118);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(50, 40);
            this.purpleButton.TabIndex = 5;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // brownButton
            // 
            this.brownButton.BackColor = System.Drawing.Color.Brown;
            this.brownButton.Location = new System.Drawing.Point(61, 118);
            this.brownButton.Name = "brownButton";
            this.brownButton.Size = new System.Drawing.Size(50, 40);
            this.brownButton.TabIndex = 4;
            this.brownButton.UseVisualStyleBackColor = false;
            this.brownButton.Click += new System.EventHandler(this.brownButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(117, 118);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(50, 40);
            this.whiteButton.TabIndex = 3;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(117, 26);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(50, 40);
            this.greenButton.TabIndex = 2;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(60, 26);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(50, 40);
            this.blueButton.TabIndex = 1;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redButton.Location = new System.Drawing.Point(4, 26);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(50, 40);
            this.redButton.TabIndex = 0;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // fileProcessPanel
            // 
            this.fileProcessPanel.Controls.Add(this.saveFilePanel);
            this.fileProcessPanel.Controls.Add(this.openFilePanel);
            this.fileProcessPanel.Controls.Add(this.label4);
            this.fileProcessPanel.Location = new System.Drawing.Point(749, 443);
            this.fileProcessPanel.Name = "fileProcessPanel";
            this.fileProcessPanel.Size = new System.Drawing.Size(170, 88);
            this.fileProcessPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DOSYA İŞLEMLERİ";
            // 
            // shapeProcessPanel
            // 
            this.shapeProcessPanel.Controls.Add(this.newBoardPanel);
            this.shapeProcessPanel.Controls.Add(this.deletePanel);
            this.shapeProcessPanel.Controls.Add(this.choosePanel);
            this.shapeProcessPanel.Controls.Add(this.label3);
            this.shapeProcessPanel.Location = new System.Drawing.Point(749, 362);
            this.shapeProcessPanel.Name = "shapeProcessPanel";
            this.shapeProcessPanel.Size = new System.Drawing.Size(170, 75);
            this.shapeProcessPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ŞEKİL İŞLEMLERİ";
            // 
            // shapePanel
            // 
            this.shapePanel.Controls.Add(this.rectanglePanel);
            this.shapePanel.Controls.Add(this.label2);
            this.shapePanel.Controls.Add(this.circlePanel);
            this.shapePanel.Controls.Add(this.hexagonPanel);
            this.shapePanel.Controls.Add(this.trianglePanel);
            this.shapePanel.Location = new System.Drawing.Point(749, 12);
            this.shapePanel.Name = "shapePanel";
            this.shapePanel.Size = new System.Drawing.Size(170, 173);
            this.shapePanel.TabIndex = 3;
            // 
            // rectanglePanel
            // 
            this.rectanglePanel.BackColor = System.Drawing.SystemColors.Info;
            this.rectanglePanel.Location = new System.Drawing.Point(3, 36);
            this.rectanglePanel.Name = "rectanglePanel";
            this.rectanglePanel.Size = new System.Drawing.Size(79, 62);
            this.rectanglePanel.TabIndex = 4;
            this.rectanglePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rectanglePanel_Paint);
            this.rectanglePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectanglePanel_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÇİZİM ŞEKLİ";
            // 
            // circlePanel
            // 
            this.circlePanel.BackColor = System.Drawing.SystemColors.Info;
            this.circlePanel.Location = new System.Drawing.Point(88, 36);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.Size = new System.Drawing.Size(79, 62);
            this.circlePanel.TabIndex = 2;
            this.circlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.circlePanel_Paint);
            this.circlePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.circlePanel_MouseClick);
            // 
            // hexagonPanel
            // 
            this.hexagonPanel.BackColor = System.Drawing.SystemColors.Info;
            this.hexagonPanel.Location = new System.Drawing.Point(88, 104);
            this.hexagonPanel.Name = "hexagonPanel";
            this.hexagonPanel.Size = new System.Drawing.Size(79, 63);
            this.hexagonPanel.TabIndex = 2;
            this.hexagonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.hexagonPanel_Paint);
            this.hexagonPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hexagonPanel_MouseClick);
            // 
            // trianglePanel
            // 
            this.trianglePanel.BackColor = System.Drawing.SystemColors.Info;
            this.trianglePanel.Location = new System.Drawing.Point(4, 104);
            this.trianglePanel.Name = "trianglePanel";
            this.trianglePanel.Size = new System.Drawing.Size(79, 63);
            this.trianglePanel.TabIndex = 2;
            this.trianglePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.trianglePanel_Paint);
            this.trianglePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trianglePanel_MouseClick);
            // 
            // saveFilePanel
            // 
            this.saveFilePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveFilePanel.BackgroundImage = global::Paint_App.Properties.Resources.floppy_35952_960_720;
            this.saveFilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveFilePanel.Location = new System.Drawing.Point(89, 25);
            this.saveFilePanel.Name = "saveFilePanel";
            this.saveFilePanel.Size = new System.Drawing.Size(78, 53);
            this.saveFilePanel.TabIndex = 3;
            this.saveFilePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveFilePanel_MouseClick);
            // 
            // openFilePanel
            // 
            this.openFilePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openFilePanel.BackgroundImage = global::Paint_App.Properties.Resources.file_folders1;
            this.openFilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openFilePanel.Location = new System.Drawing.Point(6, 25);
            this.openFilePanel.Name = "openFilePanel";
            this.openFilePanel.Size = new System.Drawing.Size(78, 53);
            this.openFilePanel.TabIndex = 2;
            this.openFilePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openFilePanel_MouseClick);
            // 
            // newBoardPanel
            // 
            this.newBoardPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.newBoardPanel.BackgroundImage = global::Paint_App.Properties.Resources.png_transparent_cartoon_paper_pencil_drawing_cartoon_pencil_food_fictional_character;
            this.newBoardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newBoardPanel.Location = new System.Drawing.Point(115, 25);
            this.newBoardPanel.Name = "newBoardPanel";
            this.newBoardPanel.Size = new System.Drawing.Size(52, 40);
            this.newBoardPanel.TabIndex = 3;
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deletePanel.BackgroundImage = global::Paint_App.Properties.Resources.çö_kutusu1;
            this.deletePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletePanel.Location = new System.Drawing.Point(60, 25);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(52, 40);
            this.deletePanel.TabIndex = 2;
            this.deletePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.deletePanel_Paint);
            this.deletePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deletePanel_MouseClick);
            // 
            // choosePanel
            // 
            this.choosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choosePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.choosePanel.BackgroundImage = global::Paint_App.Properties.Resources.cursor_148819_960_720;
            this.choosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.choosePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.choosePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.choosePanel.Location = new System.Drawing.Point(6, 25);
            this.choosePanel.Name = "choosePanel";
            this.choosePanel.Size = new System.Drawing.Size(52, 40);
            this.choosePanel.TabIndex = 1;
            this.choosePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.choosePanel_Paint);
            this.choosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.choosePanel_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 599);
            this.Controls.Add(this.shapePanel);
            this.Controls.Add(this.fileProcessPanel);
            this.Controls.Add(this.shapeProcessPanel);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.drawPanel);
            this.Name = "Form1";
            this.Text = "PaintApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.fileProcessPanel.ResumeLayout(false);
            this.fileProcessPanel.PerformLayout();
            this.shapeProcessPanel.ResumeLayout(false);
            this.shapeProcessPanel.PerformLayout();
            this.shapePanel.ResumeLayout(false);
            this.shapePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Panel fileProcessPanel;
        private System.Windows.Forms.Panel shapeProcessPanel;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button brownButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel saveFilePanel;
        private System.Windows.Forms.Panel openFilePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel newBoardPanel;
        private System.Windows.Forms.Panel choosePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel shapePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel circlePanel;
        private System.Windows.Forms.Panel hexagonPanel;
        private System.Windows.Forms.Panel trianglePanel;
        private System.Windows.Forms.Panel rectanglePanel;
        private System.Windows.Forms.Panel deletePanel;
    }
}

