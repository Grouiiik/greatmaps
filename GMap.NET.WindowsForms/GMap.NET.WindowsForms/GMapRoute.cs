﻿
namespace GMap.NET.WindowsForms
{
   using GMap.NET;
   using System.Collections.Generic;
   using System.Drawing;

   /// <summary>
   /// GMap.NET route
   /// </summary>
   public class GMapRoute : MapRoute
   {
      /// <summary>
      /// the color of route
      /// </summary>
      public Color Color;

      internal readonly List<GMap.NET.Point> LocalPoints;

      public GMapRoute(List<PointLatLng> points, string name) : base(points, name)
      {        
         Color = Color.FromArgb(140, Color.MidnightBlue);
         LocalPoints = new List<GMap.NET.Point>(Points.Count);
      }
   }
}
