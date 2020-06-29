#include<Windows.h>
#include "resource.h"
BOOL CALLBACK DigProc(HWND hDig, UINT iMessage, WPARAM wParam, LPARAM IParam);
INT APIENTRY WinMain(HINSTANCE hIns, HINSTANCE hPrev, LPSTR nCmd, int nShow)
{
	DialogBox(hIns, MAKEINTRESOURCE(IDD_DIALOG1), 0, DigProc);
	return 0;
}
void OnCommand(HWND hDig, int cid, int cmsg)
{
	switch (cid)
	{
	case IDCANCEL: EndDialog(hDig, 0);
		return;
	}
}
BOOL CALLBACK DigProc(HWND hDig, UINT iMessage, WPARAM wParam, LPARAM IParam)
{
	switch (iMessage)
	{
	case WM_COMMAND: OnCommand(hDig, LOWORD(wParam), HIWORD(wParam)); return TRUE;
	default:
		break;
	}
	return FALSE;
}
