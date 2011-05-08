//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.PowerPointApi
{
	///<summary>
	/// DispatchInterface Presentations SupportByLibrary PP09 PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
	public class Presentations : Collection
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Presentation Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			LateBindingApi.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="WithWindow">LateBindingApi.OfficeApi.Enums.MsoTriState WithWindow</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Presentation Add(LateBindingApi.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(withWindow);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="ReadOnly">LateBindingApi.OfficeApi.Enums.MsoTriState ReadOnly</param>
		/// <param name="Untitled">LateBindingApi.OfficeApi.Enums.MsoTriState Untitled</param>
		/// <param name="WithWindow">LateBindingApi.OfficeApi.Enums.MsoTriState WithWindow</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Presentation Open(string fileName, LateBindingApi.OfficeApi.Enums.MsoTriState readOnly, LateBindingApi.OfficeApi.Enums.MsoTriState untitled, LateBindingApi.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			LateBindingApi.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="ReadOnly">LateBindingApi.OfficeApi.Enums.MsoTriState ReadOnly</param>
		/// <param name="Untitled">LateBindingApi.OfficeApi.Enums.MsoTriState Untitled</param>
		/// <param name="WithWindow">LateBindingApi.OfficeApi.Enums.MsoTriState WithWindow</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Presentation OpenOld(string fileName, LateBindingApi.OfficeApi.Enums.MsoTriState readOnly, LateBindingApi.OfficeApi.Enums.MsoTriState untitled, LateBindingApi.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow);
			object returnItem = Invoker.MethodReturn(this, "OpenOld", paramsArray);
			LateBindingApi.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public void CheckOut(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "CheckOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public bool CanCheckOut(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "CanCheckOut", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="ReadOnly">LateBindingApi.OfficeApi.Enums.MsoTriState ReadOnly</param>
		/// <param name="Untitled">LateBindingApi.OfficeApi.Enums.MsoTriState Untitled</param>
		/// <param name="WithWindow">LateBindingApi.OfficeApi.Enums.MsoTriState WithWindow</param>
		/// <param name="OpenAndRepair">LateBindingApi.OfficeApi.Enums.MsoTriState OpenAndRepair</param>
		[SupportByLibrary("PP12","PP14")]
		public LateBindingApi.PowerPointApi.Presentation Open2007(string fileName, LateBindingApi.OfficeApi.Enums.MsoTriState readOnly, LateBindingApi.OfficeApi.Enums.MsoTriState untitled, LateBindingApi.OfficeApi.Enums.MsoTriState withWindow, LateBindingApi.OfficeApi.Enums.MsoTriState openAndRepair)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow, openAndRepair);
			object returnItem = Invoker.MethodReturn(this, "Open2007", paramsArray);
			LateBindingApi.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.Presentation;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}