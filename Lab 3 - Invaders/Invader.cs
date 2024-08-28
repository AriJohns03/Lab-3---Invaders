using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace Lab_3___Invaders
{
    class Invader
    {
        private const int horizontalInterval = 10;
        private const int verticalInterval = 30;

        private const int verticalAttack = 10;
        private const int horizontalAttack = 10;

        private Bitmap image;
        private Bitmap[] imageArray;

        private string side = "";
        private bool targeting = false;
        private int playerLoc = 0;

        private bool hitSide = false;

        public Point Location { get; private set; }

        public ShipType InvaderType { get; private set; }

        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, imageArray[0].Size);
            }
        }

        public int Score { get; private set; }

        public Invader(ShipType invaderType, Point location, int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;

            createInvaderBitmapArray();
            image = imageArray[0];
        }

        public void setdSide(string side)
        {
            this.side = side;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    // Location is a struct, so new one created to keep it immutable
                    Location = new Point((Location.X + horizontalInterval), Location.Y);
                    break;
                case Direction.Left:
                    Location = new Point((Location.X - horizontalInterval), Location.Y);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, (Location.Y + verticalInterval));
                    break;
            }

        }

        public void DropperAttack(int formWidth, int playerLocationY, int playerLocationX)
        {
            if (side == "Left")
            {
                if (this.targeting == false)
                {
                    this.playerLoc = playerLocationX;
                    this.targeting = true;
                }

                //if (Location.Y > playerLocationY)
                //{
                //    return;
                //}

                //&Location.X != playerLocationX

                if (Location.X > -60 & hitSide != true)
                {
                    Location = new Point((Location.X - horizontalInterval), Location.Y);
                    if (Location.X < -50)
                    {
                        hitSide = true;
                    }
                    //Location = new Point(Location.X, (Location.Y + verticalInterval));
                }

                if (hitSide == true)
                {
                    Location = new Point(Location.X, (Location.Y + verticalAttack));
                    Location = new Point((Location.X + horizontalAttack), Location.Y);
                }

                //if (Location.Y > 100)
                //{
                //    Location = new Point(Location.X, (Location.Y - verticalInterval));
                //}
            }

            if (side == "Right")
            {

                if (this.targeting == false)
                {
                    this.playerLoc = playerLocationX;
                    this.targeting = true;
                }
                
                if (Location.X < 850 & hitSide != true)
                {
                    Location = new Point((Location.X + horizontalInterval), Location.Y);
                    if (Location.X > 800)
                    {
                        hitSide = true;
                    }
                    //Location = new Point(Location.X, (Location.Y + verticalInterval));
                }

                if (hitSide == true)
                {
                    Location = new Point(Location.X, (Location.Y + verticalAttack));
                    Location = new Point((Location.X - horizontalAttack), Location.Y);
                }



            }
        }

        public Graphics Draw(Graphics graphics, int animationCell)
        {
            Graphics invaderGraphics = graphics;
            image = imageArray[animationCell];
            try
            {
                graphics.DrawImage(image, Location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            //DEBUG red square invaders
            //graphics.FillRectangle(Brushes.Red,
            //    Location.X, Location.Y, 20, 20);
            return invaderGraphics;
        }

        private void createInvaderBitmapArray()
        {
            imageArray = new Bitmap[4];
            switch (InvaderType)
            {
                case ShipType.Bug:
                    imageArray[0] = Properties.Resources.bug1;
                    imageArray[1] = Properties.Resources.bug2;
                    imageArray[2] = Properties.Resources.bug3;
                    imageArray[3] = Properties.Resources.bug4;
                    break;
                case ShipType.Satellite:
                    imageArray[0] = Properties.Resources.satellite1;
                    imageArray[1] = Properties.Resources.satellite2;
                    imageArray[2] = Properties.Resources.satellite3;
                    imageArray[3] = Properties.Resources.satellite4;
                    break;
                case ShipType.Saucer:
                    imageArray[0] = Properties.Resources.flyingsaucer1;
                    imageArray[1] = Properties.Resources.flyingsaucer2;
                    imageArray[2] = Properties.Resources.flyingsaucer3;
                    imageArray[3] = Properties.Resources.flyingsaucer4;
                    break;
                case ShipType.Spaceship:
                    imageArray[0] = Properties.Resources.spaceship1;
                    imageArray[1] = Properties.Resources.spaceship2;
                    imageArray[2] = Properties.Resources.spaceship3;
                    imageArray[3] = Properties.Resources.spaceship4;
                    break;
                case ShipType.Star:
                    imageArray[0] = Properties.Resources.star1;
                    imageArray[1] = Properties.Resources.star2;
                    imageArray[2] = Properties.Resources.star3;
                    imageArray[3] = Properties.Resources.star4;
                    break;
                case ShipType.Bomber:
                    imageArray[0] = Properties.Resources.bomber2;
                    imageArray[1] = Properties.Resources.bomber2;
                    imageArray[2] = Properties.Resources.bomber2;
                    imageArray[3] = Properties.Resources.bomber2;
                    break;
                case ShipType.Dropper:
                    imageArray[0] = Properties.Resources.spaceship1;
                    imageArray[1] = Properties.Resources.spaceship1;
                    imageArray[2] = Properties.Resources.spaceship1;
                    imageArray[3] = Properties.Resources.spaceship1;
                    break;
            }
        }
    }
}
