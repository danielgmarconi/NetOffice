//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IHTMLElement 
	/// SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLElement : COMObject
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
                    _type = typeof(IHTMLElement);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElement(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElement(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElement(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElement() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElement(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string className
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "className", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "className", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string id
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "id", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "id", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string tagName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "tagName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLElement parentElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "parentElement", paramsArray);
				NetOffice.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLElement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLStyle style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "style", paramsArray);
				NetOffice.MSHTMLApi.IHTMLStyle newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLStyle;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onhelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onhelp", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onhelp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onclick
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onclick", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onclick", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object ondblclick
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ondblclick", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ondblclick", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onkeydown
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onkeydown", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onkeydown", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onkeyup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onkeyup", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onkeyup", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onkeypress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onkeypress", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onkeypress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onmouseout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onmouseout", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onmouseout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onmouseover
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onmouseover", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onmouseover", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onmousemove
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onmousemove", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onmousemove", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onmousedown
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onmousedown", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onmousedown", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onmouseup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onmouseup", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onmouseup", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "document", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "title", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "title", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string language
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "language", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "language", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onselectstart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onselectstart", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onselectstart", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 sourceIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "sourceIndex", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object recordNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "recordNumber", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string lang
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "lang", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "lang", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 offsetLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 offsetTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetTop", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 offsetWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 offsetHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetHeight", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLElement offsetParent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetParent", paramsArray);
				NetOffice.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLElement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string innerHTML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "innerHTML", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "innerHTML", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string innerText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "innerText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "innerText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string outerHTML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "outerHTML", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "outerHTML", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string outerText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "outerText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "outerText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLElement parentTextEdit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "parentTextEdit", paramsArray);
				NetOffice.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLElement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool isTextEdit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "isTextEdit", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLFiltersCollection filters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "filters", paramsArray);
				NetOffice.MSHTMLApi.IHTMLFiltersCollection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSHTMLApi.IHTMLFiltersCollection.LateBindingApiWrapperType) as NetOffice.MSHTMLApi.IHTMLFiltersCollection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object ondragstart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ondragstart", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ondragstart", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onbeforeupdate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onbeforeupdate", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onbeforeupdate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onafterupdate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onafterupdate", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onafterupdate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onerrorupdate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onerrorupdate", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onerrorupdate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onrowexit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onrowexit", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onrowexit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onrowenter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onrowenter", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onrowenter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object ondatasetchanged
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ondatasetchanged", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ondatasetchanged", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object ondataavailable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ondataavailable", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ondataavailable", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object ondatasetcomplete
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ondatasetcomplete", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ondatasetcomplete", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onfilterchange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onfilterchange", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onfilterchange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject children
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "children", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject all
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "all", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		/// <param name="attributeValue">object AttributeValue</param>
		/// <param name="lFlags">optional Int32 lFlags = 1</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setAttribute(string strAttributeName, object attributeValue, Int32 lFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName, attributeValue, lFlags);
			Invoker.Method(this, "setAttribute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		/// <param name="attributeValue">object AttributeValue</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setAttribute(string strAttributeName, object attributeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName, attributeValue);
			Invoker.Method(this, "setAttribute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		/// <param name="lFlags">optional Int32 lFlags = 0</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object getAttribute(string strAttributeName, Int32 lFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName, lFlags);
			object returnItem = Invoker.MethodReturn(this, "getAttribute", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object getAttribute(string strAttributeName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName);
			object returnItem = Invoker.MethodReturn(this, "getAttribute", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		/// <param name="lFlags">optional Int32 lFlags = 1</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool removeAttribute(string strAttributeName, Int32 lFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName, lFlags);
			object returnItem = Invoker.MethodReturn(this, "removeAttribute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool removeAttribute(string strAttributeName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName);
			object returnItem = Invoker.MethodReturn(this, "removeAttribute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="varargStart">optional object varargStart</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scrollIntoView(object varargStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varargStart);
			Invoker.Method(this, "scrollIntoView", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scrollIntoView()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "scrollIntoView", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pChild">NetOffice.MSHTMLApi.IHTMLElement pChild</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool contains(NetOffice.MSHTMLApi.IHTMLElement pChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pChild);
			object returnItem = Invoker.MethodReturn(this, "contains", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="where">string where</param>
		/// <param name="html">string html</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void insertAdjacentHTML(string where, string html)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(where, html);
			Invoker.Method(this, "insertAdjacentHTML", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="where">string where</param>
		/// <param name="text">string text</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void insertAdjacentText(string where, string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(where, text);
			Invoker.Method(this, "insertAdjacentText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void click()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "click", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string toString()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "toString", paramsArray);
			return (string)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}