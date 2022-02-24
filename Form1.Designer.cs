
namespace Game_RoguelLike
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
            this.components = new System.ComponentModel.Container();
            this.Dworf_PictureDox = new System.Windows.Forms.PictureBox();
            this.Timer_Walking = new System.Windows.Forms.Timer(this.components);
            this.Timer_Stay = new System.Windows.Forms.Timer(this.components);
            this.Timer_Fall = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dworf_PictureDox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dworf_PictureDox
            // 
            this.Dworf_PictureDox.Location = new System.Drawing.Point(100, 100);
            this.Dworf_PictureDox.Name = "Dworf_PictureDox";
            this.Dworf_PictureDox.Size = new System.Drawing.Size(100, 50);
            this.Dworf_PictureDox.TabIndex = 0;
            this.Dworf_PictureDox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(0, 545);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 1);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dworf_PictureDox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dworf_PictureDox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Dworf_PictureDox;
        private System.Windows.Forms.Timer Timer_Walking;
        private System.Windows.Forms.Timer Timer_Stay;
        private System.Windows.Forms.Timer Timer_Fall;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

