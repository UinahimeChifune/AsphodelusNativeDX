using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.DXGI;

/// <summary>
/// INTERFACE <b>IDXGIInfoQueue</b> : IUnknown<br/>
/// DXGIDEBUG.h
/// </summary>
unsafe public interface IInfoQueue : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::SetMessageCountLimit (DXGI_DEBUG_ID Producer, UINT64 MessageCountLimit)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="messageCountLimit">_In_ <b>UINT64 MessageCountLimit</b></param>
	int SetMessageCountLimit (Guid producer, ulong messageCountLimit);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIInfoQueue::ClearStoredMessages (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	void ClearStoredMessages (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::GetMessage (DXGI_DEBUG_ID Producer, UINT64 MessageIndex, DXGI_INFO_QUEUE_MESSAGE* pMessage, SIZE_T* pMessageByteLength)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="messageIndex">_In_ <b>UINT64 MessageIndex</b></param>
	/// <param name="pMessage">_Out_writes_bytes_opt_(*pMessageByteLength) <b>DXGI_INFO_QUEUE_MESSAGE* pMessage</b></param>
	/// <param name="pMessageByteLength">_Inout_ <b>SIZE_T* pMessageByteLength</b></param>
	int GetMessage (Guid producer, ulong messageIndex, InfoQueueMessage* pMessage, nuint* pMessageByteLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 IDXGIInfoQueue::GetNumStoredMessagesAllowedByRetrievalFilters (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	ulong GetNumStoredMessagesAllowedByRetrievalFilters (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 IDXGIInfoQueue::GetNumStoredMessages (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	ulong GetNumStoredMessages (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 IDXGIInfoQueue::GetNumMessagesDiscardedByMessageCountLimit (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	ulong GetNumMessagesDiscardedByMessageCountLimit (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 IDXGIInfoQueue::GetMessageCountLimit (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	ulong GetMessageCountLimit (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 IDXGIInfoQueue::GetNumMessagesAllowedByStorageFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	ulong GetNumMessagesAllowedByStorageFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 IDXGIInfoQueue::GetNumMessagesDeniedByStorageFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	ulong GetNumMessagesDeniedByStorageFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::AddStorageFilterEntries (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER* pFilter)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="pFilter">_In_ <b>DXGI_INFO_QUEUE_FILTER* pFilter</b></param>
	int AddStorageFilterEntries (Guid producer, InfoQueueFilter* pFilter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::GetStorageFilter (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER* pFilter, SIZE_T* pFilterByteLength)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="pFilter">_Out_writes_bytes_opt_(*pFilterByteLength) <b>DXGI_INFO_QUEUE_FILTER* pFilter</b></param>
	/// <param name="pFilterByteLength">_Inout_ <b>SIZE_T* pFilterByteLength</b></param>
	int GetStorageFilter (Guid producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIInfoQueue::ClearStorageFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	void ClearStorageFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::PushEmptyStorageFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	int PushEmptyStorageFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::PushDenyAllStorageFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	int PushDenyAllStorageFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::PushCopyOfStorageFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	int PushCopyOfStorageFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::PushStorageFilter (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER* pFilter)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="pFilter">_In_ <b>DXGI_INFO_QUEUE_FILTER* pFilter</b></param>
	int PushStorageFilter (Guid producer, InfoQueueFilter* pFilter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIInfoQueue::PopStorageFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	void PopStorageFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT IDXGIInfoQueue::GetStorageFilterStackSize (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	uint GetStorageFilterStackSize (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::AddRetrievalFilterEntries (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER* pFilter)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="pFilter">_In_ <b>DXGI_INFO_QUEUE_FILTER* pFilter</b></param>
	int AddRetrievalFilterEntries (Guid producer, InfoQueueFilter* pFilter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::GetRetrievalFilter (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER* pFilter, SIZE_T* pFilterByteLength)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="pFilter">_Out_writes_bytes_opt_(*pFilterByteLength) <b>DXGI_INFO_QUEUE_FILTER* pFilter</b></param>
	/// <param name="pFilterByteLength">_Inout_ <b>SIZE_T* pFilterByteLength</b></param>
	int GetRetrievalFilter (Guid producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIInfoQueue::ClearRetrievalFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	void ClearRetrievalFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::PushEmptyRetrievalFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	int PushEmptyRetrievalFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::PushDenyAllRetrievalFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	int PushDenyAllRetrievalFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::PushCopyOfRetrievalFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	int PushCopyOfRetrievalFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::PushRetrievalFilter (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_FILTER* pFilter)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="pFilter">_In_ <b>DXGI_INFO_QUEUE_FILTER* pFilter</b></param>
	int PushRetrievalFilter (Guid producer, InfoQueueFilter* pFilter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIInfoQueue::PopRetrievalFilter (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	void PopRetrievalFilter (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT IDXGIInfoQueue::GetRetrievalFilterStackSize (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	uint GetRetrievalFilterStackSize (Guid producer);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::AddMessage (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, DXGI_INFO_QUEUE_MESSAGE_ID ID, LPCSTR pDescription)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="category">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category</b></param>
	/// <param name="severity">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity</b></param>
	/// <param name="iD">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_ID ID</b></param>
	/// <param name="pDescription">_In_ <b>LPCSTR pDescription</b></param>
	int AddMessage (Guid producer, InfoQueueMessageCategory category, InfoQueueMessageSeverity severity, int iD, char* pDescription);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::AddApplicationMessage (DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, LPCSTR pDescription)</b><br/>
	/// </summary>
	/// <param name="severity">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity</b></param>
	/// <param name="pDescription">_In_ <b>LPCSTR pDescription</b></param>
	int AddApplicationMessage (InfoQueueMessageSeverity severity, char* pDescription);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::SetBreakOnCategory (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, BOOL bEnable)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="category">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category</b></param>
	/// <param name="bEnable">_In_ <b>BOOL bEnable</b></param>
	int SetBreakOnCategory (Guid producer, InfoQueueMessageCategory category, bool bEnable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::SetBreakOnSeverity (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, BOOL bEnable)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="severity">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity</b></param>
	/// <param name="bEnable">_In_ <b>BOOL bEnable</b></param>
	int SetBreakOnSeverity (Guid producer, InfoQueueMessageSeverity severity, bool bEnable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IDXGIInfoQueue::SetBreakOnID (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_ID ID, BOOL bEnable)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="iD">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_ID ID</b></param>
	/// <param name="bEnable">_In_ <b>BOOL bEnable</b></param>
	int SetBreakOnID (Guid producer, int iD, bool bEnable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL IDXGIInfoQueue::GetBreakOnCategory (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="category">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category</b></param>
	bool GetBreakOnCategory (Guid producer, InfoQueueMessageCategory category);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL IDXGIInfoQueue::GetBreakOnSeverity (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="severity">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity</b></param>
	bool GetBreakOnSeverity (Guid producer, InfoQueueMessageSeverity severity);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL IDXGIInfoQueue::GetBreakOnID (DXGI_DEBUG_ID Producer, DXGI_INFO_QUEUE_MESSAGE_ID ID)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="iD">_In_ <b>DXGI_INFO_QUEUE_MESSAGE_ID ID</b></param>
	bool GetBreakOnID (Guid producer, int iD);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void IDXGIInfoQueue::SetMuteDebugOutput (DXGI_DEBUG_ID Producer, BOOL bMute)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	/// <param name="bMute">_In_ <b>BOOL bMute</b></param>
	void SetMuteDebugOutput (Guid producer, bool bMute);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL IDXGIInfoQueue::GetMuteDebugOutput (DXGI_DEBUG_ID Producer)</b><br/>
	/// </summary>
	/// <param name="producer">_In_ <b>DXGI_DEBUG_ID Producer</b></param>
	bool GetMuteDebugOutput (Guid producer);
}

/// <summary>
/// Instance of <b>IDXGIInfoQueue</b><br/>
/// DXGIDEBUG.h
/// </summary>
unsafe public readonly struct InfoQueue : IInfoQueue {
//unsafe public readonly struct IInfoQueueObj : IInfoQueue {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly InfoQueue* GetCurrentPointer () => (InfoQueue*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IInfoQueueObj* GetCurrentPointer () => (IInfoQueueObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0xd67441c7, 0x672a, 0x476f, 0x9e, 0x82, 0xcd, 0x55, 0xb4, 0x49, 0x49, 0xce);

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryInterface (Guid riid, void** ppvObject) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->QueryInterface (ptr, riid, ppvObject);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryInterface (Guid riid, out void* ppvObject) {
		fixed (void** _ppvObject = &ppvObject) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->QueryInterface (ptr, riid, _ppvObject);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint AddRef () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddRef (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint Release () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Release (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetMessageCountLimit (Guid producer, ulong messageCountLimit) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetMessageCountLimit (ptr, producer, messageCountLimit);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearStoredMessages (Guid producer) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearStoredMessages (ptr, producer);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMessage (Guid producer, ulong messageIndex, InfoQueueMessage* pMessage, nuint* pMessageByteLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMessage (ptr, producer, messageIndex, pMessage, pMessageByteLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumStoredMessagesAllowedByRetrievalFilters (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumStoredMessagesAllowedByRetrievalFilters (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumStoredMessages (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumStoredMessages (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumMessagesDiscardedByMessageCountLimit (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumMessagesDiscardedByMessageCountLimit (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetMessageCountLimit (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMessageCountLimit (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumMessagesAllowedByStorageFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumMessagesAllowedByStorageFilter (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumMessagesDeniedByStorageFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumMessagesDeniedByStorageFilter (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddStorageFilterEntries (Guid producer, InfoQueueFilter* pFilter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddStorageFilterEntries (ptr, producer, pFilter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStorageFilter (Guid producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStorageFilter (ptr, producer, pFilter, pFilterByteLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearStorageFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearStorageFilter (ptr, producer);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushEmptyStorageFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushEmptyStorageFilter (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushDenyAllStorageFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushDenyAllStorageFilter (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushCopyOfStorageFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushCopyOfStorageFilter (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushStorageFilter (Guid producer, InfoQueueFilter* pFilter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushStorageFilter (ptr, producer, pFilter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PopStorageFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PopStorageFilter (ptr, producer);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetStorageFilterStackSize (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStorageFilterStackSize (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddRetrievalFilterEntries (Guid producer, InfoQueueFilter* pFilter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddRetrievalFilterEntries (ptr, producer, pFilter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRetrievalFilter (Guid producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRetrievalFilter (ptr, producer, pFilter, pFilterByteLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearRetrievalFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearRetrievalFilter (ptr, producer);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushEmptyRetrievalFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushEmptyRetrievalFilter (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushDenyAllRetrievalFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushDenyAllRetrievalFilter (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushCopyOfRetrievalFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushCopyOfRetrievalFilter (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushRetrievalFilter (Guid producer, InfoQueueFilter* pFilter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushRetrievalFilter (ptr, producer, pFilter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PopRetrievalFilter (Guid producer) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PopRetrievalFilter (ptr, producer);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetRetrievalFilterStackSize (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRetrievalFilterStackSize (ptr, producer);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddMessage (Guid producer, InfoQueueMessageCategory category, InfoQueueMessageSeverity severity, int iD, char* pDescription) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddMessage (ptr, producer, category, severity, iD, pDescription);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddApplicationMessage (InfoQueueMessageSeverity severity, char* pDescription) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddApplicationMessage (ptr, severity, pDescription);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetBreakOnCategory (Guid producer, InfoQueueMessageCategory category, bool bEnable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetBreakOnCategory (ptr, producer, category, bEnable ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetBreakOnSeverity (Guid producer, InfoQueueMessageSeverity severity, bool bEnable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetBreakOnSeverity (ptr, producer, severity, bEnable ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetBreakOnID (Guid producer, int iD, bool bEnable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetBreakOnID (ptr, producer, iD, bEnable ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetBreakOnCategory (Guid producer, InfoQueueMessageCategory category) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBreakOnCategory (ptr, producer, category) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetBreakOnSeverity (Guid producer, InfoQueueMessageSeverity severity) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBreakOnSeverity (ptr, producer, severity) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetBreakOnID (Guid producer, int iD) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBreakOnID (ptr, producer, iD) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetMuteDebugOutput (Guid producer, bool bMute) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetMuteDebugOutput (ptr, producer, bMute ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetMuteDebugOutput (Guid producer) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMuteDebugOutput (ptr, producer) != 0;
		return hr;
	}

	[StructLayout (LayoutKind.Sequential)]
	readonly struct FunctionPointer {
		/// <summary>
		/// OFFSET 0
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> QueryInterface;
		/// <summary>
		/// OFFSET 1
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> AddRef;
		/// <summary>
		/// OFFSET 2
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> Release;
		/// <summary>
		/// OFFSET 3
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, ulong, int> SetMessageCountLimit;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void> ClearStoredMessages;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, ulong, InfoQueueMessage*, nuint*, int> GetMessage;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, ulong> GetNumStoredMessagesAllowedByRetrievalFilters;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, ulong> GetNumStoredMessages;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, ulong> GetNumMessagesDiscardedByMessageCountLimit;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, ulong> GetMessageCountLimit;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, ulong> GetNumMessagesAllowedByStorageFilter;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, ulong> GetNumMessagesDeniedByStorageFilter;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueFilter*, int> AddStorageFilterEntries;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueFilter*, nuint*, int> GetStorageFilter;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void> ClearStorageFilter;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int> PushEmptyStorageFilter;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int> PushDenyAllStorageFilter;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int> PushCopyOfStorageFilter;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueFilter*, int> PushStorageFilter;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void> PopStorageFilter;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint> GetStorageFilterStackSize;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueFilter*, int> AddRetrievalFilterEntries;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueFilter*, nuint*, int> GetRetrievalFilter;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void> ClearRetrievalFilter;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int> PushEmptyRetrievalFilter;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int> PushDenyAllRetrievalFilter;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int> PushCopyOfRetrievalFilter;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueFilter*, int> PushRetrievalFilter;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void> PopRetrievalFilter;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint> GetRetrievalFilterStackSize;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, char*, int> AddMessage;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InfoQueueMessageSeverity, char*, int> AddApplicationMessage;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueMessageCategory, uint, int> SetBreakOnCategory;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueMessageSeverity, uint, int> SetBreakOnSeverity;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int, uint, int> SetBreakOnID;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueMessageCategory, uint> GetBreakOnCategory;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, InfoQueueMessageSeverity, uint> GetBreakOnSeverity;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, int, uint> GetBreakOnID;
		/// <summary>
		/// OFFSET 38
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint, void> SetMuteDebugOutput;
		/// <summary>
		/// OFFSET 39
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, uint> GetMuteDebugOutput;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
