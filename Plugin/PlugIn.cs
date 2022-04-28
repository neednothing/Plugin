#region Using

using PlugIn;

#endregion

namespace Plugin1
{
    public class PlugIn : IPlugin
    {
        private string _PluginName = "Plugin1";
        private string _DisplayPluginName = "Первый плагин";
        private string _PluginDescription = "Описание первого плагина";
        private string _Author = "User";
        private int _Version = 111;
        private IPluginHost _Host;

        public void Show()
        {
            FrmP1Main frm = new FrmP1Main( this );
            frm.ShowDialog();
        }

        public IPluginHost Host
        {
            get { return this._Host; }
            set
            {
                this._Host = value;
                this._Host.Register( this );
            }
        }

        public string PluginName
        {
            get { return this._PluginName; }
        }

        public string DisplayPluginName
        {
            get { return this._DisplayPluginName; }
        }

        public string PluginDescription
        {
            get { return this._PluginDescription; }
        }

        public string Author
        {
            get { return this._Author; }
        }

        public int Version
        {
            get { return this._Version; }
        }
    }
}