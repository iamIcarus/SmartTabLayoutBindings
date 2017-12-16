using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ogaclejapan.Smarttablayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']"
	[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator", DoNotGenerateAcw=true)]
	public abstract partial class SmartTabIndicationInterpolator : global::Java.Lang.Object {


		static IntPtr LINEAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/field[@name='LINEAR']"
		[Register ("LINEAR")]
		public static global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator Linear {
			get {
				if (LINEAR_jfieldId == IntPtr.Zero)
					LINEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINEAR", "Lcom/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINEAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SMART_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/field[@name='SMART']"
		[Register ("SMART")]
		public static global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator Smart {
			get {
				if (SMART_jfieldId == IntPtr.Zero)
					SMART_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMART", "Lcom/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SMART_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.LinearIndicationInterpolator']"
		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator$LinearIndicationInterpolator", DoNotGenerateAcw=true)]
		public partial class LinearIndicationInterpolator : global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator$LinearIndicationInterpolator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LinearIndicationInterpolator); }
			}

			protected LinearIndicationInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.LinearIndicationInterpolator']/constructor[@name='SmartTabIndicationInterpolator.LinearIndicationInterpolator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe LinearIndicationInterpolator ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (LinearIndicationInterpolator)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static Delegate cb_getLeftEdge_F;
#pragma warning disable 0169
			static Delegate GetGetLeftEdge_FHandler ()
			{
				if (cb_getLeftEdge_F == null)
					cb_getLeftEdge_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetLeftEdge_F);
				return cb_getLeftEdge_F;
			}

			static float n_GetLeftEdge_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator.LinearIndicationInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator.LinearIndicationInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetLeftEdge (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getLeftEdge_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.LinearIndicationInterpolator']/method[@name='getLeftEdge' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("getLeftEdge", "(F)F", "GetGetLeftEdge_FHandler")]
			public override unsafe float GetLeftEdge (float p0)
			{
				if (id_getLeftEdge_F == IntPtr.Zero)
					id_getLeftEdge_F = JNIEnv.GetMethodID (class_ref, "getLeftEdge", "(F)F");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getLeftEdge_F, __args);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftEdge", "(F)F"), __args);
				} finally {
				}
			}

			static Delegate cb_getRightEdge_F;
#pragma warning disable 0169
			static Delegate GetGetRightEdge_FHandler ()
			{
				if (cb_getRightEdge_F == null)
					cb_getRightEdge_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetRightEdge_F);
				return cb_getRightEdge_F;
			}

			static float n_GetRightEdge_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator.LinearIndicationInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator.LinearIndicationInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRightEdge (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getRightEdge_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.LinearIndicationInterpolator']/method[@name='getRightEdge' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("getRightEdge", "(F)F", "GetGetRightEdge_FHandler")]
			public override unsafe float GetRightEdge (float p0)
			{
				if (id_getRightEdge_F == IntPtr.Zero)
					id_getRightEdge_F = JNIEnv.GetMethodID (class_ref, "getRightEdge", "(F)F");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRightEdge_F, __args);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightEdge", "(F)F"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.SmartIndicationInterpolator']"
		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator$SmartIndicationInterpolator", DoNotGenerateAcw=true)]
		public partial class SmartIndicationInterpolator : global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator$SmartIndicationInterpolator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SmartIndicationInterpolator); }
			}

			protected SmartIndicationInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.SmartIndicationInterpolator']/constructor[@name='SmartTabIndicationInterpolator.SmartIndicationInterpolator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SmartIndicationInterpolator ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (SmartIndicationInterpolator)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static IntPtr id_ctor_F;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.SmartIndicationInterpolator']/constructor[@name='SmartTabIndicationInterpolator.SmartIndicationInterpolator' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register (".ctor", "(F)V", "")]
			public unsafe SmartIndicationInterpolator (float p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (SmartIndicationInterpolator)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(F)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(F)V", __args);
						return;
					}

					if (id_ctor_F == IntPtr.Zero)
						id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_F, __args);
				} finally {
				}
			}

			static Delegate cb_getLeftEdge_F;
#pragma warning disable 0169
			static Delegate GetGetLeftEdge_FHandler ()
			{
				if (cb_getLeftEdge_F == null)
					cb_getLeftEdge_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetLeftEdge_F);
				return cb_getLeftEdge_F;
			}

			static float n_GetLeftEdge_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator.SmartIndicationInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator.SmartIndicationInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetLeftEdge (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getLeftEdge_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.SmartIndicationInterpolator']/method[@name='getLeftEdge' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("getLeftEdge", "(F)F", "GetGetLeftEdge_FHandler")]
			public override unsafe float GetLeftEdge (float p0)
			{
				if (id_getLeftEdge_F == IntPtr.Zero)
					id_getLeftEdge_F = JNIEnv.GetMethodID (class_ref, "getLeftEdge", "(F)F");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getLeftEdge_F, __args);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftEdge", "(F)F"), __args);
				} finally {
				}
			}

			static Delegate cb_getRightEdge_F;
