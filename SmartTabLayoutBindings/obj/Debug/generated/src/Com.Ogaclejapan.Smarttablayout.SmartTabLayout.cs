using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ogaclejapan.Smarttablayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']"
	[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabLayout", DoNotGenerateAcw=true)]
	public partial class SmartTabLayout : global::Android.Widget.HorizontalScrollView {


		static IntPtr tabStrip_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/field[@name='tabStrip']"
		[Register ("tabStrip")]
		protected global::Com.Ogaclejapan.Smarttablayout.SmartTabStrip TabStrip {
			get {
				if (tabStrip_jfieldId == IntPtr.Zero)
					tabStrip_jfieldId = JNIEnv.GetFieldID (class_ref, "tabStrip", "Lcom/ogaclejapan/smarttablayout/SmartTabStrip;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tabStrip_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabStrip> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tabStrip_jfieldId == IntPtr.Zero)
					tabStrip_jfieldId = JNIEnv.GetFieldID (class_ref, "tabStrip", "Lcom/ogaclejapan/smarttablayout/SmartTabStrip;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tabStrip_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout.InternalTabClickListener']"
		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$InternalTabClickListener", DoNotGenerateAcw=true)]
		public partial class InternalTabClickListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabLayout$InternalTabClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InternalTabClickListener); }
			}

			protected InternalTabClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ == null)
					cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
				return cb_onClick_Landroid_view_View_;
			}

			static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.InternalTabClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.InternalTabClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout.InternalTabClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
			public virtual unsafe void OnClick (global::Android.Views.View p0)
			{
				if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
					id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout.InternalViewPagerListener']"
		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$InternalViewPagerListener", DoNotGenerateAcw=true)]
		public partial class InternalViewPagerListener : global::Java.Lang.Object, global::Android.Support.V4.View.ViewPager.IOnPageChangeListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabLayout$InternalViewPagerListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InternalViewPagerListener); }
			}

			protected InternalViewPagerListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onPageScrollStateChanged_I;
