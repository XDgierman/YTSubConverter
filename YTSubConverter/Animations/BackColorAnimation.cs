﻿using System;
using System.Drawing;
using Arc.YTSubConverter.Formats.Ass;

namespace Arc.YTSubConverter.Animations
{
    public class BackColorAnimation : ColorAnimation
    {
        public BackColorAnimation(DateTime startTime, Color startColor, DateTime endTime, Color endColor, float acceleration)
            : base(startTime, startColor, endTime, endColor, acceleration)
        {
        }

        public override void Apply(AssLine line, AssSection section, float t)
        {
            section.BackColor = GetColor(t);
        }

        public override object Clone()
        {
            return new BackColorAnimation(StartTime, StartColor, EndTime, EndColor, Acceleration);
        }
    }
}
