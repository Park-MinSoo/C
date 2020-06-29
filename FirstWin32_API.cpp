#include<Windows.h>

LRESULT CALLBACK MyProc(HWND hWnd, UINT iMessage, WPARAM wParam, LPARAM lParam);
INT APIENTRY WinMain(HINSTANCE hIns, HINSTANCE hPrev, LPSTR nCmd, int nShow)
{
	WNDCLASS wndClass = { 0 };// �����츦 �ü���� ���
	wndClass.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);	//win32���� ù ���ڰ� H�� �����ϴ°��� �ǹ̴� Handle�̴�.
	wndClass.hInstance = hIns;	//
	wndClass.hCursor = LoadCursor(NULL, IDC_ARROW);
	wndClass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wndClass.lpfnWndProc = MyProc;
	wndClass.lpszClassName = TEXT("demo");
	ATOM atom = RegisterClass(&wndClass); // window���� �ʿ��� Ŭ���� ������ ��û

	HWND hWnd = CreateWindow(TEXT("demo"),TEXT("ù�� ° Wqin32 API"),WS_OVERLAPPEDWINDOW,10,10,1000,800,0,0,hIns,0);	// Window ����
	ShowWindow(hWnd, SW_SHOW);	// ������� Window�� �ð�ȭ
	MSG Message;
	while (GetMessage(&Message, 0, 0, 0))
	{
		DispatchMessage(&Message);
	}
	return 0;
}
void DestroyProc(HWND hWnd)
{
	PostQuitMessage(0);
}

LRESULT CALLBACK MyProc(HWND hWnd, UINT iMessage, WPARAM wParam, LPARAM lParam)
{
	switch (iMessage)
	{
	case WM_DESTROY: DestroyProc(hWnd);
		break;
	default:
		break;
	}
	return DefDlgProc(hWnd, iMessage, wParam, lParam);
}
