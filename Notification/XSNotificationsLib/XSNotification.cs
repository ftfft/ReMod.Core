using XSNotifications.Enum;
using XSNotifications.Helpers;

namespace XSNotifications
{
    public class XSNotification
    {
        public bool UseBase64Icon { get; set; }

        public float Height { get; set; }
        public float Opacity { get; set; }
        public float Timeout { get; set; }
        public float Volume { get; set; }

        public int Index { get; set; }

        public string AudioPath { get; set; }
        public string Content { get; set; }
        public string Icon { get; set; }
        public string SourceApp { get; set; }
        public string Title { get; set; }

        public XSMessageType MessageType { get; set; }

        public XSNotification()
        {
            UseBase64Icon = XSGlobals.DefaultUseBase64Icon;

            Height = XSGlobals.DefaultHeight;
            Opacity = XSGlobals.DefaultOpacity;
            Timeout = XSGlobals.DefaultTimeout;
            Volume = XSGlobals.DefaultVolume;

            Index = XSGlobals.DefaultIndex;

            AudioPath = XSGlobals.DefaultAudioPath;
            Content = string.Empty;
            Icon = XSGlobals.DefaultIcon;
            SourceApp = XSGlobals.DefaultSourceApp;
            Title = XSGlobals.DefaultTitle;

            MessageType = XSGlobals.DefaultMessageType;
        }

        public string AsJson()
        {
            return $"{{\"useBase64Icon\":{UseBase64Icon.ToString().ToLower()}, \"height\":{Height}, \"opacity\":{Opacity}, \"timeout\":{Timeout}, \"volume\":{Volume}, \"index\":{Index}, \"audioPath\":\"{AudioPath}\", \"content\":\"{Content}\", \"icon\":\"{Icon}\", \"sourceApp\":\"{SourceApp}\", \"title\":\"{Title}\", \"messageType\":{(int)MessageType}}}";
        }

        public byte[] AsJsonBytes()
        {
            return System.Text.Encoding.UTF8.GetBytes(AsJson());
        }
    }
}