#pragma warning disable 0169
			static Delegate GetGetRightEdge_FHandler ()
			{
				if (cb_getRightEdge_F == null)
					cb_getRightEdge_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetRightEdge_F);
				return cb_getRightEdge_F;
			}

			static float n_GetRightEdge_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator.SmartIndicationInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator.SmartIndicationInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRightEdge (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getRightEdge_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator.SmartIndicationInterpolator']/method[@name='getRightEdge' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("getRightEdge", "(F)F", "GetGetRightEdge_FHandler")]
			public override unsafe float GetRightEdge (float p0)
			{
				if (id_getRightEdge_F == IntPtr.Zero)
					id_getRightEdge_F = JNIEnv.GetMethodID (class_ref, "getRightEdge", "(F)F");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRightEdge_F, __args);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightEdge", "(F)F"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmartTabIndicationInterpolator); }
		}

		protected SmartTabIndicationInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/constructor[@name='SmartTabIndicationInterpolator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SmartTabIndicationInterpolator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SmartTabIndicationInterpolator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getLeftEdge_F;
#pragma warning disable 0169
		static Delegate GetGetLeftEdge_FHandler ()
		{
			if (cb_getLeftEdge_F == null)
				cb_getLeftEdge_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetLeftEdge_F);
			return cb_getLeftEdge_F;
		}

		static float n_GetLeftEdge_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLeftEdge (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/method[@name='getLeftEdge' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getLeftEdge", "(F)F", "GetGetLeftEdge_FHandler")]
		public abstract float GetLeftEdge (float p0);

		static Delegate cb_getRightEdge_F;
#pragma warning disable 0169
		static Delegate GetGetRightEdge_FHandler ()
		{
			if (cb_getRightEdge_F == null)
				cb_getRightEdge_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetRightEdge_F);
			return cb_getRightEdge_F;
		}

		static float n_GetRightEdge_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRightEdge (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/method[@name='getRightEdge' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getRightEdge", "(F)F", "GetGetRightEdge_FHandler")]
		public abstract float GetRightEdge (float p0);

		static Delegate cb_getThickness_F;
#pragma warning disable 0169
		static Delegate GetGetThickness_FHandler ()
		{
			if (cb_getThickness_F == null)
				cb_getThickness_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetThickness_F);
			return cb_getThickness_F;
		}

		static float n_GetThickness_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetThickness (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getThickness_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/method[@name='getThickness' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getThickness", "(F)F", "GetGetThickness_FHandler")]
		public virtual unsafe float GetThickness (float p0)
		{
			if (id_getThickness_F == IntPtr.Zero)
				id_getThickness_F = JNIEnv.GetMethodID (class_ref, "getThickness", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getThickness_F, __args);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThickness", "(F)F"), __args);
			} finally {
			}
		}

		static IntPtr id_of_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/method[@name='of' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("of", "(I)Lcom/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator;", "")]
		public static unsafe global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator Of (int p0)
		{
			if (id_of_I == IntPtr.Zero)
				id_of_I = JNIEnv.GetStaticMethodID (class_ref, "of", "(I)Lcom/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator", DoNotGenerateAcw=true)]
	internal partial class SmartTabIndicationInterpolatorInvoker : SmartTabIndicationInterpolator {

		public SmartTabIndicationInterpolatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmartTabIndicationInterpolatorInvoker); }
		}

		static IntPtr id_getLeftEdge_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/method[@name='getLeftEdge' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getLeftEdge", "(F)F", "GetGetLeftEdge_FHandler")]
		public override unsafe float GetLeftEdge (float p0)
		{
			if (id_getLeftEdge_F == IntPtr.Zero)
				id_getLeftEdge_F = JNIEnv.GetMethodID (class_ref, "getLeftEdge", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getLeftEdge_F, __args);
			} finally {
			}
		}

		static IntPtr id_getRightEdge_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabIndicationInterpolator']/method[@name='getRightEdge' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getRightEdge", "(F)F", "GetGetRightEdge_FHandler")]
		public override unsafe float GetRightEdge (float p0)
		{
			if (id_getRightEdge_F == IntPtr.Zero)
				id_getRightEdge_F = JNIEnv.GetMethodID (class_ref, "getRightEdge", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRightEdge_F, __args);
			} finally {
			}
		}

	}

}
