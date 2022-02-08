#region Using

using System;
using System.Windows.Forms;
using PlugIn;

#endregion

namespace Plugin1
{
    public partial class FrmP1Main : Form
    {
        private readonly IPlugin _plug;

        public FrmP1Main( IPlugin plug )
        {
            this.InitializeComponent();
            this._plug = plug;
        }

        private void FrmP1Main_Load( object sender, EventArgs e )
        {
            this.tbInfo.AppendText( this._plug.Author + "\r\n" );
            this.tbInfo.AppendText( this._plug.DisplayPluginName + "\r\n" );
            this.tbInfo.AppendText( this._plug.PluginDescription + "\r\n" );
            this.tbInfo.AppendText( this._plug.PluginName + "\r\n" );
            this.tbInfo.AppendText( this._plug.Version + "\r\n" );
        }
    }
}