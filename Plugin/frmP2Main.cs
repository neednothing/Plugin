#region Using

using System;
using System.Windows.Forms;
using PlugIn;

#endregion

namespace Plugin2
{
    public partial class FrmP2Main : Form
    {
        private readonly IPlugin _plug;

        public FrmP2Main( IPlugin plug )
        {
            this.InitializeComponent();
            this._plug = plug;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            MessageBox.Show( this._plug.PluginDescription, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void FrmP2Main_Load(object sender, EventArgs e)
        {

        }
    }
}