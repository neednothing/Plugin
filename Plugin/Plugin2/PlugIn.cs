#region Using

using PlugIn;

#endregion

namespace Plugin2
{
    public class PlugIn : IPlugin
    {
        private string _PluginName = "Plugin2";
        private string _DisplayPluginName = "Второй плагин";
        private string _PluginDescription = "Описание второго плагина";
        private string _Author = "Dev";
        private int _Version = 100;
        private IPluginHost _Host;

        public void Show()
        {
            FrmP2Main frm = new FrmP2Main( this );
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