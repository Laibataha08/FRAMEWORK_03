using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WindowsFormsApp4
{
    class GameObject
    {
        IMovement move;

        public PictureBox pictureBox;
        public int speed;
        public IMovement movement;
        public Type type;
       
        public void updateposition()
        {
            move = movement;
            move.typeofmovement(speed,pictureBox);    
        }

       
    }

}
