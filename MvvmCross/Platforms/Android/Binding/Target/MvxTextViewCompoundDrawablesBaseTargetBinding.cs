// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using Android.Widget;
using MvvmCross.Binding;

namespace MvvmCross.Platforms.Android.Binding.Target
{
    public abstract class MvxTextViewCompoundDrawablesBaseTargetBinding 
        : MvxAndroidTargetBinding
    {
        private readonly string _whichCompoundDrawable;

        protected MvxTextViewCompoundDrawablesBaseTargetBinding(object target, string whichCompoundDrawable)
            : base(target)
        {
            _whichCompoundDrawable = whichCompoundDrawable ?? throw new ArgumentNullException(nameof(whichCompoundDrawable));
        }

        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        protected override void SetValueImpl(object target, object value)
        {
            var textView = target as TextView;
            if (textView == null) return;

            if (value is int resourceId && resourceId != 0)
            {
                switch (_whichCompoundDrawable)
                {
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameLeft:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(resourceId, 0, 0, 0);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameRight:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(0, 0, resourceId, 0);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameTop:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(0, resourceId, 0, 0);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameBottom:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(0, 0, 0, resourceId);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameStart:
                        textView.SetCompoundDrawablesRelativeWithIntrinsicBounds(resourceId, 0, 0, 0);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameEnd:
                        textView.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, resourceId, 0);
                        break;
                }
            }
            else
            {
                MvxBindingLog.Warning(
                    "Value '{0}' was not a known resource drawable identifier", value);
            }
        }
    }
}
