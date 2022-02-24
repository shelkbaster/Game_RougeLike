using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_RoguelLike
{
    public partial class Form1 : Form
    {
        public  int dirX = 0, dirY = 0;
        public  int StepSize_Walking = 4;
        public  Image Dwarf;
        public int currFrame = 5;
        public int currFrame_Stay = 0;
        public int dir_Stay = 1;


        public Form1()
        {
            InitializeComponent();
            
            this.KeyDown += new KeyEventHandler(KeysControls_DOwn);
            this.KeyUp += new KeyEventHandler(KeysControls_Up);
            //////////////////////////
            Timer_Stay.Interval = 200;
            Timer_Stay.Tick += new EventHandler(update_Stay);
            Timer_Stay.Start();
            Timer_Walking.Interval = 140;
            Timer_Walking.Tick += new EventHandler(update_Walking);
            Timer_Walking.Start();
            Timer_Fall.Interval = 35;
            Timer_Fall.Tick += (update_Fall);
            Timer_Fall.Start();
        }

        
        public void update_Stay(object sender, EventArgs e)
        {
            PlayAnimation_Stay();
            ++currFrame_Stay;
            if (currFrame_Stay == 4) currFrame_Stay = 0;
        }
        public void update_Walking(object sender, EventArgs e)
        {
            PlayAnimation_Walking();
            ++currFrame;
            if (currFrame == 7) currFrame = 4;
            
        }
        public void update_Fall(object sender, EventArgs e)
        {
            CalculateClass_physics();
        }
        public void PlayAnimation_Stay()
        {
            
            if (dirX == 0 && dir_Stay == 1) // Стояние на месте вправо
            {
                Dwarf = new Bitmap(@"D:\C# project\Game_RoguelLike\Scripts\Dwarf_Scripts.png");
                Image part = new Bitmap(40, 40);
                Graphics g = Graphics.FromImage(part);
                g.DrawImage(Dwarf, 0, 0, new Rectangle(new Point(32 * currFrame_Stay, 0), new Size(30, 35)), GraphicsUnit.Pixel);
                Dworf_PictureDox.Image = part;
            }

            else if (dirX == 0 && dir_Stay == -1) // Стояние на месте влево
            {
                Dwarf = new Bitmap(@"D:\C# project\Game_RoguelLike\Scripts\Dwarf_Scripts.png");
                Image part = new Bitmap(40, 40);
                Graphics g = Graphics.FromImage(part);
                g.DrawImage(Dwarf, 0, 0, new Rectangle(new Point(32 * currFrame_Stay, 158), new Size(30, 35)), GraphicsUnit.Pixel);
                Dworf_PictureDox.Image = part;
            }
            else if (dirX == 0 && dir_Stay == 2) // Приседание на месте вправо
            {
                Dwarf = new Bitmap(@"D:\C# project\Game_RoguelLike\Scripts\Dwarf_Scripts.png");
                Image part = new Bitmap(40, 33);
                Graphics g = Graphics.FromImage(part);
                g.DrawImage(Dwarf, 0, 0, new Rectangle(new Point(32, 0), new Size(30, 34)), GraphicsUnit.Pixel);
                Dworf_PictureDox.Image = part;
            }
            else if (dirX == 0 && dir_Stay == -2) // Приседание на месте влево
            {
                Dwarf = new Bitmap(@"D:\C# project\Game_RoguelLike\Scripts\Dwarf_Scripts.png");
                Image part = new Bitmap(40, 33);
                Graphics g = Graphics.FromImage(part);
                g.DrawImage(Dwarf, 0, 0, new Rectangle(new Point(32, 0), new Size(30, 34)), GraphicsUnit.Pixel);
                Dworf_PictureDox.Image = part;
            }
        }
        public void PlayAnimation_Walking()
        {

            
            if (dirX == 1) // Ходьба вправо
            {
                Dwarf = new Bitmap(@"D:\C# project\Game_RoguelLike\Scripts\Dwarf_Scripts.png");
                Image part = new Bitmap(40, 40);
                Graphics g = Graphics.FromImage(part);
                g.DrawImage(Dwarf, 0, 0, new Rectangle(new Point(32 * currFrame, 30), new Size(30,35)), GraphicsUnit.Pixel);
                Dworf_PictureDox.Image = part;
                Dworf_PictureDox.Location = new Point(Dworf_PictureDox.Location.X + StepSize_Walking * dirX, Dworf_PictureDox.Location.Y + StepSize_Walking * dirY);
            }
            else if (dirX == -1) // Ходьба влеао
            {
                Dwarf = new Bitmap(@"D:\C# project\Game_RoguelLike\Scripts\Dwarf_Scripts.png");
                Image part = new Bitmap(40, 40);
                Graphics g = Graphics.FromImage(part);
                g.DrawImage(Dwarf, 0, 0, new Rectangle(new Point(32 * currFrame, 187), new Size(30, 35)), GraphicsUnit.Pixel);
                Dworf_PictureDox.Image = part;
                Dworf_PictureDox.Location = new Point(Dworf_PictureDox.Location.X + StepSize_Walking * dirX, Dworf_PictureDox.Location.Y + StepSize_Walking * dirY);
            }
            

        }
        // Ходьба Нажатие
        public void KeysControls_DOwn(object sendler, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "W":

                    dirX = 0;
                    dirY = -1;
                    AddForce(0.6f);
                    break;
                case "S":
                    dirX = 0;
                    dirY = 1;
                    if (dirX == 1) dir_Stay = 2;
                    else dir_Stay = -2;
                    break;
                case "A":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "D":
                    dirX = 1;
                    dirY = 0;
                    break;
            }
        }
        // Ходьба Отжатие
        public void KeysControls_Up(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "W":

                    dirX = 0;
                    dirY = 0;
                    break;
                case "S":
                    dirX = 0;
                    dirY = 0;
                    if (dir_Stay == 2) dir_Stay = -1;
                    else dir_Stay = 1;
                    break;
                case "A":
                    dirX = 0;
                    dirY = 0;
                    dir_Stay = -1;
                    break;
                case "D":
                    dirX = 0;
                    dirY = 0;
                    dir_Stay = 1;
                    break;
            }
        }
        float gravity = 0;//переменая гравитации
        float a = 0.4f; //переменая ускорения
        int gravityInt;

        public void CalculateClass_physics() //расчет физики
        {
            if (Dworf_PictureDox.Location.Y < 500 || a < 0)
            {
                if (a != 0.4f)
                {
                    a += 0.05f;
                }
                gravityInt = Convert.ToInt32(gravity);
                Dworf_PictureDox.Location = new Point(Dworf_PictureDox.Location.X, Dworf_PictureDox.Location.Y + gravityInt);
                gravity += a;
            }
        }

        public void AddForce(float jump)// прыжок
        {
            if(Dworf_PictureDox.Location.Y >= 500)
            {
                gravity = 0;
                a = -jump;
            }
            
        }
    }   
}
