#include<stdio.h>

typedef union Test
{
	float fvalue;
	unsigned uvalue;
	struct {
		unsigned c : 23;	// unsigned¸¦ bitº°·Î ÂÉ°µ°ÍÀÌ´Ù.
		unsigned b : 8;
		unsigned a : 1;
	}st;
}Test;

int main()
{
	Test t;
	t.fvalue = -12.625;
	printf("%x\n", t.uvalue);
	printf("%x %x %x\n", t.st.a, t.st.b, t.st.c);

	return 0;
}