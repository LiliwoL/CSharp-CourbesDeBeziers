using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___Courbes_de_bézier
{
    public partial class BesierCurves : Form
    {
        public List<Point> listeDePoints = new List<Point>();

        public BesierCurves()
        {
            Console.Write( "Hello" );
            InitializeComponent();
        }

        private void BesierCurves_Load(object sender, EventArgs e)
        {            
        }

        // Appelé à chaque "invalidate" du Panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen linePen = new Pen(Color.Black);

            // Commence à 2 points
            if ( listeDePoints.Count >=2 )
            {
                e.Graphics.DrawLines(linePen, listeDePoints.ToArray() );
            }            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // Ajout d'un point dans la liste
            listeDePoints.Add( new Point(MousePosition.X, MousePosition.Y) );

            // Debug
            Console.Write( listeDePoints.ToString() );

            // Pour mettre à jour le panel
            panel1.Invalidate();
        }
    }
}
