﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using Android.Preferences;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Binding.Views;

namespace MvvmCross.Platforms.Android.Binding
{
    public static class MvxAndroidPropertyBindingExtensions
    {
        public static string BindClick(this View view)
            => MvxAndroidPropertyBinding.View_Click;

        public static string BindText(this TextView textview)
            => MvxAndroidPropertyBinding.TextView_Text;

        public static string BindTextFormatted(this TextView textview)
            => MvxAndroidPropertyBinding.TextView_TextFormatted;

        public static string BindPartialText(this MvxAutoCompleteTextView mvxAutoCompleteTextView)
            => MvxAndroidPropertyBinding.MvxAutoCompleteTextView_PartialText;

        public static string BindSelectedObject(this MvxAutoCompleteTextView mvxAutoCompleteTextView)
            => MvxAndroidPropertyBinding.MvxAutoCompleteTextView_SelectedObject;

        public static string BindChecked(this CompoundButton compoundButton)
            => MvxAndroidPropertyBinding.CompoundButton_Checked;

        public static string BindProgress(this SeekBar seekBar)
            => MvxAndroidPropertyBinding.SeekBar_Progress;

        public static string BindVisible(this View view)
            => MvxAndroidPropertyBinding.View_Visible;

        public static string BindHidden(this View view)
            => MvxAndroidPropertyBinding.View_Hidden;

        public static string BindBitmap(this ImageView imageView)
            => MvxAndroidPropertyBinding.ImageView_Bitmap;

        public static string BindDrawable(this ImageView imageView)
            => MvxAndroidPropertyBinding.ImageView_Drawable;

        public static string BindDrawableId(this ImageView imageView)
            => MvxAndroidPropertyBinding.ImageView_DrawableId;

        public static string BindDrawableName(this ImageView imageView)
            => MvxAndroidPropertyBinding.ImageView_DrawableName;

        public static string BindResourceName(this ImageView imageView)
            => MvxAndroidPropertyBinding.ImageView_ResourceName;

        public static string BindAssetImagePath(this ImageView imageView)
            => MvxAndroidPropertyBinding.ImageView_AssetImagePath;

        public static string BindSelectedItem(this MvxSpinner mvxSpinner)
            => MvxAndroidPropertyBinding.MvxSpinner_SelectedItem;

        public static string BindSelectedItemPosition(this AdapterView adapterView)
            => MvxAndroidPropertyBinding.AdapterView_SelectedItemPosition;

        public static string BindSelectedItem(this MvxListView mvxListView)
            => MvxAndroidPropertyBinding.MvxListView_SelectedItem;

        public static string BindSelectedItem(this MvxExpandableListView mvxExpandableListView)
            => MvxAndroidPropertyBinding.MvxExpandableListView_SelectedItem;

        public static string BindRating(this RatingBar ratingBar)
            => MvxAndroidPropertyBinding.RatingBar_Rating;

        public static string BindLongClick(this View view)
            => MvxAndroidPropertyBinding.View_LongClick;

        public static string BindSelectedItem(this MvxRadioGroup mvxRadioGroup)
            => MvxAndroidPropertyBinding.MvxRadioGroup_SelectedItem;

        public static string BindTextFocus(this EditText editText)
            => MvxAndroidPropertyBinding.EditText_TextFocus;

        public static string BindQuery(this SearchView searchView)
            => MvxAndroidPropertyBinding.SearchView_Query;

        public static string BindValue(this Preference preference)
            => MvxAndroidPropertyBinding.Preference_Value;

        public static string BindText(this EditTextPreference editTextPreference)
            => MvxAndroidPropertyBinding.EditTextPreference_Text;

        public static string BindValue(this ListPreference listPreference)
            => MvxAndroidPropertyBinding.ListPreference_Value;

        public static string BindChecked(this TwoStatePreference twoStatePreference)
            => MvxAndroidPropertyBinding.TwoStatePreference_Checked;

        public static string BindMargin(this View view)
            => MvxAndroidPropertyBinding.View_Margin;

        public static string BindMarginLeft(this View view)
            => MvxAndroidPropertyBinding.View_MarginLeft;

        public static string BindMarginRight(this View view)
            => MvxAndroidPropertyBinding.View_MarginRight;

        public static string BindMarginTop(this View view)
            => MvxAndroidPropertyBinding.View_MarginTop;

        public static string BindMarginBottom(this View view)
            => MvxAndroidPropertyBinding.View_MarginBottom;

        public static string BindMarginStart(this View view)
            => MvxAndroidPropertyBinding.View_MarginStart;

        public static string BindMarginEnd(this View view)
            => MvxAndroidPropertyBinding.View_MarginEnd;

        public static string BindCompoundDrawableNameLeft(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableNameLeft;

        public static string BindompoundDrawableNameRight(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableNameRight;

        public static string BindCompoundDrawableNameTop(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableNameTop;

        public static string BindCompoundDrawableNameBottom(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableNameBottom;

        public static string BindCompoundDrawableNameStart(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableNameStart;

        public static string BindCompoundDrawableNameEnd(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableNameEnd;

        public static string BindCompoundDrawableIdLeft(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableIdLeft;

        public static string BindCompoundDrawableIdRight(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableIdRight;

        public static string BindCompoundDrawableIdTop(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableIdTop;

        public static string BindCompoundDrawableIdBottom(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableIdBottom;

        public static string BindCompoundDrawableIdStart(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableIdStart;

        public static string BindCompoundDrawableIdEnd(this TextView view)
            => MvxAndroidPropertyBinding.TextView_CompoundDrawableIdEnd;
    }
}
