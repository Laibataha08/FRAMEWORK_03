using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WindowsFormsApp4
{
    class Factory
    {
        private static Factory c;
        public int[] objectCount = new int [2];
       
        private Factory()
        {

        }

        public static Factory getInstance()
        {
            if (c == null)
            {
                c = new Factory();
            }
            return c;
        }

        public GameObject createObjects(PictureBox pictureBox, IMovement movement, int speed, Type type)
        {
            GameObject gameobject = new GameObject();

            gameobject.pictureBox = pictureBox;
            gameobject.movement = movement;
            gameobject.speed = speed;
            gameobject.type = type;
            objectCount[type.GetHashCode()] += 1;

            return gameobject;
        }

        public void displayplayercount(Label label)
        {
                label.Text = "player : " + objectCount[0];
                  
        }

        public void displayenemycount(Label label)
        {
            label.Text = "ghost : " + objectCount[1];
        }


    }

}
