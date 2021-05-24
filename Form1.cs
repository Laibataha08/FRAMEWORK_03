using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Game game;
        Factory f;


        public Form1()
        {
            InitializeComponent();
            
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.update();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            game = Game.getInstance();

            f = Factory.getInstance();

            GameObject G1 = f.createObjects(pictureBox1, new Moveupleft(), 2, Type.player);
            GameObject G2 = f.createObjects(pictureBox2, new MoveLeft(), 2, Type.ghost);
            GameObject G3 = f.createObjects(pictureBox3, new MoveRight(), 2, Type.ghost);
            GameObject G4 =  f.createObjects(pictureBox4, new Falling(), 3, Type.ghost);

            f.displayplayercount(label1);
            f.displayenemycount(label2);

            game.AddObjects(G1);
            game.AddObjects(G2);
            game.AddObjects(G3);
            game.AddObjects(G4);


        }

      
    }
}
