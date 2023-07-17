using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative.Direct3D12;

/// <summary>
/// INTERFACE <b>ID3D12InfoQueue</b> : IUnknown<br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public interface IInfoQueue : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::SetMessageCountLimit (UINT64 MessageCountLimit)</b><br/>
	/// </summary>
	/// <param name="messageCountLimit">_In_ <b>UINT64 MessageCountLimit</b></param>
	int SetMessageCountLimit (ulong messageCountLimit);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12InfoQueue::ClearStoredMessages ()</b><br/>
	/// </summary>
	void ClearStoredMessages ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::GetMessage (UINT64 MessageIndex, D3D12_MESSAGE* pMessage, SIZE_T* pMessageByteLength)</b><br/>
	/// </summary>
	/// <param name="messageIndex">_In_ <b>UINT64 MessageIndex</b></param>
	/// <param name="pMessage">_Out_writes_bytes_opt_(*pMessageByteLength) <b>D3D12_MESSAGE* pMessage</b></param>
	/// <param name="pMessageByteLength">_Inout_ <b>SIZE_T* pMessageByteLength</b></param>
	int GetMessage (ulong messageIndex, Message* pMessage, nuint* pMessageByteLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D12InfoQueue::GetNumMessagesAllowedByStorageFilter ()</b><br/>
	/// </summary>
	ulong GetNumMessagesAllowedByStorageFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D12InfoQueue::GetNumMessagesDeniedByStorageFilter ()</b><br/>
	/// </summary>
	ulong GetNumMessagesDeniedByStorageFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D12InfoQueue::GetNumStoredMessages ()</b><br/>
	/// </summary>
	ulong GetNumStoredMessages ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D12InfoQueue::GetNumStoredMessagesAllowedByRetrievalFilter ()</b><br/>
	/// </summary>
	ulong GetNumStoredMessagesAllowedByRetrievalFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D12InfoQueue::GetNumMessagesDiscardedByMessageCountLimit ()</b><br/>
	/// </summary>
	ulong GetNumMessagesDiscardedByMessageCountLimit ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT64 ID3D12InfoQueue::GetMessageCountLimit ()</b><br/>
	/// </summary>
	ulong GetMessageCountLimit ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::AddStorageFilterEntries (D3D12_INFO_QUEUE_FILTER* pFilter)</b><br/>
	/// </summary>
	/// <param name="pFilter">_In_ <b>D3D12_INFO_QUEUE_FILTER* pFilter</b></param>
	int AddStorageFilterEntries (InfoQueueFilter* pFilter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::GetStorageFilter (D3D12_INFO_QUEUE_FILTER* pFilter, SIZE_T* pFilterByteLength)</b><br/>
	/// </summary>
	/// <param name="pFilter">_Out_writes_bytes_opt_(*pFilterByteLength) <b>D3D12_INFO_QUEUE_FILTER* pFilter</b></param>
	/// <param name="pFilterByteLength">_Inout_ <b>SIZE_T* pFilterByteLength</b></param>
	int GetStorageFilter (InfoQueueFilter* pFilter, nuint* pFilterByteLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12InfoQueue::ClearStorageFilter ()</b><br/>
	/// </summary>
	void ClearStorageFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::PushEmptyStorageFilter ()</b><br/>
	/// </summary>
	int PushEmptyStorageFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::PushCopyOfStorageFilter ()</b><br/>
	/// </summary>
	int PushCopyOfStorageFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::PushStorageFilter (D3D12_INFO_QUEUE_FILTER* pFilter)</b><br/>
	/// </summary>
	/// <param name="pFilter">_In_ <b>D3D12_INFO_QUEUE_FILTER* pFilter</b></param>
	int PushStorageFilter (InfoQueueFilter* pFilter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12InfoQueue::PopStorageFilter ()</b><br/>
	/// </summary>
	void PopStorageFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D12InfoQueue::GetStorageFilterStackSize ()</b><br/>
	/// </summary>
	uint GetStorageFilterStackSize ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::AddRetrievalFilterEntries (D3D12_INFO_QUEUE_FILTER* pFilter)</b><br/>
	/// </summary>
	/// <param name="pFilter">_In_ <b>D3D12_INFO_QUEUE_FILTER* pFilter</b></param>
	int AddRetrievalFilterEntries (InfoQueueFilter* pFilter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::GetRetrievalFilter (D3D12_INFO_QUEUE_FILTER* pFilter, SIZE_T* pFilterByteLength)</b><br/>
	/// </summary>
	/// <param name="pFilter">_Out_writes_bytes_opt_(*pFilterByteLength) <b>D3D12_INFO_QUEUE_FILTER* pFilter</b></param>
	/// <param name="pFilterByteLength">_Inout_ <b>SIZE_T* pFilterByteLength</b></param>
	int GetRetrievalFilter (InfoQueueFilter* pFilter, nuint* pFilterByteLength);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12InfoQueue::ClearRetrievalFilter ()</b><br/>
	/// </summary>
	void ClearRetrievalFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::PushEmptyRetrievalFilter ()</b><br/>
	/// </summary>
	int PushEmptyRetrievalFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::PushCopyOfRetrievalFilter ()</b><br/>
	/// </summary>
	int PushCopyOfRetrievalFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::PushRetrievalFilter (D3D12_INFO_QUEUE_FILTER* pFilter)</b><br/>
	/// </summary>
	/// <param name="pFilter">_In_ <b>D3D12_INFO_QUEUE_FILTER* pFilter</b></param>
	int PushRetrievalFilter (InfoQueueFilter* pFilter);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12InfoQueue::PopRetrievalFilter ()</b><br/>
	/// </summary>
	void PopRetrievalFilter ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>UINT ID3D12InfoQueue::GetRetrievalFilterStackSize ()</b><br/>
	/// </summary>
	uint GetRetrievalFilterStackSize ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::AddMessage (D3D12_MESSAGE_CATEGORY Category, D3D12_MESSAGE_SEVERITY Severity, D3D12_MESSAGE_ID ID, LPCSTR pDescription)</b><br/>
	/// </summary>
	/// <param name="category">_In_ <b>D3D12_MESSAGE_CATEGORY Category</b></param>
	/// <param name="severity">_In_ <b>D3D12_MESSAGE_SEVERITY Severity</b></param>
	/// <param name="iD">_In_ <b>D3D12_MESSAGE_ID ID</b></param>
	/// <param name="pDescription">_In_ <b>LPCSTR pDescription</b></param>
	int AddMessage (MessageCategory category, MessageSeverity severity, MessageId iD, char* pDescription);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::AddApplicationMessage (D3D12_MESSAGE_SEVERITY Severity, LPCSTR pDescription)</b><br/>
	/// </summary>
	/// <param name="severity">_In_ <b>D3D12_MESSAGE_SEVERITY Severity</b></param>
	/// <param name="pDescription">_In_ <b>LPCSTR pDescription</b></param>
	int AddApplicationMessage (MessageSeverity severity, char* pDescription);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::SetBreakOnCategory (D3D12_MESSAGE_CATEGORY Category, BOOL bEnable)</b><br/>
	/// </summary>
	/// <param name="category">_In_ <b>D3D12_MESSAGE_CATEGORY Category</b></param>
	/// <param name="bEnable">_In_ <b>BOOL bEnable</b></param>
	int SetBreakOnCategory (MessageCategory category, bool bEnable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::SetBreakOnSeverity (D3D12_MESSAGE_SEVERITY Severity, BOOL bEnable)</b><br/>
	/// </summary>
	/// <param name="severity">_In_ <b>D3D12_MESSAGE_SEVERITY Severity</b></param>
	/// <param name="bEnable">_In_ <b>BOOL bEnable</b></param>
	int SetBreakOnSeverity (MessageSeverity severity, bool bEnable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ID3D12InfoQueue::SetBreakOnID (D3D12_MESSAGE_ID ID, BOOL bEnable)</b><br/>
	/// </summary>
	/// <param name="iD">_In_ <b>D3D12_MESSAGE_ID ID</b></param>
	/// <param name="bEnable">_In_ <b>BOOL bEnable</b></param>
	int SetBreakOnID (MessageId iD, bool bEnable);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D12InfoQueue::GetBreakOnCategory (D3D12_MESSAGE_CATEGORY Category)</b><br/>
	/// </summary>
	/// <param name="category">_In_ <b>D3D12_MESSAGE_CATEGORY Category</b></param>
	bool GetBreakOnCategory (MessageCategory category);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D12InfoQueue::GetBreakOnSeverity (D3D12_MESSAGE_SEVERITY Severity)</b><br/>
	/// </summary>
	/// <param name="severity">_In_ <b>D3D12_MESSAGE_SEVERITY Severity</b></param>
	bool GetBreakOnSeverity (MessageSeverity severity);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D12InfoQueue::GetBreakOnID (D3D12_MESSAGE_ID ID)</b><br/>
	/// </summary>
	/// <param name="iD">_In_ <b>D3D12_MESSAGE_ID ID</b></param>
	bool GetBreakOnID (MessageId iD);
	/// <summary>
	/// STDMETHODCALLTYPE <b>void ID3D12InfoQueue::SetMuteDebugOutput (BOOL bMute)</b><br/>
	/// </summary>
	/// <param name="bMute">_In_ <b>BOOL bMute</b></param>
	void SetMuteDebugOutput (bool bMute);
	/// <summary>
	/// STDMETHODCALLTYPE <b>BOOL ID3D12InfoQueue::GetMuteDebugOutput ()</b><br/>
	/// </summary>
	bool GetMuteDebugOutput ();
}

/// <summary>
/// Instance of <b>ID3D12InfoQueue</b><br/>
/// D3D12SDKLAYERS.h
/// </summary>
unsafe public readonly struct InfoQueue : IInfoQueue {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly InfoQueue* GetCurrentPointer () => (InfoQueue*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x0742a90b, 0xc387, 0x483f, 0xb9, 0x46, 0x30, 0xa7, 0xe4, 0xe6, 0x14, 0x58);

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
	public readonly int SetMessageCountLimit (ulong messageCountLimit) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetMessageCountLimit (ptr, messageCountLimit);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearStoredMessages () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearStoredMessages (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetMessage (ulong messageIndex, Message* pMessage, nuint* pMessageByteLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMessage (ptr, messageIndex, pMessage, pMessageByteLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumMessagesAllowedByStorageFilter () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumMessagesAllowedByStorageFilter (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumMessagesDeniedByStorageFilter () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumMessagesDeniedByStorageFilter (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumStoredMessages () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumStoredMessages (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumStoredMessagesAllowedByRetrievalFilter () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumStoredMessagesAllowedByRetrievalFilter (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetNumMessagesDiscardedByMessageCountLimit () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetNumMessagesDiscardedByMessageCountLimit (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly ulong GetMessageCountLimit () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMessageCountLimit (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddStorageFilterEntries (InfoQueueFilter* pFilter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddStorageFilterEntries (ptr, pFilter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetStorageFilter (InfoQueueFilter* pFilter, nuint* pFilterByteLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStorageFilter (ptr, pFilter, pFilterByteLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearStorageFilter () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearStorageFilter (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushEmptyStorageFilter () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushEmptyStorageFilter (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushCopyOfStorageFilter () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushCopyOfStorageFilter (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushStorageFilter (InfoQueueFilter* pFilter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushStorageFilter (ptr, pFilter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PopStorageFilter () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PopStorageFilter (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetStorageFilterStackSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetStorageFilterStackSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddRetrievalFilterEntries (InfoQueueFilter* pFilter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddRetrievalFilterEntries (ptr, pFilter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetRetrievalFilter (InfoQueueFilter* pFilter, nuint* pFilterByteLength) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRetrievalFilter (ptr, pFilter, pFilterByteLength);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void ClearRetrievalFilter () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->ClearRetrievalFilter (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushEmptyRetrievalFilter () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushEmptyRetrievalFilter (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushCopyOfRetrievalFilter () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushCopyOfRetrievalFilter (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int PushRetrievalFilter (InfoQueueFilter* pFilter) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->PushRetrievalFilter (ptr, pFilter);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void PopRetrievalFilter () {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->PopRetrievalFilter (ptr);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint GetRetrievalFilterStackSize () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetRetrievalFilterStackSize (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddMessage (MessageCategory category, MessageSeverity severity, MessageId iD, char* pDescription) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddMessage (ptr, category, severity, iD, pDescription);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int AddApplicationMessage (MessageSeverity severity, char* pDescription) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddApplicationMessage (ptr, severity, pDescription);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetBreakOnCategory (MessageCategory category, bool bEnable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetBreakOnCategory (ptr, category, bEnable ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetBreakOnSeverity (MessageSeverity severity, bool bEnable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetBreakOnSeverity (ptr, severity, bEnable ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetBreakOnID (MessageId iD, bool bEnable) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetBreakOnID (ptr, iD, bEnable ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetBreakOnCategory (MessageCategory category) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBreakOnCategory (ptr, category) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetBreakOnSeverity (MessageSeverity severity) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBreakOnSeverity (ptr, severity) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetBreakOnID (MessageId iD) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetBreakOnID (ptr, iD) != 0;
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly void SetMuteDebugOutput (bool bMute) {
		var ptr = GetCurrentPointer ();
		((FunctionPointer*) ptr->_pointer)->SetMuteDebugOutput (ptr, bMute ? 1U : 0U);
		return;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly bool GetMuteDebugOutput () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetMuteDebugOutput (ptr) != 0;
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
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, int> SetMessageCountLimit;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> ClearStoredMessages;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, Message*, nuint*, int> GetMessage;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetNumMessagesAllowedByStorageFilter;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetNumMessagesDeniedByStorageFilter;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetNumStoredMessages;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetNumStoredMessagesAllowedByRetrievalFilter;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetNumMessagesDiscardedByMessageCountLimit;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong> GetMessageCountLimit;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InfoQueueFilter*, int> AddStorageFilterEntries;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InfoQueueFilter*, nuint*, int> GetStorageFilter;
		/// <summary>
		/// OFFSET 14
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> ClearStorageFilter;
		/// <summary>
		/// OFFSET 15
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> PushEmptyStorageFilter;
		/// <summary>
		/// OFFSET 16
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> PushCopyOfStorageFilter;
		/// <summary>
		/// OFFSET 17
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InfoQueueFilter*, int> PushStorageFilter;
		/// <summary>
		/// OFFSET 18
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> PopStorageFilter;
		/// <summary>
		/// OFFSET 19
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetStorageFilterStackSize;
		/// <summary>
		/// OFFSET 20
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InfoQueueFilter*, int> AddRetrievalFilterEntries;
		/// <summary>
		/// OFFSET 21
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InfoQueueFilter*, nuint*, int> GetRetrievalFilter;
		/// <summary>
		/// OFFSET 22
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> ClearRetrievalFilter;
		/// <summary>
		/// OFFSET 23
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> PushEmptyRetrievalFilter;
		/// <summary>
		/// OFFSET 24
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> PushCopyOfRetrievalFilter;
		/// <summary>
		/// OFFSET 25
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, InfoQueueFilter*, int> PushRetrievalFilter;
		/// <summary>
		/// OFFSET 26
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void> PopRetrievalFilter;
		/// <summary>
		/// OFFSET 27
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetRetrievalFilterStackSize;
		/// <summary>
		/// OFFSET 28
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MessageCategory, MessageSeverity, MessageId, char*, int> AddMessage;
		/// <summary>
		/// OFFSET 29
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MessageSeverity, char*, int> AddApplicationMessage;
		/// <summary>
		/// OFFSET 30
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MessageCategory, uint, int> SetBreakOnCategory;
		/// <summary>
		/// OFFSET 31
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MessageSeverity, uint, int> SetBreakOnSeverity;
		/// <summary>
		/// OFFSET 32
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MessageId, uint, int> SetBreakOnID;
		/// <summary>
		/// OFFSET 33
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MessageCategory, uint> GetBreakOnCategory;
		/// <summary>
		/// OFFSET 34
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MessageSeverity, uint> GetBreakOnSeverity;
		/// <summary>
		/// OFFSET 35
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, MessageId, uint> GetBreakOnID;
		/// <summary>
		/// OFFSET 36
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void> SetMuteDebugOutput;
		/// <summary>
		/// OFFSET 37
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> GetMuteDebugOutput;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
