#include<Windows.h>

LRESULT CALLBACK MyProc(HWND hWnd, UINT iMessage, WPARAM wParam, LPARAM lParam);
INT APIENTRY WinMain(HINSTANCE hIns, HINSTANCE hPrev, LPSTR nCmd, int nShow)
{
	WNDCLASS wndClass = { 0 };// 윈도우를 운영체제에 등록
	wndClass.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);	//win32에서 첫 글자가 H로 시작하는것의 의미는 Handle이다.
	wndClass.hInstance = hIns;	//
	wndClass.hCursor = LoadCursor(NULL, IDC_ARROW);
	wndClass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wndClass.lpfnWndProc = MyProc;
	wndClass.lpszClassName = TEXT("demo");
	ATOM atom = RegisterClass(&wndClass); // window에게 필요한 클래스 생성을 요청

	HWND hWnd = CreateWindow(TEXT("demo"),TEXT("첫번 째 Wqin32 API"),WS_OVERLAPPEDWINDOW,10,10,1000,800,0,0,hIns,0);	// Window 생성
	ShowWindow(hWnd, SW_SHOW);	// 만들어진 Window를 시각화
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

void OnCreate(HWND hWnd)
{
	CreateWindow(TEXT("button"), TEXT("확인"), WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 10, 10, 150, 24, hWnd, 0, GetModuleHandle(0), 0);
}

LRESULT CALLBACK MyProc(HWND hWnd, UINT iMessage, WPARAM wParam, LPARAM lParam)
{
	switch (iMessage)
	{
	case WM_CREATE: OnCreate(hWnd); return 0;
	case WM_DESTROY: DestroyProc(hWnd); return 0;
	}
	return DefDlgProc(hWnd, iMessage, wParam, lParam);
}
