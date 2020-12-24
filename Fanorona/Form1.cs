using Fanorona.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fanorona
{
    public partial class Form1 : Form
    {
        PictureBox[,] pbs;
        Image jetonVert = Resources.jetonVert;
        Image jetonBleu = Resources.jetonBleu;
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb11.Width - 0, pb11.Width - 0);
            Region rg = new Region(gp);
            //Set radius
            //Ligne 1
            pb11.Region = rg;
            pb12.Region = rg;
            pb13.Region = rg;
            pb14.Region = rg;
            pb15.Region = rg;
            //Ligne2
            pb21.Region = rg;
            pb22.Region = rg;
            pb23.Region = rg;
            pb24.Region = rg;
            pb25.Region = rg;
            //Ligne3
            pb31.Region = rg;
            pb32.Region = rg;
            pb33.Region = rg;
            pb34.Region = rg;
            pb35.Region = rg;
            //Ligne4
            pb41.Region = rg;
            pb42.Region = rg;
            pb43.Region = rg;
            pb44.Region = rg;
            pb45.Region = rg;
            //Ligne5
            pb51.Region = rg;
            pb52.Region = rg;
            pb53.Region = rg;
            pb54.Region = rg;
            pb55.Region = rg;

            //Enable DragDrop
            //Ligne 1
            pb11.AllowDrop = true;
            pb12.AllowDrop = true;
            pb13.AllowDrop = true;
            pb14.AllowDrop = true;
            pb15.AllowDrop = true;
            //Ligne2
            pb21.AllowDrop = true;
            pb22.AllowDrop = true;
            pb23.AllowDrop = true;
            pb24.AllowDrop = true;
            pb25.AllowDrop = true;
            //Ligne3
            pb31.AllowDrop = true;
            pb32.AllowDrop = true;
            pb33.AllowDrop = true;
            pb34.AllowDrop = true;
            pb35.AllowDrop = true;
            //Ligne4
            pb41.AllowDrop = true;
            pb42.AllowDrop = true;
            pb43.AllowDrop = true;
            pb44.AllowDrop = true;
            pb45.AllowDrop = true;
            //Ligne5
            pb51.AllowDrop = true;
            pb52.AllowDrop = true;
            pb53.AllowDrop = true;
            pb54.AllowDrop = true;
            pb55.AllowDrop = true;

            //Delegate event
            //Ligne 1
            pb11.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb11.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb11.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb12.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb12.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb12.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb13.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb13.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb13.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb14.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb14.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb14.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb15.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb15.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb15.DragEnter += new DragEventHandler(pb11_DragDrop);

            //Ligne2
            pb21.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb21.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb21.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb22.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb22.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb22.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb23.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb23.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb23.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb24.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb24.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb24.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb25.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb25.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb25.DragEnter += new DragEventHandler(pb11_DragDrop);

            //Ligne 3
            pb31.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb31.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb31.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb32.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb32.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb32.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb33.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb33.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb33.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb34.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb34.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb34.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb35.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb35.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb35.DragEnter += new DragEventHandler(pb11_DragDrop);


            //Ligne 4
            pb41.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb41.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb41.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb42.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb42.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb42.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb43.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb43.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb43.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb44.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb44.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb44.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb45.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb45.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb45.DragEnter += new DragEventHandler(pb11_DragDrop);


            //Ligne5

            pb51.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb51.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb51.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb52.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb52.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb52.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb53.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb53.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb53.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb54.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb54.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb54.DragEnter += new DragEventHandler(pb11_DragDrop);

            pb55.MouseDown += new MouseEventHandler(pb11_MouseDown);
            pb55.DragEnter += new DragEventHandler(pb11_DragEnter);
            pb55.DragEnter += new DragEventHandler(pb11_DragDrop);

            pbs = new PictureBox[,] {   {   pb11,pb12,pb13,pb14,pb15 },
                                        {   pb21,pb22,pb23,pb24,pb25},
                                        {   pb31,pb32,pb33,pb34,pb35} ,
                                        {   pb41,pb42,pb43,pb44,pb45},
                                        {   pb51,pb52,pb53,pb54,pb55 } };
            for (int i = 0; i < pbs.GetLength(0); i++)
            {
                for (int j = 0; j < pbs.GetLength(1); j++)
                {
                    if (pbs[i, j].Image == null)
                        pbs[i, j].Cursor = Cursors.Default;
                    else
                        pbs[i, j].Cursor = Cursors.Hand;

                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            initialisationJeton();
          
        }
        private void initialisationJeton() {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pbs[i, j].Image = jetonVert;
                }
            }
            pbs[2, 0].Image = pbs[2, 3].Image = jetonVert;
            pbs[2, 1].Image = pbs[2, 4].Image = jetonBleu;
            for (int i = 3; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pbs[i, j].Image = jetonBleu;
                }
            }
        }
        private Boolean isMovable(PictureBox source, PictureBox destination)
        {
            char[] n = source.Name.ToCharArray();
            char[] d = destination.Name.ToCharArray();
            int sLigne =int.Parse(n[n.Length - 2]+""); int sColonne =int.Parse( n[n.Length - 1]+"");
            int dLigne =int.Parse( d[d.Length - 2]+""); int dColonne =int.Parse( d[d.Length - 1]+"");
            Debug.WriteLine("source: "+sLigne + "");
            if (
               /* ((dColonne == sColonne + 1) && (dLigne == sLigne)) ||
                ((dColonne == sColonne - 1) && (dLigne == sLigne)) ||
                ((dLigne == sLigne + 1) && (dColonne == sColonne)) ||
                ((dLigne == sLigne - 1) && (dColonne == sColonne)) ||
                ((dColonne == sColonne + 1) && (sLigne == sColonne) && (dLigne == dColonne)) ||
                ((dColonne == sColonne - 1) && (sLigne == sColonne) && (dLigne == dColonne)) ||
                ((dColonne == sColonne + 1) && (dLigne == sLigne - 1) && (sLigne != dColonne) && (dLigne != sColonne)) &&(sLigne==sColonne)||
                 ((dColonne == sColonne + 1) && (dLigne == sLigne - 1) && (sLigne != dColonne) && (dLigne != sColonne)) && (dLigne == dColonne) ||
                ((dLigne == sLigne + 1) && (dColonne == sColonne - 1) && (sLigne != dColonne) && (dLigne != sColonne)) && (sLigne == sColonne) ||
                ((dLigne == sLigne + 1) && (dColonne == sColonne - 1) && (sLigne != dColonne) && (dLigne != sColonne)) && (dLigne == dColonne)*/
                (Math.Abs(dLigne-sLigne)<=1)&&(Math.Abs(dColonne-sColonne)<=1)&&(((sLigne+sColonne)%2)==0|| ((dLigne + dColonne) % 2) == 0)
                )
            {
                return true;
            }
            return false;
        }
        
        private void pb11_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.Image == null)
            {
                return;
            }
            else
            {
                pb.DoDragDrop(pb, DragDropEffects.Move);
            }
        }

        private void pb11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pb11_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            // if (e.Data.GetDataPresent(typeof(PictureBox))) {}
            var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
            if (source != pb)
            {
                if (isMovable(source, pb))
                {
                    if (pb.Image == null)
                    {
                        pb.Image = source.Image;

                        source.Image = null;
                    }
                    twoPlayer(source,pb);
                  
                }
            }
        }
        private String[] ijSuccs(int i,int j)
        {
            //Ligne 1
            if (i == 0 && j == 0)
            {
                return new String[] { "01","11","10"};
            }
            else if (i==0&&j==1)
            {
                return new String[] {"00","11","02" };
            }
            else if (i == 0 && j == 2)
            {
                return new String[] { "01", "12", "03" };
            }
            else if (i == 0 && j == 3)
            {
                return new String[] { "02", "13", "04" };
            }
            else if (i == 0 && j == 4)
            {
                return new String[] { "03", "13", "14" };
            }
            //Ligne 2
            else if (i == 1 && j == 0)
            {
                return new String[] { "00", "11", "20" };
            }
            else if (i == 1 && j == 1)
            {
                return new String[] { "00", "01", "02","10","12","20","21","22" };
            }
            else if (i == 1 && j == 2)
            {
                return new String[] { "02", "11", "13","22" };
            }
            else if (i == 1 && j == 3)
            {
                return new String[] { "02", "03", "04","12","14","22","23","24" };
            }
            else if (i == 1 && j == 4)
            {
                return new String[] { "04", "13", "24" };
            }
            //Ligne 3
            else if (i == 2 && j == 0)
            {
                return new String[] { "10", "11", "21" ,"30","31"};
            }
            else if (i == 2 && j == 1)
            {
                return new String[] { "11","20","22","31" };
            }
            else if (i == 2 && j == 2)
            {
                return new String[] { "11", "12", "13", "21","23","31","32","33" };
            }
            else if (i == 2 && j == 3)
            {
                return new String[] { "13","22","24","33" };
            }
            else if (i == 2 && j == 4)
            {
                return new String[] { "14", "23", "34" };
            }
            //Ligne 4
            else if (i == 3 && j == 0)
            {
                return new String[] { "20", "31", "40" };
            }
            else if (i == 3 && j == 1)
            {
                return new String[] { "20", "21", "22", "30","32","40","41","42" };
            }
            else if (i == 3 && j == 2)
            {
                return new String[] { "22", "31", "33", "42" };
            }
            else if (i == 3 && j == 3)
            {
                return new String[] { "22", "23", "24", "32","34","42","43","44" };
            }
            else if (i == 3 && j == 4)
            {
                return new String[] { "24", "33", "44" };
            }
            //Ligne 5
            else if (i == 4 && j == 0)
            {
                return new String[] { "30", "31", "41" };
            }
            else if (i == 4 && j == 1)
            {
                return new String[] { "31", "40", "42" };
            }
            else if (i == 4 && j == 2)
            {
                return new String[] { "31", "32", "33", "41","43" };
            }
            else if (i == 4 && j == 3)
            {
                return new String[] { "33", "42","44"};
            }
            else if (i == 4 && j == 4)
            {
                return new String[] { "33", "34", "43" };
            }
            return new String[] {""};
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private int[,] imgToMatrice() {
            int[,] mat = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (pbs[i, j].Image == jetonVert)
                        mat[i, j] = 1;
                    else if (pbs[i, j].Image == jetonBleu)
                        mat[i, j] = -1;
                    else if (pbs[i, j].Image == null)
                        mat[i, j] = 0;
                }
            }
         
            return mat;
        }
        private void matriceToImg(int[,] t)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (t[i, j] == 1)
                        pbs[i, j].Image = jetonVert;
                    else if (t[i, j] == -1)
                        pbs[i, j].Image = jetonBleu;
                    else
                        pbs[i, j].Image = null;
                }
            }

        }

        private void Afficher(int [,] mat) {
            String s = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    s += "" + mat[i, j]+"|";
                }
                s += "|\n";
            }
            Debug.WriteLine(s);
        }

        private void twoPlayer(PictureBox from ,PictureBox to)
        {
            char[] n = from.Name.ToCharArray();
            char[] d = to.Name.ToCharArray();
            int sLigne = int.Parse(n[n.Length - 2] + "")-1; int sColonne = int.Parse(n[n.Length - 1] + "")-1;
            int dLigne = int.Parse(d[d.Length - 2] + "")-1; int dColonne = int.Parse(d[d.Length - 1] + "")-1;
               
            matriceToImg(jeux.elimination(imgToMatrice(),new int[] {sLigne,sColonne },new int[] {dLigne,dColonne }));
            Afficher(imgToMatrice());
        }
        private void choix(int[] from, int[] to)
        {
          //  if (to[0]) { }

            int[] newLigne = new int[] {0,0};
            int[] newColonne = new int[] { 0, 0 }; ;
        }
    }
}
