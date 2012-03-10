//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface PivotLayout 
	/// SupportByLibrary Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotLayout : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(PivotLayout);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotLayout(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotLayout(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotLayout(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotLayout() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotLayout(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject get_ColumnFields(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ColumnFields", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject ColumnFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnFields", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject get_DataFields(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "DataFields", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject DataFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataFields", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject get_PageFields(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "PageFields", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject PageFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageFields", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject get_RowFields(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "RowFields", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject RowFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowFields", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject get_HiddenFields(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "HiddenFields", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject HiddenFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HiddenFields", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject get_VisibleFields(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "VisibleFields", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject VisibleFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VisibleFields", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject get_PivotFields(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "PivotFields", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject PivotFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotFields", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.CubeFields CubeFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CubeFields", paramsArray);
				NetOffice.ExcelApi.CubeFields newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CubeFields.LateBindingApiWrapperType) as NetOffice.ExcelApi.CubeFields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.PivotCache PivotCache
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotCache", paramsArray);
				NetOffice.ExcelApi.PivotCache newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotCache;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.PivotTable PivotTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotTable", paramsArray);
				NetOffice.ExcelApi.PivotTable newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotTable.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotTable;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public string InnerDetail
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InnerDetail", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InnerDetail", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="rowFields">optional object RowFields</param>
		/// <param name="columnFields">optional object ColumnFields</param>
		/// <param name="pageFields">optional object PageFields</param>
		/// <param name="appendField">optional object AppendField</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddFields(object rowFields, object columnFields, object pageFields, object appendField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowFields, columnFields, pageFields, appendField);
			Invoker.Method(this, "AddFields", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddFields()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddFields", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="rowFields">optional object RowFields</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddFields(object rowFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowFields);
			Invoker.Method(this, "AddFields", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="rowFields">optional object RowFields</param>
		/// <param name="columnFields">optional object ColumnFields</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddFields(object rowFields, object columnFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowFields, columnFields);
			Invoker.Method(this, "AddFields", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="rowFields">optional object RowFields</param>
		/// <param name="columnFields">optional object ColumnFields</param>
		/// <param name="pageFields">optional object PageFields</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddFields(object rowFields, object columnFields, object pageFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowFields, columnFields, pageFields);
			Invoker.Method(this, "AddFields", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}