#pragma warning disable 0169
			static Delegate GetOnPageScrollStateChanged_IHandler ()
			{
				if (cb_onPageScrollStateChanged_I == null)
					cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageScrollStateChanged_I);
				return cb_onPageScrollStateChanged_I;
			}

			static void n_OnPageScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.InternalViewPagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.InternalViewPagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageScrollStateChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPageScrollStateChanged_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout.InternalViewPagerListener']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler")]
			public virtual unsafe void OnPageScrollStateChanged (int p0)
			{
				if (id_onPageScrollStateChanged_I == IntPtr.Zero)
					id_onPageScrollStateChanged_I = JNIEnv.GetMethodID (class_ref, "onPageScrollStateChanged", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrollStateChanged_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageScrollStateChanged", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
			static Delegate GetOnPageScrolled_IFIHandler ()
			{
				if (cb_onPageScrolled_IFI == null)
					cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, int>) n_OnPageScrolled_IFI);
				return cb_onPageScrolled_IFI;
			}

			static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int p0, float p1, int p2)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.InternalViewPagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.InternalViewPagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageScrolled (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onPageScrolled_IFI;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout.InternalViewPagerListener']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
			[Register ("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
			public virtual unsafe void OnPageScrolled (int p0, float p1, int p2)
			{
				if (id_onPageScrolled_IFI == IntPtr.Zero)
					id_onPageScrolled_IFI = JNIEnv.GetMethodID (class_ref, "onPageScrolled", "(IFI)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrolled_IFI, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageScrolled", "(IFI)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPageSelected_I;
#pragma warning disable 0169
			static Delegate GetOnPageSelected_IHandler ()
			{
				if (cb_onPageSelected_I == null)
					cb_onPageSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageSelected_I);
				return cb_onPageSelected_I;
			}

			static void n_OnPageSelected_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.InternalViewPagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.InternalViewPagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageSelected (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPageSelected_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout.InternalViewPagerListener']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onPageSelected", "(I)V", "GetOnPageSelected_IHandler")]
			public virtual unsafe void OnPageSelected (int p0)
			{
				if (id_onPageSelected_I == IntPtr.Zero)
					id_onPageSelected_I = JNIEnv.GetMethodID (class_ref, "onPageSelected", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageSelected_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageSelected", "(I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.OnScrollChangeListener']"
		[Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$OnScrollChangeListener", "", "Com.Ogaclejapan.Smarttablayout.SmartTabLayout/IOnScrollChangeListenerInvoker")]
		public partial interface IOnScrollChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.OnScrollChangeListener']/method[@name='onScrollChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onScrollChanged", "(II)V", "GetOnScrollChanged_IIHandler:Com.Ogaclejapan.Smarttablayout.SmartTabLayout/IOnScrollChangeListenerInvoker, SmartTabLayoutBindings")]
			void OnScrollChanged (int p0, int p1);

		}

		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$OnScrollChangeListener", DoNotGenerateAcw=true)]
		internal class IOnScrollChangeListenerInvoker : global::Java.Lang.Object, IOnScrollChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabLayout$OnScrollChangeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnScrollChangeListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnScrollChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnScrollChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ogaclejapan.smarttablayout.SmartTabLayout.OnScrollChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnScrollChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onScrollChanged_II;
#pragma warning disable 0169
			static Delegate GetOnScrollChanged_IIHandler ()
			{
				if (cb_onScrollChanged_II == null)
					cb_onScrollChanged_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnScrollChanged_II);
				return cb_onScrollChanged_II;
			}

			static void n_OnScrollChanged_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnScrollChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onScrollChanged_II;
			public unsafe void OnScrollChanged (int p0, int p1)
			{
				if (id_onScrollChanged_II == IntPtr.Zero)
					id_onScrollChanged_II = JNIEnv.GetMethodID (class_ref, "onScrollChanged", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollChanged_II, __args);
			}

		}

		public partial class ScrollChangeEventArgs : global::System.EventArgs {

			public ScrollChangeEventArgs (int p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/ogaclejapan/smarttablayout/SmartTabLayout_OnScrollChangeListenerImplementor")]
		internal sealed partial class IOnScrollChangeListenerImplementor : global::Java.Lang.Object, IOnScrollChangeListener {

			object sender;

			public IOnScrollChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ogaclejapan/smarttablayout/SmartTabLayout_OnScrollChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ScrollChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnScrollChanged (int p0, int p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ScrollChangeEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnScrollChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.OnTabClickListener']"
		[Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$OnTabClickListener", "", "Com.Ogaclejapan.Smarttablayout.SmartTabLayout/IOnTabClickListenerInvoker")]
		public partial interface IOnTabClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.OnTabClickListener']/method[@name='onTabClicked' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTabClicked", "(I)V", "GetOnTabClicked_IHandler:Com.Ogaclejapan.Smarttablayout.SmartTabLayout/IOnTabClickListenerInvoker, SmartTabLayoutBindings")]
			void OnTabClicked (int p0);

		}

		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$OnTabClickListener", DoNotGenerateAcw=true)]
		internal class IOnTabClickListenerInvoker : global::Java.Lang.Object, IOnTabClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabLayout$OnTabClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnTabClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnTabClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnTabClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ogaclejapan.smarttablayout.SmartTabLayout.OnTabClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnTabClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTabClicked_I;
#pragma warning disable 0169
			static Delegate GetOnTabClicked_IHandler ()
			{
				if (cb_onTabClicked_I == null)
					cb_onTabClicked_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTabClicked_I);
				return cb_onTabClicked_I;
			}

			static void n_OnTabClicked_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTabClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTabClicked_I;
			public unsafe void OnTabClicked (int p0)
			{
				if (id_onTabClicked_I == IntPtr.Zero)
					id_onTabClicked_I = JNIEnv.GetMethodID (class_ref, "onTabClicked", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTabClicked_I, __args);
			}

		}

		public partial class TabClickEventArgs : global::System.EventArgs {

			public TabClickEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/ogaclejapan/smarttablayout/SmartTabLayout_OnTabClickListenerImplementor")]
		internal sealed partial class IOnTabClickListenerImplementor : global::Java.Lang.Object, IOnTabClickListener {

			object sender;

			public IOnTabClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ogaclejapan/smarttablayout/SmartTabLayout_OnTabClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TabClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnTabClicked (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new TabClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnTabClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout.SimpleTabProvider']"
		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$SimpleTabProvider", DoNotGenerateAcw=true)]
		public partial class SimpleTabProvider : global::Java.Lang.Object, global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabProvider {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabLayout$SimpleTabProvider", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SimpleTabProvider); }
			}

			protected SimpleTabProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_;
#pragma warning disable 0169
			static Delegate GetCreateTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_Handler ()
			{
				if (cb_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ == null)
					cb_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_CreateTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_);
				return cb_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_;
			}

			static IntPtr n_CreateTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.SimpleTabProvider __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.SimpleTabProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V4.View.PagerAdapter p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.PagerAdapter> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateTabView (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout.SimpleTabProvider']/method[@name='createTabView' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int'] and parameter[3][@type='android.support.v4.view.PagerAdapter']]"
			[Register ("createTabView", "(Landroid/view/ViewGroup;ILandroid/support/v4/view/PagerAdapter;)Landroid/view/View;", "GetCreateTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_Handler")]
			public virtual unsafe global::Android.Views.View CreateTabView (global::Android.Views.ViewGroup p0, int p1, global::Android.Support.V4.View.PagerAdapter p2)
			{
				if (id_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ == IntPtr.Zero)
					id_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ = JNIEnv.GetMethodID (class_ref, "createTabView", "(Landroid/view/ViewGroup;ILandroid/support/v4/view/PagerAdapter;)Landroid/view/View;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Android.Views.View __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTabView", "(Landroid/view/ViewGroup;ILandroid/support/v4/view/PagerAdapter;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.TabColorizer']"
		[Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$TabColorizer", "", "Com.Ogaclejapan.Smarttablayout.SmartTabLayout/ITabColorizerInvoker")]
		public partial interface ITabColorizer : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.TabColorizer']/method[@name='getDividerColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getDividerColor", "(I)I", "GetGetDividerColor_IHandler:Com.Ogaclejapan.Smarttablayout.SmartTabLayout/ITabColorizerInvoker, SmartTabLayoutBindings")]
			int GetDividerColor (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.TabColorizer']/method[@name='getIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getIndicatorColor", "(I)I", "GetGetIndicatorColor_IHandler:Com.Ogaclejapan.Smarttablayout.SmartTabLayout/ITabColorizerInvoker, SmartTabLayoutBindings")]
			int GetIndicatorColor (int p0);

		}

		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$TabColorizer", DoNotGenerateAcw=true)]
		internal class ITabColorizerInvoker : global::Java.Lang.Object, ITabColorizer {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabLayout$TabColorizer");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ITabColorizerInvoker); }
			}

			IntPtr class_ref;

			public static ITabColorizer GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITabColorizer> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ogaclejapan.smarttablayout.SmartTabLayout.TabColorizer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITabColorizerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getDividerColor_I;
#pragma warning disable 0169
			static Delegate GetGetDividerColor_IHandler ()
			{
				if (cb_getDividerColor_I == null)
					cb_getDividerColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetDividerColor_I);
				return cb_getDividerColor_I;
			}

			static int n_GetDividerColor_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetDividerColor (p0);
			}
#pragma warning restore 0169

			IntPtr id_getDividerColor_I;
			public unsafe int GetDividerColor (int p0)
			{
				if (id_getDividerColor_I == IntPtr.Zero)
					id_getDividerColor_I = JNIEnv.GetMethodID (class_ref, "getDividerColor", "(I)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDividerColor_I, __args);
			}

			static Delegate cb_getIndicatorColor_I;
#pragma warning disable 0169
			static Delegate GetGetIndicatorColor_IHandler ()
			{
				if (cb_getIndicatorColor_I == null)
					cb_getIndicatorColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIndicatorColor_I);
				return cb_getIndicatorColor_I;
			}

			static int n_GetIndicatorColor_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetIndicatorColor (p0);
			}
#pragma warning restore 0169

			IntPtr id_getIndicatorColor_I;
			public unsafe int GetIndicatorColor (int p0)
			{
				if (id_getIndicatorColor_I == IntPtr.Zero)
					id_getIndicatorColor_I = JNIEnv.GetMethodID (class_ref, "getIndicatorColor", "(I)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorColor_I, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.TabProvider']"
		[Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$TabProvider", "", "Com.Ogaclejapan.Smarttablayout.SmartTabLayout/ITabProviderInvoker")]
		public partial interface ITabProvider : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/interface[@name='SmartTabLayout.TabProvider']/method[@name='createTabView' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int'] and parameter[3][@type='android.support.v4.view.PagerAdapter']]"
			[Register ("createTabView", "(Landroid/view/ViewGroup;ILandroid/support/v4/view/PagerAdapter;)Landroid/view/View;", "GetCreateTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_Handler:Com.Ogaclejapan.Smarttablayout.SmartTabLayout/ITabProviderInvoker, SmartTabLayoutBindings")]
			global::Android.Views.View CreateTabView (global::Android.Views.ViewGroup p0, int p1, global::Android.Support.V4.View.PagerAdapter p2);

		}

		[global::Android.Runtime.Register ("com/ogaclejapan/smarttablayout/SmartTabLayout$TabProvider", DoNotGenerateAcw=true)]
		internal class ITabProviderInvoker : global::Java.Lang.Object, ITabProvider {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabLayout$TabProvider");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ITabProviderInvoker); }
			}

			IntPtr class_ref;

			public static ITabProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITabProvider> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ogaclejapan.smarttablayout.SmartTabLayout.TabProvider"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITabProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_;
#pragma warning disable 0169
			static Delegate GetCreateTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_Handler ()
			{
				if (cb_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ == null)
					cb_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_CreateTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_);
				return cb_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_;
			}

			static IntPtr n_CreateTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabProvider __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V4.View.PagerAdapter p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.PagerAdapter> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateTabView (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_;
			public unsafe global::Android.Views.View CreateTabView (global::Android.Views.ViewGroup p0, int p1, global::Android.Support.V4.View.PagerAdapter p2)
			{
				if (id_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ == IntPtr.Zero)
					id_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_ = JNIEnv.GetMethodID (class_ref, "createTabView", "(Landroid/view/ViewGroup;ILandroid/support/v4/view/PagerAdapter;)Landroid/view/View;");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createTabView_Landroid_view_ViewGroup_ILandroid_support_v4_view_PagerAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ogaclejapan/smarttablayout/SmartTabLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmartTabLayout); }
		}

		protected SmartTabLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/constructor[@name='SmartTabLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SmartTabLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SmartTabLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/constructor[@name='SmartTabLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SmartTabLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SmartTabLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/constructor[@name='SmartTabLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SmartTabLayout (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SmartTabLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_createDefaultTabView_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetCreateDefaultTabView_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_createDefaultTabView_Ljava_lang_CharSequence_ == null)
				cb_createDefaultTabView_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDefaultTabView_Ljava_lang_CharSequence_);
			return cb_createDefaultTabView_Ljava_lang_CharSequence_;
		}

		static IntPtr n_CreateDefaultTabView_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDefaultTabView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createDefaultTabView_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='createDefaultTabView' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("createDefaultTabView", "(Ljava/lang/CharSequence;)Landroid/widget/TextView;", "GetCreateDefaultTabView_Ljava_lang_CharSequence_Handler")]
		protected virtual unsafe global::Android.Widget.TextView CreateDefaultTabView (global::Java.Lang.ICharSequence p0)
		{
			if (id_createDefaultTabView_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_createDefaultTabView_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "createDefaultTabView", "(Ljava/lang/CharSequence;)Landroid/widget/TextView;");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Widget.TextView __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createDefaultTabView_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createDefaultTabView", "(Ljava/lang/CharSequence;)Landroid/widget/TextView;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		protected global::Android.Widget.TextView CreateDefaultTabView (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			global::Android.Widget.TextView __result = CreateDefaultTabView (jls_p0);
			var __rsval = __result;
			jls_p0?.Dispose ();
			return __rsval;
		}

		static Delegate cb_getTabAt_I;
#pragma warning disable 0169
		static Delegate GetGetTabAt_IHandler ()
		{
			if (cb_getTabAt_I == null)
				cb_getTabAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTabAt_I);
			return cb_getTabAt_I;
		}

		static IntPtr n_GetTabAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTabAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTabAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='getTabAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTabAt", "(I)Landroid/view/View;", "GetGetTabAt_IHandler")]
		public virtual unsafe global::Android.Views.View GetTabAt (int p0)
		{
			if (id_getTabAt_I == IntPtr.Zero)
				id_getTabAt_I = JNIEnv.GetMethodID (class_ref, "getTabAt", "(I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTabAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabAt", "(I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_;
#pragma warning disable 0169
		static Delegate GetSetCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_Handler ()
		{
			if (cb_setCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_ == null)
				cb_setCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_);
			return cb_setCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_;
		}

		static void n_SetCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer p0 = (global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer)global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomTabColorizer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setCustomTabColorizer' and count(parameter)=1 and parameter[1][@type='com.ogaclejapan.smarttablayout.SmartTabLayout.TabColorizer']]"
		[Register ("setCustomTabColorizer", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$TabColorizer;)V", "GetSetCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_Handler")]
		public virtual unsafe void SetCustomTabColorizer (global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabColorizer p0)
		{
			if (id_setCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_ == IntPtr.Zero)
				id_setCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_ = JNIEnv.GetMethodID (class_ref, "setCustomTabColorizer", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$TabColorizer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomTabColorizer_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabColorizer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomTabColorizer", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$TabColorizer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_;
#pragma warning disable 0169
		static Delegate GetSetCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_Handler ()
		{
			if (cb_setCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_ == null)
				cb_setCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_);
			return cb_setCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_;
		}

		static void n_SetCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabProvider p0 = (global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabProvider)global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomTabView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setCustomTabView' and count(parameter)=1 and parameter[1][@type='com.ogaclejapan.smarttablayout.SmartTabLayout.TabProvider']]"
		[Register ("setCustomTabView", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$TabProvider;)V", "GetSetCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_Handler")]
		public virtual unsafe void SetCustomTabView (global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ITabProvider p0)
		{
			if (id_setCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_ == IntPtr.Zero)
				id_setCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_ = JNIEnv.GetMethodID (class_ref, "setCustomTabView", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$TabProvider;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomTabView_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_TabProvider_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomTabView", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$TabProvider;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCustomTabView_II;
#pragma warning disable 0169
		static Delegate GetSetCustomTabView_IIHandler ()
		{
			if (cb_setCustomTabView_II == null)
				cb_setCustomTabView_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetCustomTabView_II);
			return cb_setCustomTabView_II;
		}

		static void n_SetCustomTabView_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomTabView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomTabView_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setCustomTabView' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCustomTabView", "(II)V", "GetSetCustomTabView_IIHandler")]
		public virtual unsafe void SetCustomTabView (int p0, int p1)
		{
			if (id_setCustomTabView_II == IntPtr.Zero)
				id_setCustomTabView_II = JNIEnv.GetMethodID (class_ref, "setCustomTabView", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomTabView_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomTabView", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultTabTextColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetDefaultTabTextColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setDefaultTabTextColor_Landroid_content_res_ColorStateList_ == null)
				cb_setDefaultTabTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultTabTextColor_Landroid_content_res_ColorStateList_);
			return cb_setDefaultTabTextColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetDefaultTabTextColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.ColorStateList p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultTabTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultTabTextColor_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setDefaultTabTextColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setDefaultTabTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetDefaultTabTextColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetDefaultTabTextColor (global::Android.Content.Res.ColorStateList p0)
		{
			if (id_setDefaultTabTextColor_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				id_setDefaultTabTextColor_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID (class_ref, "setDefaultTabTextColor", "(Landroid/content/res/ColorStateList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultTabTextColor_Landroid_content_res_ColorStateList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultTabTextColor", "(Landroid/content/res/ColorStateList;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultTabTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultTabTextColor_IHandler ()
		{
			if (cb_setDefaultTabTextColor_I == null)
				cb_setDefaultTabTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDefaultTabTextColor_I);
			return cb_setDefaultTabTextColor_I;
		}

		static void n_SetDefaultTabTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultTabTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultTabTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setDefaultTabTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultTabTextColor", "(I)V", "GetSetDefaultTabTextColor_IHandler")]
		public virtual unsafe void SetDefaultTabTextColor (int p0)
		{
			if (id_setDefaultTabTextColor_I == IntPtr.Zero)
				id_setDefaultTabTextColor_I = JNIEnv.GetMethodID (class_ref, "setDefaultTabTextColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultTabTextColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultTabTextColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDistributeEvenly_Z;
#pragma warning disable 0169
		static Delegate GetSetDistributeEvenly_ZHandler ()
		{
			if (cb_setDistributeEvenly_Z == null)
				cb_setDistributeEvenly_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDistributeEvenly_Z);
			return cb_setDistributeEvenly_Z;
		}

		static void n_SetDistributeEvenly_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDistributeEvenly (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDistributeEvenly_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setDistributeEvenly' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDistributeEvenly", "(Z)V", "GetSetDistributeEvenly_ZHandler")]
		public virtual unsafe void SetDistributeEvenly (bool p0)
		{
			if (id_setDistributeEvenly_Z == IntPtr.Zero)
				id_setDistributeEvenly_Z = JNIEnv.GetMethodID (class_ref, "setDistributeEvenly", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDistributeEvenly_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistributeEvenly", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDividerColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetDividerColors_arrayIHandler ()
		{
			if (cb_setDividerColors_arrayI == null)
				cb_setDividerColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDividerColors_arrayI);
			return cb_setDividerColors_arrayI;
		}

		static void n_SetDividerColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetDividerColors (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDividerColors_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setDividerColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setDividerColors", "([I)V", "GetSetDividerColors_arrayIHandler")]
		public virtual unsafe void SetDividerColors (params  int[] p0)
		{
			if (id_setDividerColors_arrayI == IntPtr.Zero)
				id_setDividerColors_arrayI = JNIEnv.GetMethodID (class_ref, "setDividerColors", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDividerColors_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerColors", "([I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_;
#pragma warning disable 0169
		static Delegate GetSetIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_Handler ()
		{
			if (cb_setIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_ == null)
				cb_setIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_);
			return cb_setIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_;
		}

		static void n_SetIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator p0 = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicationInterpolator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setIndicationInterpolator' and count(parameter)=1 and parameter[1][@type='com.ogaclejapan.smarttablayout.SmartTabIndicationInterpolator']]"
		[Register ("setIndicationInterpolator", "(Lcom/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator;)V", "GetSetIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_Handler")]
		public virtual unsafe void SetIndicationInterpolator (global::Com.Ogaclejapan.Smarttablayout.SmartTabIndicationInterpolator p0)
		{
			if (id_setIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_ == IntPtr.Zero)
				id_setIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_ = JNIEnv.GetMethodID (class_ref, "setIndicationInterpolator", "(Lcom/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicationInterpolator_Lcom_ogaclejapan_smarttablayout_SmartTabIndicationInterpolator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicationInterpolator", "(Lcom/ogaclejapan/smarttablayout/SmartTabIndicationInterpolator;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_Handler ()
		{
			if (cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ == null)
				cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_);
			return cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		}

		static void n_SetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0 = (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager.OnPageChangeListener']]"
		[Register ("setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V", "GetSetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_Handler")]
		public virtual unsafe void SetOnPageChangeListener (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0)
		{
			if (id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ == IntPtr.Zero)
				id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_Handler ()
		{
			if (cb_setOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_ == null)
				cb_setOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_);
			return cb_setOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_;
		}

		static void n_SetOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener p0 = (global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener)global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnScrollChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setOnScrollChangeListener' and count(parameter)=1 and parameter[1][@type='com.ogaclejapan.smarttablayout.SmartTabLayout.OnScrollChangeListener']]"
		[Register ("setOnScrollChangeListener", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$OnScrollChangeListener;)V", "GetSetOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_Handler")]
		public virtual unsafe void SetOnScrollChangeListener (global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener p0)
		{
			if (id_setOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_ == IntPtr.Zero)
				id_setOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnScrollChangeListener", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$OnScrollChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnScrollChangeListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnScrollChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnScrollChangeListener", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$OnScrollChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_Handler ()
		{
			if (cb_setOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_ == null)
				cb_setOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_);
			return cb_setOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_;
		}

		static void n_SetOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener p0 = (global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener)global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTabClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setOnTabClickListener' and count(parameter)=1 and parameter[1][@type='com.ogaclejapan.smarttablayout.SmartTabLayout.OnTabClickListener']]"
		[Register ("setOnTabClickListener", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$OnTabClickListener;)V", "GetSetOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_Handler")]
		public virtual unsafe void SetOnTabClickListener (global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener p0)
		{
			if (id_setOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_ == IntPtr.Zero)
				id_setOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnTabClickListener", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$OnTabClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnTabClickListener_Lcom_ogaclejapan_smarttablayout_SmartTabLayout_OnTabClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnTabClickListener", "(Lcom/ogaclejapan/smarttablayout/SmartTabLayout$OnTabClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectedIndicatorColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetSelectedIndicatorColors_arrayIHandler ()
		{
			if (cb_setSelectedIndicatorColors_arrayI == null)
				cb_setSelectedIndicatorColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedIndicatorColors_arrayI);
			return cb_setSelectedIndicatorColors_arrayI;
		}

		static void n_SetSelectedIndicatorColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetSelectedIndicatorColors (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectedIndicatorColors_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setSelectedIndicatorColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setSelectedIndicatorColors", "([I)V", "GetSetSelectedIndicatorColors_arrayIHandler")]
		public virtual unsafe void SetSelectedIndicatorColors (params  int[] p0)
		{
			if (id_setSelectedIndicatorColors_arrayI == IntPtr.Zero)
				id_setSelectedIndicatorColors_arrayI = JNIEnv.GetMethodID (class_ref, "setSelectedIndicatorColors", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedIndicatorColors_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedIndicatorColors", "([I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setViewPager_Landroid_support_v4_view_ViewPager_;
#pragma warning disable 0169
		static Delegate GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler ()
		{
			if (cb_setViewPager_Landroid_support_v4_view_ViewPager_ == null)
				cb_setViewPager_Landroid_support_v4_view_ViewPager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewPager_Landroid_support_v4_view_ViewPager_);
			return cb_setViewPager_Landroid_support_v4_view_ViewPager_;
		}

		static void n_SetViewPager_Landroid_support_v4_view_ViewPager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogaclejapan.smarttablayout']/class[@name='SmartTabLayout']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler")]
		public virtual unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0)
		{
			if (id_setViewPager_Landroid_support_v4_view_ViewPager_ == IntPtr.Zero)
				id_setViewPager_Landroid_support_v4_view_ViewPager_ = JNIEnv.GetMethodID (class_ref, "setViewPager", "(Landroid/support/v4/view/ViewPager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewPager_Landroid_support_v4_view_ViewPager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewPager", "(Landroid/support/v4/view/ViewPager;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener"
		public event EventHandler<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.ScrollChangeEventArgs> ScrollChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener, global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListenerImplementor>(
						ref weak_implementor_SetOnScrollChangeListener,
						__CreateIOnScrollChangeListenerImplementor,
						SetOnScrollChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListener, global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListenerImplementor>(
						ref weak_implementor_SetOnScrollChangeListener,
						global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListenerImplementor.__IsEmpty,
						__v => SetOnScrollChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnScrollChangeListener;

		global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListenerImplementor __CreateIOnScrollChangeListenerImplementor ()
		{
			return new global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnScrollChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener"
		public event EventHandler<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.TabClickEventArgs> TabClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener, global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListenerImplementor>(
						ref weak_implementor_SetOnTabClickListener,
						__CreateIOnTabClickListenerImplementor,
						SetOnTabClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListener, global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListenerImplementor>(
						ref weak_implementor_SetOnTabClickListener,
						global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListenerImplementor.__IsEmpty,
						__v => SetOnTabClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnTabClickListener;

		global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListenerImplementor __CreateIOnTabClickListenerImplementor ()
		{
			return new global::Com.Ogaclejapan.Smarttablayout.SmartTabLayout.IOnTabClickListenerImplementor (this);
		}
#endregion
	}
}
