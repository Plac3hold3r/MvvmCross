// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding;

namespace MvvmCross.Platforms.Android.Binding.Target
{
    public class MvxCompoundDrawablesDrawableNameTargetBinding
        : MvxAndroidTargetBinding
    {
        private readonly string _whichCompoundDrawable;

        public MvxCompoundDrawablesDrawableNameTargetBinding(View target, string whichCompoundDrawable)
            : base(target)
        {
            _whichCompoundDrawable = whichCompoundDrawable ?? throw new ArgumentNullException(nameof(whichCompoundDrawable));
        }

        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        public override Type TargetType => typeof(string);

        protected override void SetValueImpl(object target, object value)
        {
            var textView = target as TextView;
            if (textView == null) return;

            var drawableName = (string)value;

            var resources = AndroidGlobals.ApplicationContext.Resources;
            var id = resources.GetIdentifier(drawableName, "drawable", AndroidGlobals.ApplicationContext.PackageName);
            if (id == 0)
            {
                MvxBindingLog.Warning(
                    "Value '{0}' was not a known compound drawable name", value);
                return;
            }

            textView.SetCompoundDrawablesWithIntrinsicBounds(id, 0, 0, 0);

            switch (_whichCompoundDrawable)
            {
                case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameLeft:
                    textView.SetCompoundDrawablesWithIntrinsicBounds(id, 0, 0, 0);
                    break;
                case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameRight:
                    textView.SetCompoundDrawablesWithIntrinsicBounds(0, 0, id, 0);
                    break;
                case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameTop:
                    textView.SetCompoundDrawablesWithIntrinsicBounds(0, id, 0, 0);
                    break;
                case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameBottom:
                    textView.SetCompoundDrawablesWithIntrinsicBounds(0, 0, 0, id);
                    break;
                case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameStart:
                    textView.SetCompoundDrawablesRelativeWithIntrinsicBounds(id, 0, 0, 0);
                    break;
                case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameEnd:
                    textView.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, id, 0);
                    break;
            }
        }
    }
}
