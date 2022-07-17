using UnityEngine;
using ReMod.Core.Unity;
using XSNotifications;

namespace ReMod.Core.Notification
{
    public class NotificationObject
    {
        public string Title;
        public string Description;
        public Sprite Icon;
        public float DisplayLength;
        public Color BackgroundColor;

        public NotificationObject(string title, string description, Sprite icon, float displayLength, Color backgroundColor)
        {
            Title = title;
            Description = description;
            Icon = icon;
            DisplayLength = displayLength;
            BackgroundColor = backgroundColor;
        }

        public static explicit operator XSNotification(NotificationObject rn)
        {
            return new XSNotification()
            {
                Title = rn.Title,
                Content = rn.Description,
                Timeout = rn.DisplayLength,
                UseBase64Icon = true,
                Icon = rn.Icon.texture.AsBase64(),
                Volume = NotificationSystem.xsoVolume.Value,
                Opacity = rn.BackgroundColor.ScaleMinimumAlpha(.5f).a,
                SourceApp = "vrchat/remod.core"
            };
        }
    }
}