//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.MSHTMLApi
{

	#region Delegates

	#pragma warning disable
	public delegate void HTMLBody_onhelpEventHandler();
	public delegate void HTMLBody_onclickEventHandler();
	public delegate void HTMLBody_ondblclickEventHandler();
	public delegate void HTMLBody_onkeypressEventHandler();
	public delegate void HTMLBody_onkeydownEventHandler();
	public delegate void HTMLBody_onkeyupEventHandler();
	public delegate void HTMLBody_onmouseoutEventHandler();
	public delegate void HTMLBody_onmouseoverEventHandler();
	public delegate void HTMLBody_onmousemoveEventHandler();
	public delegate void HTMLBody_onmousedownEventHandler();
	public delegate void HTMLBody_onmouseupEventHandler();
	public delegate void HTMLBody_onselectstartEventHandler();
	public delegate void HTMLBody_onfilterchangeEventHandler();
	public delegate void HTMLBody_ondragstartEventHandler();
	public delegate void HTMLBody_onbeforeupdateEventHandler();
	public delegate void HTMLBody_onafterupdateEventHandler();
	public delegate void HTMLBody_onerrorupdateEventHandler();
	public delegate void HTMLBody_onrowexitEventHandler();
	public delegate void HTMLBody_onrowenterEventHandler();
	public delegate void HTMLBody_ondatasetchangedEventHandler();
	public delegate void HTMLBody_ondataavailableEventHandler();
	public delegate void HTMLBody_ondatasetcompleteEventHandler();
	public delegate void HTMLBody_onlosecaptureEventHandler();
	public delegate void HTMLBody_onpropertychangeEventHandler();
	public delegate void HTMLBody_onscrollEventHandler();
	public delegate void HTMLBody_onfocusEventHandler();
	public delegate void HTMLBody_onblurEventHandler();
	public delegate void HTMLBody_onresizeEventHandler();
	public delegate void HTMLBody_ondragEventHandler();
	public delegate void HTMLBody_ondragendEventHandler();
	public delegate void HTMLBody_ondragenterEventHandler();
	public delegate void HTMLBody_ondragoverEventHandler();
	public delegate void HTMLBody_ondragleaveEventHandler();
	public delegate void HTMLBody_ondropEventHandler();
	public delegate void HTMLBody_onbeforecutEventHandler();
	public delegate void HTMLBody_oncutEventHandler();
	public delegate void HTMLBody_onbeforecopyEventHandler();
	public delegate void HTMLBody_oncopyEventHandler();
	public delegate void HTMLBody_onbeforepasteEventHandler();
	public delegate void HTMLBody_onpasteEventHandler();
	public delegate void HTMLBody_oncontextmenuEventHandler();
	public delegate void HTMLBody_onrowsdeleteEventHandler();
	public delegate void HTMLBody_onrowsinsertedEventHandler();
	public delegate void HTMLBody_oncellchangeEventHandler();
	public delegate void HTMLBody_onreadystatechangeEventHandler();
	public delegate void HTMLBody_onbeforeeditfocusEventHandler();
	public delegate void HTMLBody_onlayoutcompleteEventHandler();
	public delegate void HTMLBody_onpageEventHandler();
	public delegate void HTMLBody_onbeforedeactivateEventHandler();
	public delegate void HTMLBody_onbeforeactivateEventHandler();
	public delegate void HTMLBody_onmoveEventHandler();
	public delegate void HTMLBody_oncontrolselectEventHandler();
	public delegate void HTMLBody_onmovestartEventHandler();
	public delegate void HTMLBody_onmoveendEventHandler();
	public delegate void HTMLBody_onresizestartEventHandler();
	public delegate void HTMLBody_onresizeendEventHandler();
	public delegate void HTMLBody_onmouseenterEventHandler();
	public delegate void HTMLBody_onmouseleaveEventHandler();
	public delegate void HTMLBody_onmousewheelEventHandler();
	public delegate void HTMLBody_onactivateEventHandler();
	public delegate void HTMLBody_ondeactivateEventHandler();
	public delegate void HTMLBody_onfocusinEventHandler();
	public delegate void HTMLBody_onfocusoutEventHandler();
	public delegate void HTMLBody_onchangeEventHandler();
	public delegate void HTMLBody_onselectEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass HTMLBody 
	/// SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class HTMLBody : DispHTMLBody, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		HTMLTextContainerEvents_SinkHelper _hTMLTextContainerEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(HTMLBody);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public HTMLBody(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLBody(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLBody(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of HTMLBody 
        /// </summary>		
		public HTMLBody():base("MSHTML.HTMLBody")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of HTMLBody
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public HTMLBody(string progId):base(progId)
		{
			
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, HTMLTextContainerEvents_SinkHelper.Id);


			if(HTMLTextContainerEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_hTMLTextContainerEvents_SinkHelper = new HTMLTextContainerEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onhelpEventHandler _onhelpEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onhelpEventHandler onhelpEvent
		{
			add
			{
				CreateEventBridge();
				_onhelpEvent += value;
			}
			remove
			{
				_onhelpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onclickEventHandler _onclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onclickEventHandler onclickEvent
		{
			add
			{
				CreateEventBridge();
				_onclickEvent += value;
			}
			remove
			{
				_onclickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondblclickEventHandler _ondblclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondblclickEventHandler ondblclickEvent
		{
			add
			{
				CreateEventBridge();
				_ondblclickEvent += value;
			}
			remove
			{
				_ondblclickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onkeypressEventHandler _onkeypressEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onkeypressEventHandler onkeypressEvent
		{
			add
			{
				CreateEventBridge();
				_onkeypressEvent += value;
			}
			remove
			{
				_onkeypressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onkeydownEventHandler _onkeydownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onkeydownEventHandler onkeydownEvent
		{
			add
			{
				CreateEventBridge();
				_onkeydownEvent += value;
			}
			remove
			{
				_onkeydownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onkeyupEventHandler _onkeyupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onkeyupEventHandler onkeyupEvent
		{
			add
			{
				CreateEventBridge();
				_onkeyupEvent += value;
			}
			remove
			{
				_onkeyupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmouseoutEventHandler _onmouseoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmouseoutEventHandler onmouseoutEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseoutEvent += value;
			}
			remove
			{
				_onmouseoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmouseoverEventHandler _onmouseoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmouseoverEventHandler onmouseoverEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseoverEvent += value;
			}
			remove
			{
				_onmouseoverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmousemoveEventHandler _onmousemoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmousemoveEventHandler onmousemoveEvent
		{
			add
			{
				CreateEventBridge();
				_onmousemoveEvent += value;
			}
			remove
			{
				_onmousemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmousedownEventHandler _onmousedownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmousedownEventHandler onmousedownEvent
		{
			add
			{
				CreateEventBridge();
				_onmousedownEvent += value;
			}
			remove
			{
				_onmousedownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmouseupEventHandler _onmouseupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmouseupEventHandler onmouseupEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseupEvent += value;
			}
			remove
			{
				_onmouseupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onselectstartEventHandler _onselectstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onselectstartEventHandler onselectstartEvent
		{
			add
			{
				CreateEventBridge();
				_onselectstartEvent += value;
			}
			remove
			{
				_onselectstartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onfilterchangeEventHandler _onfilterchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onfilterchangeEventHandler onfilterchangeEvent
		{
			add
			{
				CreateEventBridge();
				_onfilterchangeEvent += value;
			}
			remove
			{
				_onfilterchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondragstartEventHandler _ondragstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondragstartEventHandler ondragstartEvent
		{
			add
			{
				CreateEventBridge();
				_ondragstartEvent += value;
			}
			remove
			{
				_ondragstartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onbeforeupdateEventHandler _onbeforeupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onbeforeupdateEventHandler onbeforeupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeupdateEvent += value;
			}
			remove
			{
				_onbeforeupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onafterupdateEventHandler _onafterupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onafterupdateEventHandler onafterupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onafterupdateEvent += value;
			}
			remove
			{
				_onafterupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onerrorupdateEventHandler _onerrorupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onerrorupdateEventHandler onerrorupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onerrorupdateEvent += value;
			}
			remove
			{
				_onerrorupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onrowexitEventHandler _onrowexitEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onrowexitEventHandler onrowexitEvent
		{
			add
			{
				CreateEventBridge();
				_onrowexitEvent += value;
			}
			remove
			{
				_onrowexitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onrowenterEventHandler _onrowenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onrowenterEventHandler onrowenterEvent
		{
			add
			{
				CreateEventBridge();
				_onrowenterEvent += value;
			}
			remove
			{
				_onrowenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondatasetchangedEventHandler _ondatasetchangedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondatasetchangedEventHandler ondatasetchangedEvent
		{
			add
			{
				CreateEventBridge();
				_ondatasetchangedEvent += value;
			}
			remove
			{
				_ondatasetchangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondataavailableEventHandler _ondataavailableEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondataavailableEventHandler ondataavailableEvent
		{
			add
			{
				CreateEventBridge();
				_ondataavailableEvent += value;
			}
			remove
			{
				_ondataavailableEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondatasetcompleteEventHandler _ondatasetcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondatasetcompleteEventHandler ondatasetcompleteEvent
		{
			add
			{
				CreateEventBridge();
				_ondatasetcompleteEvent += value;
			}
			remove
			{
				_ondatasetcompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onlosecaptureEventHandler _onlosecaptureEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onlosecaptureEventHandler onlosecaptureEvent
		{
			add
			{
				CreateEventBridge();
				_onlosecaptureEvent += value;
			}
			remove
			{
				_onlosecaptureEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onpropertychangeEventHandler _onpropertychangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onpropertychangeEventHandler onpropertychangeEvent
		{
			add
			{
				CreateEventBridge();
				_onpropertychangeEvent += value;
			}
			remove
			{
				_onpropertychangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onscrollEventHandler _onscrollEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onscrollEventHandler onscrollEvent
		{
			add
			{
				CreateEventBridge();
				_onscrollEvent += value;
			}
			remove
			{
				_onscrollEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onfocusEventHandler _onfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onfocusEventHandler onfocusEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusEvent += value;
			}
			remove
			{
				_onfocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onblurEventHandler _onblurEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onblurEventHandler onblurEvent
		{
			add
			{
				CreateEventBridge();
				_onblurEvent += value;
			}
			remove
			{
				_onblurEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onresizeEventHandler _onresizeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onresizeEventHandler onresizeEvent
		{
			add
			{
				CreateEventBridge();
				_onresizeEvent += value;
			}
			remove
			{
				_onresizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondragEventHandler _ondragEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondragEventHandler ondragEvent
		{
			add
			{
				CreateEventBridge();
				_ondragEvent += value;
			}
			remove
			{
				_ondragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondragendEventHandler _ondragendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondragendEventHandler ondragendEvent
		{
			add
			{
				CreateEventBridge();
				_ondragendEvent += value;
			}
			remove
			{
				_ondragendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondragenterEventHandler _ondragenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondragenterEventHandler ondragenterEvent
		{
			add
			{
				CreateEventBridge();
				_ondragenterEvent += value;
			}
			remove
			{
				_ondragenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondragoverEventHandler _ondragoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondragoverEventHandler ondragoverEvent
		{
			add
			{
				CreateEventBridge();
				_ondragoverEvent += value;
			}
			remove
			{
				_ondragoverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondragleaveEventHandler _ondragleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondragleaveEventHandler ondragleaveEvent
		{
			add
			{
				CreateEventBridge();
				_ondragleaveEvent += value;
			}
			remove
			{
				_ondragleaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondropEventHandler _ondropEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondropEventHandler ondropEvent
		{
			add
			{
				CreateEventBridge();
				_ondropEvent += value;
			}
			remove
			{
				_ondropEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onbeforecutEventHandler _onbeforecutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onbeforecutEventHandler onbeforecutEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforecutEvent += value;
			}
			remove
			{
				_onbeforecutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_oncutEventHandler _oncutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_oncutEventHandler oncutEvent
		{
			add
			{
				CreateEventBridge();
				_oncutEvent += value;
			}
			remove
			{
				_oncutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onbeforecopyEventHandler _onbeforecopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onbeforecopyEventHandler onbeforecopyEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforecopyEvent += value;
			}
			remove
			{
				_onbeforecopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_oncopyEventHandler _oncopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_oncopyEventHandler oncopyEvent
		{
			add
			{
				CreateEventBridge();
				_oncopyEvent += value;
			}
			remove
			{
				_oncopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onbeforepasteEventHandler _onbeforepasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onbeforepasteEventHandler onbeforepasteEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforepasteEvent += value;
			}
			remove
			{
				_onbeforepasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onpasteEventHandler _onpasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onpasteEventHandler onpasteEvent
		{
			add
			{
				CreateEventBridge();
				_onpasteEvent += value;
			}
			remove
			{
				_onpasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_oncontextmenuEventHandler _oncontextmenuEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_oncontextmenuEventHandler oncontextmenuEvent
		{
			add
			{
				CreateEventBridge();
				_oncontextmenuEvent += value;
			}
			remove
			{
				_oncontextmenuEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onrowsdeleteEventHandler _onrowsdeleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onrowsdeleteEventHandler onrowsdeleteEvent
		{
			add
			{
				CreateEventBridge();
				_onrowsdeleteEvent += value;
			}
			remove
			{
				_onrowsdeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onrowsinsertedEventHandler _onrowsinsertedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onrowsinsertedEventHandler onrowsinsertedEvent
		{
			add
			{
				CreateEventBridge();
				_onrowsinsertedEvent += value;
			}
			remove
			{
				_onrowsinsertedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_oncellchangeEventHandler _oncellchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_oncellchangeEventHandler oncellchangeEvent
		{
			add
			{
				CreateEventBridge();
				_oncellchangeEvent += value;
			}
			remove
			{
				_oncellchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onreadystatechangeEventHandler _onreadystatechangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onreadystatechangeEventHandler onreadystatechangeEvent
		{
			add
			{
				CreateEventBridge();
				_onreadystatechangeEvent += value;
			}
			remove
			{
				_onreadystatechangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onbeforeeditfocusEventHandler _onbeforeeditfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onbeforeeditfocusEventHandler onbeforeeditfocusEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeeditfocusEvent += value;
			}
			remove
			{
				_onbeforeeditfocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onlayoutcompleteEventHandler _onlayoutcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onlayoutcompleteEventHandler onlayoutcompleteEvent
		{
			add
			{
				CreateEventBridge();
				_onlayoutcompleteEvent += value;
			}
			remove
			{
				_onlayoutcompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onpageEventHandler _onpageEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onpageEventHandler onpageEvent
		{
			add
			{
				CreateEventBridge();
				_onpageEvent += value;
			}
			remove
			{
				_onpageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onbeforedeactivateEventHandler _onbeforedeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onbeforedeactivateEventHandler onbeforedeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforedeactivateEvent += value;
			}
			remove
			{
				_onbeforedeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onbeforeactivateEventHandler _onbeforeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onbeforeactivateEventHandler onbeforeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeactivateEvent += value;
			}
			remove
			{
				_onbeforeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmoveEventHandler _onmoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmoveEventHandler onmoveEvent
		{
			add
			{
				CreateEventBridge();
				_onmoveEvent += value;
			}
			remove
			{
				_onmoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_oncontrolselectEventHandler _oncontrolselectEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_oncontrolselectEventHandler oncontrolselectEvent
		{
			add
			{
				CreateEventBridge();
				_oncontrolselectEvent += value;
			}
			remove
			{
				_oncontrolselectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmovestartEventHandler _onmovestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmovestartEventHandler onmovestartEvent
		{
			add
			{
				CreateEventBridge();
				_onmovestartEvent += value;
			}
			remove
			{
				_onmovestartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmoveendEventHandler _onmoveendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmoveendEventHandler onmoveendEvent
		{
			add
			{
				CreateEventBridge();
				_onmoveendEvent += value;
			}
			remove
			{
				_onmoveendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onresizestartEventHandler _onresizestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onresizestartEventHandler onresizestartEvent
		{
			add
			{
				CreateEventBridge();
				_onresizestartEvent += value;
			}
			remove
			{
				_onresizestartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onresizeendEventHandler _onresizeendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onresizeendEventHandler onresizeendEvent
		{
			add
			{
				CreateEventBridge();
				_onresizeendEvent += value;
			}
			remove
			{
				_onresizeendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmouseenterEventHandler _onmouseenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmouseenterEventHandler onmouseenterEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseenterEvent += value;
			}
			remove
			{
				_onmouseenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmouseleaveEventHandler _onmouseleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmouseleaveEventHandler onmouseleaveEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseleaveEvent += value;
			}
			remove
			{
				_onmouseleaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onmousewheelEventHandler _onmousewheelEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onmousewheelEventHandler onmousewheelEvent
		{
			add
			{
				CreateEventBridge();
				_onmousewheelEvent += value;
			}
			remove
			{
				_onmousewheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onactivateEventHandler _onactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onactivateEventHandler onactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onactivateEvent += value;
			}
			remove
			{
				_onactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_ondeactivateEventHandler _ondeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_ondeactivateEventHandler ondeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_ondeactivateEvent += value;
			}
			remove
			{
				_ondeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onfocusinEventHandler _onfocusinEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onfocusinEventHandler onfocusinEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusinEvent += value;
			}
			remove
			{
				_onfocusinEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onfocusoutEventHandler _onfocusoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onfocusoutEventHandler onfocusoutEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusoutEvent += value;
			}
			remove
			{
				_onfocusoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onchangeEventHandler _onchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onchangeEventHandler onchangeEvent
		{
			add
			{
				CreateEventBridge();
				_onchangeEvent += value;
			}
			remove
			{
				_onchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLBody_onselectEventHandler _onselectEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLBody_onselectEventHandler onselectEvent
		{
			add
			{
				CreateEventBridge();
				_onselectEvent += value;
			}
			remove
			{
				_onselectEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _hTMLTextContainerEvents_SinkHelper)
			{
				_hTMLTextContainerEvents_SinkHelper.Dispose();
				_hTMLTextContainerEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}