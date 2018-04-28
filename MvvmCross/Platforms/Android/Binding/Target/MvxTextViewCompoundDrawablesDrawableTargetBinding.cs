// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using Android.Widget;
using MvvmCross.Binding;

namespace MvvmCross.Platforms.Android.Binding.Target
{
    public class MvxTextViewCompoundDrawablesDrawableTargetBinding 
        : MvxAndroidTargetBinding
    {
        private readonly string _whichCompoundDrawable;

        public MvxTextViewCompoundDrawablesDrawableTargetBinding(TextView target, string whichCompoundDrawable)
            : base(target)
        {
            _whichCompoundDrawable = whichCompoundDrawable ?? throw new ArgumentNullException(nameof(whichCompoundDrawable));
        }

        public override Type TargetType => typeof(int);

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
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableIdLeft:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(resourceId, 0, 0, 0);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameRight:
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableIdRight:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(0, 0, resourceId, 0);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameTop:
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableIdTop:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(0, resourceId, 0, 0);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameBottom:
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableIdBottom:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(0, 0, 0, resourceId);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameStart:
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableIdStart:
                        textView.SetCompoundDrawablesRelativeWithIntrinsicBounds(resourceId, 0, 0, 0);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameEnd:
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableIdEnd:
                        textView.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, resourceId, 0);
                        break;
                }
            }
            else if (value is ValueTuple<int, int, int, int> directions)
            {
                switch (_whichCompoundDrawable)
                {
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableName:
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableId:
                        textView.SetCompoundDrawablesWithIntrinsicBounds(directions.Item1, directions.Item2, directions.Item3, directions.Item4);
                        break;
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableNameRelative:
                    case MvxAndroidPropertyBinding.TextView_CompoundDrawableIdRelative:
                        textView.SetCompoundDrawablesRelativeWithIntrinsicBounds(directions.Item1, directions.Item2, directions.Item3, directions.Item4);
                        break;
                }
            }
            else
            {
                MvxBindingLog.Warning("Value '{0}' was not a known resource drawable identifier", value);
            }
        }
    }
}
