//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OfficeApi
{
	///<summary>
	/// DispatchInterface DiagramNode SupportByLibrary OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF10","OF11","OF12","OF14")]
	public class DiagramNode : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
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

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.DiagramNodeChildren Children
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Children", paramsArray);
				LateBindingApi.OfficeApi.DiagramNodeChildren newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.DiagramNodeChildren;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.Shape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				LateBindingApi.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.DiagramNode Root
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Root", paramsArray);
				LateBindingApi.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.IMsoDiagram Diagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Diagram", paramsArray);
				LateBindingApi.OfficeApi.IMsoDiagram newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.IMsoDiagram;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.Enums.MsoOrgChartLayoutType Layout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Layout", paramsArray);
				return (LateBindingApi.OfficeApi.Enums.MsoOrgChartLayoutType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Layout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.Shape TextShape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextShape", paramsArray);
				LateBindingApi.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.Shape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Pos">LateBindingApi.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		/// <param name="NodeType">LateBindingApi.OfficeApi.Enums.MsoDiagramNodeType NodeType</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.DiagramNode AddNode(LateBindingApi.OfficeApi.Enums.MsoRelativeNodePosition pos, LateBindingApi.OfficeApi.Enums.MsoDiagramNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pos, nodeType);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			LateBindingApi.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="TargetNode">LateBindingApi.OfficeApi.DiagramNode TargetNode</param>
		/// <param name="Pos">LateBindingApi.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void MoveNode(LateBindingApi.OfficeApi.DiagramNode targetNode, LateBindingApi.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode, pos);
			Invoker.Method(this, "MoveNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="TargetNode">LateBindingApi.OfficeApi.DiagramNode TargetNode</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void ReplaceNode(LateBindingApi.OfficeApi.DiagramNode targetNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode);
			Invoker.Method(this, "ReplaceNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="TargetNode">LateBindingApi.OfficeApi.DiagramNode TargetNode</param>
		/// <param name="SwapChildren">bool SwapChildren</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void SwapNode(LateBindingApi.OfficeApi.DiagramNode targetNode, bool swapChildren)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode, swapChildren);
			Invoker.Method(this, "SwapNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="CopyChildren">bool CopyChildren</param>
		/// <param name="TargetNode">LateBindingApi.OfficeApi.DiagramNode TargetNode</param>
		/// <param name="Pos">LateBindingApi.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.DiagramNode CloneNode(bool copyChildren, LateBindingApi.OfficeApi.DiagramNode targetNode, LateBindingApi.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(copyChildren, targetNode, pos);
			object returnItem = Invoker.MethodReturn(this, "CloneNode", paramsArray);
			LateBindingApi.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="ReceivingNode">LateBindingApi.OfficeApi.DiagramNode ReceivingNode</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void TransferChildren(LateBindingApi.OfficeApi.DiagramNode receivingNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(receivingNode);
			Invoker.Method(this, "TransferChildren", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.DiagramNode NextNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextNode", paramsArray);
			LateBindingApi.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.DiagramNode PrevNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PrevNode", paramsArray);
			LateBindingApi.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.DiagramNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}