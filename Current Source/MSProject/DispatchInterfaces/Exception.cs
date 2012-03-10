//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.MSProjectApi
{
	///<summary>
	/// DispatchInterface Exception 
	/// SupportByLibrary MSProject, 12,14
	///</summary>
	[SupportByLibraryAttribute("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Exception : COMObject
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
                    _type = typeof(Exception);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Exception(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Exception(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Exception(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Exception() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Exception(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.MSProjectApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Application.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Calendar Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.MSProjectApi.Calendar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Calendar.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Calendar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public object Start
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Start", paramsArray);
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
				Invoker.PropertySet(this, "Start", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public object Finish
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Finish", paramsArray);
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
				Invoker.PropertySet(this, "Finish", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 Occurrences
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Occurrences", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Occurrences", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Enums.PjExceptionType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.MSProjectApi.Enums.PjExceptionType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 Period
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Period", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Period", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 DaysOfWeek
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DaysOfWeek", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DaysOfWeek", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Enums.PjExceptionPosition MonthPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MonthPosition", paramsArray);
				return (NetOffice.MSProjectApi.Enums.PjExceptionPosition)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MonthPosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Enums.PjExceptionItem MonthItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MonthItem", paramsArray);
				return (NetOffice.MSProjectApi.Enums.PjExceptionItem)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MonthItem", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Enums.PjMonth Month
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Month", paramsArray);
				return (NetOffice.MSProjectApi.Enums.PjMonth)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Month", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 MonthDay
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MonthDay", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MonthDay", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Shift Shift1
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shift1", paramsArray);
				NetOffice.MSProjectApi.Shift newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Shift.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Shift;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Shift Shift2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shift2", paramsArray);
				NetOffice.MSProjectApi.Shift newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Shift.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Shift;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Shift Shift3
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shift3", paramsArray);
				NetOffice.MSProjectApi.Shift newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Shift.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Shift;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Shift Shift4
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shift4", paramsArray);
				NetOffice.MSProjectApi.Shift newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Shift.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Shift;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Shift Shift5
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shift5", paramsArray);
				NetOffice.MSProjectApi.Shift newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Shift.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Shift;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}