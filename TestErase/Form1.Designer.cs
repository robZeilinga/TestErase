namespace TestErase
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_Canvas = new System.Windows.Forms.PictureBox();
            this.pb_Draw = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_Erase = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_brushSize = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Erase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_brushSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pb_Canvas
            // 
            this.pb_Canvas.Location = new System.Drawing.Point(15, 49);
            this.pb_Canvas.Name = "pb_Canvas";
            this.pb_Canvas.Size = new System.Drawing.Size(387, 375);
            this.pb_Canvas.TabIndex = 3;
            this.pb_Canvas.TabStop = false;
            this.pb_Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Canvas_MouseDown);
            this.pb_Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Canvas_MouseMove);
            this.pb_Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_Canvas_MouseUp);
            // 
            // pb_Draw
            // 
            this.pb_Draw.Location = new System.Drawing.Point(432, 90);
            this.pb_Draw.Name = "pb_Draw";
            this.pb_Draw.Size = new System.Drawing.Size(92, 81);
            this.pb_Draw.TabIndex = 4;
            this.pb_Draw.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Draw Colour";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Erase Colour";
            // 
            // pb_Erase
            // 
            this.pb_Erase.Location = new System.Drawing.Point(432, 209);
            this.pb_Erase.Name = "pb_Erase";
            this.pb_Erase.Size = new System.Drawing.Size(92, 81);
            this.pb_Erase.TabIndex = 6;
            this.pb_Erase.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(434, 323);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(261, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pen Size";
            // 
            // pb_brushSize
            // 
            this.pb_brushSize.Location = new System.Drawing.Point(436, 362);
            this.pb_brushSize.Name = "pb_brushSize";
            this.pb_brushSize.Size = new System.Drawing.Size(69, 62);
            this.pb_brushSize.TabIndex = 10;
            this.pb_brushSize.TabStop = false;
            this.pb_brushSize.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_brushSize_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Choose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "Choose";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(533, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pb_brushSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_Erase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_Draw);
            this.Controls.Add(this.pb_Canvas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Erase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_brushSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_Canvas;
        private System.Windows.Forms.PictureBox pb_Draw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_Erase;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_brushSize;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

