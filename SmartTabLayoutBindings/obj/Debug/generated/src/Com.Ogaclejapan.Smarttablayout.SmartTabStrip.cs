using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ogaclejapan.Smarttablayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabStrip']"
	[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabStrip", DoNotGenerateAcw=true)]
	public partial class SmartTabStrip : global::Android.Widget.LinearLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabStrip.SimpleTabColorizer']"
		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabStrip$SimpleTabColorizer", DoNotGenerateAcw=true)]
		public partial class SimpleTabColorizer : global::Java.Lang.Object, global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabStrip$SimpleTabColorizer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SimpleTabColorizer); }
			}

			protected SimpleTabColorizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDividerColor_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabStrip.SimpleTabColorizer']/method[@name='getDividerColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getDividerColor", "(I)I", "")]
			public unsafe int GetDividerColor (int p0)
			{
				if (id_getDividerColor_I == IntPtr.Zero)
					id_getDividerColor_I = JNIEnv.GetMethodID (class_ref, "getDividerColor", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDividerColor_I, __args);
				} finally {
				}
			}

			static IntPtr id_getIndicatorColor_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabStrip.SimpleTabColorizer']/method[@name='getIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getIndicatorColor", "(I)I", "")]
			public unsafe int GetIndicatorColor (int p0)
			{
				if (id_getIndicatorColor_I == IntPtr.Zero)
					id_getIndicatorColor_I = JNIEnv.GetMethodID (class_ref, "getIndicatorColor", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorColor_I, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabStrip", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmartTabStrip); }
		}

		protected SmartTabStrip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
