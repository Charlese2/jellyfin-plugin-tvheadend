using System;
using MediaBrowser.Model.Plugins;

namespace TVHeadEnd.Configuration
{
    /// <summary>
    /// Class PluginConfiguration
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string TVH_ServerName { get; set; }
		public int HTTP_Port { get; set; }
		public int HTSP_Port { get; set; }
        public string WebRoot { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Priority { get; set; }
        public string Profile { get; set; }
        public string ChannelType { get; set; }
        public bool HideRecordingsChannel { get; set; }
        public bool EnableSubsMaudios { get; set; }
        public bool ForceDeinterlace { get; set; }

        public PluginConfiguration()
        {
            TVH_ServerName = "localhost";
            HTTP_Port = 9981;
			HTSP_Port = 9982;
            WebRoot = "/";
            Username = "";
            Password = "";
            Priority = 5;
            Profile = "";
            ChannelType = "Ignore";
            HideRecordingsChannel = false;
            EnableSubsMaudios = false;
            ForceDeinterlace = false;
        }
    }
}