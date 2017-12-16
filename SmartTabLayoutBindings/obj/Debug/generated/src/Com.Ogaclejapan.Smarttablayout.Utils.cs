using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ogaclejapan.Smarttablayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/Utils", DoNotGenerateAcw=true)]
	public sealed partial class Utils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		internal Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
