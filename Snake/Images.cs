﻿using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = loadImage("Empty.png");
        public readonly static ImageSource Body = loadImage("Body.png");
        public readonly static ImageSource Head = loadImage("Head.png");
        public readonly static ImageSource Food = loadImage("Food.png");
        public readonly static ImageSource DeadBody = loadImage("DeadBody.png");
        public readonly static ImageSource DeadHead = loadImage("DeadHead.png");

        private static ImageSource loadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}
