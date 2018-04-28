// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using Android.Widget;
using MvvmCross.Binding;

namespace MvvmCross.Platforms.Android.Binding.Target
{
    public class MvxTextViewCompoundDrawablesDrawableNameTargetBinding
        : MvxTextViewCompoundDrawablesDrawableTargetBinding
    {
        public MvxTextViewCompoundDrawablesDrawableNameTargetBinding(TextView target, string whichCompoundDrawable)
            : base(target, whichCompoundDrawable)
        {
        }

        public override Type TargetType => typeof(string);

        protected override void SetValueImpl(object target, object value)
        {
            var drawableName = (string)value;

            var resources = AndroidGlobals.ApplicationContext.Resources;
            var id = resources.GetIdentifier(drawableName, "drawable", AndroidGlobals.ApplicationContext.PackageName);
            if (id == 0)
            {
                MvxBindingLog.Warning(
                    "Value '{0}' was not a known resource drawable name", value);
            }
            else
            {
                base.SetValueImpl(target, id);
            }
        }
    }
}
