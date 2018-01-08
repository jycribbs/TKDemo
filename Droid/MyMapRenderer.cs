﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TK.CustomMap.Droid;
using Android.Graphics;
using Android.Media;
using Xamarin.Forms;
using TKDemo.Droid;
using TKDemo;

[assembly: ExportRenderer(typeof(MyMap), typeof(MyMapRenderer))]

namespace TKDemo.Droid
{
    public class MyMapRenderer : TKCustomMapRenderer, Android.Gms.Maps.GoogleMap.IInfoWindowAdapter
    {
        public override void OnMapReady(Android.Gms.Maps.GoogleMap googleMap)
        {
            System.Diagnostics.Debug.WriteLine("===========OnMapReady==============");
            base.OnMapReady(googleMap);
            googleMap.SetInfoWindowAdapter(this);
        }

        Android.Views.View Android.Gms.Maps.GoogleMap.IInfoWindowAdapter.GetInfoContents(Android.Gms.Maps.Model.Marker marker)
        {
            System.Diagnostics.Debug.WriteLine("===========GetInfoContents==============");
            var pin = GetPinByMarker(marker);
            if (pin == null) return null;

            var image = new ImageView(Context);
            image.SetImageResource(Resource.Drawable.icon);
            return image;
        }

        Android.Views.View Android.Gms.Maps.GoogleMap.IInfoWindowAdapter.GetInfoWindow(Android.Gms.Maps.Model.Marker marker)
        {
            System.Diagnostics.Debug.WriteLine("===========GetInfoWindow==============");
            return null;
        }
    }
}

