﻿using UnityEngine;
using UnityEditor;
using System.Collections;

using UForms.Events;

namespace UForms.Controls
{
    public class ContextMenuControl : Control
    {
        public GenericMenu Menu { get; private set; }

        public bool Positionless { get; set; }

        public ContextMenuControl(  ) : base()
        {
            Menu = new GenericMenu();
            SetSize( 100.0f, 100.0f, MetricsUnits.Percentage, MetricsUnits.Percentage );
        }


        protected override void OnContextClick( Event e )
        {
            if ( Positionless || PointInControl( e.mousePosition ) )
            {
                Menu.ShowAsContext();
                e.Use();
            }
        }

    }
}