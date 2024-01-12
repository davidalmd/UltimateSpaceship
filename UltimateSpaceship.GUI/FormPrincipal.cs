using System;
using System.Windows.Forms;
using UltimateSpaceship.GameLogic;
using System.Windows.Threading;
using System.Drawing;

namespace UltimateSpaceship.GUI
{
    public partial class FormPrincipal : Form
    {
        DispatcherTimer gameLoopTimer { get; set; }
        Bitmap screenBuffer { get; set; }
        Graphics screenPainter { get; set; }
        Background background { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            this.screenBuffer = new Bitmap(Media.fundo.Width, Media.fundo.Height);
            this.screenPainter = Graphics.FromImage(this.screenBuffer);
            this.background = new Background(this.screenBuffer.Size, this.screenPainter);
            this.gameLoopTimer = new DispatcherTimer(DispatcherPriority.Render);

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
